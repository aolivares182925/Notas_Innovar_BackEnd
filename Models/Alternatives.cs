using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Alternatives
    {
        public long Id {get;set;}
        public long IdQuestion {get;set;}
        public string Alternative1 {get;set;}
        public string Alternative2 {get;set;}
        public string Alternative3 {get;set;}
        public string Alternative4 {get;set;}
        public string CorrectAlternative {get;set;}
        
    }
}