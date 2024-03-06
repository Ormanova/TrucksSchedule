using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckSchedule.Infrastructure.Migrations
{
    public partial class DomainTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Truck category");

            migrationBuilder.CreateTable(
                name: "Despatchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Despatcher identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Despatcher`s name"),
                    PersonalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Personal job position number "),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Despatcher`s phone number"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despatchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despatchers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Client Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Client`s name"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client`s phone number"),
                    DespatcherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Despatchers_DespatcherId",
                        column: x => x.DespatcherId,
                        principalTable: "Despatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Driver identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Driver`s name"),
                    LicenseNumber = table.Column<int>(type: "int", maxLength: 8, nullable: false, comment: "Driver`s license number"),
                    IsBusy = table.Column<bool>(type: "bit", nullable: false, comment: "Point if the driver is available"),
                    DespatcherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Despatchers_DespatcherId",
                        column: x => x.DespatcherId,
                        principalTable: "Despatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Truck license plate number"),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Company manufactured the truck"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CargoCapacity = table.Column<int>(type: "int", maxLength: 2500, nullable: false, comment: "Cargo capacity"),
                    CargoType = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Cargo type"),
                    LevelOfLoading = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    NotAvailable = table.Column<bool>(type: "bit", nullable: false, comment: "Point out if the Truck is available"),
                    DespatcherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trucks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trucks_Despatchers_DespatcherId",
                        column: x => x.DespatcherId,
                        principalTable: "Despatchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeparturePlace = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Truck`s point of departure"),
                    ArrivalPlace = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Trruck`s point of arrival"),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date and time of departure"),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Estimated date and time of arrival"),
                    Distance = table.Column<int>(type: "int", maxLength: 5000, nullable: false, comment: "Route`s total distance"),
                    IsCompleated = table.Column<bool>(type: "bit", nullable: false, comment: "Point if the route is compleated"),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriversTrucks",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversTrucks", x => new { x.TruckId, x.DriverId });
                    table.ForeignKey(
                        name: "FK_DriversTrucks_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DriversTrucks_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DespatcherId",
                table: "Clients",
                column: "DespatcherId");

            migrationBuilder.CreateIndex(
                name: "IX_Despatchers_UserId",
                table: "Despatchers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_DespatcherId",
                table: "Drivers",
                column: "DespatcherId");

            migrationBuilder.CreateIndex(
                name: "IX_DriversTrucks_DriverId",
                table: "DriversTrucks",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_DriverId",
                table: "Routes",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_CategoryId",
                table: "Trucks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_DespatcherId",
                table: "Trucks",
                column: "DespatcherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "DriversTrucks");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Despatchers");
        }
    }
}
