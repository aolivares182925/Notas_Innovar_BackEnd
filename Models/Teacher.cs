using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Teacher
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}

        public ICollection<TeacherCourse>? TeacherCourses {get;set;}

        
    }
}