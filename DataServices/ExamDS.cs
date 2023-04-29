using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class ExamDS
    {
        private Context _context;

        public ExamDS(Context context){
            _context = context;
        }

        public List<Exam> Get(){
            return _context.Exams.ToList();
        }

        public Exam? Get(long Id){
            return _context.Exams.Find(Id);
        }

        public Exam? Insert(Exam exam){
            _context.Exams.Add(exam);
            _context.SaveChanges();
            return exam;
        }
        public Exam? Update(Exam exam){
            var examDbo = _context.Exams.Find(exam.Id);

            if(examDbo == null) return null;

            examDbo.Date = exam.Date;
            examDbo.Score = exam.Score;
            examDbo.IdChapter = exam.IdChapter;

            _context.SaveChanges();
            return examDbo;
        }
        public bool Delete(long Id){
            var examDbo = _context.Exams.Find(Id);
            if(examDbo == null) return false;

            _context.Exams.Remove(examDbo);
            _context.SaveChanges();
            return true;
        }
    }
}