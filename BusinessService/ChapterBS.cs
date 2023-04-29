using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class ChapterBS
    {
        private ChapterDS _chapterDS;
        public ChapterBS(ChapterDS chapterDS){
            _chapterDS = chapterDS;
        }
        public List<Chapter> Get(){
            var chapterList = _chapterDS.Get();
            return chapterList;
        }

        public Chapter? Get(long id){
            var answer = _chapterDS.Get(id);
            return answer;
        }

        public Chapter? Insert(Chapter acDe){
            var answerI = _chapterDS.Insert(acDe);
            return answerI;
        }

        public Chapter? Update(Chapter acDe){
            return _chapterDS.Update(acDe);
        }

        public bool Delete(long id){
            return _chapterDS.Delete(id);
        }
    }
}