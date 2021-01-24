using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Melike",
                LastName = "Özbey",
                IdentityNumber = "11111111111"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer.Id);
            customerManager.Delete(customer.Id);
            customerManager.List();

            
        }
    }
}
