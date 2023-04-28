using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamController: ControllerBase
    {
        private Context _context;
        public ExamController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<Exam> Get(){
            return _context.Exams.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public Exam? Get(long id){
            var exam = _context.Exams.Find(id);
            return exam;
        }

        //Insert Beer
        [HttpPost]
        public Exam Insert(Exam exam){
            _context.Exams.Add(exam);
            _context.SaveChanges();
            return exam;
        }

        //Update beer
        [HttpPut]
        public Exam? Update(Exam exam){
            var examDbo = _context.Exams.Find(exam.Id);

            if(examDbo == null) return null;

            examDbo.Date = exam.Date;
            examDbo.Score = exam.Score;
            examDbo.IdChapter = exam.IdChapter;

            _context.SaveChanges();
            return examDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var examDbo = _context.Exams.Find(id);
            if(examDbo==null) return false;

            _context.Exams.Remove(examDbo);
            _context.SaveChanges();
            return true;
        }
 
    }
}