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
    public class SemesterController:ControllerBase
    {
        private Context _context;
        public SemesterController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<Semester> Get(){
            return _context.Semesters.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public Semester? Get(long id){
            var semester = _context.Semesters.Find(id);
            return semester;
        }

        //Insert Beer
        [HttpPost]
        public Semester Insert(Semester semester){
            _context.Semesters.Add(semester);
            _context.SaveChanges();
            return semester;
        }

        //Update beer
        [HttpPut]
        public Semester? Update(Semester semester){
            var semesterDbo = _context.Semesters.Find(semester.Id);

            if(semesterDbo == null) return null;

            semesterDbo.Name = semester.Name;
            semesterDbo.DateStart = semester.DateStart;
            semesterDbo.DateFinish = semester.DateFinish;

            _context.SaveChanges();
            return semesterDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var semesterDbo = _context.Semesters.Find(id);
            if(semesterDbo==null) return false;

            _context.Semesters.Remove(semesterDbo);
            _context.SaveChanges();
            return true;
        }
    }
}