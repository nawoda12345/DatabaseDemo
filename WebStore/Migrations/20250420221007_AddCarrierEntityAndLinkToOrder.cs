using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class AddCarrierEntityAndLinkToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carrier",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "CarrierId",
                table: "orders",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Carrier",
                columns: table => new
                {
                    CarrierId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CarrierName = table.Column<string>(type: "text", nullable: false),
                    ContactUrl = table.Column<string>(type: "text", nullable: true),
                    ContactPhone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrier", x => x.CarrierId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_CarrierId",
                table: "orders",
                column: "CarrierId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Carrier_CarrierId",
                table: "orders",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "CarrierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_Carrier_CarrierId",
                table: "orders");

            migrationBuilder.DropTable(
                name: "Carrier");

            migrationBuilder.DropIndex(
                name: "IX_orders_CarrierId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "CarrierId",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "Carrier",
                table: "orders",
                type: "text",
                nullable: true);
        }
    }
}
