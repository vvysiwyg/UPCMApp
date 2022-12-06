using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace kursovajaEF.Migrations
{
    public partial class NewtableChairaddedNewconnectionChairparentTeacherchild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "chair_id",
                table: "teachers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "chairs",
                columns: table => new
                {
                    chair_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    chair_name = table.Column<string>(type: "character varying(65)", maxLength: 65, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chairs", x => x.chair_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_teachers_chair_id",
                table: "teachers",
                column: "chair_id");

            migrationBuilder.AddForeignKey(
                name: "chair_id_fkey",
                table: "teachers",
                column: "chair_id",
                principalTable: "chairs",
                principalColumn: "chair_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "chair_id_fkey",
                table: "teachers");

            migrationBuilder.DropTable(
                name: "chairs");

            migrationBuilder.DropIndex(
                name: "IX_teachers_chair_id",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "chair_id",
                table: "teachers");
        }
    }
}
