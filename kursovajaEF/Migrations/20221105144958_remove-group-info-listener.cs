using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class removegroupinfolistener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group_info_listeners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "group_info_listeners",
                columns: table => new
                {
                    group_info_id = table.Column<int>(type: "integer", nullable: true),
                    listener_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "group_info_id_fkey",
                        column: x => x.group_info_id,
                        principalTable: "group_info",
                        principalColumn: "group_info_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "listener_id_fkey",
                        column: x => x.listener_id,
                        principalTable: "listeners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_info_listeners_group_info_id",
                table: "group_info_listeners",
                column: "group_info_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_info_listeners_listener_id",
                table: "group_info_listeners",
                column: "listener_id");
        }
    }
}
