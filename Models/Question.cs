using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Question
    {
        [Key]
        public long Id {get;set;}
        public string TextQuestion {get;set;}
        public long IdExam {get;set;}
        [ForeignKey(nameof(IdExam))]
        public Exam? Exam {get;set;}

        public ICollection<Answer>? Answers {get;set;}

        public ICollection<Alternative>? Alternatives {get;set;}

    }
}