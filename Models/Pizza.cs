﻿using la_mia_pizzeria.Validator;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(25)]
        public string? Name { get; set; }


        [Column(TypeName="text")]
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(100)]
        [descriptionMinimumWords]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(200)]
        public string? Image { get; set; }
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public double? Price { get; set; }


        public Pizza()
        {

        }
        public Pizza (string name, string description, string image, double price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
