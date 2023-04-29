using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class AnswerBS
    {
        private AnswerDS _answerDS;
        public AnswerBS(AnswerDS alternativeDS){
            _answerDS = alternativeDS;
        }
        public List<Answer> Get(){
            var answerList = _answerDS.Get();
            return answerList;
        }

        public Answer? Get(long id){
            var answer = _answerDS.Get(id);
            return answer;
        }

        public Answer? Insert(Answer acDe){
            var answerI = _answerDS.Insert(acDe);
            return answerI;
        }

        public Answer? Update(Answer acDe){
            return _answerDS.Update(acDe);
        }

        public bool Delete(long id){
            return _answerDS.Delete(id);
        }

    }
}