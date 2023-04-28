using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Alternative
    {
        [Key]
        public long Id {get;set;}
        
        public long IdQuestion {get;set;}
        [ForeignKey(nameof(IdQuestion))]
        public Question? Question {get;set;}
        
        public string Alternative1 {get;set;}
        public string Alternative2 {get;set;}
        public string Alternative3 {get;set;}
        public string Alternative4 {get;set;}
        public string CorrectAlternative {get;set;}
        
    }
}