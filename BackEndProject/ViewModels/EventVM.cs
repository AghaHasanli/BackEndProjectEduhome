using BackEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.ViewModels
{
    public class EventVM
    {
        public Event Event { get; set; }
        public EventDetail EventDetail { get; set; }
        public List<int> Speakers { get; set; } 
        public List<Speaker> SpekarsModels { get; set; }
    }
}
