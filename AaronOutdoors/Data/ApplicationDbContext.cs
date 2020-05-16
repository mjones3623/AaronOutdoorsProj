using System;
using System.Collections.Generic;
using System.Text;
using AaronOutdoors.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AaronOutdoors.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole()
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "SiteUser",
                    NormalizedName = "SiteUser"
                }
                );
            builder.Entity<State>()
                .HasData(
                    new State { StateId = 1, StateName = "Alabama", StateAbbreviation = "AL" },
                    new State { StateId = 2, StateName = "Alaska", StateAbbreviation = "AK" },
                    new State { StateId = 3, StateName = "Arizona", StateAbbreviation = "AZ" },
                    new State { StateId = 4, StateName = "Arkansas", StateAbbreviation = "AR" },
                    new State { StateId = 5, StateName = "California", StateAbbreviation = "CA" },
                    new State { StateId = 6, StateName = "Colorado", StateAbbreviation = "CO" },
                    new State { StateId = 7, StateName = "Connecticut", StateAbbreviation = "CT" },
                    new State { StateId = 8, StateName = "Delaware", StateAbbreviation = "DE" },
                    new State { StateId = 9, StateName = "Florida", StateAbbreviation = "FL" },
                    new State { StateId = 10, StateName = "Georgia", StateAbbreviation = "GA" },
                    new State { StateId = 11, StateName = "Hawaii", StateAbbreviation = "HI" },
                    new State { StateId = 12, StateName = "Idaho", StateAbbreviation = "ID" },
                    new State { StateId = 13, StateName = "Illinois", StateAbbreviation = "IL" },
                    new State { StateId = 14, StateName = "Indiana", StateAbbreviation = "IN" },
                    new State { StateId = 15, StateName = "Iowa", StateAbbreviation = "IA" },
                    new State { StateId = 16, StateName = "Kansas", StateAbbreviation = "KS" },
                    new State { StateId = 17, StateName = "Kentucky", StateAbbreviation = "KY" },
                    new State { StateId = 18, StateName = "Louisiana", StateAbbreviation = "LA" },
                    new State { StateId = 19, StateName = "Maine", StateAbbreviation = "ME" },
                    new State { StateId = 20, StateName = "Maryland", StateAbbreviation = "MD" },
                    new State { StateId = 21, StateName = "Massachusetts", StateAbbreviation = "MA" },
                    new State { StateId = 22, StateName = "Michigan", StateAbbreviation = "MI" },
                    new State { StateId = 23, StateName = "Minnesota", StateAbbreviation = "MN" },
                    new State { StateId = 24, StateName = "Mississippi", StateAbbreviation = "MS" },
                    new State { StateId = 25, StateName = "Missouri", StateAbbreviation = "MO" },
                    new State { StateId = 26, StateName = "Montana", StateAbbreviation = "MT" },
                    new State { StateId = 27, StateName = "Nebraska", StateAbbreviation = "NE" },
                    new State { StateId = 28, StateName = "Nevada", StateAbbreviation = "NV" },
                    new State { StateId = 29, StateName = "New Hampshire", StateAbbreviation = "NH" },
                    new State { StateId = 30, StateName = "New Jersey", StateAbbreviation = "NJ" },
                    new State { StateId = 31, StateName = "New Mexico", StateAbbreviation = "NM" },
                    new State { StateId = 32, StateName = "New York", StateAbbreviation = "NY" },
                    new State { StateId = 33, StateName = "North Carolina", StateAbbreviation = "NC" },
                    new State { StateId = 34, StateName = "North Dakota", StateAbbreviation = "ND" },
                    new State { StateId = 35, StateName = "Ohio", StateAbbreviation = "OH" },
                    new State { StateId = 36, StateName = "Oklahoma", StateAbbreviation = "OK" },
                    new State { StateId = 37, StateName = "Oregon", StateAbbreviation = "OR" },
                    new State { StateId = 38, StateName = "Pennsylvania", StateAbbreviation = "PA" },
                    new State { StateId = 39, StateName = "Rhode Island", StateAbbreviation = "RI" },
                    new State { StateId = 40, StateName = "South Carolina", StateAbbreviation = "SC" },
                    new State { StateId = 41, StateName = "South Dakota", StateAbbreviation = "SD" },
                    new State { StateId = 42, StateName = "Tennessee", StateAbbreviation = "TN" },
                    new State { StateId = 43, StateName = "Texas", StateAbbreviation = "TX" },
                    new State { StateId = 44, StateName = "Utah", StateAbbreviation = "UT" },
                    new State { StateId = 45, StateName = "Vermont", StateAbbreviation = "VT" },
                    new State { StateId = 46, StateName = "Virginia", StateAbbreviation = "VA" },
                    new State { StateId = 47, StateName = "Washington", StateAbbreviation = "WA" },
                    new State { StateId = 48, StateName = "West Virginia", StateAbbreviation = "WV" },
                    new State { StateId = 49, StateName = "Wisconsin", StateAbbreviation = "WI" },
                    new State { StateId = 50, StateName = "Wyoming", StateAbbreviation = "WY" },
                    new State { StateId = 51, StateName = "District of Columbia", StateAbbreviation = "DC" }
                );
        }
        public DbSet<State> States { get; set; }
        public DbSet<SiteUser> SiteUsers { get; set; }
    }
    
}
