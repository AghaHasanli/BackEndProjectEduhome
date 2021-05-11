using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        [Required,MaxLength(255)]
        public string Lesson { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required,MaxLength(255)]
        public string Venue { get; set; }
    }
}
