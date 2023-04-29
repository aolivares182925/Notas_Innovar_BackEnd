using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class SemesterBS
    {
        private SemesterDS _semesterDS;
        public SemesterBS(SemesterDS semesterDS){
            _semesterDS = semesterDS;
        }
        public List<Semester> Get(){
            var semesterList = _semesterDS.Get();
            return semesterList;
        }

        public Semester? Get(long id){
            var semester = _semesterDS.Get(id);
            return semester;
        }

        public Semester? Insert(Semester semester){
            var semesterInserted = _semesterDS.Insert(semester);
            return semesterInserted;
        }

        public Semester? Update(Semester semester){
            return _semesterDS.Update(semester);
        }

        public bool Delete(long id){
            return _semesterDS.Delete(id);
        }
    }
}