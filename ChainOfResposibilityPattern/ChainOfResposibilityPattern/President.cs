using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class President : Handler
    {
        public President()
        {
            LimitAmount = 50000;
        }
        public override bool Approve(decimal amount)
        {
            Console.WriteLine("President");
            return amount > LimitAmount ? Next.Approve(amount) : true;
        }

        protected override Handler LoadNextApprover()
        {
            return Repository.GetNextApproverById(5);
        }
    }
}
