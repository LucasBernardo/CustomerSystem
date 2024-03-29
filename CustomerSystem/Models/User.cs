﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Web;
using static CustomerSystem.Enum.Enum;

namespace CustomerSystem.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "E-mail is required")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public Role Role { get; set; }
    }
}