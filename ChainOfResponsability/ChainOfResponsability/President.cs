using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class President : Approver
    {
        public override void Approve(double amount)
        {
            if (CanApprove(amount)) Console.WriteLine($"Approved by {GetType().Name}");
            else Console.WriteLine("Denied.");
        }

        protected override bool CanApprove(double amount)
        {
            return amount <= 100000;
        }
    }
}
