using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SerempreClientAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 19, 11, 2, 27, 97, DateTimeKind.Local).AddTicks(5676)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 19, 11, 2, 27, 97, DateTimeKind.Local).AddTicks(6159))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 19, 11, 2, 27, 97, DateTimeKind.Local).AddTicks(7480)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 19, 11, 2, 27, 97, DateTimeKind.Local).AddTicks(7851))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 19, 11, 2, 27, 97, DateTimeKind.Local).AddTicks(6592)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 19, 11, 2, 27, 97, DateTimeKind.Local).AddTicks(7038))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bogotá" },
                    { 2, "Medellín" },
                    { 3, "Cali" },
                    { 4, "Barranquilla" },
                    { 5, "Cartagena" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Photo" },
                values: new object[] { 1, "admin@admin.com", "Administrador", "admin123", "photo1.jpg" });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Antonio Garcia" },
                    { 2, 2, "Sonia Flores" },
                    { 3, 3, "Ana Gomez" },
                    { 4, 4, "Jose Gonzalez" },
                    { 5, 5, "Servelina Montaño" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_CityId",
                table: "Client",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
