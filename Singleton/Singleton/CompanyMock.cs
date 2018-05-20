using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class CompanyMock
    {
        public static void CreateCompanies()
        {
            var companyOne = new Company
            {
                Id = 1,
                Name = "Company Name One",
                NumberOfEmployees = 2
            };

            CompanySingleton.Instance.AddCompany(companyOne);

            var companyTwo = new Company
            {
                Id = 2,
                Name = "Company Name Two",
                NumberOfEmployees = 200
            };

            CompanySingleton.Instance.AddCompany(companyTwo);
        }

        public static void ChangeDatabase()
        {
            CompanySingleton.Instance.RemoveCompany(1);

            var companyThree = new Company
            {
                Id = 3,
                Name = "Company Name Three",
                NumberOfEmployees = 1
            };

            CompanySingleton.Instance.AddCompany(companyThree);
        }
    }
}
