using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Student
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}


        public ICollection<Registration>? Registrations {get;set;}
        public ICollection<Answer>? Answers {get;set;}
    }
}