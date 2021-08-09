using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer){
            Console.WriteLine(customer.Firstname+" "+customer.Lastname+" Eklendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Firstname + " " + customer.Lastname + " Silindi.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id+" "+customer.Firstname + " " + customer.Lastname +" "+ customer.City+ " Listelendi.");
        }
    }
}
