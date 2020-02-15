using System;
namespace MyPortfolio.Models
{
    public class YelpCompleteDetails
    {
        public YelpReviews YelpReviews { get; set; }
        public YelpBusiness  YelpBusiness { get; set; }
        public string HoursToday { get; set; }
        public string ReviewImage { get; set; }
    }
}
