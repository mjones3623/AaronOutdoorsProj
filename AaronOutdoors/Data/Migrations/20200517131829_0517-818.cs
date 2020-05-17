using Microsoft.EntityFrameworkCore.Migrations;

namespace AaronOutdoors.Data.Migrations
{
    public partial class _0517818 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cb79ae3-0728-4319-9733-1c8721266f2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f780e57-6349-407e-afb6-da545b1af61e");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "SiteUsers",
                newName: "Image");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9605e105-29d0-44be-8cbe-a3eba9fe49cd", "9aa92afe-4a66-4761-af4e-c7b395069b32", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e1431c9-5305-4078-9929-711bd69800bf", "b97d0511-400d-436a-987f-ce4df1f3c036", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e1431c9-5305-4078-9929-711bd69800bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9605e105-29d0-44be-8cbe-a3eba9fe49cd");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "SiteUsers",
                newName: "image");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cb79ae3-0728-4319-9733-1c8721266f2e", "ea094bb2-a84a-457b-b027-93ec5c9f2a84", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f780e57-6349-407e-afb6-da545b1af61e", "d7692d42-2d40-4a33-87e2-8f55d1f1361e", "SiteUser", "SiteUser" });
        }
    }
}
