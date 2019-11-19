using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace SportLab.ViewModel
{
    public class ClubDetailViewModel : ClubsViewModel
    {
        public string GetImage() => $"http://img.uefa.com/imgml/TP/teams/logos/70x70/{Id}.png";

        public string GetTeamDetail() => $"https://www.uefa.com/teamsandplayers/teams/club={Id}/profile/index.html";

        public List<SelectListItem> GetCountries() {

            return countries.Select(x => new SelectListItem
            {
                Text = x,
                Value = x,
                Selected = Country == x || Country == "England" &&  x == "United Kingdom"
            }).ToList();
        }


        private string[] countries = new string[] {
         "Afghanistan"
        ,"Åland Islands"
        ,"Albania"
        ,"Algeria"
        ,"American Samoa"
        ,"Andorra"
        ,"Angola"
        ,"Anguilla"
        ,"Antarctica"
        ,"Antigua and Barbuda"
        ,"Argentina"
        ,"Armenia"
        ,"Aruba"
        ,"Australia"
        ,"Austria"
        ,"Azerbaijan"
        ,"Bahrain"
        ,"Bahamas"
        ,"Barbados"
        ,"Belarus"
        ,"Belgium"
        ,"Belize"
        ,"Benin"
        ,"Bermuda"
        ,"Bhutan"
        ,"Bolivia, Plurinational State of"
        ,"Bonaire, Sint Eustatius and Saba"
        ,"Bosnia and Herzegovina"
        ,"Botswana"
        ,"Bouvet Island"
        ,"Brazil"
        ,"British Indian Ocean Territory"
        ,"Brunei Darussalam"
        ,"Bulgaria"
        ,"Burkina Faso"
        ,"Burundi"
        ,"Cambodia"
        ,"Cameroon"
        ,"Canada"
        ,"Cape Verde"
        ,"Cayman Islands"
        ,"Central African Republic"
        ,"Chad"
        ,"Chile"
        ,"China"
        ,"Christmas Island"
        ,"Cocos (Keeling) Islands"
        ,"Colombia"
        ,"Comoros"
        ,"Congo"
        ,"Congo, the Democratic Republic of the"
        ,"Cook Islands"
        ,"Costa Rica"
        ,"Côte d'Ivoire"
        ,"Croatia"
        ,"Cuba"
        ,"Curaçao"
        ,"Cyprus"
        ,"Czech Republic"
        ,"Denmark"
        ,"Djibouti"
        ,"Dominica"
        ,"Dominican Republic"
        ,"Ecuador"
        ,"Egypt"
        ,"El Salvador"
        ,"Equatorial Guinea"
        ,"Eritrea"
        ,"Estonia"
        ,"Ethiopia"
        ,"Faroe Islands"
        ,"Fiji"
        ,"Finland"
        ,"France"
        ,"Greece"
        ,"United Arab Emirates"
        ,"United Kingdom"
        ,"United States"
        ,"United States Minor Outlying Islands"
        ,"Uruguay"
        ,"Uzbekistan"
        ,"Vanuatu"
        ,"Venezuela, Bolivarian Republic of"
        ,"Viet Nam"
        ,"Virgin Islands, British"
        ,"Virgin Islands, U.S."
        ,"Wallis and Futuna"
        ,"Western Sahara"
        ,"Yemen"
        ,"Zambia"
        ,"Zimbabwe"
     };

    }
}
