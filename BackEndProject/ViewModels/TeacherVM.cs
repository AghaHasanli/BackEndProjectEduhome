using BackEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.ViewModels
{
    public class TeacherVM
    {
        public Teacher Teacher { get; set; } 
        public TeacherDetail TeacherDetail { get; set; }
    }
}
