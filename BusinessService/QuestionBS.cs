using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class QuestionBS
    {
        private QuestionDS _questionDS;
        public QuestionBS(QuestionDS questionDS){
            _questionDS = questionDS;
        }
        public List<Question> Get(){
            var questionList = _questionDS.Get();
            return questionList;
        }

        public Question? Get(long id){
            var question = _questionDS.Get(id);
            return question;
        }

        public Question? Insert(Question question){
            var questionInserted = _questionDS.Insert(question);
            return questionInserted;
        }

        public Question? Update(Question question){
            return _questionDS.Update(question);
        }

        public bool Delete(long id){
            return _questionDS.Delete(id);
        }

    }
}