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
    public class QuestionController
    {
        private QuestionBS _QuestionBS;
        public QuestionController(QuestionBS QuestionBS)
        {
            _QuestionBS = QuestionBS;
        }
        //Get todos
        [HttpGet]
        public List<Question> Get(){
            return _QuestionBS.Get();
        }
        //Get by id
        [HttpGet("{id}")]
        public Question? Get(long id){
            return _QuestionBS.Get(id);
        }
        //Insert Beer
        [HttpPost]
        public Question? Insert(Question acDe){
            return _QuestionBS.Insert(acDe);
        }

        //Update beer
        [HttpPut]
        public Question? Update(Question acDe){
            return _QuestionBS.Update(acDe);
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            return _QuestionBS.Delete(id);
        }
        // private Context _context;
        // public QuestionController(Context context)
        // {
        //     _context = context;
        // }
        // // Get Beers
        // [HttpGet]
        // public IEnumerable<Question> Get(){
        //     return _context.Questions.ToList();
        // }

        // //Get one beer
        // [HttpGet("{id}")]
        // public Question? Get(long id){
        //     var question = _context.Questions.Find(id);
        //     return question;
        // }

        // //Insert Beer
        // [HttpPost]
        // public Question Insert(Question question){
        //     _context.Questions.Add(question);
        //     _context.SaveChanges();
        //     return question;
        // }

        // //Update beer
        // [HttpPut]
        // public Question? Update(Question question){
        //     var questionDbo = _context.Questions.Find(question.Id);

        //     if(questionDbo == null) return null;

        //     questionDbo.TextQuestion = question.TextQuestion;
        //     questionDbo.IdExam = question.IdExam;

        //     _context.SaveChanges();
        //     return questionDbo;
        // }

        // //Delete beer
        // [HttpDelete("{id}")]
        // public bool Delete(long id){
        //     var questionDbo = _context.Questions.Find(id);
        //     if(questionDbo==null) return false;

        //     _context.Questions.Remove(questionDbo);
        //     _context.SaveChanges();
        //     return true;
        // }
 
    }
}