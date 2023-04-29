using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class RegistrationDS
    {
        private Context _context;

        public RegistrationDS(Context context){
            _context = context;
        }

        public List<Registration> Get(){
            return _context.Registrations.ToList();
        }

        public Registration? Get(long Id){
            return _context.Registrations.Find(Id);
        }

        public Registration? Insert(Registration registration){
            _context.Registrations.Add(registration);
            _context.SaveChanges();
            return registration;
        }
        public Registration? Update(Registration registration){
            var registrationDbo = _context.Registrations.Find(registration.Id);

            if(registrationDbo == null) return null;

            registrationDbo.IdStudent = registration.IdStudent;
            registrationDbo.IdCourse = registration.IdCourse;
            registrationDbo.IdProfessionalSchool = registration.IdProfessionalSchool;
            registrationDbo.IdSemester = registration.IdSemester;


            _context.SaveChanges();
            return registrationDbo;
        }
        public bool Delete(long Id){
            var registrationDbo = _context.Registrations.Find(Id);
            if(registrationDbo == null) return false;

            _context.Registrations.Remove(registrationDbo);
            _context.SaveChanges();
            return true;
        }
    }
}