using System;
using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class Business
    {
        public double rating { get; set; }
        public string price { get; set; }
        public string phone { get; set; }
        public string id { get; set; }
        public string alias { get; set; }
        public bool is_closed { get; set; }
        public List<Category> categories { get; set; }
        public int review_count { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public Coordinates coordinates { get; set; }
        public string image_url { get; set; }
        public Location location { get; set; }
        public double distance { get; set; }
        public List<string> transactions { get; set; }
        public bool hasErrors { get; set; }
    }

    public class Center
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Region
    {
        public Center center { get; set; }
    }

    public class YelpSearchResult
    {
        public int total { get; set; }
        public List<Business> businesses { get; set; }
        public Region region { get; set; }
        public bool hasErrors { get; set; }
    }
}
