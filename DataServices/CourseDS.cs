using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class CourseDS
    {
        private Context _context;

        public CourseDS(Context context){
            _context = context;
        }

        public List<Course> Get(){
            return _context.Courses.ToList();
        }

        public Course? Get(long Id){
            return _context.Courses.Find(Id);
        }

        public Course? Insert(Course course){
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }
        public Course? Update(Course course){
            var courseDbo = _context.Courses.Find(course.Id);

            if(courseDbo == null) return null;

            courseDbo.Name = course.Name;
            courseDbo.Credits = course.Credits;

            _context.SaveChanges();
            return courseDbo;
        }
        public bool Delete(long Id){
            var courseDbo = _context.Courses.Find(Id);
            if(courseDbo == null) return false;

            _context.Courses.Remove(courseDbo);
            _context.SaveChanges();
            return true;
        }
    }
}