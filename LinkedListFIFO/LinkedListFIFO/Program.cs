using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListFIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            //list.AddLast(4);
            //list.AddLast(5);
            //list.AddLast(6); 

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var mod = list.Count % 2;

            var middleElement = mod == 0 ? list.Count / 2 : list.Count / 2 + 1;
            
            Console.WriteLine(list.Find(middleElement).Value);

            Console.WriteLine();

            Console.WriteLine("Get Customer");
            var rep = new Repository();
            var customer = rep.GetCustomer();
            
            Console.WriteLine("Calling emp");
            Console.WriteLine(customer.Employment.CompanyName);
            Console.WriteLine(customer.Employment.Address);

            Console.WriteLine();

            Console.WriteLine("Get Order");
            var order = rep.GetOrder();

            Console.WriteLine("Call Cust");
            Console.WriteLine(order.Customer.Name);
            Console.WriteLine(order.Customer.Employment.CompanyName);

            Console.ReadKey();
        }
    }
}
