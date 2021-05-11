using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Titel { get; set; }
        [MaxLength(255)]
        public string TitelButton { get; set; }
        public string Description { get; set; }
        [Required, MaxLength(255)]
        public string ImageUrl { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
    }
}
