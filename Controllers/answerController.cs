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
    public class AnswerController: ControllerBase
    {
        private Context _context;
        public AnswerController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<Answer> Get(){
            return _context.Answers.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public Answer? Get(long id){
            var answer = _context.Answers.Find(id);
            return answer;
        }

        //Insert Beer
        [HttpPost]
        public Answer Insert(Answer answer){
            _context.Answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        //Update beer
        [HttpPut]
        public Answer? Update(Answer answer){
            var answerDbo = _context.Answers.Find(answer.Id);

            if(answerDbo == null) return null;

            answerDbo.Question = answer.Question;
            answerDbo.IdStudent = answer.IdStudent;

            _context.SaveChanges();
            return answerDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var answerDbo = _context.Answers.Find(id);
            if(answerDbo==null) return false;

            _context.Answers.Remove(answerDbo);
            _context.SaveChanges();
            return true;
        }
 

        
    }
}