using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class AlternativeBS
    {
        private AlternativeDS _alternativeDS;
        public AlternativeBS(AlternativeDS alternativeDS){
            _alternativeDS = alternativeDS;
        }
        public List<Alternative> Get(){
            var alternativeList = _alternativeDS.Get();
            return alternativeList;
        }

        public Alternative? Get(long id){
            var alternative = _alternativeDS.Get(id);
            return alternative;
        }

        public Alternative? Insert(Alternative acDe){
            var acDeInserted = _alternativeDS.Insert(acDe);
            return acDeInserted;
        }

        public Alternative? Update(Alternative acDe){
            return _alternativeDS.Update(acDe);
        }

        public bool Delete(long id){
            return _alternativeDS.Delete(id);
        }


        
    }
}