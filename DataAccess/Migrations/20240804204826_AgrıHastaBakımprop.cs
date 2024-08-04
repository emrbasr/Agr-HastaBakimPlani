using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AgrıHastaBakımprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgriHastaBakimPlaniId",
                table: "Degerlendirmeler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirmeler_AgriHastaBakimPlaniId",
                table: "Degerlendirmeler",
                column: "AgriHastaBakimPlaniId");

            migrationBuilder.AddForeignKey(
                name: "FK_Degerlendirmeler_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                table: "Degerlendirmeler",
                column: "AgriHastaBakimPlaniId",
                principalTable: "AgriHastaBakimPlanlari",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Degerlendirmeler_AgriHastaBakimPlanlari_AgriHastaBakimPlaniId",
                table: "Degerlendirmeler");

            migrationBuilder.DropIndex(
                name: "IX_Degerlendirmeler_AgriHastaBakimPlaniId",
                table: "Degerlendirmeler");

            migrationBuilder.DropColumn(
                name: "AgriHastaBakimPlaniId",
                table: "Degerlendirmeler");
        }
    }
}
