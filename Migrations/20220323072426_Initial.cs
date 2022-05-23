using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2121_wave_cafe.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cafe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TênSP = table.Column<string>(nullable: true),
                    NgàyNhập = table.Column<DateTime>(nullable: false),
                    SốLượng = table.Column<string>(nullable: true),
                    GiáTiền = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cafe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cafe");
        }
    }
}
