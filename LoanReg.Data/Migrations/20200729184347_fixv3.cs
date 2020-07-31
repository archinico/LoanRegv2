using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanReg.Data.Migrations
{
    public partial class fixv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cuotas",
                table: "Solicitudes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaSolicitud",
                table: "Solicitudes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Interes",
                table: "Solicitudes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MontoSolicitado",
                table: "Solicitudes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Empleados",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmpDireccion",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmpIngresoFech",
                table: "Clientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmpNombre",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivil",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNac",
                table: "Clientes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Trabaja",
                table: "Clientes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cuotas",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "FechaSolicitud",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "Interes",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "MontoSolicitado",
                table: "Solicitudes");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EmpDireccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EmpIngresoFech",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EmpNombre",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FechaNac",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Trabaja",
                table: "Clientes");
        }
    }
}
