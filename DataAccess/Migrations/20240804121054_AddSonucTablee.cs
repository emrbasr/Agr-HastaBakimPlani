﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSonucTablee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sonuclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgriHastaBakimPlaniId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sonuclar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sonuclar_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                        column: x => x.AgriHastaBakimPlaniId,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sonuclar_AgriHastaBakimPlaniId",
                table: "Sonuclar",
                column: "AgriHastaBakimPlaniId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sonuclar");
        }
    }
}
