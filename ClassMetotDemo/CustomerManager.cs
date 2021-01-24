using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri başarılı bir şekilde kayıt olmuştur.");
        }

        public void Delete(int Id)
        {
            Console.WriteLine("Müşteri başarılı bir şekilde silinmiştir.");
        }

        public void List()
        {
            Console.WriteLine("Müşteriler Listesi");
        }

        public void Update(int Id)
        {
            Console.WriteLine("Müşteri başarılı bir şekilde güncellenmiştir.");
        }
    }
}
