using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class addgroupinfoteacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "group_info_teacher",
                columns: table => new
                {
                    group_info_id = table.Column<int>(type: "integer", nullable: false),
                    teacher_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_info_teacher", x => new { x.group_info_id, x.teacher_id });
                    table.ForeignKey(
                        name: "group_info_fkey",
                        column: x => x.group_info_id,
                        principalTable: "group_info",
                        principalColumn: "group_info_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "teacher_fkey",
                        column: x => x.teacher_id,
                        principalTable: "teachers",
                        principalColumn: "teacher_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_group_info_teacher_teacher_id",
                table: "group_info_teacher",
                column: "teacher_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group_info_teacher");
        }
    }
}
