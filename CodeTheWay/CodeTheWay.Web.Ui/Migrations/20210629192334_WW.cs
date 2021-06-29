using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTheWay.Web.Ui.Migrations
{
    public partial class WW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HighTemp = table.Column<double>(nullable: false),
                    LowTemp = table.Column<double>(nullable: false),
                    AvgWindSpeed = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalPrecipitation = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
