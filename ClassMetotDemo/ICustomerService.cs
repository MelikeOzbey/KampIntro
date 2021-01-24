using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public interface ICustomerService
    {
        public void Add(Customer customer);
        public void List();
        public void Update(int Id);
        public void Delete(int Id);
    }
}
