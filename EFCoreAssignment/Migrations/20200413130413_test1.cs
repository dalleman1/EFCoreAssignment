using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assignments",
                columns: table => new
                {
                    assignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignments", x => x.assignmentId);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    courseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "exercises",
                columns: table => new
                {
                    lecture = table.Column<int>(nullable: false),
                    number = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises", x => new { x.number, x.lecture });
                });

            migrationBuilder.CreateTable(
                name: "helpRequestExercises",
                columns: table => new
                {
                    auId = table.Column<string>(nullable: true),
                    helpwhere = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "helprequests",
                columns: table => new
                {
                    auId = table.Column<string>(nullable: true),
                    assignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    auId = table.Column<string>(nullable: true),
                    Reviewtext = table.Column<string>(nullable: true),
                    assignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    AuId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Semester = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.AuId);
                });

            migrationBuilder.CreateTable(
                name: "studentsInCourses",
                columns: table => new
                {
                    auId = table.Column<string>(nullable: true),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "teacherHelpsWithExercises",
                columns: table => new
                {
                    auId = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "teacherHelpsWiths",
                columns: table => new
                {
                    auId = table.Column<string>(nullable: true),
                    assignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    AuId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.AuId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "assignments");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "exercises");

            migrationBuilder.DropTable(
                name: "helpRequestExercises");

            migrationBuilder.DropTable(
                name: "helprequests");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "studentsInCourses");

            migrationBuilder.DropTable(
                name: "teacherHelpsWithExercises");

            migrationBuilder.DropTable(
                name: "teacherHelpsWiths");

            migrationBuilder.DropTable(
                name: "teachers");
        }
    }
}
