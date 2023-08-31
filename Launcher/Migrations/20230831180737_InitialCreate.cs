using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_Card_Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_SaleItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_SaleItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_ShoppingCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_ShoppingCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_ShoppingCards_Tb_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Tb_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_ShoppingCardsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCardId = table.Column<int>(type: "int", nullable: false),
                    SaleItemId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_ShoppingCardsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_ShoppingCardsDetails_Tb_SaleItems_SaleItemId",
                        column: x => x.SaleItemId,
                        principalTable: "Tb_SaleItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_ShoppingCardsDetails_Tb_ShoppingCards_ShoppingCardId",
                        column: x => x.ShoppingCardId,
                        principalTable: "Tb_ShoppingCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_SaleItems_Name",
                table: "Tb_SaleItems",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_ShoppingCards_UserId",
                table: "Tb_ShoppingCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_ShoppingCardsDetails_SaleItemId",
                table: "Tb_ShoppingCardsDetails",
                column: "SaleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_ShoppingCardsDetails_ShoppingCardId_SaleItemId",
                table: "Tb_ShoppingCardsDetails",
                columns: new[] { "ShoppingCardId", "SaleItemId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Users_Email",
                table: "Tb_Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_ShoppingCardsDetails");

            migrationBuilder.DropTable(
                name: "Tb_SaleItems");

            migrationBuilder.DropTable(
                name: "Tb_ShoppingCards");

            migrationBuilder.DropTable(
                name: "Tb_Users");
        }
    }
}
