using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCavoFinal.Migrations
{
    public partial class jsgass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ContactToTeam");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ContactToTeam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ContactToTeam",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ContactToTeam",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }
    }
}
