using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController:ControllerBase
    {
        private Context _context;
        public StudentController(Context context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Student> Get(){
            return _context.Students.ToList();
        }
        [HttpPost]
        public Student Post(Student student){
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        
    }
}