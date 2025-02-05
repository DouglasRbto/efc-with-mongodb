﻿using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RestRes.Models
{
    [Collection("restaurants")]
    public class Restaurant
    {
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "You must provide a name")]
        [Display(Name = "Name")]
        public string? name { get; set; }

        [Required(ErrorMessage = "You must provide a cuisine type")]
        [Display(Name = "Cuisine")]
        public string? cuisine { get; set; }
        
        [Required(ErrorMessage = "You must add the borough of the restaurant")]
        public string? borough { get; set; }
    }
}
