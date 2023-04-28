using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Course
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}
        public int Credits {get;set;}

        public ICollection<Chapter>? Chapters {get;set;}

        public ICollection<TeacherCourse>? TeacherCourses {get;set;}

        public ICollection<Registration>? Registrations {get;set;} 
    }
}