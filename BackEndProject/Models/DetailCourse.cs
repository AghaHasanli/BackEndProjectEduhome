using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class DetailCourse
    {
        public int Id { get; set; }
        public string AboutCourse { get; set; }
        public string  HowToApply { get; set; }
        public string Certifcation { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [Required]
        public DateTime? Starts { get; set; }
        [Required, MaxLength(250)]
        public string Duration { get; set; }
        [Required, MaxLength(250)]
        public string ClassDuration { get; set; }
        [Required, MaxLength(250)]
        public string SkilLevel { get; set; }
        [Required, MaxLength(250)]
        public string Language { get; set; }
        [Required]
        public int Students { get; set; }
        [Required, MaxLength(250)]
        public string Assesment { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
