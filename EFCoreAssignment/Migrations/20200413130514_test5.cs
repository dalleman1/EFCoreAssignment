using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "courseId", "Name" },
                values: new object[] { 1, "DAB" });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "courseId", "Name" },
                values: new object[] { 2, "GFV" });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "courseId", "Name" },
                values: new object[] { 3, "ISU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "courseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "courseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "courseId",
                keyValue: 3);
        }
    }
}
