using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiWSB.Migrations
{
    public partial class wsbtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wsbObjects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no_of_comments = table.Column<int>(nullable: false),
                    sentiment = table.Column<string>(nullable: true),
                    sentiment_score = table.Column<decimal>(nullable: false),
                    ticker = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wsbObjects", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wsbObjects");
        }
    }
}
