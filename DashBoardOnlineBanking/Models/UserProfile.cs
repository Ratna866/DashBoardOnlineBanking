using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DashBoardOnlineBanking.Models
{
    public class UserProfile
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public int MobileNo { get; set; }
        public string EmailId { get; set; }
        public int AadharcardNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string OccupationalType { get; set; }
        public string SourceOfIncome{ get; set; }
        public Decimal GrossAnnualIncome { get; set; }
    }
}