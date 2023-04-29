using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.BusinessService;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalSchoolController:ControllerBase
    {
        private ProfessionalSchoolBS _ProfessionalSchoolBS;
        public ProfessionalSchoolController(ProfessionalSchoolBS ProfessionalSchoolBS)
        {
            _ProfessionalSchoolBS = ProfessionalSchoolBS;
        }
        //Get todos
        [HttpGet]
        public List<ProfessionalSchool> Get(){
            return _ProfessionalSchoolBS.Get();
        }
        //Get by id
        [HttpGet("{id}")]
        public ProfessionalSchool? Get(long id){
            return _ProfessionalSchoolBS.Get(id);
        }
        //Insert Beer
        [HttpPost]
        public ProfessionalSchool? Insert(ProfessionalSchool acDe){
            return _ProfessionalSchoolBS.Insert(acDe);
        }

        //Update beer
        [HttpPut]
        public ProfessionalSchool? Update(ProfessionalSchool acDe){
            return _ProfessionalSchoolBS.Update(acDe);
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            return _ProfessionalSchoolBS.Delete(id);
        }
        // private Context _context;
        // public ProfessionalSchoolController(Context context)
        // {
        //     _context = context;
        // }
        // // Get Beers
        // [HttpGet]
        // public IEnumerable<ProfessionalSchool> Get(){
            
        //     return _context.ProfessionalSchools.ToList();
        // }

        // //Get one beer
        // [HttpGet("{id}")]
        // public ProfessionalSchool? Get(long id){
        //     var professionalSchools = _context.ProfessionalSchools.Find(id);
        //     return professionalSchools;
        // }

        // //Insert Beer
        // [HttpPost]
        // public ProfessionalSchool Insert(ProfessionalSchool professionalSchool){
        //     _context.ProfessionalSchools.Add(professionalSchool);
        //     _context.SaveChanges();
        //     return professionalSchool;
        // }

        // //Update beer
        // [HttpPut]
        // public ProfessionalSchool? Update(ProfessionalSchool professionalSchool){
        //     var professionalSchoolDbo = _context.ProfessionalSchools.Find(professionalSchool.Id);

        //     if(professionalSchoolDbo == null) return null;

        //     professionalSchoolDbo.Name = professionalSchool.Name;
        //     _context.SaveChanges();
        //     return professionalSchoolDbo;
        // }

        // //Delete beer
        // [HttpDelete("{id}")]
        // public bool Delete(long id){
        //     var professionalSchoolDbo = _context.ProfessionalSchools.Find(id);
        //     if(professionalSchoolDbo==null) return false;

        //     _context.ProfessionalSchools.Remove(professionalSchoolDbo);
        //     _context.SaveChanges();
        //     return true;
        // }
    }
}