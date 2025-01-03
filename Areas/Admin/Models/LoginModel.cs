﻿using System.ComponentModel.DataAnnotations;

namespace practice_C_.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
