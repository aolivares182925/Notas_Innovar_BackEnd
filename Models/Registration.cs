using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Registration
    {
        [Key]
        public long Id {get;set;}

        public long IdStudent {get;set;}
        [ForeignKey(nameof(IdStudent))]
        public Student? Student {get;set;}

        public long IdCourse {get;set;}
        [ForeignKey(nameof(IdCourse))]
        public Course? Course {get;set;}

        public long IdSemester {get;set;}
        [ForeignKey(nameof(IdSemester))]
        public Semester? Semester {get;set;}

        public long IdProfessionalSchool {get;set;}
        [ForeignKey(nameof(IdProfessionalSchool))]
        public ProfessionalSchool? ProfessionalSchool {get;set;}

        // public ICollection<CourseRegistration>? CourseRegistrations {get;set;}
    }
}