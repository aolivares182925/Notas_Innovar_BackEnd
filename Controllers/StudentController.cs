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
    public class StudentController : ControllerBase
    {
        private Context _context;
        public StudentController(Context context){
            _context = context;
        }
        //Get Student
        [HttpGet]
        public IEnumerable<Student> Get(){
            return _context.Students.ToList();
        }
        //Get one student
        [HttpGet("{id}")]
        public Student? Get(long id){
            var student = _context.Students.Find(id);
            return student;
        }
        //Insert Student
        [HttpPost]
        public Student Post(Student student){
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }
        //Update Student
        [HttpPut]
        public Student? Update(Student student){
            var studentDbo = _context.Students.Find(student.Id);

            if(studentDbo == null) return null;

            studentDbo.Name = student.Name;
            _context.SaveChanges();
            return studentDbo;
        }
        //Delete Student
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var studentDbo = _context.Students.Find(id);
            if(studentDbo==null) return false;

            _context.Students.Remove(studentDbo);
            _context.SaveChanges();
            return true;
        }

    }


}