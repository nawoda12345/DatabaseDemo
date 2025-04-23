using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountEnumSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // STEP 1: Create the PostgreSQL enum type
            migrationBuilder.Sql("CREATE TYPE discount_type AS ENUM ('Percentage', 'Flat');");

            // STEP 2: Alter the column to use the new enum
            migrationBuilder.Sql("ALTER TABLE discount_codes ALTER COLUMN discount_type TYPE discount_type USING discount_type::text::discount_type;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:public.discount_type", "percentage,flat");

            migrationBuilder.AlterColumn<int>(
                name: "discount_type",
                table: "discount_codes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "discount_type");
        }
    }
}
