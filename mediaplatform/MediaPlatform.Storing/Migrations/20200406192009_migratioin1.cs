using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaPlatform.Storing.Migrations
{
    public partial class migratioin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Community_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Duration = table.Column<long>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    CommunityID = table.Column<long>(nullable: true),
                    UserID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Video_Community_CommunityID",
                        column: x => x.CommunityID,
                        principalTable: "Community",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Video_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Community",
                columns: new[] { "ID", "Name", "UserID" },
                values: new object[] { 637217796089743941L, "Random Community", null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 637217796089725213L, "Demi Demi", "12345", "demi" },
                    { 637217796089726186L, "Jesus", "Password12345", "jesus" },
                    { 637217796089726218L, "George", "password", "george" },
                    { 637217796089726224L, "Jeremy", "12345", "jeremy" }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "ID", "CommunityID", "Duration", "Title", "URL", "UploadedBy", "UserID" },
                values: new object[,]
                {
                    { 637217796089740797L, null, 31L, "Tough Time Never Last, Only Tough People Last", "https://www.youtube.com/embed/1puR8jGK03A", "Demi Demi", null },
                    { 637217796089742280L, null, 247L, "Birds are not real", "https://www.youtube.com/embed/l30_APBNPXg", "George", null },
                    { 637217796089742334L, null, 552L, "Americans brace for possible approach of coronavirus peak", "https://www.youtube.com/embed/MwaK-SmcIx0", "Jeremy", null },
                    { 637217796089742340L, null, 1343L, "Watch Elon Musk announce the Tesla Cybertruck in 14 minutes", "https://www.youtube.com/embed/464puoD09dM", "Jesus", null },
                    { 637217796089742346L, null, 332L, "Rick Astley - Never Gonna Give You up (video)", "https://www.youtube.com/embed/dQw4w9WgXcQ", "George", null },
                    { 637217796089742351L, null, 322L, "The Kooks - Naive", "https://www.youtube.com/embed/jkaMiaRLgvY", " George", null },
                    { 637217796089742357L, null, 535L, "Gladiator Opening Scene(Part 1)", "https://www.youtube.com/embed/yXiSp9aJYN4", "Jeremy", null },
                    { 637217796089742363L, null, 428L, "Harry Potter and the Deathly Hallows part 2 - Snape's memories part 2 (HD)", "https://www.youtube.com/embed/iqyf-kJWwIg", "Jesus", null },
                    { 637217796089742369L, null, 3109L, "Shaq Tries to Not Make a Face While Eating Spicy Wings | Hot Ones", "https://www.youtube.com/embed/_sZH-psg9yE", "George", null },
                    { 637217796089742374L, null, 1336L, "Engine Placement EXPLAINED", "https://www.youtube.com/embed/SiOSbHo2dvk", "Jesus", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Community_UserID",
                table: "Community",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Video_CommunityID",
                table: "Video",
                column: "CommunityID");

            migrationBuilder.CreateIndex(
                name: "IX_Video_UserID",
                table: "Video",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
