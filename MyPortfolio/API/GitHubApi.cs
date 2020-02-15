using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MyPortfolio.Models;
using Newtonsoft.Json;

namespace MyPortfolio.API
{
    public class GitHubApi
    {
        public GitHubApi()
        {
        }

        public async Task<GitHubResult> GetGitHubResultAsync()
        {
            GitHubResult repos = new GitHubResult();
            using (HttpClient client = new HttpClient())
            {
                IRequest request;
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");



                //string user = Constants.gitHubUserName;
                //string pass = Constants.gitHubApiKey;
                //bool sendImmediately = false;
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Constants.gitHubApiKey);
                //client.DefaultRequestHeaders.Authorization =
                //    new AuthenticationHeaderValue(
                //    "Basic", Convert.ToBase64String(
                //    System.Text.ASCIIEncoding.ASCII.GetBytes(
                //    $"{user}:{pass}:{sendImmediately}")));
                Uri address = new Uri("http://alinneman:80ff3eab27092c5ea5d73f1b1bf3a31f3260e7fe@api.github.com/users/alinneman/repos");
                var response = client.GetStringAsync(address).Result;
                repos = JsonConvert.DeserializeObject<GitHubResult>(response);
            }

            
            return repos;
        }

    }
}
