using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotasAPI.Modules;

namespace NotasAPI.DataServices
{
    public class AcademicDepartmentDataService
    {
        private Context _context;

        public AcademicDepartmentDataService(Context context){
            _context = context;
        }

        public List<AcademicDepartment> Get(){
            return _context.AcademicDepartments.Include(AcDe => AcDe.ProfessionalSchools).ToList();
        }

        public List<AcademicDepartment> GetADByName(string name){
            return _context.AcademicDepartments.Where(academicDepartemt => academicDepartemt.Name == name).ToList();
        }

        public List<AcademicDepartment> GetADWhitProfSchools(){
            return _context.AcademicDepartments.Include(ad=>ad.ProfessionalSchools).ToList();
        }



        public AcademicDepartment? Get(long id){
            var academicDepartemt = _context.AcademicDepartments.Find(id);
            return academicDepartemt;
        }

        public AcademicDepartment? Insert(AcademicDepartment academicDepartment){
            _context.AcademicDepartments.Add(academicDepartment);
            _context.SaveChanges();
            return academicDepartment;
        }

        public AcademicDepartment? Update(AcademicDepartment academicDepartment){
            var academicDepartmentDbo = _context.AcademicDepartments.Find(academicDepartment.Id);

            if(academicDepartmentDbo == null) return null;

            academicDepartmentDbo.Name = academicDepartment.Name;

            _context.SaveChanges();
            return academicDepartmentDbo;
        }

        public bool Delete(long id){
            var academicDepartmentDbo = _context.AcademicDepartments.Find(id);
            if(academicDepartmentDbo==null) return false;

            _context.AcademicDepartments.Remove(academicDepartmentDbo);
            _context.SaveChanges();
            return true;
        }

    }
}