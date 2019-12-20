using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class NullHandler : Handler
    {
        public NullHandler()
        {
        }
        public override bool Approve(decimal amount)
        {
            Console.WriteLine("Nullable");
            return false;
        }

        protected override Handler LoadNextApprover()
        {
            return null;
        }
    }
}
