using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class TeacherDS
    {
        private Context _context;

        public TeacherDS(Context context){
            _context = context;
        }

        public List<Teacher> Get(){
            return _context.Teachers.ToList();
        }

        public Teacher? Get(long Id){
            return _context.Teachers.Find(Id);
        }

        public Teacher? Insert(Teacher teacher){
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }
        public Teacher? Update(Teacher teacher){
            var teacherDbo = _context.Teachers.Find(teacher.Id);

            if(teacherDbo == null) return null;

            teacherDbo.Name = teacher.Name;

            _context.SaveChanges();
            return teacherDbo;
        }
        public bool Delete(long Id){
            var teacherDbo = _context.Teachers.Find(Id);
            if(teacherDbo == null) return false;

            _context.Teachers.Remove(teacherDbo);
            _context.SaveChanges();
            return true;
        }
    }
}