using System;

namespace ChainOfResposibilityPattern
{
    public abstract class Handler
    {
        protected Lazy<Handler> _handler;

        public Handler()
        {
            _handler = new Lazy<Handler>(LoadNextApprover);
        }

        protected Handler Next => _handler.Value;
        protected decimal LimitAmount;
        protected int Id = 0;

        protected abstract Handler LoadNextApprover();

        public abstract bool Approve(decimal amount);
    }
}
