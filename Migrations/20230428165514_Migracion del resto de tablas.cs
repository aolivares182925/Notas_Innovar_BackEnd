using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migraciondelrestodetablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Semesters_SemesterId",
                table: "Registrations");

            migrationBuilder.DropTable(
                name: "CourseRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_SemesterId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "IDCourse",
                table: "Chapters",
                newName: "IdCourse");

            migrationBuilder.AlterColumn<long>(
                name: "IdExam",
                table: "Questions",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_IdCourse",
                table: "TeacherCourses",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_IdTeacher",
                table: "TeacherCourses",
                column: "IdTeacher");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdCourse",
                table: "Registrations",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdProfessionalSchool",
                table: "Registrations",
                column: "IdProfessionalSchool");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdSemester",
                table: "Registrations",
                column: "IdSemester");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IdStudent",
                table: "Registrations",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IdExam",
                table: "Questions",
                column: "IdExam");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_IdChapter",
                table: "Exams",
                column: "IdChapter");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_IdCourse",
                table: "Chapters",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_IdQuestion",
                table: "Answers",
                column: "IdQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_IdStudent",
                table: "Answers",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Alternatives_IdQuestion",
                table: "Alternatives",
                column: "IdQuestion");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternatives_Questions_IdQuestion",
                table: "Alternatives",
                column: "IdQuestion",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_IdQuestion",
                table: "Answers",
                column: "IdQuestion",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Students_IdStudent",
                table: "Answers",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Courses_IdCourse",
                table: "Chapters",
                column: "IdCourse",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Chapters_IdChapter",
                table: "Exams",
                column: "IdChapter",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exams_IdExam",
                table: "Questions",
                column: "IdExam",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Courses_IdCourse",
                table: "Registrations",
                column: "IdCourse",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_ProfessionalSchools_IdProfessionalSchool",
                table: "Registrations",
                column: "IdProfessionalSchool",
                principalTable: "ProfessionalSchools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Semesters_IdSemester",
                table: "Registrations",
                column: "IdSemester",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Students_IdStudent",
                table: "Registrations",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourses_Courses_IdCourse",
                table: "TeacherCourses",
                column: "IdCourse",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourses_Teachers_IdTeacher",
                table: "TeacherCourses",
                column: "IdTeacher",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternatives_Questions_IdQuestion",
                table: "Alternatives");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_IdQuestion",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Students_IdStudent",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Courses_IdCourse",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Chapters_IdChapter",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exams_IdExam",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Courses_IdCourse",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_ProfessionalSchools_IdProfessionalSchool",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Semesters_IdSemester",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Students_IdStudent",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourses_Courses_IdCourse",
                table: "TeacherCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourses_Teachers_IdTeacher",
                table: "TeacherCourses");

            migrationBuilder.DropIndex(
                name: "IX_TeacherCourses_IdCourse",
                table: "TeacherCourses");

            migrationBuilder.DropIndex(
                name: "IX_TeacherCourses_IdTeacher",
                table: "TeacherCourses");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_IdCourse",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_IdProfessionalSchool",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_IdSemester",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_IdStudent",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Questions_IdExam",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Exams_IdChapter",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_IdCourse",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Answers_IdQuestion",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_IdStudent",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Alternatives_IdQuestion",
                table: "Alternatives");

            migrationBuilder.RenameColumn(
                name: "IdCourse",
                table: "Chapters",
                newName: "IDCourse");

            migrationBuilder.AddColumn<long>(
                name: "SemesterId",
                table: "Registrations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdExam",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "CourseRegistrations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCourse = table.Column<long>(type: "bigint", nullable: false),
                    IdRegistration = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRegistrations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_SemesterId",
                table: "Registrations",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Semesters_SemesterId",
                table: "Registrations",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id");
        }
    }
}
