using System;
using System.Collections.Generic;

namespace ChainOfResposibilityPattern
{
    class Program
    {
        private List<Handler> _approvers = new List<Handler>();
        static void Main(string[] args)
        {
            //var nullable = new NullHandler();

            //var president = new President();
            //president.SetNext(nullable);

            //var director = new Director();
            //director.SetNext(president);

            //var manager = new Manager();
            //manager.SetNext(director);

            var tl = new TeamLead();
            //tl.SetNext(manager);

            var approved = tl.Approve(60000) ? "Approved" : "Not Approved";

            Console.WriteLine(approved);

            Console.ReadKey();
        }
    }
}
