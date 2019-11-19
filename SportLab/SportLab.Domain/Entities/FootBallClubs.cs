using System;
using System.ComponentModel.DataAnnotations;

namespace SportLab.Domain.Entities
{
    public class FootBallClub
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public bool Eliminated { get; set; }
    }
}
