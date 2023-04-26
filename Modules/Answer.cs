using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Answer
    {
        public long Id {get;set;}
        public long IdStudent {get;set;}
        public long IdQuestion {get;set;}
        public string SelectedAnswer {get;set;}
    }
}