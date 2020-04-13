using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "exercises",
                columns: new[] { "number", "lecture", "courseId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 1, 4, 2 },
                    { 6, 10, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumns: new[] { "number", "lecture" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumns: new[] { "number", "lecture" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumns: new[] { "number", "lecture" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "exercises",
                keyColumns: new[] { "number", "lecture" },
                keyValues: new object[] { 6, 10 });
        }
    }
}
