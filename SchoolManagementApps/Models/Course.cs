using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoolManagementApps.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
    }
}