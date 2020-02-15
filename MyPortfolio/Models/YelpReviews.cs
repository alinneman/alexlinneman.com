﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace MyPortfolio.Models
{
    

    public partial class YelpReviews
    {
        [JsonProperty("reviews")]
        public Review[] Reviews { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("possible_languages")]
        public string[] PossibleLanguages { get; set; }
    }

    public partial class Review
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("time_created")]
        public DateTimeOffset TimeCreated { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public partial class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
