using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class QuestionDS
    {
        private Context _context;

        public QuestionDS(Context context){
            _context = context;
        }

        public List<Question> Get(){
            return _context.Questions.ToList();
        }

        public Question? Get(long Id){
            return _context.Questions.Find(Id);
        }

        public Question? Insert(Question question){
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question;
        }
        public Question? Update(Question question){
            var questionDbo = _context.Questions.Find(question.Id);

            if(questionDbo == null) return null;

            questionDbo.TextQuestion = question.TextQuestion;
            questionDbo.IdExam = question.IdExam;

            _context.SaveChanges();
            return questionDbo;
        }
        public bool Delete(long Id){
            var questionDbo = _context.Questions.Find(Id);
            if(questionDbo == null) return false;

            _context.Questions.Remove(questionDbo);
            _context.SaveChanges();
            return true;
        }
    }
}