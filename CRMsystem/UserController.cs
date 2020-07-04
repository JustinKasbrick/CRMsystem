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
            object[] userData = _database.GetUserById(userId);
            var user = UserFactory.Create(userData);

            object[] companyData = _database.GetCompany();
            var company = CompanyFactory.Create(companyData);

            user.ChangeEmail(newEmail, company);

            _database.SaveCompany(company);
            _database.SaveUser(user);
            _messageBus.SendEmailChangedMessage(userId, newEmail);
        }
    }
}
