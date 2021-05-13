using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        public string Degree { get; set; }
        public string Exprience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string MailMe { get; set; }
        public string MakeACall { get; set; }
        public string Language { get; set; }
        public string TeamLeader { get; set; }
        public string Development { get; set; }
        public string Design { get; set; }
        public string Innovation { get; set; }
        public string Communication { get; set; }
        public string Skype { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
