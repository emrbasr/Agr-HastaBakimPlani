using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSonucTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amac",
                table: "AgriHastaBakimPlanlari");

            migrationBuilder.DropColumn(
                name: "Degerlendirme",
                table: "AgriHastaBakimPlanlari");

            migrationBuilder.DropColumn(
                name: "Neden",
                table: "AgriHastaBakimPlanlari");

            migrationBuilder.DropColumn(
                name: "TaniOlculeri",
                table: "AgriHastaBakimPlanlari");

            migrationBuilder.AddColumn<DateTime>(
                name: "Saat",
                table: "AgriHastaBakimPlanlari",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saat",
                table: "AgriHastaBakimPlanlari");

            migrationBuilder.AddColumn<string>(
                name: "Amac",
                table: "AgriHastaBakimPlanlari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Degerlendirme",
                table: "AgriHastaBakimPlanlari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neden",
                table: "AgriHastaBakimPlanlari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaniOlculeri",
                table: "AgriHastaBakimPlanlari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
