using System;
using static System.Console;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Creating Companies");
            WriteLine();
            CompanyMock.CreateCompanies();


            WriteLine("Displaying all companies");
            WriteLine();
            CompanySingleton.Instance.Display();

            
            WriteLine("Deleting a company and adding a new one");
            WriteLine();
            CompanyMock.ChangeDatabase();

            CompanySingleton.Instance.Display();

            
            WriteLine("Two different classes can access the same instance and share the same data.");

            ReadKey();
        }
    }
}
