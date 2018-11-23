using Microsoft.EntityFrameworkCore.Migrations;

namespace Leo.Test.AutoRT.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    ScreenName = table.Column<string>(nullable: true),
                    ScreenJpName = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    VeriMethod = table.Column<string>(nullable: true),
                    VeriNo = table.Column<string>(nullable: true),
                    BrowserType = table.Column<string>(nullable: true),
                    BrowserFilter = table.Column<string>(nullable: true),
                    BrowserContent = table.Column<string>(nullable: true),
                    ScreenType = table.Column<string>(nullable: true),
                    ScreenFilter = table.Column<string>(nullable: true),
                    ScreenContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Screens");
        }
    }
}
