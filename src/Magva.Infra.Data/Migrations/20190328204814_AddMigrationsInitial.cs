using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Magva.Infra.Data.Migrations
{
    public partial class AddMigrationsInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Street = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Number = table.Column<string>(maxLength: 10, nullable: false),
                    Complement = table.Column<string>(maxLength: 20, nullable: false),
                    District = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "Varchar(25)", maxLength: 25, nullable: false),
                    State = table.Column<string>(type: "Varchar(25)", maxLength: 25, nullable: false),
                    Country = table.Column<string>(type: "Varchar(25)", maxLength: 25, nullable: false),
                    ZipeCode = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(type: "Varchar()", nullable: false),
                    LastName = table.Column<string>(type: "Varchar(40)", nullable: false),
                    Email = table.Column<string>(type: "Varchar(25)", nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(type: "Varchar(11)", nullable: false),
                    Phone = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CardholderNameId = table.Column<Guid>(nullable: true),
                    Number = table.Column<string>(maxLength: 19, nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    CardBrand = table.Column<string>(type: "Varchar(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    HasPassword = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_Customer_CardholderNameId",
                        column: x => x.CardholderNameId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    money = table.Column<decimal>(maxLength: 50, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    DateTransaction = table.Column<DateTime>(nullable: false),
                    CardId = table.Column<Guid>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Card_CardId",
                        column: x => x.CardId,
                        principalTable: "Card",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transaction_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_CardholderNameId",
                table: "Card",
                column: "CardholderNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AddressId",
                table: "Customer",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CardId",
                table: "Transaction",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerId",
                table: "Transaction",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
