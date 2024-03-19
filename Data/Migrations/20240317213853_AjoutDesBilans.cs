using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_ASI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDesBilans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DateConsultation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureConsultation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotifConsultation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteSupplementaire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bilan_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilan_PatientId",
                table: "Bilan",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilan");
        }
    }
}
