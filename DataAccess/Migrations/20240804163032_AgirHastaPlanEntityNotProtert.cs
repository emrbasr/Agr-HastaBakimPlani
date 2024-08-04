using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AgirHastaPlanEntityNotProtert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId1",
                table: "CheckboxItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId2",
                table: "CheckboxItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId3",
                table: "CheckboxItems");

            migrationBuilder.DropIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId1",
                table: "CheckboxItems");

            migrationBuilder.DropIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId2",
                table: "CheckboxItems");

            migrationBuilder.DropIndex(
                name: "IX_CheckboxItems_AgriHastaBakimPlaniId3",
                table: "CheckboxItems");

            migrationBuilder.DropColumn(
                name: "AgriHastaBakimPlaniId1",
                table: "CheckboxItems");

            migrationBuilder.DropColumn(
                name: "AgriHastaBakimPlaniId2",
                table: "CheckboxItems");

            migrationBuilder.DropColumn(
                name: "AgriHastaBakimPlaniId3",
                table: "CheckboxItems");

            migrationBuilder.CreateTable(
                name: "Amaclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgriHastaBakimPlaniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amaclar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amaclar_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                        column: x => x.AgriHastaBakimPlaniId,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nedenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgriHastaBakimPlaniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nedenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nedenler_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                        column: x => x.AgriHastaBakimPlaniId,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaniOlculeriList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgriHastaBakimPlaniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaniOlculeriList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaniOlculeriList_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                        column: x => x.AgriHastaBakimPlaniId,
                        principalTable: "AgriHastaBakimPlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amaclar_AgriHastaBakimPlaniId",
                table: "Amaclar",
                column: "AgriHastaBakimPlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_Nedenler_AgriHastaBakimPlaniId",
                table: "Nedenler",
                column: "AgriHastaBakimPlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_TaniOlculeriList_AgriHastaBakimPlaniId",
                table: "TaniOlculeriList",
                column: "AgriHastaBakimPlaniId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amaclar");

            migrationBuilder.DropTable(
                name: "Nedenler");

            migrationBuilder.DropTable(
                name: "TaniOlculeriList");

            migrationBuilder.AddColumn<int>(
                name: "AgriHastaBakimPlaniId1",
                table: "CheckboxItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgriHastaBakimPlaniId2",
                table: "CheckboxItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgriHastaBakimPlaniId3",
                table: "CheckboxItems",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId1",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId1",
                principalTable: "AgriHastaBakimPlanlari",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId2",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId2",
                principalTable: "AgriHastaBakimPlanlari",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckboxItems_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId3",
                table: "CheckboxItems",
                column: "AgriHastaBakimPlaniId3",
                principalTable: "AgriHastaBakimPlanlari",
                principalColumn: "Id");
        }
    }
}
