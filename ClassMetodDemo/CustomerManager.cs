using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    public class CustomerManager:ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + "  Musterisi Eklendi..");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.Surname+"  Müsterisi Silindi..");
        }
    }
}
