using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_ASI.Data.Migrations
{
    /// <inheritdoc />
    public partial class MiseAJourDuBilan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilan_Patient_PatientId",
                table: "Bilan");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Bilan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilan_Patient_PatientId",
                table: "Bilan",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilan_Patient_PatientId",
                table: "Bilan");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Bilan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilan_Patient_PatientId",
                table: "Bilan",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
