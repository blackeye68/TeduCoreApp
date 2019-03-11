using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Data.Interfaces;

namespace TeduCoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
    }
}