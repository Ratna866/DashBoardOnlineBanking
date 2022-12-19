using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DashBoardOnlineBanking.Models
{
    public class DashboardContext:DbContext
    {
        public DbSet<AccountStatement> Accountstatements { get; set; }
        public DbSet<AccountSummary> AccountSummarys { get; set; }
        public DbSet<ChangePassword> ChangePasswords { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

    }
}