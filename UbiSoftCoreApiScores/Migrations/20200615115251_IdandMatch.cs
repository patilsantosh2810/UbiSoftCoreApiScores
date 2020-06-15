using Microsoft.EntityFrameworkCore.Migrations;

namespace UbiSoftCoreApiScores.Migrations
{
    public partial class IdandMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Match",
                table: "users",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_users_Id",
                table: "users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_users_Id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Match",
                table: "users");
        }
    }
}
