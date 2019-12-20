using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository();
            var contributionYearPaymentLine = repository.BuildContributionYearPaymentLine();

            contributionYearPaymentLine.HasClass("A0");
            contributionYearPaymentLine.HasContributions(50);
            contributionYearPaymentLine.HasDates(DateTime.Now, null);

            Console.WriteLine($"Contribution WIES: {contributionYearPaymentLine.Wies}, Contribution Class: {contributionYearPaymentLine.Class}," +
                              $"Contribution Start Date: {contributionYearPaymentLine.FromDate}");

            Console.ReadKey();
        }
    }
}
