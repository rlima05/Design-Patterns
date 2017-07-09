using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Approver
    {
        protected Approver NextApprover;

        public void SetNextApprover(Approver nextApprover)
        {
            NextApprover = nextApprover;
        }

        public abstract void Approve(double amount);
        protected abstract bool CanApprove(double amount);
    }
}
