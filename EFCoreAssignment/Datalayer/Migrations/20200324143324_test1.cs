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
                    reviewId = table.Column<int>(nullable: false),
                    studentId = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false),
                    teacherId = table.Column<int>(nullable: false),
                    helprequestId = table.Column<int>(nullable: false)
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
                    Name = table.Column<string>(nullable: true),
                    teacherId = table.Column<int>(nullable: false),
                    studentId = table.Column<int>(nullable: false),
                    assignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "exercises",
                columns: table => new
                {
                    exerciseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lecture = table.Column<int>(nullable: false),
                    number = table.Column<int>(nullable: false),
                    helpwhere = table.Column<int>(nullable: false),
                    studentId = table.Column<int>(nullable: false),
                    teacherId = table.Column<int>(nullable: false),
                    helprequestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises", x => x.exerciseId);
                });

            migrationBuilder.CreateTable(
                name: "helprequests",
                columns: table => new
                {
                    helprequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(nullable: false),
                    assignmentId = table.Column<int>(nullable: false),
                    exerciseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_helprequests", x => x.helprequestId);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    reviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reviewtext = table.Column<string>(nullable: true),
                    assignmentId = table.Column<int>(nullable: false),
                    studentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.reviewId);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    exerciseId = table.Column<int>(nullable: false),
                    assignmentId = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false),
                    reviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    teacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    exerciseId = table.Column<int>(nullable: false),
                    assignmentId = table.Column<int>(nullable: false),
                    courseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.teacherId);
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "AuId", "Name", "assignmentId", "courseId", "exerciseId", "reviewId" },
                values: new object[] { 1, "au616639", "Morten Dalsgaard", 0, 0, 0, 0 });
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
                name: "helprequests");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "teachers");
        }
    }
}
