using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListFIFO
{
    public class CustomerLazy
    {
        private Lazy<Employment> _employment = new Lazy<Employment>(() => new Repository().GetEmploymentById(1));

        public string Name { get; set; }

        public Employment Employment
        {
            get
            {                
                return _employment.Value;
            }
        }
    }

    public class Employment
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }

    public class Order
    {
        private Lazy<CustomerLazy> _customer = new Lazy<CustomerLazy>(() => new Repository().GetCustomer());
        public int Id { get; set; }
        public CustomerLazy Customer
        {
            get
            {
                return _customer.Value;
            }
        }
    }

    public class Repository
    {
        public Employment GetEmploymentById(int id)
        {
            Console.WriteLine("Getting Emp");
            return new Employment
            {
                Address = "Address",
                CompanyName = "Company"
            };
        }

        public CustomerLazy GetCustomer()
        {
            Console.WriteLine("Getting Cus");
            return new CustomerLazy
            {
                Name = "Name"
            };
        }

        public Order GetOrder()
        {
            return new Order
            {
                Id = 1
            };
        }
    }
}
