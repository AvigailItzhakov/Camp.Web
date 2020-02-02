using Microsoft.EntityFrameworkCore.Migrations;

namespace Camp.Data.Migrations
{
    public partial class camperName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Bunk_BunkId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Contact_ContactId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Campers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ContactId",
                table: "Campers",
                newName: "IX_Campers_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_BunkId",
                table: "Campers",
                newName: "IX_Campers_BunkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campers",
                table: "Campers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Campers_Bunk_BunkId",
                table: "Campers",
                column: "BunkId",
                principalTable: "Bunk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Campers_Contact_ContactId",
                table: "Campers",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campers_Bunk_BunkId",
                table: "Campers");

            migrationBuilder.DropForeignKey(
                name: "FK_Campers_Contact_ContactId",
                table: "Campers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campers",
                table: "Campers");

            migrationBuilder.RenameTable(
                name: "Campers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_Campers_ContactId",
                table: "Users",
                newName: "IX_Users_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Campers_BunkId",
                table: "Users",
                newName: "IX_Users_BunkId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Bunk_BunkId",
                table: "Users",
                column: "BunkId",
                principalTable: "Bunk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Contact_ContactId",
                table: "Users",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
