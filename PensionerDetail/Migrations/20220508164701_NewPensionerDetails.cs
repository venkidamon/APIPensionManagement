using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PensionerDetail.Migrations
{
    public partial class NewPensionerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Pensioners",
                newName: "PensionType");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Pensioners",
                newName: "AadharNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PensionType",
                table: "Pensioners",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "AadharNumber",
                table: "Pensioners",
                newName: "Type");
        }
    }
}
