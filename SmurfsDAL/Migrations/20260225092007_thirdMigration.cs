using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmurfsDAL.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_Forests_ForestId",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Forests_ForestId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ForestId",
                table: "Items",
                newName: "ForestIdf1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Items",
                newName: "Idi");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ForestId",
                table: "Items",
                newName: "IX_Items_ForestIdf1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Forests",
                newName: "Idf");

            migrationBuilder.RenameColumn(
                name: "ForestId",
                table: "Creatures",
                newName: "ForestIdf1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Creatures",
                newName: "Idc");

            migrationBuilder.RenameIndex(
                name: "IX_Creatures_ForestId",
                table: "Creatures",
                newName: "IX_Creatures_ForestIdf1");

            migrationBuilder.AddColumn<int>(
                name: "ForestIdf",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForestIdf",
                table: "Creatures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ForestIdf",
                table: "Items",
                column: "ForestIdf");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_ForestIdf",
                table: "Creatures",
                column: "ForestIdf");

            migrationBuilder.AddForeignKey(
                name: "FK_Creatures_Forests_ForestIdf",
                table: "Creatures",
                column: "ForestIdf",
                principalTable: "Forests",
                principalColumn: "Idf",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Creatures_Forests_ForestIdf1",
                table: "Creatures",
                column: "ForestIdf1",
                principalTable: "Forests",
                principalColumn: "Idf");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Forests_ForestIdf",
                table: "Items",
                column: "ForestIdf",
                principalTable: "Forests",
                principalColumn: "Idf",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Forests_ForestIdf1",
                table: "Items",
                column: "ForestIdf1",
                principalTable: "Forests",
                principalColumn: "Idf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_Forests_ForestIdf",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_Forests_ForestIdf1",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Forests_ForestIdf",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Forests_ForestIdf1",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ForestIdf",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Creatures_ForestIdf",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "ForestIdf",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ForestIdf",
                table: "Creatures");

            migrationBuilder.RenameColumn(
                name: "ForestIdf1",
                table: "Items",
                newName: "ForestId");

            migrationBuilder.RenameColumn(
                name: "Idi",
                table: "Items",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ForestIdf1",
                table: "Items",
                newName: "IX_Items_ForestId");

            migrationBuilder.RenameColumn(
                name: "Idf",
                table: "Forests",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ForestIdf1",
                table: "Creatures",
                newName: "ForestId");

            migrationBuilder.RenameColumn(
                name: "Idc",
                table: "Creatures",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Creatures_ForestIdf1",
                table: "Creatures",
                newName: "IX_Creatures_ForestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Creatures_Forests_ForestId",
                table: "Creatures",
                column: "ForestId",
                principalTable: "Forests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Forests_ForestId",
                table: "Items",
                column: "ForestId",
                principalTable: "Forests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
