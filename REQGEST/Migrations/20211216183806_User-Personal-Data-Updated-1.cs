using Microsoft.EntityFrameworkCore.Migrations;

namespace REQGEST.Migrations
{
    public partial class UserPersonalDataUpdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FiscalNumber",
                table: "AspNetUsers",
                column: "FiscalNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IdentificationDocument",
                table: "AspNetUsers",
                column: "IdentificationDocument",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FiscalNumber",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IdentificationDocument",
                table: "AspNetUsers");
        }
    }
}
