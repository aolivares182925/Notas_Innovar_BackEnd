using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotasAPI.Modules
{
    public class ProfessionalSchool
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}

        
        public long IdAcademicDepartment {get;set;}

        [ForeignKey(nameof(IdAcademicDepartment))]
        public AcademicDepartment? AcademicDepartment {get;set;}

    }
}