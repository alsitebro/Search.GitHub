using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Search.GitHub.Models;

namespace Search.GitHub.Api
{
    public class Client
    {
        private const string _apiUrl = "https://api.github.com";

        public GitUser GetUser(string name)
        {
            using (var client = new HttpClient())
            {
                using (var req = new HttpRequestMessage())
                {
                    req.Method = HttpMethod.Get;
                    req.Headers.Add("User-Agent","avo-search-github");
                    try
                    {
                        req.RequestUri = new Uri(new Uri(_apiUrl), "/users/" + name);
                        var response = client.SendAsync(req).Result;
                        var user = JsonConvert.DeserializeObject<GitUser>(response.Content.ReadAsStringAsync().Result);
                        user.Repos = GetRepos(user.ReposUrl);
                        return user;
                    }
                    catch (Exception exception)
                    {
                        return null;
                    }
                }
            }
        }

        public List<GitRepo> GetRepos(string repoUrl)
        {
            List<GitRepo> repos;
            using (var client = new HttpClient())
            {
                using (var req = new HttpRequestMessage())
                {
                    req.Method = HttpMethod.Get;
                    req.Headers.Add("User-Agent", "avo-search-github");
                    try
                    {
                        req.RequestUri = new Uri(repoUrl);
                        var response = client.SendAsync(req).Result;
                        repos = JsonConvert.DeserializeObject<List<GitRepo>>(response.Content.ReadAsStringAsync().Result);
                    }
                    catch(Exception ex)
                    {
                        repos = new List<GitRepo>();
                    }
                    return repos;
                }
            }
        }
    }
}