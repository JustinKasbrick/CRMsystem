using System;
using System.Collections.Generic;
using System.Text;

namespace CRMsystem
{
    public class Database
    {
        public object[] GetUserById(int userId)
        {
            return new object[] { 1, "justink@iqmetrix.com", 2 };
        }

        public object[] GetCompany()
        {
            return new object[] { "iqmetrix.com", 2 };
        }

        public void SaveCompany(int newNumber)
        {

        }
        
        public void SaveUser(User user)
        {

        }
    }
}
