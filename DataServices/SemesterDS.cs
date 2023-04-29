using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class SemesterDS
    {
        private Context _context;

        public SemesterDS(Context context){
            _context = context;
        }

        public List<Semester> Get(){
            return _context.Semesters.ToList();
        }

        public Semester? Get(long Id){
            return _context.Semesters.Find(Id);
        }

        public Semester? Insert(Semester semester){
            _context.Semesters.Add(semester);
            _context.SaveChanges();
            return semester;
        }
        public Semester? Update(Semester semester){
            var semesterDbo = _context.Semesters.Find(semester.Id);

            if(semesterDbo == null) return null;

            semesterDbo.Name = semester.Name;
            semesterDbo.DateStart = semester.DateStart;
            semesterDbo.DateFinish = semester.DateFinish;

            _context.SaveChanges();
            return semesterDbo;
        }
        public bool Delete(long Id){
            var semesterDbo = _context.Semesters.Find(Id);
            if(semesterDbo == null) return false;

            _context.Semesters.Remove(semesterDbo);
            _context.SaveChanges();
            return true;
        }
    }
}