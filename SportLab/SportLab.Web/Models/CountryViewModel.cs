using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportLab.Web.Models
{
    public class CountryViewModel
    {
        public List<SelectListItem> GetCountries = new List<SelectListItem>();

    }
}
