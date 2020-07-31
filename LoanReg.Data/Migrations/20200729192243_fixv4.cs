using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanReg.Data.Migrations
{
    public partial class fixv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPago",
                table: "Solicitudes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPago",
                table: "Solicitudes");
        }
    }
}
