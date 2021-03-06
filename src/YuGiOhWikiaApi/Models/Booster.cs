﻿using System.Collections.Generic;

namespace YuGiOhWikiaApi.Models
{
    public class Booster
    {
        public Booster()
        {
        }
        public string name { get; set; }
        public string enReleaseDate { get; set; }
        public string jpReleaseDate { get; set; }
        public string skReleaseDate { get; set; }
        public string worldwideReleaseDate { get; set; }
        public string imgSrc { get; set; }
        public string prefixes { get; set; }
        public string prefix { get; set; }
        public List<BoosterCard> cardList { get; set; }
    }
}
