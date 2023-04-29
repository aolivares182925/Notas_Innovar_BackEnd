using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class ProfessionalSchoolDS
    {
        private Context _context;

        public ProfessionalSchoolDS(Context context){
            _context = context;
        }

        public List<ProfessionalSchool> Get(){
            return _context.ProfessionalSchools.ToList();
        }

        public ProfessionalSchool? Get(long Id){
            return _context.ProfessionalSchools.Find(Id);
        }

        public ProfessionalSchool? Insert(ProfessionalSchool professionalSchool){
            _context.ProfessionalSchools.Add(professionalSchool);
            _context.SaveChanges();
            return professionalSchool;
        }
        public ProfessionalSchool? Update(ProfessionalSchool professionalSchool){
            var professionalSchoolDbo = _context.ProfessionalSchools.Find(professionalSchool.Id);

            if(professionalSchoolDbo == null) return null;

            professionalSchoolDbo.Name = professionalSchool.Name;
            professionalSchoolDbo.IdAcademicDepartment = professionalSchool.IdAcademicDepartment;

            _context.SaveChanges();
            return professionalSchoolDbo;
        }
        public bool Delete(long Id){
            var professionalSchoolDbo = _context.ProfessionalSchools.Find(Id);
            if(professionalSchoolDbo == null) return false;

            _context.ProfessionalSchools.Remove(professionalSchoolDbo);
            _context.SaveChanges();
            return true;
        }
    }
}