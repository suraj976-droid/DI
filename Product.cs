﻿using System.ComponentModel.DataAnnotations;

namespace DI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    

        public string Category { get; set; }

        public decimal Price { get; set; }
    }
}
