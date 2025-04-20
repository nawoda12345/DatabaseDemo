using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureCarrierRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_Carrier_CarrierId",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carrier",
                table: "Carrier");

            migrationBuilder.RenameTable(
                name: "Carrier",
                newName: "carriers");

            migrationBuilder.RenameColumn(
                name: "TrackingNumber",
                table: "orders",
                newName: "tracking_number");

            migrationBuilder.RenameColumn(
                name: "ShippedDate",
                table: "orders",
                newName: "shipped_date");

            migrationBuilder.RenameColumn(
                name: "DeliveredDate",
                table: "orders",
                newName: "delivered_date");

            migrationBuilder.RenameColumn(
                name: "ContactUrl",
                table: "carriers",
                newName: "contact_url");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "carriers",
                newName: "contact_phone");

            migrationBuilder.RenameColumn(
                name: "CarrierName",
                table: "carriers",
                newName: "carrier_name");

            migrationBuilder.AlterColumn<string>(
                name: "tracking_number",
                table: "orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contact_url",
                table: "carriers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contact_phone",
                table: "carriers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "carrier_name",
                table: "carriers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "carriers_pkey",
                table: "carriers",
                column: "CarrierId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_carriers_CarrierId",
                table: "orders",
                column: "CarrierId",
                principalTable: "carriers",
                principalColumn: "CarrierId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_carriers_CarrierId",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "carriers_pkey",
                table: "carriers");

            migrationBuilder.RenameTable(
                name: "carriers",
                newName: "Carrier");

            migrationBuilder.RenameColumn(
                name: "tracking_number",
                table: "orders",
                newName: "TrackingNumber");

            migrationBuilder.RenameColumn(
                name: "shipped_date",
                table: "orders",
                newName: "ShippedDate");

            migrationBuilder.RenameColumn(
                name: "delivered_date",
                table: "orders",
                newName: "DeliveredDate");

            migrationBuilder.RenameColumn(
                name: "contact_url",
                table: "Carrier",
                newName: "ContactUrl");

            migrationBuilder.RenameColumn(
                name: "contact_phone",
                table: "Carrier",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "carrier_name",
                table: "Carrier",
                newName: "CarrierName");

            migrationBuilder.AlterColumn<string>(
                name: "TrackingNumber",
                table: "orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactUrl",
                table: "Carrier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactPhone",
                table: "Carrier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CarrierName",
                table: "Carrier",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carrier",
                table: "Carrier",
                column: "CarrierId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Carrier_CarrierId",
                table: "orders",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "CarrierId");
        }
    }
}
