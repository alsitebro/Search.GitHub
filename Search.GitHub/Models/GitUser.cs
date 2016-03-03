using System.Collections.Generic;
using Newtonsoft.Json;

namespace Search.GitHub.Models
{
    public class GitUser
    {
        [JsonProperty("login")]
        public string Username { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        public List<GitRepo> Repos { get; set; } 
    }
}
