using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication36.Migrations
{
    public partial class @in : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrants",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantPhotoVideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantFacebookPageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantTwitterHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantInstagramHandle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantYouTubeChannelUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantFullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantGooglePlaceId = table.Column<int>(type: "int", nullable: false),
                    EntrantPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrantWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfWriteIns = table.Column<int>(type: "int", nullable: false),
                    NumberOfVotes = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrants", x => x.GroupId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrants");
        }
    }
}
