using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkCore.Migrations
{
    public partial class SchoolDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "subjectScore",
                table: "StudentSubjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Name" },
                values: new object[,]
                {
                    { 1, "Student 1" },
                    { 29, "Student 29" },
                    { 30, "Student 30" },
                    { 31, "Student 31" },
                    { 32, "Student 32" },
                    { 33, "Student 33" },
                    { 34, "Student 34" },
                    { 35, "Student 35" },
                    { 36, "Student 36" },
                    { 37, "Student 37" },
                    { 38, "Student 38" },
                    { 27, "Student 27" },
                    { 39, "Student 39" },
                    { 41, "Student 41" },
                    { 42, "Student 42" },
                    { 43, "Student 43" },
                    { 44, "Student 44" },
                    { 45, "Student 45" },
                    { 46, "Student 46" },
                    { 47, "Student 47" },
                    { 48, "Student 48" },
                    { 49, "Student 49" },
                    { 50, "Student 50" },
                    { 40, "Student 40" },
                    { 26, "Student 26" },
                    { 28, "Student 28" },
                    { 24, "Student 24" },
                    { 2, "Student 2" },
                    { 3, "Student 3" },
                    { 4, "Student 4" },
                    { 5, "Student 5" },
                    { 6, "Student 6" },
                    { 7, "Student 7" },
                    { 8, "Student 8" },
                    { 9, "Student 9" },
                    { 10, "Student 10" },
                    { 25, "Student 25" },
                    { 12, "Student 12" },
                    { 11, "Student 11" },
                    { 14, "Student 14" },
                    { 15, "Student 15" },
                    { 16, "Student 16" },
                    { 17, "Student 17" },
                    { 18, "Student 18" },
                    { 19, "Student 19" },
                    { 20, "Student 20" },
                    { 21, "Student 21" },
                    { 22, "Student 22" },
                    { 23, "Student 23" },
                    { 13, "Student 13" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "Name" },
                values: new object[,]
                {
                    { 4, "subj 4" },
                    { 1, "subj 1" },
                    { 2, "subj 2" },
                    { 3, "subj 3" },
                    { 5, "subj 5" }
                });

            migrationBuilder.InsertData(
                table: "StudentSubjects",
                columns: new[] { "StudentSubjectId", "StudentId", "SubjectId", "subjectScore" },
                values: new object[,]
                {
                    { 7, 4, 1, 0 },
                    { 83, 42, 3, 0 },
                    { 81, 41, 3, 0 },
                    { 80, 40, 3, 0 },
                    { 78, 39, 3, 0 },
                    { 75, 38, 3, 0 },
                    { 74, 37, 3, 0 },
                    { 72, 36, 3, 0 },
                    { 67, 34, 3, 0 },
                    { 66, 33, 3, 0 },
                    { 63, 32, 3, 0 },
                    { 61, 31, 3, 0 },
                    { 59, 30, 3, 0 },
                    { 58, 29, 3, 0 },
                    { 56, 28, 3, 0 },
                    { 54, 27, 3, 0 },
                    { 51, 26, 3, 0 },
                    { 48, 24, 3, 0 },
                    { 43, 22, 3, 0 },
                    { 42, 21, 3, 0 },
                    { 40, 20, 3, 0 },
                    { 35, 18, 3, 0 },
                    { 85, 43, 3, 0 },
                    { 29, 15, 3, 0 },
                    { 87, 44, 3, 0 },
                    { 91, 46, 3, 0 },
                    { 88, 44, 4, 0 },
                    { 86, 43, 4, 0 },
                    { 84, 42, 4, 0 },
                    { 82, 41, 4, 0 },
                    { 76, 38, 4, 0 },
                    { 68, 34, 4, 0 },
                    { 64, 32, 4, 0 },
                    { 62, 31, 4, 0 },
                    { 60, 30, 4, 0 },
                    { 52, 26, 4, 0 },
                    { 44, 22, 4, 0 },
                    { 36, 18, 4, 0 },
                    { 30, 15, 4, 0 },
                    { 26, 13, 4, 0 },
                    { 24, 12, 4, 0 },
                    { 22, 11, 4, 0 },
                    { 6, 3, 4, 0 },
                    { 4, 2, 4, 0 },
                    { 100, 50, 3, 0 },
                    { 95, 48, 3, 0 },
                    { 94, 47, 3, 0 },
                    { 90, 45, 3, 0 },
                    { 28, 14, 3, 0 },
                    { 25, 13, 3, 0 },
                    { 23, 12, 3, 0 },
                    { 38, 19, 2, 0 },
                    { 34, 17, 2, 0 },
                    { 32, 16, 2, 0 },
                    { 27, 14, 2, 0 },
                    { 19, 10, 2, 0 },
                    { 17, 9, 2, 0 },
                    { 16, 8, 2, 0 },
                    { 13, 7, 2, 0 },
                    { 12, 6, 2, 0 },
                    { 9, 5, 2, 0 },
                    { 8, 4, 2, 0 },
                    { 1, 1, 2, 0 },
                    { 97, 49, 1, 0 },
                    { 69, 35, 1, 0 },
                    { 49, 25, 1, 0 },
                    { 45, 23, 1, 0 },
                    { 37, 19, 1, 0 },
                    { 33, 17, 1, 0 },
                    { 31, 16, 1, 0 },
                    { 15, 8, 1, 0 },
                    { 11, 6, 1, 0 },
                    { 39, 20, 2, 0 },
                    { 41, 21, 2, 0 },
                    { 46, 23, 2, 0 },
                    { 47, 24, 2, 0 },
                    { 21, 11, 3, 0 },
                    { 20, 10, 3, 0 },
                    { 18, 9, 3, 0 },
                    { 14, 7, 3, 0 },
                    { 10, 5, 3, 0 },
                    { 5, 3, 3, 0 },
                    { 3, 2, 3, 0 },
                    { 2, 1, 3, 0 },
                    { 99, 50, 2, 0 },
                    { 98, 49, 2, 0 },
                    { 92, 46, 4, 0 },
                    { 93, 47, 2, 0 },
                    { 79, 40, 2, 0 },
                    { 77, 39, 2, 0 },
                    { 73, 37, 2, 0 },
                    { 71, 36, 2, 0 },
                    { 70, 35, 2, 0 },
                    { 65, 33, 2, 0 },
                    { 57, 29, 2, 0 },
                    { 55, 28, 2, 0 },
                    { 53, 27, 2, 0 },
                    { 50, 25, 2, 0 },
                    { 89, 45, 2, 0 },
                    { 96, 48, 4, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StudentSubjects",
                keyColumn: "StudentSubjectId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "subjectScore",
                table: "StudentSubjects");
        }
    }
}
