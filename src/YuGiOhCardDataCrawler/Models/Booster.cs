﻿using LiteDB;

namespace YuGiOhCardDataCrawler.Models
{
    public class Booster
    {
        public Booster(YuGiOhWikiaApi.Models.Booster booster)
        {
            Name = booster.name;
            ReleaseDateEnglish = booster.enReleaseDate;
            ReleaseDateJapanese = booster.jpReleaseDate;
            ReleaseDateSouthKorea = booster.skReleaseDate;
            ReleaseDateWorldWide = booster.worldwideReleaseDate;
            Imageurl = booster.imgSrc;
        }

        [BsonId(true)]
        public int Id { get; set; }

        [BsonField("name")]
        public string Name { get; set; }

        [BsonField("release_date_english")]
        public string ReleaseDateEnglish { get; set; }

        [BsonField("release_date_japanese")]
        public string ReleaseDateJapanese { get; set; }

        [BsonField("release_date_south_korea")]
        public string ReleaseDateSouthKorea { get; set; }

        [BsonField("release_date_world_wide")]
        public string ReleaseDateWorldWide { get; set; }

        [BsonField("release_date_image_url")]
        public string Imageurl { get; set; }
    }
}
