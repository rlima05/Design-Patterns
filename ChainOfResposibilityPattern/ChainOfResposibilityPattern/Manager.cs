using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class Manager : Handler
    {
        public Manager()
        {
            LimitAmount = 5000;
        }

        public override bool Approve(decimal amount)
        {
            Console.WriteLine("Manager");
            return amount > LimitAmount ? Next.Approve(amount) : true;
        }

        protected override Handler LoadNextApprover()
        {
            return Repository.GetNextApproverById(3);
        }
    }
}
