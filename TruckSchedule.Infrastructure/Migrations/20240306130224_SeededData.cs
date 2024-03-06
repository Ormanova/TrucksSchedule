using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckSchedule.Infrastructure.Migrations
{
    public partial class SeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "aea76059-d922-4f25-ace3-bd225d4ccd23", "juniorDriver@mail.com", false, false, null, "juniorDriver@mail.com", "juniorDriver@mail.com", "AQAAAAEAACcQAAAAEOby0vglEt1QRxVNiN77c8IQYqqMuYcQz7GP/bTMpq9TABqwAxDs8x8GTXaXT+wfig==", null, false, "5992530d-b818-4c3f-a4e2-8b70cede84b1", false, "juniorDriver@mail.com" },
                    { "dea12856-c198-4129-83d9-d6b3ac1f591e", 0, "d3666b1b-7383-4acf-8275-1c1a35e33e3b", "client001@mail.com", false, false, null, "client001@mail.com", "client001@mail.com", "AQAAAAEAACcQAAAAEGAOTbY715FMddCqq7UfZaWZ05cVUn84yPqPUEFcy0ab9J2nHWPaSzKiRGK95w1m0w==", null, false, "afa9b36d-16ab-4e38-9125-19aa638edc53", false, "client001@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "8f7017ba-1bf3-4787-9d91-132998c6e900", "despatcher01@mail.com", false, false, null, "despatcher01@mail.com", "despatcher01@mail.com", "AQAAAAEAACcQAAAAEPTYngk4MdkXbjRiwNefBDqsU7YB/j3vvphcQgI9Zc9h/W4mIstZ5p3v0oRTOboa2Q==", null, false, "efa089ae-ae1d-4b84-adf0-ec3bdf408da6", false, "despatcher01@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tanker" },
                    { 2, "Jumbo" },
                    { 3, "SemiTrailer" },
                    { 4, "Tautliner" },
                    { 5, "Conestoga" }
                });

            migrationBuilder.InsertData(
                table: "Despatchers",
                columns: new[] { "Id", "Name", "PersonalNumber", "PhoneNumber", "UserId" },
                values: new object[] { 1, "Nikola NIkolov Nikolov", "1234567", "359894000000", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "DespatcherId", "IsBusy", "LicenseNumber", "Name" },
                values: new object[] { 1, 1, false, 23456789, "Ivan Ivanov Ivanov" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "DespatcherId", "IsBusy", "LicenseNumber", "Name" },
                values: new object[] { 2, 1, false, 67890123, "Stoyan Stoyanov Stoyanov" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "DespatcherId", "IsBusy", "LicenseNumber", "Name" },
                values: new object[] { 3, 1, false, 98765432, "Ivailo Ivailov Ivailov" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Despatchers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
