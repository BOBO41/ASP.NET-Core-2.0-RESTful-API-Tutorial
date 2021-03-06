﻿using System.Collections.Generic;

namespace MyRestful.Api.Resources
{
    public class CountryAddResource
    {
        public CountryAddResource()
        {
            Cities = new List<CityAddResource>();
        }

        public string EnglishName { get; set; }
        public string ChineseName { get; set; }
        public string Abbreviation { get; set; }

        public List<CityAddResource> Cities { get; set; }
    }
}
