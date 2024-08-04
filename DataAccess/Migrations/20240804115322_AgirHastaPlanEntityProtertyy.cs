using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AgirHastaPlanEntityProtertyy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sonuclar");

            migrationBuilder.CreateTable(
                name: "CheckboxItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    AgriHastaBakimPlaniId = table.Column<int>(type: "int", nullable: true),
                    AgriHastaBakimPlaniId1 = table.Column<int>(type: "int", nullable: true),
                    AgriHastaBakimPlaniId2 = table.Column<int>(type: "int", nullable: true),
                    AgriHastaBakimPlaniId3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckboxItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                        column: x => x.AgriHastaBakimPlaniId,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId1",
                        column: x => x.AgriHastaBakimPlaniId1,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId2",
                        column: x => x.AgriHastaBakimPlaniId2,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId3",
                        column: x => x.AgriHastaBakimPlaniId3,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId1",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId1");

            migrationBuilder.CreateIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId2",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId2");

            migrationBuilder.CreateIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId3",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckboxItems");

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
    }
}
