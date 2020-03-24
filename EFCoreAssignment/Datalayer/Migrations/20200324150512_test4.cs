using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 1,
                column: "studentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 2,
                column: "studentId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 1,
                column: "studentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 2,
                column: "studentId",
                value: 3);
        }
    }
}
