using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaPlatform.Storing.Migrations
{
    public partial class migratioin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Community",
                keyColumn: "ID",
                keyValue: 637217694438362014L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217694438344862L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217694438346469L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217694438346501L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217694438346507L);

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumn: "ID",
                keyValue: 637217694438359757L);

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumn: "ID",
                keyValue: 637217694438360866L);

            migrationBuilder.InsertData(
                table: "Community",
                columns: new[] { "ID", "Name", "UserID" },
                values: new object[] { 637217761682925054L, "Random Community", null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 637217761682906727L, "Demi Demi", "12345", "demi" },
                    { 637217761682907686L, "Jesus", "Password12345", "jesus" },
                    { 637217761682907722L, "George", "password", "george" },
                    { 637217761682907728L, "Jeremy", "12345", "jeremy" }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "ID", "CommunityID", "Duration", "Title", "URL", "UploadedBy", "UserID" },
                values: new object[,]
                {
                    { 637217761682922348L, null, 31L, "Tough Time Never Last, Only Tough People Last", "https://www.youtube.com/embed/1puR8jGK03A", "Demi Demi", null },
                    { 637217761682923770L, null, 500L, "Birds are not real", null, "George", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Community",
                keyColumn: "ID",
                keyValue: 637217761682925054L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217761682906727L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217761682907686L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217761682907722L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 637217761682907728L);

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumn: "ID",
                keyValue: 637217761682922348L);

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumn: "ID",
                keyValue: 637217761682923770L);

            migrationBuilder.InsertData(
                table: "Community",
                columns: new[] { "ID", "Name", "UserID" },
                values: new object[] { 637217694438362014L, "Random Community", null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 637217694438344862L, "Demi Demi", "12345", "demi" },
                    { 637217694438346469L, "Jesus", "Password12345", "jesus" },
                    { 637217694438346501L, "George", "password", "george" },
                    { 637217694438346507L, "Jeremy", "12345", "jeremy" }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "ID", "CommunityID", "Duration", "Title", "URL", "UploadedBy", "UserID" },
                values: new object[,]
                {
                    { 637217694438359757L, null, 31L, "Tough Time Never Last, Only Tough People Last", "https://www.youtube.com/watch?v=1puR8jGK03A", "Demi Demi", null },
                    { 637217694438360866L, null, 500L, "Birds are not real", null, "George", null }
                });
        }
    }
}
