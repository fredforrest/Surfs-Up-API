﻿using Surfs_Up_API.Models;
using System.ComponentModel.DataAnnotations;

namespace Surfs_Up_API.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Invalid Start Date")]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public User User { get; set; }
        public List<Surfboard>? Surfboards { get; set; }
        public List<Wetsuit>? Wetsuits { get; set; } // Én booking kan stadig have mange wetsuits
        public string Remark { get; set; }
    }
}
