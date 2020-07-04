using System;
using System.Collections.Generic;
using System.Text;

namespace CRMsystem
{
    public class CompanyFactory
    {

        public static Company Create(object[] companyData)
        {
            Precondition.Requires(companyData.Length >= 2);

            string companyDomainName = (string)companyData[0];
            int numberOfEmployees = (int)companyData[1];

            return new Company(companyDomainName, numberOfEmployees);
        }
    }
}
