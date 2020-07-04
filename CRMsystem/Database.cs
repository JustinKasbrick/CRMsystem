using System;
using System.Collections.Generic;
using System.Text;

namespace CRMsystem
{
    public static class Database
    {
        public static object[] GetUserById(int userId)
        {
            return new object[] { 1, "justink@iqmetrix.com", 2 };
        }

        public static object[] GetCompany()
        {
            return new object[] { "iqmetrix.com", 2 };
        }

        public static void SaveCompany(int newNumber)
        {

        }
        
        public static void SaveUser(User user)
        {

        }
    }
}
