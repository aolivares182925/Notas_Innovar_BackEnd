using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class TeacherCourseBS
    {
        private TeacherCourseDS _teacherCourseDS;
        public TeacherCourseBS(TeacherCourseDS teacherCourseDS){
            _teacherCourseDS = teacherCourseDS;
        }
        public List<TeacherCourse> Get(){
            var teacherCourseList = _teacherCourseDS.Get();
            return teacherCourseList;
        }

        public TeacherCourse? Get(long id){
            var teacherCourse = _teacherCourseDS.Get(id);
            return teacherCourse;
        }

        public TeacherCourse? Insert(TeacherCourse teacherCourse){
            var teacherCourseInserted = _teacherCourseDS.Insert(teacherCourse);
            return teacherCourseInserted;
        }

        public TeacherCourse? Update(TeacherCourse teacherCourse){
            return _teacherCourseDS.Update(teacherCourse);
        }

        public bool Delete(long id){
            return _teacherCourseDS.Delete(id);
        }
    }
}