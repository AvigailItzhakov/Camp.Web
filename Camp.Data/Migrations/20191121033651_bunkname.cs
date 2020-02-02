using Microsoft.EntityFrameworkCore.Migrations;

namespace Camp.Data.Migrations
{
    public partial class bunkname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campers_Bunk_BunkId",
                table: "Campers");

            migrationBuilder.AlterColumn<int>(
                name: "BunkId",
                table: "Campers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "BunkName",
                table: "Campers",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Campers_Bunk_BunkId",
                table: "Campers",
                column: "BunkId",
                principalTable: "Bunk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campers_Bunk_BunkId",
                table: "Campers");

            migrationBuilder.DropColumn(
                name: "BunkName",
                table: "Campers");

            migrationBuilder.AlterColumn<int>(
                name: "BunkId",
                table: "Campers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Campers_Bunk_BunkId",
                table: "Campers",
                column: "BunkId",
                principalTable: "Bunk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
