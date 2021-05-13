using System;
using System.Collections.Generic;
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
        public string Starts { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkilLevel { get; set; }
        public string Language { get; set; }
        public string Students { get; set; }
        public string Assesment { get; set; }
        public int Price { get; set; }
    }
}
