﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Models
{
    public class Social
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
