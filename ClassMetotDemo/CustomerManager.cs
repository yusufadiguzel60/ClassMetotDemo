using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
   

        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is added : " + customer.CustomerFirstName);
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer is removed : " + customer.CustomerFirstName);
        }
        public void List( Customer[] customers, Customer customer1, Customer customer2, Customer customer3)
        {
            for (int i = customers.Length - 1; i < customers.Length; i++)
            {
                Console.WriteLine("Müşteri Id : " + customer1.CustomerId + " Müşteri Ad : " + customer1.CustomerFirstName + " Müşteri Soyad : " + customer1.CustomerLastName + " Müşteri Kimlik Numarası : " + customer1.CustomerNationallyId);
                Console.WriteLine("Müşteri Id : " + customer2.CustomerId + " Müşteri Ad : " + customer2.CustomerFirstName + " Müşteri Soyad : " + customer2.CustomerLastName + " Müşteri Kimlik Numarası : " + customer2.CustomerNationallyId);
                Console.WriteLine("Müşteri Id : " + customer3.CustomerId + " Müşteri Ad : " + customer3.CustomerFirstName + " Müşteri Soyad : " + customer3.CustomerLastName + " Müşteri Kimlik Numarası : " + customer3.CustomerNationallyId);

            }
        }
    }
}
