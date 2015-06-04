using mvc_321.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_321.ViewModels
{
    public class course_student
    {
        public course course { get; set; }
        public List<student> students{get;set;}
    }
}