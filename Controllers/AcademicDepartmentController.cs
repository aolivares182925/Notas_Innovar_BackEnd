using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.Modules;
using Microsoft.EntityFrameworkCore;
using NotasAPI.BusinessService;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcademicDepartmentController:ControllerBase
    {
        private AcademicDepartmentBusinessService _AcDeBusinessService;
        public AcademicDepartmentController(AcademicDepartmentBusinessService AcDeBusinessService)
        {
            _AcDeBusinessService = AcDeBusinessService;
        }
        //Get todos
        [HttpGet]
        public List<AcademicDepartment> Get(){
            return _AcDeBusinessService.Get();
        }
        //Get by id
        [HttpGet("{id}")]
        public AcademicDepartment? Get(long id){
            return _AcDeBusinessService.Get(id);
        }
        //Insert Beer
        [HttpPost]
        public AcademicDepartment? Insert(AcademicDepartment acDe){
            return _AcDeBusinessService.Insert(acDe);
        }

        //Update beer
        [HttpPut]
        public AcademicDepartment? Update(AcademicDepartment acDe){
            return _AcDeBusinessService.Update(acDe);
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            return _AcDeBusinessService.Delete(id);
        }

        [HttpPost("[action]")]
        public List<AcademicDepartment> GetADByName(string name){
            return _AcDeBusinessService.GetADByName(name);
        }

        [HttpPost("[action]")]
        public List<AcademicDepartment> GetADWhitProfSchools(){
            return _AcDeBusinessService.GetADWhitProfSchools();
        }

        //Get beer names
        [HttpPost("[action]")]
        public List<string> GetAcDeNames(){
            return _AcDeBusinessService.GetAcDeNames();
        }
        
        //Get beer names upper case
        [HttpPost("[action]")]
        public List<string> GetAcDeNamesUpperCase(){
            return _AcDeBusinessService.GetAcDeNamesUpperCase();
        }

        // private Context _context;
        // public AcademicDepartmentController(Context context)
        // {
        //     _context = context;
        // }
        // // Get Beers
        // [HttpGet]
        // public IEnumerable<AcademicDepartment> Get(){
        //     return _context.AcademicDepartments.Include(PS => PS.ProfessionalSchools).ToList();
        // }


        // //Get one beer
        // [HttpGet("{id}")]
        // public AcademicDepartment? Get(long id){
        //     var academicDepartment = _context.AcademicDepartments.Find(id);
        //     return academicDepartment;
        // }

        // //Insert Beer
        // [HttpPost]
        // public AcademicDepartment Insert(AcademicDepartment academicDepartment){
        //     _context.AcademicDepartments.Add(academicDepartment);
        //     _context.SaveChanges();
        //     return academicDepartment;
        // }

        // //Update beer
        // [HttpPut]
        // public AcademicDepartment? Update(AcademicDepartment academicDepartment){
        //     var academicDepartmentDbo = _context.AcademicDepartments.Find(academicDepartment.Id);

        //     if(academicDepartmentDbo == null) return null;

        //     academicDepartmentDbo.Name = academicDepartment.Name;
        //     _context.SaveChanges();
        //     return academicDepartmentDbo;
        // }

        // //Delete beer
        // [HttpDelete("{id}")]
        // public bool Delete(long id){
        //     var academicDepartmentDbo = _context.AcademicDepartments.Find(id);
        //     if(academicDepartmentDbo==null) return false;

        //     _context.AcademicDepartments.Remove(academicDepartmentDbo);
        //     _context.SaveChanges();
        //     return true;
        // }

    }
}