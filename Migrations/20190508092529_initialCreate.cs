using Microsoft.EntityFrameworkCore.Migrations;

namespace Leo.Test.AutoRT.Migrations
{
    public partial class initialCreate : Migration
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
                    Availability = table.Column<bool>(nullable: false),
                    VeriMethod = table.Column<string>(nullable: true),
                    VeriNo = table.Column<string>(nullable: true),
                    BrowserType = table.Column<string>(nullable: true),
                    BrowserFilter = table.Column<int>(nullable: false),
                    BrowserContent = table.Column<string>(nullable: true),
                    ScreenType = table.Column<string>(nullable: true),
                    ScreenFilter = table.Column<int>(nullable: false),
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
