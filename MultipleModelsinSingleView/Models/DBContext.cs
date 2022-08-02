using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelsinSingleView.Models
{
    public static class DBContext
    {

        public static List<Member> GetMembers()
        {
            List<Member> Members = new List<Member>();
            Members.Add(new Member { MemberId = 1, Code = "L0001", Name = "Amit Gupta", EnrollmentNo = "201404150001" });
            Members.Add(new Member { MemberId = 2, Code = "L0002", Name = "Chetan Gujjar", EnrollmentNo = "201404150002" });
            Members.Add(new Member { MemberId = 3, Code = "L0003", Name = "Bhavin Patel", EnrollmentNo = "201404150003" });
            return Members;
        }

        public static List<Scheme> GetSchemes()
        {
            List<Scheme> Schemes = new List<Scheme>();
            Schemes.Add(new Scheme { SchemeId = 1, Code = "GP", Name = "Group Pension Fund" });
            Schemes.Add(new Scheme { SchemeId = 2, Code = "JP", Name = "Join Pension Fund" });
            Schemes.Add(new Scheme { SchemeId = 3, Code = "IP", Name = "Individual Provident Fund" });
            return Schemes;
        }
    }
}