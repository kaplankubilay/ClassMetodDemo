using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
