using System;

namespace BuilderPattern
{
    public class ContributionYearPaymentLine
    {
        public int Id { get; private set; }
        public int Wies { get; private set; }
        public DateTime? FromDate { get; private set; }
        public DateTime? ToDate { get; private set; }
        public string Class { get; private set; }

        public void HasContributions(int wies) => Wies = wies;

        public void HasDates(DateTime? fromDate, DateTime? toDate)
        {
            FromDate = fromDate;
            ToDate = toDate;
        }

        public void HasClass(string contributionClass) => Class = contributionClass;
    }
}
