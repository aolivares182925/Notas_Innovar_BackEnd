using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Exam
    {
        public long Id {get;set;}
        public string Date {get;set;}
        public float Score {get;set;}
        public long IdChapter {get;set;}
    }
}