using Microsoft.EntityFrameworkCore.Migrations;

namespace AaronOutdoors.Data.Migrations
{
    public partial class _0517709 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68ca2558-4e26-40c1-81cf-e7d5cd715f1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdbe1522-29d9-422d-82fd-c2c226c00a2c");

            migrationBuilder.CreateTable(
                name: "BlogViews",
                columns: table => new
                {
                    BlogViewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogViewPostBlogPostId = table.Column<int>(nullable: true),
                    BlogViewCommentBlogCommentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogViews", x => x.BlogViewId);
                    table.ForeignKey(
                        name: "FK_BlogViews_BlogComments_BlogViewCommentBlogCommentId",
                        column: x => x.BlogViewCommentBlogCommentId,
                        principalTable: "BlogComments",
                        principalColumn: "BlogCommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogViews_BlogPosts_BlogViewPostBlogPostId",
                        column: x => x.BlogViewPostBlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cb79ae3-0728-4319-9733-1c8721266f2e", "ea094bb2-a84a-457b-b027-93ec5c9f2a84", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f780e57-6349-407e-afb6-da545b1af61e", "d7692d42-2d40-4a33-87e2-8f55d1f1361e", "SiteUser", "SiteUser" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogViews_BlogViewCommentBlogCommentId",
                table: "BlogViews",
                column: "BlogViewCommentBlogCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogViews_BlogViewPostBlogPostId",
                table: "BlogViews",
                column: "BlogViewPostBlogPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogViews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cb79ae3-0728-4319-9733-1c8721266f2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f780e57-6349-407e-afb6-da545b1af61e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68ca2558-4e26-40c1-81cf-e7d5cd715f1d", "8585827c-7305-47f6-97f1-f767a44344e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cdbe1522-29d9-422d-82fd-c2c226c00a2c", "2508fba3-d3aa-4279-bae0-f159519c4299", "SiteUser", "SiteUser" });
        }
    }
}
