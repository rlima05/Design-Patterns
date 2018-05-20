using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CompanySingleton
    {
        private static readonly CompanySingleton _instance = new CompanySingleton();
        private List<Company> Companies;

        public static CompanySingleton Instance { get; } = _instance;

        private CompanySingleton()
        {
            Companies = new List<Company>();
        }

        public void AddCompany(Company company)
        {
            Companies.Add(company);            
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return Companies;
        }

        public void RemoveCompany(int id)
        {
            Companies.Remove(Companies.First(c => c.Id == id));
        }

        public void Display()
        {
            foreach (var company in Companies)
            {
                company.Display();
            }
        }
    }
}
