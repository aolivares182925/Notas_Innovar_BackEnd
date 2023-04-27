using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalSchoolController:ControllerBase
    {
        private Context _context;
        public ProfessionalSchoolController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<ProfessionalSchool> Get(){
            
            return _context.ProfessionalSchools.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public ProfessionalSchool? Get(long id){
            var professionalSchools = _context.ProfessionalSchools.Find(id);
            return professionalSchools;
        }

        //Insert Beer
        [HttpPost]
        public ProfessionalSchool Insert(ProfessionalSchool professionalSchool){
            _context.ProfessionalSchools.Add(professionalSchool);
            _context.SaveChanges();
            return professionalSchool;
        }

        //Update beer
        [HttpPut]
        public ProfessionalSchool? Update(ProfessionalSchool professionalSchool){
            var professionalSchoolDbo = _context.ProfessionalSchools.Find(professionalSchool.Id);

            if(professionalSchoolDbo == null) return null;

            professionalSchoolDbo.Name = professionalSchool.Name;
            _context.SaveChanges();
            return professionalSchoolDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var professionalSchoolDbo = _context.ProfessionalSchools.Find(id);
            if(professionalSchoolDbo==null) return false;

            _context.ProfessionalSchools.Remove(professionalSchoolDbo);
            _context.SaveChanges();
            return true;
        }
    }
}