using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class AcademicDepartment
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}
        public ICollection<ProfessionalSchool>? ProfessionalSchools {get;set;}
    }
}