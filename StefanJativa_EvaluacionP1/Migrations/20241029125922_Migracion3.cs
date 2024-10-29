using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StefanJativa_EvaluacionP1.Migrations
{
    /// <inheritdoc />
    public partial class Migracion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefono_Persona_IDpersona",
                table: "Telefono");

            migrationBuilder.DropIndex(
                name: "IX_Telefono_IDpersona",
                table: "Telefono");

            migrationBuilder.DropColumn(
                name: "IDpersona",
                table: "Telefono");

            migrationBuilder.AddColumn<int>(
                name: "Telefonos",
                table: "Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Telefonos",
                table: "Persona",
                column: "Telefonos");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Telefono_Telefonos",
                table: "Persona",
                column: "Telefonos",
                principalTable: "Telefono",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Telefono_Telefonos",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_Telefonos",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Telefonos",
                table: "Persona");

            migrationBuilder.AddColumn<int>(
                name: "IDpersona",
                table: "Telefono",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telefono_IDpersona",
                table: "Telefono",
                column: "IDpersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefono_Persona_IDpersona",
                table: "Telefono",
                column: "IDpersona",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
