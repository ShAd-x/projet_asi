using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_ASI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjoutLienMedecinPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedecinId",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedecinId",
                table: "Patient",
                column: "MedecinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Medecin_MedecinId",
                table: "Patient",
                column: "MedecinId",
                principalTable: "Medecin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Medecin_MedecinId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_MedecinId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "MedecinId",
                table: "Patient");
        }
    }
}
