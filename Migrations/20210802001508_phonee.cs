using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCavoFinal.Migrations
{
    public partial class phonee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Messages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Messages");
        }
    }
}
