using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    public interface ICustomerManager
    {
        void Add(Customer customer);
        void Delete(Customer customer);
    }
}
