using Microsoft.EntityFrameworkCore.Migrations;

namespace kursovajaEF.Migrations
{
    public partial class New_tables_listener_enrollment_orders_and_listener_expulsion_orders_Both_of_them_connected_to_table_contracts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateSequence<int>(
                name: "ListenerEnrollmentOrderIdSequence",
                schema: "public",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence<int>(
                name: "ListenerExpulsionOrderIdSequence",
                schema: "public",
                maxValue: 2147483647L);

            migrationBuilder.CreateTable(
                name: "listener_enrollment_orders",
                columns: table => new
                {
                    listener_enrollment_order_id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"ListenerEnrollmentOrderIdSequence\"')"),
                    number = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    contract_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("listener_enrollment_orders_pkey", x => x.listener_enrollment_order_id);
                    table.ForeignKey(
                        name: "listener_enrollment_orders_contract_id__fkey",
                        column: x => x.contract_id,
                        principalTable: "contracts",
                        principalColumn: "contract_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "listener_expulsion_orders",
                columns: table => new
                {
                    listener_expulsion_order_id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"ListenerExpulsionOrderIdSequence\"')"),
                    number = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    contract_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("listener_expulsion_orders_pkey", x => x.listener_expulsion_order_id);
                    table.ForeignKey(
                        name: "listener_expulsion_orders_contract_id__fkey",
                        column: x => x.contract_id,
                        principalTable: "contracts",
                        principalColumn: "contract_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "unique_index_contract_id_listener_enrollment_orders",
                table: "listener_enrollment_orders",
                column: "contract_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unique_index_contract_id_listener_expulsion_orders",
                table: "listener_expulsion_orders",
                column: "contract_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "listener_enrollment_orders");

            migrationBuilder.DropTable(
                name: "listener_expulsion_orders");

            migrationBuilder.DropSequence(
                name: "ListenerEnrollmentOrderIdSequence",
                schema: "public");

            migrationBuilder.DropSequence(
                name: "ListenerExpulsionOrderIdSequence",
                schema: "public");
        }
    }
}
