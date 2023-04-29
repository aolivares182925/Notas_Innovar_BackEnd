using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class StudentDS
    {
        private Context _context;

        public StudentDS(Context context){
            _context = context;
        }

        public List<Student> Get(){
            return _context.Students.ToList();
        }

        public Student? Get(long Id){
            return _context.Students.Find(Id);
        }

        public Student? Insert(Student student){
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }
        public Student? Update(Student student){
            var studentDbo = _context.Students.Find(student.Id);

            if(studentDbo == null) return null;

            studentDbo.Name = student.Name;

            _context.SaveChanges();
            return studentDbo;
        }
        public bool Delete(long Id){
            var studentDbo = _context.Students.Find(Id);
            if(studentDbo == null) return false;

            _context.Students.Remove(studentDbo);
            _context.SaveChanges();
            return true;
        }
    }
}