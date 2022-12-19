using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashBoardOnlineBanking.Models
{
    public class AccountStatement
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public Decimal Balance { get; set; }
        public DateTime Betweendates { get; set; }
    }
}