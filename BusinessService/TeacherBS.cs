using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class TeacherBS
    {
        private TeacherDS _teacherDS;
        public TeacherBS(TeacherDS teacherDS){
            _teacherDS = teacherDS;
        }
        public List<Teacher> Get(){
            var teacherList = _teacherDS.Get();
            return teacherList;
        }

        public Teacher? Get(long id){
            var teacher = _teacherDS.Get(id);
            return teacher;
        }

        public Teacher? Insert(Teacher teacher){
            var teacherInserted = _teacherDS.Insert(teacher);
            return teacherInserted;
        }

        public Teacher? Update(Teacher teacher){
            return _teacherDS.Update(teacher);
        }

        public bool Delete(long id){
            return _teacherDS.Delete(id);
        }
    }
}