using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class Semester
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}
        public string DateStart {get;set;}
        public string DateFinish {get;set;}
        public ICollection<Registration>? Registrations {get;set;}
    }
}