using System;
using MyPortfolio.Models;
using MyPortfolio.API;
using System.Threading.Tasks;

namespace MyPortfolio.Managers
{
    public class IDCManager
    {
        public IDCManager()
        {
        }

        public async Task<Business> GetRandomBusiness(string city, string latitude, string longitude, string radius, string price, string rating, string openNow, string cats)
        {
            YelpApi yelpApi = new YelpApi();
            Random random = new Random();
            YelpSearchResult result = await yelpApi.GetYelpSearchResultsAsync(city, latitude, longitude, radius, price, rating, openNow, cats);
            if(result.businesses == null || result.businesses.Count == 0)
            {
                Business business = new Business
                {
                    hasErrors = true
                };
                return business;
            }
            else
            {
                int index = random.Next(result.businesses.Count);
                result.businesses[index].hasErrors = false;
                return result.businesses[index];
            }
        }

        public async Task<YelpBusiness> GetBusinessDetails(string id)
        {
            YelpApi yelpApi = new YelpApi();
            return await yelpApi.GetYelpBusinessAsync(id);
        }

        public async Task<YelpReviews> GetYelpReviews(string id)
        {
            YelpApi yelpApi = new YelpApi();
            var reviews = await yelpApi.GetYelpReviewsAsync(id);
            foreach(var review in reviews.Reviews)
            {
                review.Id = YelpStarSelector(review.Rating);
            }
            return reviews;
        }
        public string ConvertToHoursToday(long start, long end)
        {
            string hoursToday = "";

            if (start < 1200)
                hoursToday = (start / 100) + ":00 AM - ";
            else
                hoursToday = ((start - 1200)/100) + ":00 PM - ";

            if (end < 1200)
                hoursToday = hoursToday + (end / 100) + ":00 AM";
            else
                hoursToday = hoursToday + ((end - 1200) / 100) + ":00 PM";

            return hoursToday;
        }
        public string ConvertPrice(string price)
        {
            if (String.IsNullOrWhiteSpace(price))
            {
                price = "Information not yet available";
            }
            else
            {
                price = price.Equals("$") ? price + " (under $10 per person)" : price;
                price = price.Equals("$$") ? price + " ($11 - $30 per person)" : price;
                price = price.Equals("$$$") ? price + " ($31 - $60 per person)" : price;
                price = price.Equals("$$$$") ? price + " (over $61 per person)" : price;
            }
            return price;
        }
        public int GetImageIndexFromRating(double rating)
        {
            if (rating > 4.5)
                return 9;
            else if (rating > 4)
                return 8;
            else if (rating > 3.5)
                return 7;
            else if (rating > 3)
                return 6;
            else if (rating > 2.5)
                return 5;
            else if (rating > 2)
                return 4;
            else if (rating > 1.5)
                return 3;
            else if (rating > 1)
                return 2;
            else if (rating > 0.5)
                return 1;
            else
                return 0;
        }
        public string YelpStarSelector(double rating)
        {
            int index = GetImageIndexFromRating(rating);
            string[] imageArray =
            {
                "https://i.imgur.com/CFhVkcX.png",
                "https://i.imgur.com/cTYQbw6.png",
                "https://i.imgur.com/rofFH4H.png",
                "https://i.imgur.com/XxIeY8N.png",
                "https://i.imgur.com/8scb5p5.png",
                "https://i.imgur.com/wxieS2R.png",
                "https://i.imgur.com/9H5CCUJ.png",
                "https://i.imgur.com/Thmd2gJ.png",
                "https://i.imgur.com/kN4Sh1c.png",
                "https://i.imgur.com/3JN5YKQ.png"
            };
            return imageArray[index];
        }
    }
}
