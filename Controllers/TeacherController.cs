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
    public class TeacherController:ControllerBase
    {
        private Context _context;
        public TeacherController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<Teacher> Get(){
            return _context.Teachers.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public Teacher? Get(long id){
            var teacher = _context.Teachers.Find(id);
            return teacher;
        }

        //Insert Beer
        [HttpPost]
        public Teacher Insert(Teacher teacher){
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        //Update beer
        [HttpPut]
        public Teacher? Update(Teacher teacher){
            var teacherDbo = _context.Teachers.Find(teacher.Id);

            if(teacherDbo == null) return null;

            teacherDbo.Name = teacher.Name;

            _context.SaveChanges();
            return teacherDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var teacherDbo = _context.Teachers.Find(id);
            if(teacherDbo==null) return false;

            _context.Teachers.Remove(teacherDbo);
            _context.SaveChanges();
            return true;
        }
        
    }
}