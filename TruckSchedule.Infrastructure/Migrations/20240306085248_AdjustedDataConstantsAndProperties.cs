using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckSchedule.Infrastructure.Migrations
{
    public partial class AdjustedDataConstantsAndProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Trucks",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the client, rented the truck");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Despatchers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Despatcher`s phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Despatcher`s phone number");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalNumber",
                table: "Despatchers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                comment: "Personal job position number ",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Personal job position number ");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Client`s phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client`s phone number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Trucks");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Despatchers",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Despatcher`s phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Despatcher`s phone number");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalNumber",
                table: "Despatchers",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Personal job position number ",
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13,
                oldComment: "Personal job position number ");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client`s phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Client`s phone number");
        }
    }
}
