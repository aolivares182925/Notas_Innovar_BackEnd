using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasAPI.Modules;

namespace NotasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController
    {
        private Context _context;
        public RegistrationController(Context context)
        {
            _context = context;
        }
        // Get Beers
        [HttpGet]
        public IEnumerable<Registration> Get(){
            return _context.Registrations.ToList();
        }

        //Get one beer
        [HttpGet("{id}")]
        public Registration? Get(long id){
            var registration = _context.Registrations.Find(id);
            return registration;
        }

        //Insert Beer
        [HttpPost]
        public Registration Insert(Registration registration){
            _context.Registrations.Add(registration);
            _context.SaveChanges();
            return registration;
        }

        //Update beer
        [HttpPut]
        public Registration? Update(Registration registration){
            var registrationDbo = _context.Registrations.Find(registration.Id);

            if(registrationDbo == null) return null;

            registrationDbo.IdStudent = registration.IdStudent;
            registrationDbo.IdCourse = registration.IdCourse;
            registrationDbo.IdSemester = registration.IdSemester;
            registrationDbo.IdProfessionalSchool = registration.IdProfessionalSchool;


            _context.SaveChanges();
            return registrationDbo;
        }

        //Delete beer
        [HttpDelete("{id}")]
        public bool Delete(long id){
            var registrationDbo = _context.Registrations.Find(id);
            if(registrationDbo==null) return false;

            _context.Registrations.Remove(registrationDbo);
            _context.SaveChanges();
            return true;
        }
 
    }
}