using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 5786;
            customer1.CustomerFirstName = "Yusuf";
            customer1.CustomerLastName = "Adıgüzel";
            customer1.CustomerNationallyId = "00000000000";

            Customer customer2 = new Customer();
            customer2.CustomerId = 5432;
            customer2.CustomerFirstName = "Ali";
            customer2.CustomerLastName = "Karaca";
            customer2.CustomerNationallyId = "11111111111";

            Customer customer3 = new Customer();
            customer3.CustomerId = 9642;
            customer3.CustomerFirstName = "Ayşe";
            customer3.CustomerLastName = "Koç";
            customer3.CustomerNationallyId = "222222222222";

            Customer[] customers = { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Remove(customer2);
            customerManager.List(customers,customer1,customer2,customer3);

            Console.ReadLine();

        }
    }
}
