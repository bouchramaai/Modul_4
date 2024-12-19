using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    addressId = table.Column<Guid>(name: "address Id", type: "TEXT", nullable: false),
                    street = table.Column<string>(type: "TEXT", nullable: false),
                    nr = table.Column<string>(type: "TEXT", nullable: false),
                    city = table.Column<string>(type: "TEXT", nullable: false),
                    zipCode = table.Column<string>(type: "TEXT", nullable: false),
                    country = table.Column<string>(type: "TEXT", nullable: false),
                    Continent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.addressId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<Guid>(name: "user Id", type: "TEXT", nullable: false),
                    firstName = table.Column<string>(name: "first Name", type: "TEXT", nullable: false),
                    secondName = table.Column<string>(name: "second Name ", type: "TEXT", nullable: true),
                    lastName = table.Column<string>(name: "last Name", type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    addressId = table.Column<Guid>(name: "address Id", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_addresses_address Id",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "address Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_address Id",
                table: "users",
                column: "address Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "addresses");
        }
    }
}
