using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "teacherHelpsWithExercises",
                newName: "number");

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "teacherHelpsWiths",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "teacherHelpsWithExercises",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "studentsInCourses",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "helpRequestExercises",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_teacherHelpsWiths",
                table: "teacherHelpsWiths",
                columns: new[] { "auId", "assignmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_teacherHelpsWithExercises",
                table: "teacherHelpsWithExercises",
                columns: new[] { "auId", "number" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentsInCourses",
                table: "studentsInCourses",
                columns: new[] { "auId", "courseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_reviews",
                table: "reviews",
                columns: new[] { "auId", "assignmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_helpRequestExercises",
                table: "helpRequestExercises",
                columns: new[] { "auId", "number" });

            migrationBuilder.InsertData(
                table: "helpRequestExercises",
                columns: new[] { "auId", "number", "helpwhere" },
                values: new object[,]
                {
                    { "Au614328", 2, "Bord 20" },
                    { "Au612238", 1, "Bord 22" },
                    { "Au614328", 1, "Bord 21" },
                    { "Au616638", 6, "Bord 23" }
                });

            migrationBuilder.InsertData(
                table: "reviews",
                columns: new[] { "auId", "assignmentId", "Reviewtext" },
                values: new object[,]
                {
                    { "Au616621", 1, "Fint nok" },
                    { "Au616621", 2, "Helt ok" },
                    { "Au616621", 3, "Meget fint" }
                });

            migrationBuilder.InsertData(
                table: "studentsInCourses",
                columns: new[] { "auId", "courseId" },
                values: new object[,]
                {
                    { "Au612638", 1 },
                    { "Au612638", 3 },
                    { "Au631321", 3 },
                    { "Au616621", 2 },
                    { "Au612638", 2 },
                    { "Au616638", 3 },
                    { "Au616621", 3 },
                    { "Au616621", 1 },
                    { "Au616638", 1 },
                    { "Au616638", 2 }
                });

            migrationBuilder.InsertData(
                table: "teacherHelpsWithExercises",
                columns: new[] { "auId", "number" },
                values: new object[,]
                {
                    { "Au616639", 2 },
                    { "Au420322", 1 },
                    { "Au620433", 6 },
                    { "Au420322", 2 }
                });

            migrationBuilder.InsertData(
                table: "teacherHelpsWiths",
                columns: new[] { "auId", "assignmentId" },
                values: new object[,]
                {
                    { "Au620433", 1 },
                    { "Au504234", 2 },
                    { "Au420322", 3 },
                    { "Au302420", 4 }
                });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "AuId", "Name", "courseId" },
                values: new object[,]
                {
                    { "Au620433", "Kaj Løkke", 1 },
                    { "Au302420", "Oliver Escobar", 3 },
                    { "Au616639", "Morten Bobsen", 1 },
                    { "Au504234", "Kasper Kaj", 2 },
                    { "Au420322", "Mads Madsen", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_teacherHelpsWiths",
                table: "teacherHelpsWiths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teacherHelpsWithExercises",
                table: "teacherHelpsWithExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentsInCourses",
                table: "studentsInCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reviews",
                table: "reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_helpRequestExercises",
                table: "helpRequestExercises");

            migrationBuilder.DeleteData(
                table: "helpRequestExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au612238", 1 });

            migrationBuilder.DeleteData(
                table: "helpRequestExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au614328", 1 });

            migrationBuilder.DeleteData(
                table: "helpRequestExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au614328", 2 });

            migrationBuilder.DeleteData(
                table: "helpRequestExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au616638", 6 });

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au616621", 1 });

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au616621", 2 });

            migrationBuilder.DeleteData(
                table: "reviews",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au616621", 3 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au612638", 1 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au612638", 2 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au612638", 3 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au616621", 1 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au616621", 2 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au616621", 3 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au616638", 1 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au616638", 2 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au616638", 3 });

            migrationBuilder.DeleteData(
                table: "studentsInCourses",
                keyColumns: new[] { "auId", "courseId" },
                keyValues: new object[] { "Au631321", 3 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWithExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au420322", 1 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWithExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au420322", 2 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWithExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au616639", 2 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWithExercises",
                keyColumns: new[] { "auId", "number" },
                keyValues: new object[] { "Au620433", 6 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWiths",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au302420", 4 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWiths",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au420322", 3 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWiths",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au504234", 2 });

            migrationBuilder.DeleteData(
                table: "teacherHelpsWiths",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au620433", 1 });

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "AuId",
                keyValue: "Au302420");

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "AuId",
                keyValue: "Au420322");

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "AuId",
                keyValue: "Au504234");

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "AuId",
                keyValue: "Au616639");

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "AuId",
                keyValue: "Au620433");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "teacherHelpsWithExercises",
                newName: "Number");

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "teacherHelpsWiths",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "teacherHelpsWithExercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "studentsInCourses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "helpRequestExercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
