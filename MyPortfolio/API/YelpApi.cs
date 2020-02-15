using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MyPortfolio.Models;
using Newtonsoft.Json;

namespace MyPortfolio.API
{
    public class YelpApi
    {
        public YelpApi()
        {
        }


        public async Task<YelpSearchResult> GetYelpSearchResultsAsync (string city, string latitude, string longitude, string radius, string price, string rating, string openNow, string cats)
        {
            YelpSearchResult yelpSearchResult = new YelpSearchResult();
            yelpSearchResult.hasErrors = false;

            double dRadius = 0;
            if(!String.IsNullOrEmpty(radius))
                dRadius = Double.Parse(radius);
            dRadius = dRadius > 24.8 ? 24.8 : dRadius;

            string address = "https://api.yelp.com/v3/businesses/search?limit=50";
            address = String.IsNullOrEmpty(price) ? address : address + "&price=" + GetPriceForUrl(price);
            address = String.IsNullOrEmpty(rating) ? address : address + "&rating=" + GetRatingForUrl(rating);
            address = (!String.IsNullOrEmpty(openNow) && openNow.Equals("1")) ? address + "&open_now=true" : address;
            address = dRadius > 0 ? address + "&radius=" + ((int)(dRadius * 1609)).ToString() : address;
            address = String.IsNullOrEmpty(cats) ? address : address + "&categories=" + cats;

            if (String.IsNullOrEmpty(city) && (!String.IsNullOrEmpty(latitude) && !String.IsNullOrEmpty(longitude)))
            {
                address = address + "&latitude=" + latitude;
                address = address + "&longitude=" + longitude;
            }
            else
            {
                address = address + "&location=" + city;
            }

            

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Constants.yelpApiKey);
                var response = await client.GetAsync(address);
                if (response.IsSuccessStatusCode)
                    yelpSearchResult = await response.Content.ReadAsAsync<YelpSearchResult>();
            }


            return yelpSearchResult;
        }

        public async Task<YelpBusiness> GetYelpBusinessAsync(string id)
        {
            string address = $"https://api.yelp.com/v3/businesses/{id}";
            YelpBusiness business = new YelpBusiness();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Constants.yelpApiKey);
                var response = await client.GetAsync(address);
                if (response.IsSuccessStatusCode)
                    business = await response.Content.ReadAsAsync<YelpBusiness>();
            }
            return business;
        }

        public async Task<YelpReviews> GetYelpReviewsAsync(string id)
        {
            string address = $"https://api.yelp.com/v3/businesses/{id}/reviews";
            YelpReviews reviews = new YelpReviews();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Constants.yelpApiKey);
                var response = await client.GetAsync(address);
                if (response.IsSuccessStatusCode)
                    reviews = await response.Content.ReadAsAsync<YelpReviews>();
            }
            return reviews;
        }
        private string GetPriceForUrl(string price)
        {
            if (!String.IsNullOrWhiteSpace(price))
            {
                price = price.Equals("2") ? "1,2": price;
                price = price.Equals("3") ? "1,2,3" : price;
                price = price.Equals("4") ? "1,2,3,4" : price;
            }
            return price;
        }
        private string GetRatingForUrl(string rating)
        {
            if (!String.IsNullOrWhiteSpace(rating))
            {
                rating = rating.Equals("2") ? "1,2" : rating;
                rating = rating.Equals("3") ? "1,2,3" : rating;
                rating = rating.Equals("4") ? "1,2,3,4" : rating;
                rating = rating.Equals("5") ? "1,2,3,4,5" : rating;
            }
            return rating;
        }
    }
}
