﻿// <auto-generated />
using System;
using AaronOutdoors.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AaronOutdoors.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AaronOutdoors.Models.BlogComment", b =>
                {
                    b.Property<int>("BlogCommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BlogCommentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BlogCommentSiteUserId")
                        .HasColumnType("int");

                    b.Property<string>("BlogCommentText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogCommentId");

                    b.ToTable("BlogComments");
                });

            modelBuilder.Entity("AaronOutdoors.Models.BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogPostId");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("AaronOutdoors.Models.BlogView", b =>
                {
                    b.Property<int>("BlogViewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogViewCommentBlogCommentId")
                        .HasColumnType("int");

                    b.Property<int?>("BlogViewPostBlogPostId")
                        .HasColumnType("int");

                    b.HasKey("BlogViewId");

                    b.HasIndex("BlogViewCommentBlogCommentId");

                    b.HasIndex("BlogViewPostBlogPostId");

                    b.ToTable("BlogViews");
                });

            modelBuilder.Entity("AaronOutdoors.Models.SiteUser", b =>
                {
                    b.Property<int>("SiteUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserStreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteUserId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("SiteUsers");
                });

            modelBuilder.Entity("AaronOutdoors.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateAbbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = 1,
                            StateAbbreviation = "AL",
                            StateName = "Alabama"
                        },
                        new
                        {
                            StateId = 2,
                            StateAbbreviation = "AK",
                            StateName = "Alaska"
                        },
                        new
                        {
                            StateId = 3,
                            StateAbbreviation = "AZ",
                            StateName = "Arizona"
                        },
                        new
                        {
                            StateId = 4,
                            StateAbbreviation = "AR",
                            StateName = "Arkansas"
                        },
                        new
                        {
                            StateId = 5,
                            StateAbbreviation = "CA",
                            StateName = "California"
                        },
                        new
                        {
                            StateId = 6,
                            StateAbbreviation = "CO",
                            StateName = "Colorado"
                        },
                        new
                        {
                            StateId = 7,
                            StateAbbreviation = "CT",
                            StateName = "Connecticut"
                        },
                        new
                        {
                            StateId = 8,
                            StateAbbreviation = "DE",
                            StateName = "Delaware"
                        },
                        new
                        {
                            StateId = 9,
                            StateAbbreviation = "FL",
                            StateName = "Florida"
                        },
                        new
                        {
                            StateId = 10,
                            StateAbbreviation = "GA",
                            StateName = "Georgia"
                        },
                        new
                        {
                            StateId = 11,
                            StateAbbreviation = "HI",
                            StateName = "Hawaii"
                        },
                        new
                        {
                            StateId = 12,
                            StateAbbreviation = "ID",
                            StateName = "Idaho"
                        },
                        new
                        {
                            StateId = 13,
                            StateAbbreviation = "IL",
                            StateName = "Illinois"
                        },
                        new
                        {
                            StateId = 14,
                            StateAbbreviation = "IN",
                            StateName = "Indiana"
                        },
                        new
                        {
                            StateId = 15,
                            StateAbbreviation = "IA",
                            StateName = "Iowa"
                        },
                        new
                        {
                            StateId = 16,
                            StateAbbreviation = "KS",
                            StateName = "Kansas"
                        },
                        new
                        {
                            StateId = 17,
                            StateAbbreviation = "KY",
                            StateName = "Kentucky"
                        },
                        new
                        {
                            StateId = 18,
                            StateAbbreviation = "LA",
                            StateName = "Louisiana"
                        },
                        new
                        {
                            StateId = 19,
                            StateAbbreviation = "ME",
                            StateName = "Maine"
                        },
                        new
                        {
                            StateId = 20,
                            StateAbbreviation = "MD",
                            StateName = "Maryland"
                        },
                        new
                        {
                            StateId = 21,
                            StateAbbreviation = "MA",
                            StateName = "Massachusetts"
                        },
                        new
                        {
                            StateId = 22,
                            StateAbbreviation = "MI",
                            StateName = "Michigan"
                        },
                        new
                        {
                            StateId = 23,
                            StateAbbreviation = "MN",
                            StateName = "Minnesota"
                        },
                        new
                        {
                            StateId = 24,
                            StateAbbreviation = "MS",
                            StateName = "Mississippi"
                        },
                        new
                        {
                            StateId = 25,
                            StateAbbreviation = "MO",
                            StateName = "Missouri"
                        },
                        new
                        {
                            StateId = 26,
                            StateAbbreviation = "MT",
                            StateName = "Montana"
                        },
                        new
                        {
                            StateId = 27,
                            StateAbbreviation = "NE",
                            StateName = "Nebraska"
                        },
                        new
                        {
                            StateId = 28,
                            StateAbbreviation = "NV",
                            StateName = "Nevada"
                        },
                        new
                        {
                            StateId = 29,
                            StateAbbreviation = "NH",
                            StateName = "New Hampshire"
                        },
                        new
                        {
                            StateId = 30,
                            StateAbbreviation = "NJ",
                            StateName = "New Jersey"
                        },
                        new
                        {
                            StateId = 31,
                            StateAbbreviation = "NM",
                            StateName = "New Mexico"
                        },
                        new
                        {
                            StateId = 32,
                            StateAbbreviation = "NY",
                            StateName = "New York"
                        },
                        new
                        {
                            StateId = 33,
                            StateAbbreviation = "NC",
                            StateName = "North Carolina"
                        },
                        new
                        {
                            StateId = 34,
                            StateAbbreviation = "ND",
                            StateName = "North Dakota"
                        },
                        new
                        {
                            StateId = 35,
                            StateAbbreviation = "OH",
                            StateName = "Ohio"
                        },
                        new
                        {
                            StateId = 36,
                            StateAbbreviation = "OK",
                            StateName = "Oklahoma"
                        },
                        new
                        {
                            StateId = 37,
                            StateAbbreviation = "OR",
                            StateName = "Oregon"
                        },
                        new
                        {
                            StateId = 38,
                            StateAbbreviation = "PA",
                            StateName = "Pennsylvania"
                        },
                        new
                        {
                            StateId = 39,
                            StateAbbreviation = "RI",
                            StateName = "Rhode Island"
                        },
                        new
                        {
                            StateId = 40,
                            StateAbbreviation = "SC",
                            StateName = "South Carolina"
                        },
                        new
                        {
                            StateId = 41,
                            StateAbbreviation = "SD",
                            StateName = "South Dakota"
                        },
                        new
                        {
                            StateId = 42,
                            StateAbbreviation = "TN",
                            StateName = "Tennessee"
                        },
                        new
                        {
                            StateId = 43,
                            StateAbbreviation = "TX",
                            StateName = "Texas"
                        },
                        new
                        {
                            StateId = 44,
                            StateAbbreviation = "UT",
                            StateName = "Utah"
                        },
                        new
                        {
                            StateId = 45,
                            StateAbbreviation = "VT",
                            StateName = "Vermont"
                        },
                        new
                        {
                            StateId = 46,
                            StateAbbreviation = "VA",
                            StateName = "Virginia"
                        },
                        new
                        {
                            StateId = 47,
                            StateAbbreviation = "WA",
                            StateName = "Washington"
                        },
                        new
                        {
                            StateId = 48,
                            StateAbbreviation = "WV",
                            StateName = "West Virginia"
                        },
                        new
                        {
                            StateId = 49,
                            StateAbbreviation = "WI",
                            StateName = "Wisconsin"
                        },
                        new
                        {
                            StateId = 50,
                            StateAbbreviation = "WY",
                            StateName = "Wyoming"
                        },
                        new
                        {
                            StateId = 51,
                            StateAbbreviation = "DC",
                            StateName = "District of Columbia"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "66f27418-9dfe-4e95-b377-76bb61980ba0",
                            ConcurrencyStamp = "53122c72-729b-4231-bca4-4456dcb7ed6b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6fb1ec94-3e3a-442d-9746-323e5944e88b",
                            ConcurrencyStamp = "60bfc185-2f24-4de9-9b94-5cae1143ae2b",
                            Name = "SiteUser",
                            NormalizedName = "SiteUser"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AaronOutdoors.Models.BlogComment", b =>
                {
                    b.HasOne("AaronOutdoors.Models.BlogPost", "BlogPost")
                        .WithMany("BlogCommentList")
                        .HasForeignKey("BlogCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AaronOutdoors.Models.BlogView", b =>
                {
                    b.HasOne("AaronOutdoors.Models.BlogComment", "BlogViewComment")
                        .WithMany()
                        .HasForeignKey("BlogViewCommentBlogCommentId");

                    b.HasOne("AaronOutdoors.Models.BlogPost", "BlogViewPost")
                        .WithMany()
                        .HasForeignKey("BlogViewPostBlogPostId");
                });

            modelBuilder.Entity("AaronOutdoors.Models.SiteUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}