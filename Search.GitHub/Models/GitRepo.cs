using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Search.GitHub.Models
{
    public class GitRepo
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }
    }
}