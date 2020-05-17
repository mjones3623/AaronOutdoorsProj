using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AaronOutdoors.Data.Migrations
{
    public partial class _0516225 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "920221b9-371e-4d4f-8aa3-8d8b3034d62f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f86dbdbf-287b-43b7-ade3-bf89fd7e62d2");

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text1 = table.Column<string>(nullable: true),
                    Text2 = table.Column<string>(nullable: true),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                });

            migrationBuilder.CreateTable(
                name: "SiteUsers",
                columns: table => new
                {
                    SiteUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    SiteUserFirstName = table.Column<string>(nullable: true),
                    SiteUserLastName = table.Column<string>(nullable: true),
                    SiteUserStreetAddress = table.Column<string>(nullable: true),
                    SiteUserCity = table.Column<string>(nullable: true),
                    SiteUserState = table.Column<string>(nullable: true),
                    SiteUserZipCode = table.Column<string>(nullable: true),
                    SiteUserPhone = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteUsers", x => x.SiteUserId);
                    table.ForeignKey(
                        name: "FK_SiteUsers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    StateAbbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    BlogCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCommentSiteUserId = table.Column<int>(nullable: false),
                    BlogCommentText = table.Column<string>(nullable: true),
                    BlogCommentDateTime = table.Column<DateTime>(nullable: false),
                    BlogPostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.BlogCommentId);
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cdbe1522-29d9-422d-82fd-c2c226c00a2c", "2508fba3-d3aa-4279-bae0-f159519c4299", "SiteUser", "SiteUser" },
                    { "68ca2558-4e26-40c1-81cf-e7d5cd715f1d", "8585827c-7305-47f6-97f1-f767a44344e0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "StateAbbreviation", "StateName" },
                values: new object[,]
                {
                    { 50, "WY", "Wyoming" },
                    { 29, "NH", "New Hampshire" },
                    { 30, "NJ", "New Jersey" },
                    { 31, "NM", "New Mexico" },
                    { 32, "NY", "New York" },
                    { 33, "NC", "North Carolina" },
                    { 34, "ND", "North Dakota" },
                    { 35, "OH", "Ohio" },
                    { 36, "OK", "Oklahoma" },
                    { 37, "OR", "Oregon" },
                    { 38, "PA", "Pennsylvania" },
                    { 39, "RI", "Rhode Island" },
                    { 28, "NV", "Nevada" },
                    { 41, "SD", "South Dakota" },
                    { 42, "TN", "Tennessee" },
                    { 43, "TX", "Texas" },
                    { 44, "UT", "Utah" },
                    { 45, "VT", "Vermont" },
                    { 46, "VA", "Virginia" },
                    { 47, "WA", "Washington" },
                    { 48, "WV", "West Virginia" },
                    { 49, "WI", "Wisconsin" },
                    { 51, "DC", "District of Columbia" },
                    { 40, "SC", "South Carolina" },
                    { 27, "NE", "Nebraska" },
                    { 25, "MO", "Missouri" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "FL", "Florida" },
                    { 10, "GA", "Georgia" },
                    { 11, "HI", "Hawaii" },
                    { 12, "ID", "Idaho" },
                    { 13, "IL", "Illinois" },
                    { 14, "IN", "Indiana" },
                    { 15, "IA", "Iowa" },
                    { 16, "KS", "Kansas" },
                    { 17, "KY", "Kentucky" },
                    { 18, "LA", "Louisiana" },
                    { 19, "ME", "Maine" },
                    { 20, "MD", "Maryland" },
                    { 21, "MA", "Massachusetts" },
                    { 22, "MI", "Michigan" },
                    { 23, "MN", "Minnesota" },
                    { 24, "MS", "Mississippi" },
                    { 26, "MT", "Montana" },
                    { 1, "AL", "Alabama" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogPostId",
                table: "BlogComments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUsers_IdentityUserId",
                table: "SiteUsers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "SiteUsers");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68ca2558-4e26-40c1-81cf-e7d5cd715f1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdbe1522-29d9-422d-82fd-c2c226c00a2c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f86dbdbf-287b-43b7-ade3-bf89fd7e62d2", "e914e7d8-9399-4a90-91a3-62c8eb55b4fc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "920221b9-371e-4d4f-8aa3-8d8b3034d62f", "a87ace75-71d1-45ff-989e-a94a65f63773", "SiteUser", "SiteUser" });
        }
    }
}
