using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class HastaDegerlendirmeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "Hastalar",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirmeler_HastaId",
                table: "Degerlendirmeler",
                column: "HastaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Degerlendirmeler_Hastalar_HastaId",
                table: "Degerlendirmeler",
                column: "HastaId",
                principalTable: "Hastalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Degerlendirmeler_Hastalar_HastaId",
                table: "Degerlendirmeler");

            migrationBuilder.DropIndex(
                name: "IX_Degerlendirmeler_HastaId",
                table: "Degerlendirmeler");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "Hastalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
