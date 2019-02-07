﻿using System.ComponentModel.DataAnnotations;

namespace BookingApp.DTOs
{
    public class ResourceMinimalDto
    {
        public int ResourceId { get; set; }

        [MinLength(3, ErrorMessage = "Title is too short.")]
        [MaxLength(64, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Invalid group identifier.")]
        public int? TreeGroupId { get; set; }

        [Required]
        public bool? IsActive { get; set; }
    }
}