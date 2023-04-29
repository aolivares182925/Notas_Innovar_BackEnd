using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotasAPI.BusinessService;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CourseController:ControllerBase
    {
        private CourseBS _CourseBS;
        public CourseController(CourseBS CourseBS)
        {
            _CourseBS = CourseBS;
        }
        //Get todos
        [HttpGet]
        public List<Course> Get(){
            return _CourseBS.Get();
        }
        //Get by id
        [HttpGet("{id}")]
        public Course? Get(long id){
            return _CourseBS.Get(id);
        }
        //Insert Beer
        [HttpPost]
        public Course? Insert(Course acDe){
            return _CourseBS.Insert(acDe);
        }

        //Update beer
        [HttpPut]
        public Course? Update(Course acDe){
            return _CourseBS.Update(acDe);
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            return _CourseBS.Delete(id);
        }
        // private Context _context;
        // public CourseController(Context context)
        // {
        //     _context = context;
        // }
        // // Get Beers
        // [HttpGet]
        // public IEnumerable<Course> Get(){
        //     return _context.Courses.Include(course => course.Chapters).ToList();
        // }

        // //Get one beer
        // [HttpGet("{id}")]
        // public Course? Get(long id){
        //     var course = _context.Courses.Find(id);
        //     return course;
        // }

        // //Insert Beer
        // [HttpPost]
        // public Course Insert(Course course){
        //     _context.Courses.Add(course);
        //     _context.SaveChanges();
        //     return course;
        // }

        // //Update beer
        // [HttpPut]
        // public Course? Update(Course course){
        //     var courseDbo = _context.Courses.Find(course.Id);

        //     if(courseDbo == null) return null;

        //     courseDbo.Name = course.Name;

        //     _context.SaveChanges();
        //     return courseDbo;
        // }

        // //Delete beer
        // [HttpDelete("{id}")]
        // public bool Delete(long id){
        //     var courseDbo = _context.Courses.Find(id);
        //     if(courseDbo==null) return false;

        //     _context.Courses.Remove(courseDbo);
        //     _context.SaveChanges();
        //     return true;
        // }
    }
}