using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AaronOutdoors.Models
{
    public class SiteUser
    {
        public int SiteUserId { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [Display(Name = "First Name")]
        public string SiteUserFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string SiteUserLastName { get; set; }

        [Display(Name = "Street Address")]
        public string SiteUserStreetAddress { get; set; }
        [Display(Name = "City")]
        public string SiteUserCity { get; set; }
        [Display(Name = "State")]
        public string SiteUserState { get; set; }
        [Display(Name = "Zip Code")]
        public string SiteUserZipCode { get; set; }
        [Display(Name = "Phone Number")]
        public string SiteUserPhone { get; set; }
    }
}
