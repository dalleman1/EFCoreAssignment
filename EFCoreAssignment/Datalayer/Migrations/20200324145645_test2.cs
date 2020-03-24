using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "AuId", "Name", "assignmentId", "courseId", "exerciseId", "reviewId" },
                values: new object[,]
                {
                    { 2, "au382010", "", 0, 0, 0, 0 },
                    { 3, "au616333", "", 0, 0, 0, 0 },
                    { 4, "au615063", "", 0, 0, 0, 0 },
                    { 5, "au616604", "", 0, 0, 0, 0 },
                    { 6, "au453232", "", 0, 0, 0, 0 },
                    { 7, "au549032", "", 0, 0, 0, 0 },
                    { 8, "au450321", "", 0, 0, 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: 8);
        }
    }
}
