using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class HastaEntityProterty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HemsireTanisi",
                table: "Hastalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tani",
                table: "Hastalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tanim",
                table: "Hastalar",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HemsireTanisi",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "Tani",
                table: "Hastalar");

            migrationBuilder.DropColumn(
                name: "Tanim",
                table: "Hastalar");
        }
    }
}
