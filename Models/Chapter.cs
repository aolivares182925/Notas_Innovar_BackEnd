using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Chapter
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}
        public long IdCourse {get;set;}
        [ForeignKey(nameof(IdCourse))]
        public Course? Course {get;set;}

        public ICollection<Exam>? Exams {get;set;}
    }
}