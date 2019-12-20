using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public static class Repository
    {
        private static readonly Dictionary<int, Handler> Handlers = new Dictionary<int, Handler>
        {
            {1, new TeamLead()},
            {2, new Manager()},
            {3, new Director()},
            {4, new President()},
            {5, new NullHandler()}
        };

        public static Handler GetNextApproverById(int id)
        {
            Console.WriteLine($"Returning approver id: {id}");
            return Handlers.FirstOrDefault(c => c.Key == id).Value;
        }
    }
}
