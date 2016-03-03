using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Search.GitHub.Models
{
    public class UserSearchRequest
    {
        [Required(ErrorMessage = "Provide name to search for.")]
        public string Name { get; set; }
        public GitUser User { get; set; }
    }
}