using Microsoft.EntityFrameworkCore.Migrations;

namespace REQGEST.Migrations
{
    public partial class UserPersonalDataUpdated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmergencyNumber",
                table: "AspNetUsers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmergencyNumber",
                table: "AspNetUsers");
        }
    }
}
