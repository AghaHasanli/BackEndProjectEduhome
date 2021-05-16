using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Lesson { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime EventEndTime { get; set; }
        [Required,MaxLength(255)]
        public string Venue { get; set; }
        public EventDetail EventDetail { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}
