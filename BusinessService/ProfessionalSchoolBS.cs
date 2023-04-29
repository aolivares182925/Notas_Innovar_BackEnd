using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class ProfessionalSchoolBS
    {
        private ProfessionalSchoolDS _professionalSchoolDS;
        public ProfessionalSchoolBS(ProfessionalSchoolDS professionalSchoolDS){
            _professionalSchoolDS = professionalSchoolDS;
        }
        public List<ProfessionalSchool> Get(){
            var professionalSchoolList = _professionalSchoolDS.Get();
            return professionalSchoolList;
        }

        public ProfessionalSchool? Get(long id){
            var professionalSchool = _professionalSchoolDS.Get(id);
            return professionalSchool;
        }

        public ProfessionalSchool? Insert(ProfessionalSchool acDe){
            var professionalSchoolInserted = _professionalSchoolDS.Insert(acDe);
            return professionalSchoolInserted;
        }

        public ProfessionalSchool? Update(ProfessionalSchool acDe){
            return _professionalSchoolDS.Update(acDe);
        }

        public bool Delete(long id){
            return _professionalSchoolDS.Delete(id);
        }

    }
}