using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class Director : Handler
    {
        public Director()
        {
            LimitAmount = 10000;
        }
        public override bool Approve(decimal amount)
        {
            Console.WriteLine("Director");
            return amount > LimitAmount ? Next.Approve(amount) : true;
        }

        protected override Handler LoadNextApprover()
        {
            return Repository.GetNextApproverById(4);
        }
    }
}
