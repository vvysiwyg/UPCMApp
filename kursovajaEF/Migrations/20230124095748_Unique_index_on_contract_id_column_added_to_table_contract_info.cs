using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class Unique_index_on_contract_id_column_added_to_table_contract_info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "unique_index_contract_id",
                table: "contract_info",
                column: "contract_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "unique_index_contract_id",
                table: "contract_info");
        }
    }
}
