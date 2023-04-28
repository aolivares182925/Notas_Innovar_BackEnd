using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Exam
    {
        [Key]
        public long Id {get;set;}
        public string Date {get;set;}
        public float Score {get;set;}
        public long IdChapter {get;set;}
        [ForeignKey(nameof(IdChapter))]
        public Chapter? Chapter {get;set;}


        public ICollection<Question>? Questions {get;set;}

    }
}