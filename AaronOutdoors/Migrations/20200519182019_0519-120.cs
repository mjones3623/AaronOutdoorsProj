using Microsoft.EntityFrameworkCore.Migrations;

namespace AaronOutdoors.Migrations
{
    public partial class _0519120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66f27418-9dfe-4e95-b377-76bb61980ba0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fb1ec94-3e3a-442d-9746-323e5944e88b");

            migrationBuilder.AddColumn<string>(
                name: "Text1Heading",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text2Heading",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentBlogPostId",
                table: "BlogComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3dd8ff2b-e5ca-40b5-902f-3d5016e541ac", "bd5942e0-0c24-4f85-8065-9191f1a5ae1d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f29171bb-40e8-4d05-81ea-f4652330838e", "911f8d63-201d-4de2-b226-1fa66db52d4e", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd8ff2b-e5ca-40b5-902f-3d5016e541ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f29171bb-40e8-4d05-81ea-f4652330838e");

            migrationBuilder.DropColumn(
                name: "Text1Heading",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Text2Heading",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "CommentBlogPostId",
                table: "BlogComments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66f27418-9dfe-4e95-b377-76bb61980ba0", "53122c72-729b-4231-bca4-4456dcb7ed6b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6fb1ec94-3e3a-442d-9746-323e5944e88b", "60bfc185-2f24-4de9-9b94-5cae1143ae2b", "SiteUser", "SiteUser" });
        }
    }
}
