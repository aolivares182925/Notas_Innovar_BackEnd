using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotasAPI.Modules
{
    public class Context: DbContext
    {
        public Context ( DbContextOptions<Context> options):base(options){


        }

        public DbSet<Student> Students {get;set;}
        public DbSet<AcademicDepartment> AcademicDepartments {get;set;}
        public DbSet<ProfessionalSchool> ProfessionalSchools {get;set;}
        public DbSet<Alternative> Alternatives {get;set;}
        public DbSet<Answer> Answers {get;set;}
        public DbSet<Chapter> Chapters {get;set;}
        public DbSet<Course> Courses {get;set;}
        public DbSet<CourseRegistration> CourseRegistrations {get;set;}
        public DbSet<Exam> Exams {get;set;}
        public DbSet<Question> Questions {get;set;}
        public DbSet<Registration> Registrations {get;set;}
        public DbSet<Semester> Semesters {get;set;}
        public DbSet<Teacher> Teachers {get;set;}
        public DbSet<TeacherCourse> TeacherCourses {get;set;}

    }
}