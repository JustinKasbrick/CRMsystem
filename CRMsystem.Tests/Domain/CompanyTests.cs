using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CRMsystem.Tests.Domain
{
    public class CompanyTests
    {
        [InlineData("mycorp.com", "email@mycorp.com", true)]
        [InlineData("mycorp.com", "email@gmail.com", false)]
        [Theory]
        public void Differentiates_a_corporate_email_from_non_corporate(string domain, string email, bool expectedResult)
        {
            //arrange
            var sut = new Company(domain, 0);

            // act
            var isEmailCorporate = sut.IsEmailCorporate(email);

            // assert
            Assert.Equal(expectedResult, isEmailCorporate);
        }
    }
}
