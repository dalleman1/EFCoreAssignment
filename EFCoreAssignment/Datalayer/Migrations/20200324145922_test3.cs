using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "exercises",
                columns: new[] { "exerciseId", "helprequestId", "helpwhere", "lecture", "number", "studentId", "teacherId" },
                values: new object[,]
                {
                    { 1, 0, 0, 1, 1, 2, 0 },
                    { 2, 0, 0, 1, 1, 3, 0 },
                    { 3, 0, 0, 1, 1, 1, 0 },
                    { 4, 0, 0, 1, 1, 5, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumn: "exerciseId",
                keyValue: 4);
        }
    }
}
