using Microsoft.EntityFrameworkCore.Migrations;

namespace _2121_wave_cafe.Migrations
{
    public partial class NhậnXét : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "GiáTiền",
                table: "cafe",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "NhậnXét",
                table: "cafe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NhậnXét",
                table: "cafe");

            migrationBuilder.AlterColumn<decimal>(
                name: "GiáTiền",
                table: "cafe",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
