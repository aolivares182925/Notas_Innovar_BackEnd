using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class ExamBS
    {
        private ExamDS _examDS;
        public ExamBS(ExamDS examDS){
            _examDS = examDS;
        }
        public List<Exam> Get(){
            var examList = _examDS.Get();
            return examList;
        }

        public Exam? Get(long id){
            var exam = _examDS.Get(id);
            return exam;
        }

        public Exam? Insert(Exam acDe){
            var acDeInserted = _examDS.Insert(acDe);
            return acDeInserted;
        }

        public Exam? Update(Exam acDe){
            return _examDS.Update(acDe);
        }

        public bool Delete(long id){
            return _examDS.Delete(id);
        }

    }
}