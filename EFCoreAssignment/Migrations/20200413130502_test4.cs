using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "assignments",
                columns: new[] { "assignmentId", "courseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "assignments",
                keyColumn: "assignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "assignments",
                keyColumn: "assignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "assignments",
                keyColumn: "assignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "assignments",
                keyColumn: "assignmentId",
                keyValue: 4);
        }
    }
}
