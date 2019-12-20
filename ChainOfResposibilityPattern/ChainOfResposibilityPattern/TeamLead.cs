using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class TeamLead : Handler
    {         
        public TeamLead()
        {
            LimitAmount = 1000;
        }        

        public override bool Approve(decimal amount)
        {            
            Console.WriteLine("Team Lead");
            return amount > LimitAmount ? Next.Approve(amount) : true;
        }

        protected override Handler LoadNextApprover()
        {
            return Repository.GetNextApproverById(2);
        }
    }
}
