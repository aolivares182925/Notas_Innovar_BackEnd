using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class AnswerDS
    {
        private Context _context;

        public AnswerDS(Context context){
            _context = context;
        }

        public List<Answer> Get(){
            return _context.Answers.ToList();
        }

        public Answer? Get(long Id){
            return _context.Answers.Find(Id);
        }

        public Answer? Insert(Answer answer){
            _context.Answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }
        public Answer? Update(Answer answer){
            var answerDbo = _context.Answers.Find(answer.Id);

            if(answerDbo == null) return null;

            answerDbo.SelectedAnswer = answer.SelectedAnswer;
            answerDbo.IdStudent = answer.IdStudent;
            answerDbo.IdQuestion = answer.IdQuestion;

            _context.SaveChanges();
            return answerDbo;
        }
        public bool Delete(long Id){
            var answerDbo = _context.Answers.Find(Id);
            if(answerDbo == null) return false;

            _context.Answers.Remove(answerDbo);
            _context.SaveChanges();
            return true;
        }

    }
}