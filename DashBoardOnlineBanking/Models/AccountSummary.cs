using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashBoardOnlineBanking.Models
{
    public class AccountSummary
    {
        public int UserId { get; set; }
        public int AccountNumber { get; set; }
        public DateTime RecentTranasction { get; set; }
    }
}