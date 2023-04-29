using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class TeacherCourseDS
    {
        private Context _context;

        public TeacherCourseDS(Context context){
            _context = context;
        }

        public List<TeacherCourse> Get(){
            return _context.TeacherCourses.ToList();
        }

        public TeacherCourse? Get(long Id){
            return _context.TeacherCourses.Find(Id);
        }

        public TeacherCourse? Insert(TeacherCourse teacherCourse){
            _context.TeacherCourses.Add(teacherCourse);
            _context.SaveChanges();
            return teacherCourse;
        }
        public TeacherCourse? Update(TeacherCourse teacherCourse){
            var teacherCourseDbo = _context.TeacherCourses.Find(teacherCourse.Id);

            if(teacherCourseDbo == null) return null;

            teacherCourseDbo.IdTeacher = teacherCourse.IdTeacher;
            teacherCourseDbo.IdCourse = teacherCourse.IdCourse;

            _context.SaveChanges();
            return teacherCourseDbo;
        }
        public bool Delete(long Id){
            var teacherCourseDbo = _context.TeacherCourses.Find(Id);
            if(teacherCourseDbo == null) return false;

            _context.TeacherCourses.Remove(teacherCourseDbo);
            _context.SaveChanges();
            return true;
        }
    }
}