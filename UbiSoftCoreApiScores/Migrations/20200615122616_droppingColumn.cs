using Microsoft.EntityFrameworkCore.Migrations;

namespace UbiSoftCoreApiScores.Migrations
{
    public partial class droppingColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_users_Id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_users_Id",
                table: "users",
                column: "Id");
        }
    }
}
