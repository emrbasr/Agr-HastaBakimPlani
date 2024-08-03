using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hemsireler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hemsireler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgriHastaBakimPlanlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Neden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaniOlculeri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degerlendirme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Not = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaId = table.Column<int>(type: "int", nullable: false),
                    HemsireId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriHastaBakimPlanlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgriHastaBakimPlanlari_Hastalar_HastaId",
                        column: x => x.HastaId,
                        principalTable: "Hastalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgriHastaBakimPlanlari_Hemsireler_HemsireId",
                        column: x => x.HemsireId,
                        principalTable: "Hemsireler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Girisimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgriHastaBakimPlaniId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Girisimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Girisimler_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                        column: x => x.AgriHastaBakimPlaniId,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AgriHastaBakimPlanlari_HastaId",
                table: "AgriHastaBakimPlanlari",
                column: "HastaId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriHastaBakimPlanlari_HemsireId",
                table: "AgriHastaBakimPlanlari",
                column: "HemsireId");

            migrationBuilder.CreateIndex(
                name: "IX_Girisimler_AgriHastaBakimPlaniId",
                table: "Girisimler",
                column: "AgriHastaBakimPlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_Sonuclar_AgriHastaBakimPlaniId",
                table: "Sonuclar",
                column: "AgriHastaBakimPlaniId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Girisimler");

            migrationBuilder.DropTable(
                name: "Sonuclar");

            migrationBuilder.DropTable(
                name: "AgriHastaBakimPlanlari");

            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Hemsireler");
        }
    }
}
