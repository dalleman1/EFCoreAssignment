using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "AuId", "Name", "Semester" },
                values: new object[,]
                {
                    { "Au616638", "Bjarke Bjarkesen", 4 },
                    { "Au612638", "Morten Bjarkesen", 3 },
                    { "Au632638", "Bjarke Mortensen", 2 },
                    { "Au652638", "Morten Mortensen", 4 },
                    { "Au616621", "Oliver Madsen", 4 },
                    { "Au631321", "Mads Oliversen", 5 },
                    { "Au614328", "Mads Madsen", 1 },
                    { "Au612238", "Oliver Oliversen", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au612238");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au612638");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au614328");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au616621");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au616638");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au631321");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au632638");

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "AuId",
                keyValue: "Au652638");
        }
    }
}
