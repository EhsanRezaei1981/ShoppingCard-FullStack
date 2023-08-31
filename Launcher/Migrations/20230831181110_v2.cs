using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping_Card_Api.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_ShoppingCards_Tb_Users_UserId",
                table: "Tb_ShoppingCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_ShoppingCardsDetails_Tb_SaleItems_SaleItemId",
                table: "Tb_ShoppingCardsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_ShoppingCardsDetails_Tb_ShoppingCards_ShoppingCardId",
                table: "Tb_ShoppingCardsDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Users",
                table: "Tb_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_ShoppingCardsDetails",
                table: "Tb_ShoppingCardsDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_ShoppingCards",
                table: "Tb_ShoppingCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_SaleItems",
                table: "Tb_SaleItems");

            migrationBuilder.RenameTable(
                name: "Tb_Users",
                newName: "Tb_User");

            migrationBuilder.RenameTable(
                name: "Tb_ShoppingCardsDetails",
                newName: "Tb_ShoppingCardDetail");

            migrationBuilder.RenameTable(
                name: "Tb_ShoppingCards",
                newName: "Tb_ShoppingCard");

            migrationBuilder.RenameTable(
                name: "Tb_SaleItems",
                newName: "Tb_SaleItem");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_Users_Email",
                table: "Tb_User",
                newName: "IX_Tb_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_ShoppingCardsDetails_ShoppingCardId_SaleItemId",
                table: "Tb_ShoppingCardDetail",
                newName: "IX_Tb_ShoppingCardDetail_ShoppingCardId_SaleItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_ShoppingCardsDetails_SaleItemId",
                table: "Tb_ShoppingCardDetail",
                newName: "IX_Tb_ShoppingCardDetail_SaleItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_ShoppingCards_UserId",
                table: "Tb_ShoppingCard",
                newName: "IX_Tb_ShoppingCard_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_SaleItems_Name",
                table: "Tb_SaleItem",
                newName: "IX_Tb_SaleItem_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_User",
                table: "Tb_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_ShoppingCardDetail",
                table: "Tb_ShoppingCardDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_ShoppingCard",
                table: "Tb_ShoppingCard",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_SaleItem",
                table: "Tb_SaleItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_ShoppingCard_Tb_User_UserId",
                table: "Tb_ShoppingCard",
                column: "UserId",
                principalTable: "Tb_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_ShoppingCardDetail_Tb_SaleItem_SaleItemId",
                table: "Tb_ShoppingCardDetail",
                column: "SaleItemId",
                principalTable: "Tb_SaleItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_ShoppingCardDetail_Tb_ShoppingCard_ShoppingCardId",
                table: "Tb_ShoppingCardDetail",
                column: "ShoppingCardId",
                principalTable: "Tb_ShoppingCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_ShoppingCard_Tb_User_UserId",
                table: "Tb_ShoppingCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_ShoppingCardDetail_Tb_SaleItem_SaleItemId",
                table: "Tb_ShoppingCardDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_ShoppingCardDetail_Tb_ShoppingCard_ShoppingCardId",
                table: "Tb_ShoppingCardDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_User",
                table: "Tb_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_ShoppingCardDetail",
                table: "Tb_ShoppingCardDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_ShoppingCard",
                table: "Tb_ShoppingCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_SaleItem",
                table: "Tb_SaleItem");

            migrationBuilder.RenameTable(
                name: "Tb_User",
                newName: "Tb_Users");

            migrationBuilder.RenameTable(
                name: "Tb_ShoppingCardDetail",
                newName: "Tb_ShoppingCardsDetails");

            migrationBuilder.RenameTable(
                name: "Tb_ShoppingCard",
                newName: "Tb_ShoppingCards");

            migrationBuilder.RenameTable(
                name: "Tb_SaleItem",
                newName: "Tb_SaleItems");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_User_Email",
                table: "Tb_Users",
                newName: "IX_Tb_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_ShoppingCardDetail_ShoppingCardId_SaleItemId",
                table: "Tb_ShoppingCardsDetails",
                newName: "IX_Tb_ShoppingCardsDetails_ShoppingCardId_SaleItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_ShoppingCardDetail_SaleItemId",
                table: "Tb_ShoppingCardsDetails",
                newName: "IX_Tb_ShoppingCardsDetails_SaleItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_ShoppingCard_UserId",
                table: "Tb_ShoppingCards",
                newName: "IX_Tb_ShoppingCards_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_SaleItem_Name",
                table: "Tb_SaleItems",
                newName: "IX_Tb_SaleItems_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Users",
                table: "Tb_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_ShoppingCardsDetails",
                table: "Tb_ShoppingCardsDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_ShoppingCards",
                table: "Tb_ShoppingCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_SaleItems",
                table: "Tb_SaleItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_ShoppingCards_Tb_Users_UserId",
                table: "Tb_ShoppingCards",
                column: "UserId",
                principalTable: "Tb_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_ShoppingCardsDetails_Tb_SaleItems_SaleItemId",
                table: "Tb_ShoppingCardsDetails",
                column: "SaleItemId",
                principalTable: "Tb_SaleItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_ShoppingCardsDetails_Tb_ShoppingCards_ShoppingCardId",
                table: "Tb_ShoppingCardsDetails",
                column: "ShoppingCardId",
                principalTable: "Tb_ShoppingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
