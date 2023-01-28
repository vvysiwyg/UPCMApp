using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class Removed_FK_from_Listener_and_added_new_FK_to_Contract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "contracts_fkey",
                table: "listeners");

            migrationBuilder.DropIndex(
                name: "unique_contract_id",
                table: "listeners");

            migrationBuilder.DropColumn(
                name: "contract_id",
                table: "listeners");

            migrationBuilder.AddColumn<int>(
                name: "listener_id",
                table: "contracts",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_contracts_listener_id",
                table: "contracts",
                column: "listener_id");

            migrationBuilder.AddForeignKey(
                name: "listener_id_fkey2",
                table: "contracts",
                column: "listener_id",
                principalTable: "listeners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "listener_id_fkey2",
                table: "contracts");

            migrationBuilder.DropIndex(
                name: "IX_contracts_listener_id",
                table: "contracts");

            migrationBuilder.DropColumn(
                name: "listener_id",
                table: "contracts");

            migrationBuilder.AddColumn<int>(
                name: "contract_id",
                table: "listeners",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "unique_contract_id",
                table: "listeners",
                column: "contract_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "contracts_fkey",
                table: "listeners",
                column: "contract_id",
                principalTable: "contracts",
                principalColumn: "contract_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
