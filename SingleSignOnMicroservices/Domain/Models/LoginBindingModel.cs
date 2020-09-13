using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SingleSignOnMicroservices.Domain.Models
{
    public class LoginBindingModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Provider { get; set; }
        public string ReturnUrl { get; set; }
    }
}
