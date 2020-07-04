using System;
using System.Collections.Generic;
using System.Text;

namespace CRMsystem
{
    public class UserController
    {
        private readonly Database _database = new Database();
        private readonly MessageBus _messageBus = new MessageBus();

        public void ChangeEmail(int userId, string newEmail)
        {
            object[] data = _database.GetUserById(userId);
            string email = (string)data[1];
            UserType type = (UserType)data[2];
            var user = new User(userId, email, type);

            object[] companyData = _database.GetCompany();
            string companyDomainName = (string)companyData[0];
            int numberOfEmployees = (int)companyData[1];

            int newNumberOfEmployees = user.ChangeEmail(newEmail, companyDomainName, numberOfEmployees);

            _database.SaveCompany(newNumberOfEmployees);
            _database.SaveUser(user);
            _messageBus.SendEmailChangedMessage(userId, newEmail);
        }
    }
}
