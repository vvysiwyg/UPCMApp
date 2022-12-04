using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class BankcolumnaddedtoContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "teacher_id",
                table: "disciplines_teachers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pay_date_40pct",
                table: "contracts",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "bank",
                table: "contracts",
                type: "character varying(55)",
                maxLength: 55,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_disciplines_teachers",
                table: "disciplines_teachers",
                columns: new[] { "discipline_id", "teacher_id" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_disciplines_teachers",
                table: "disciplines_teachers");

            migrationBuilder.DropColumn(
                name: "bank",
                table: "contracts");

            migrationBuilder.AlterColumn<int>(
                name: "teacher_id",
                table: "disciplines_teachers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "pay_date_40pct",
                table: "contracts",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
