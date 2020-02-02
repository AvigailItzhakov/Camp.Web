using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Camp.Data.Migrations
{
    public partial class ContactToCamperClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campers_Contact_ContactId",
                table: "Campers");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Campers_ContactId",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Campers");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactFirstName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactLastName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactPhoneNumber",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherFirstName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherLastName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherPhoneNumber",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherFirstName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherLastName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherPhoneNumber",
                table: "Campers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmergencyContactFirstName",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "EmergencyContactLastName",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "EmergencyContactPhoneNumber",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "FatherFirstName",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "FatherLastName",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "FatherPhoneNumber",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "MotherFirstName",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "MotherLastName",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "MotherPhoneNumber",
                table: "Campers");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Campers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmergencyContactFirstName = table.Column<string>(nullable: true),
                    EmergencyContactLastName = table.Column<string>(nullable: true),
                    EmergencyContactPhoneNumber = table.Column<string>(nullable: true),
                    FatherFirstName = table.Column<string>(nullable: true),
                    FatherLastName = table.Column<string>(nullable: true),
                    FatherPhoneNumber = table.Column<string>(nullable: true),
                    MotherFirstName = table.Column<string>(nullable: true),
                    MotherLastName = table.Column<string>(nullable: true),
                    MotherPhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campers_ContactId",
                table: "Campers",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campers_Contact_ContactId",
                table: "Campers",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
