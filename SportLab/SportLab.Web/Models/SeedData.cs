using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportLab.Data;
using SportLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportLab.Web.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (var context = new SportLabContext(
              serviceProvider.GetRequiredService<DbContextOptions<SportLabContext>>())) {

                if (context.FootBallClubs.Any()) return;
                

                try
                {

                    context.Database.OpenConnection();
                    using (StreamReader reader = new StreamReader("teams.csv"))
                        {
                            CsvReader csvReader = new CsvReader(reader);
                        context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.FootBallClubs ON");
                        var teams = csvReader.GetRecords<Team>().Select(x => new FootBallClub() { 
                                Id = x.ID,
                                Name = x.Name,
                                Country = x.Country,
                                Eliminated = x.Eliminated
                            
                            }).ToList();

                            context.FootBallClubs.AddRange(teams);
                            context.SaveChanges();
                        context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.FootBallClubs OFF");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
       

            }

        }

        public class Team {

            public int ID { get; set; }

            public string Name { get; set; }

            public string Country { get; set; }
            public bool Eliminated { get; set; }

        }
    }
}
