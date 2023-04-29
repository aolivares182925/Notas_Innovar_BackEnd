using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.BusinessService;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController: ControllerBase
    {
        private AnswerBS _AnswerBS;
        public AnswerController(AnswerBS AnswerBS)
        {
            _AnswerBS = AnswerBS;
        }
        //Get todos
        [HttpGet]
        public List<Answer> Get(){
            return _AnswerBS.Get();
        }
        //Get by id
        [HttpGet("{id}")]
        public Answer? Get(long id){
            return _AnswerBS.Get(id);
        }
        //Insert Beer
        [HttpPost]
        public Answer? Insert(Answer acDe){
            return _AnswerBS.Insert(acDe);
        }

        //Update beer
        [HttpPut]
        public Answer? Update(Answer acDe){
            return _AnswerBS.Update(acDe);
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            return _AnswerBS.Delete(id);
        }
        // private Context _context;
        // public AnswerController(Context context)
        // {
        //     _context = context;
        // }
        // // Get Beers
        // [HttpGet]
        // public IEnumerable<Answer> Get(){
        //     return _context.Answers.ToList();
        // }

        // //Get one beer
        // [HttpGet("{id}")]
        // public Answer? Get(long id){
        //     var answer = _context.Answers.Find(id);
        //     return answer;
        // }

        // //Insert Beer
        // [HttpPost]
        // public Answer Insert(Answer answer){
        //     _context.Answers.Add(answer);
        //     _context.SaveChanges();
        //     return answer;
        // }

        // //Update beer
        // [HttpPut]
        // public Answer? Update(Answer answer){
        //     var answerDbo = _context.Answers.Find(answer.Id);

        //     if(answerDbo == null) return null;

        //     answerDbo.Question = answer.Question;
        //     answerDbo.IdStudent = answer.IdStudent;

        //     _context.SaveChanges();
        //     return answerDbo;
        // }

        // //Delete beer
        // [HttpDelete("{id}")]
        // public bool Delete(long id){
        //     var answerDbo = _context.Answers.Find(id);
        //     if(answerDbo==null) return false;

        //     _context.Answers.Remove(answerDbo);
        //     _context.SaveChanges();
        //     return true;
        // }
 

        
    }
}