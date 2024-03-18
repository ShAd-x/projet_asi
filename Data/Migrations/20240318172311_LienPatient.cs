using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_ASI.Data.Migrations
{
    /// <inheritdoc />
    public partial class LienPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Medecin_MedecinId",
                table: "Patient");

            migrationBuilder.AlterColumn<int>(
                name: "MedecinId",
                table: "Patient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Medecin_MedecinId",
                table: "Patient",
                column: "MedecinId",
                principalTable: "Medecin",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Medecin_MedecinId",
                table: "Patient");

            migrationBuilder.AlterColumn<int>(
                name: "MedecinId",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Medecin_MedecinId",
                table: "Patient",
                column: "MedecinId",
                principalTable: "Medecin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
