using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.DataServices;
using NotasAPI.Modules;

namespace NotasAPI.BusinessService
{
    public class RegistrationBS
    {
        private RegistrationDS _registrationDS;
        public RegistrationBS(RegistrationDS registrationDS){
            _registrationDS = registrationDS;
        }
        public List<Registration> Get(){
            var registrationList = _registrationDS.Get();
            return registrationList;
        }

        public Registration? Get(long id){
            var registration = _registrationDS.Get(id);
            return registration;
        }

        public Registration? Insert(Registration registration){
            var registrationInserted = _registrationDS.Insert(registration);
            return registrationInserted;
        }

        public Registration? Update(Registration registration){
            return _registrationDS.Update(registration);
        }

        public bool Delete(long id){
            return _registrationDS.Delete(id);
        }
    }
}