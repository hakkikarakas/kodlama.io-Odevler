using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Firstname = "Hakkı";
            customer.Lastname = "Karakaş";
            customer.City = "İzmir";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.List(customer);
        }
    }
}
