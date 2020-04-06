using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaPlatform.Storing.Migrations
{
    public partial class migratioin2 : Migration
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
                values: new object[] { 637217767848196661L, "Random Community", null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 637217767848182179L, "Demi Demi", "12345", "demi" },
                    { 637217767848183074L, "Jesus", "Password12345", "jesus" },
                    { 637217767848183101L, "George", "password", "george" },
                    { 637217767848183107L, "Jeremy", "12345", "jeremy" }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "ID", "CommunityID", "Duration", "Title", "URL", "UploadedBy", "UserID" },
                values: new object[,]
                {
                    { 637217767848194626L, null, 31L, "Tough Time Never Last, Only Tough People Last", "https://www.youtube.com/embed/1puR8jGK03A", "Demi Demi", null },
                    { 637217767848195645L, null, 500L, "Birds are not real", null, "George", null }
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
