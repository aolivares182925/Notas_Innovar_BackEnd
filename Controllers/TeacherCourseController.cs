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
    public class TeacherCourseController
    {
        private Context _context;
        public TeacherCourseController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<TeacherCourse> Get(){
            return _context.TeacherCourses.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public TeacherCourse? Get(long id){
            var teacherCourse = _context.TeacherCourses.Find(id);
            return teacherCourse;
        }

        //Insert Beer
        [HttpPost]
        public TeacherCourse Insert(TeacherCourse teacherCourse){
            _context.TeacherCourses.Add(teacherCourse);
            _context.SaveChanges();
            return teacherCourse;
        }

        //Update beer
        [HttpPut]
        public TeacherCourse? Update(TeacherCourse teacherCourse){
            var teacherCourseDbo = _context.TeacherCourses.Find(teacherCourse.Id);

            if(teacherCourseDbo == null) return null;

            teacherCourseDbo.IdCourse = teacherCourse.IdTeacher;
            teacherCourseDbo.IdCourse = teacherCourse.IdTeacher;

            _context.SaveChanges();
            return teacherCourseDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var teacherCourseDbo = _context.TeacherCourses.Find(id);
            if(teacherCourseDbo==null) return false;

            _context.TeacherCourses.Remove(teacherCourseDbo);
            _context.SaveChanges();
            return true;
        }
 
    }
}