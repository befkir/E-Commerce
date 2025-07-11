﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue,ErrorMessage ="Display Order should be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
