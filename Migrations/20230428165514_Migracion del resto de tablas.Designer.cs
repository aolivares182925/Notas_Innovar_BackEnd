﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotasAPI.Modules;

#nullable disable

namespace NotasAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230428165514_Migracion del resto de tablas")]
    partial class Migraciondelrestodetablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NotasAPI.Modules.AcademicDepartment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AcademicDepartments");
                });

            modelBuilder.Entity("NotasAPI.Modules.Alternative", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Alternative1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alternative2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alternative3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alternative4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectAlternative")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IdQuestion")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdQuestion");

                    b.ToTable("Alternatives");
                });

            modelBuilder.Entity("NotasAPI.Modules.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdQuestion")
                        .HasColumnType("bigint");

                    b.Property<long>("IdStudent")
                        .HasColumnType("bigint");

                    b.Property<string>("SelectedAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdQuestion");

                    b.HasIndex("IdStudent");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("NotasAPI.Modules.Chapter", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdCourse")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCourse");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("NotasAPI.Modules.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NotasAPI.Modules.Exam", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IdChapter")
                        .HasColumnType("bigint");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("IdChapter");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("NotasAPI.Modules.ProfessionalSchool", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdAcademicDepartment")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAcademicDepartment");

                    b.ToTable("ProfessionalSchools");
                });

            modelBuilder.Entity("NotasAPI.Modules.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdExam")
                        .HasColumnType("bigint");

                    b.Property<string>("TextQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdExam");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("NotasAPI.Modules.Registration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdCourse")
                        .HasColumnType("bigint");

                    b.Property<long>("IdProfessionalSchool")
                        .HasColumnType("bigint");

                    b.Property<long>("IdSemester")
                        .HasColumnType("bigint");

                    b.Property<long>("IdStudent")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdCourse");

                    b.HasIndex("IdProfessionalSchool");

                    b.HasIndex("IdSemester");

                    b.HasIndex("IdStudent");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("NotasAPI.Modules.Semester", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("DateFinish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("NotasAPI.Modules.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("NotasAPI.Modules.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("NotasAPI.Modules.TeacherCourse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("IdCourse")
                        .HasColumnType("bigint");

                    b.Property<long>("IdTeacher")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("IdCourse");

                    b.HasIndex("IdTeacher");

                    b.ToTable("TeacherCourses");
                });

            modelBuilder.Entity("NotasAPI.Modules.Alternative", b =>
                {
                    b.HasOne("NotasAPI.Modules.Question", "Question")
                        .WithMany("Alternatives")
                        .HasForeignKey("IdQuestion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("NotasAPI.Modules.Answer", b =>
                {
                    b.HasOne("NotasAPI.Modules.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("IdQuestion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotasAPI.Modules.Student", "Student")
                        .WithMany("Answers")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("NotasAPI.Modules.Chapter", b =>
                {
                    b.HasOne("NotasAPI.Modules.Course", "Course")
                        .WithMany("Chapters")
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("NotasAPI.Modules.Exam", b =>
                {
                    b.HasOne("NotasAPI.Modules.Chapter", "Chapter")
                        .WithMany("Exams")
                        .HasForeignKey("IdChapter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapter");
                });

            modelBuilder.Entity("NotasAPI.Modules.ProfessionalSchool", b =>
                {
                    b.HasOne("NotasAPI.Modules.AcademicDepartment", "AcademicDepartment")
                        .WithMany("ProfessionalSchools")
                        .HasForeignKey("IdAcademicDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AcademicDepartment");
                });

            modelBuilder.Entity("NotasAPI.Modules.Question", b =>
                {
                    b.HasOne("NotasAPI.Modules.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("IdExam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("NotasAPI.Modules.Registration", b =>
                {
                    b.HasOne("NotasAPI.Modules.Course", "Course")
                        .WithMany("Registrations")
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotasAPI.Modules.ProfessionalSchool", "ProfessionalSchool")
                        .WithMany("Registrations")
                        .HasForeignKey("IdProfessionalSchool")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotasAPI.Modules.Semester", "Semester")
                        .WithMany("Registrations")
                        .HasForeignKey("IdSemester")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotasAPI.Modules.Student", "Student")
                        .WithMany("Registrations")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("ProfessionalSchool");

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("NotasAPI.Modules.TeacherCourse", b =>
                {
                    b.HasOne("NotasAPI.Modules.Course", "Course")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotasAPI.Modules.Teacher", "Teacher")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("IdTeacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("NotasAPI.Modules.AcademicDepartment", b =>
                {
                    b.Navigation("ProfessionalSchools");
                });

            modelBuilder.Entity("NotasAPI.Modules.Chapter", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("NotasAPI.Modules.Course", b =>
                {
                    b.Navigation("Chapters");

                    b.Navigation("Registrations");

                    b.Navigation("TeacherCourses");
                });

            modelBuilder.Entity("NotasAPI.Modules.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("NotasAPI.Modules.ProfessionalSchool", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("NotasAPI.Modules.Question", b =>
                {
                    b.Navigation("Alternatives");

                    b.Navigation("Answers");
                });

            modelBuilder.Entity("NotasAPI.Modules.Semester", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("NotasAPI.Modules.Student", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("NotasAPI.Modules.Teacher", b =>
                {
                    b.Navigation("TeacherCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
