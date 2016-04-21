﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class GuestResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool? WillAttend { get; set; }
    }
}
