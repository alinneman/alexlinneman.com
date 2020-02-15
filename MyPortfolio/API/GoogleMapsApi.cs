using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MyPortfolio.Models;
using Newtonsoft.Json;

namespace MyPortfolio.API
{
    public class GoogleMapsApi
    {
        public GoogleMapsApi()
        {
        }

        public async Task<GoogleMapsAutocomplete> GetAutocompleteAsync(string input)
        {
            GoogleMapsAutocomplete autocomplete = new GoogleMapsAutocomplete();
            using (HttpClient client = new HttpClient())
            {
                string address = $"https://maps.googleapis.com/maps/api/place/autocomplete/xml?input={input}&types=(cities)&location=40.820744,-96.700470&radius=2400000&key={Constants.googleMapsApiKey}";
                var response = client.GetStringAsync(new Uri(address)).Result;
                //string header = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
                //response = response.Remove(0, header.Length);
                XmlSerializer serializer = new XmlSerializer(typeof(AutocompletionResponse), new XmlRootAttribute("AutocompletionResponse"));
                using (TextReader reader = new StringReader(response))
                {
                    AutocompletionResponse res = new AutocompletionResponse();
                    res = (AutocompletionResponse) serializer.Deserialize(reader);
                    autocomplete.AutocompletionResponse = res;
                }
            }


            return autocomplete;
        }
    }
}
