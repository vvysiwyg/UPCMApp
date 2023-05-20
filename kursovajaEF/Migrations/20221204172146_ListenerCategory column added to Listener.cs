using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class ListenerCategorycolumnaddedtoListener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "listener_category",
                table: "listeners",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "listener_category",
                table: "listeners");
        }
    }
}
