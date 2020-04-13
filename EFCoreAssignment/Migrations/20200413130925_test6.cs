using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreAssignment.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "helprequests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_helprequests",
                table: "helprequests",
                columns: new[] { "auId", "assignmentId" });

            migrationBuilder.InsertData(
                table: "helprequests",
                columns: new[] { "auId", "assignmentId" },
                values: new object[] { "Au616638", 1 });

            migrationBuilder.InsertData(
                table: "helprequests",
                columns: new[] { "auId", "assignmentId" },
                values: new object[] { "Au616638", 2 });

            migrationBuilder.InsertData(
                table: "helprequests",
                columns: new[] { "auId", "assignmentId" },
                values: new object[] { "Au612638", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_helprequests",
                table: "helprequests");

            migrationBuilder.DeleteData(
                table: "helprequests",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au612638", 4 });

            migrationBuilder.DeleteData(
                table: "helprequests",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au616638", 1 });

            migrationBuilder.DeleteData(
                table: "helprequests",
                keyColumns: new[] { "auId", "assignmentId" },
                keyValues: new object[] { "Au616638", 2 });

            migrationBuilder.AlterColumn<string>(
                name: "auId",
                table: "helprequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
