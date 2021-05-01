using System;
using System.Collections;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Ali",
                Surname = "Veli"
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Ali"
            };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);

            customerManager.Delete(customer2);
        }
    }
}
