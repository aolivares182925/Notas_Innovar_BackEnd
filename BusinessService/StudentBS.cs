using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class StudentBS
    {
        private StudentDS _studentDS;
        public StudentBS(StudentDS studentDS){
            _studentDS = studentDS;
        }
        public List<Student> Get(){
            var studentList = _studentDS.Get();
            return studentList;
        }

        public Student? Get(long id){
            var student = _studentDS.Get(id);
            return student;
        }

        public Student? Insert(Student student){
            var studentInserted = _studentDS.Insert(student);
            return studentInserted;
        }

        public Student? Update(Student student){
            return _studentDS.Update(student);
        }

        public bool Delete(long id){
            return _studentDS.Delete(id);
        }
    }
}