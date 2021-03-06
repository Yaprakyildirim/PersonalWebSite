﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Models
{
    public class Mail
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname{ get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string About { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
