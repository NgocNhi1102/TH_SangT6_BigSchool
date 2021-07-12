using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH_SangT6_BigSchool.Models;

namespace TH_SangT6_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}