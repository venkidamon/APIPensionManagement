using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProcessPension.Migrations
{
    public partial class NewProcessPension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "processes");

            migrationBuilder.CreateTable(
                name: "appProcessPensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Allowance = table.Column<double>(type: "float", nullable: false),
                    PensionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    BankServiceCharge = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appProcessPensions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appProcessPensions");

            migrationBuilder.CreateTable(
                name: "processes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allowance = table.Column<double>(type: "float", nullable: false),
                    BankType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PensionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultAmount = table.Column<double>(type: "float", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processes", x => x.Id);
                });
        }
    }
}
