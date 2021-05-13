using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        [Required, MaxLength(255)]
        public string FullName { get; set; }
        [Required, MaxLength(255)]
        public string Position { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
        public List<Social> Socials { get; set; }
    }
}
