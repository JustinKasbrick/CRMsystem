using System;
using System.Collections.Generic;
using System.Text;

namespace CRMsystem
{
    public class UserFactory
    {
        public static User Create(object[] data)
        {
            Precondition.Requires(data.Length >= 0);

            int id = (int)data[0];
            string email = (string)data[1];
            UserType type = (UserType)data[2];

            return new User(id, email, type);
        }
    }
}
