using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CRMsystem.Tests.Domain
{
    public class UserTests
    {
        [Fact]
        public void Changing_email_from_non_corporate_to_corporate()
        {
            var company = new Company("mycorp.com", 1);
            var sut = new User(1, "user@gmail.com", UserType.Customer);

            sut.ChangeEmail("new@mycorp.com", company);

            Assert.Equal(2, company.NumberOfEmployees);
            Assert.Equal("new@mycorp.com", sut.Email);
            Assert.Equal(UserType.Employee, sut.Type);
        }

        [Fact]
        public void Changing_email_from_corporate_to_non_corporate()
        {
            var company = new Company("mycorp.com", 1);
            var sut = new User(1, "user@mycorp.com", UserType.Customer);

            sut.ChangeEmail("new@gmail.com", company);

            Assert.Equal(2, company.NumberOfEmployees);
            Assert.Equal("new@gmail.com", sut.Email);
            Assert.Equal(UserType.Customer, sut.Type);
        }

        [Fact]
        public void Changing_email_to_the_same_one()
        {
            var company = new Company("mycorp.com", 1);
            var sut = new User(1, "user@mycorp.com", UserType.Customer);

            sut.ChangeEmail("user@mycorp.com", company);

            Assert.Equal(1, company.NumberOfEmployees);
            Assert.Equal("new@gmail.com", sut.Email);
            Assert.Equal(UserType.Employee, sut.Type);
        }
    }
}
