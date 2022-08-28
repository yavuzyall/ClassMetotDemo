using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public List<Musteri>  customers = new List<Musteri> ();
        public void AddCustomer(params Musteri[] customer)
        {
            Console.WriteLine("-------");
            for (int i = 0; i < customer.Length; i++)
            {
                customers.Add(customer[i]);
            }
            Console.WriteLine("Add customer successfully.");
            Console.WriteLine("-------");
        }
        public void ListCustomer()
        {
            foreach (Musteri customer in customers)
            {
                Console.WriteLine("________________ {0} _________________", customer.Id);
                Console.WriteLine("Customer Name: " + customer.CustomerName);
                Console.WriteLine("Custumer Surname: " + customer.CustomerSurname);
                Console.WriteLine("TC No:" + customer.TcNo);
            }   
        }
        public void RemoveCustomer(Musteri customer)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("!Customer deletion completed successfully!");
            customers.Remove(customer);
            Console.WriteLine("Deleted customer name and surname::: " + customer.CustomerName + " " + customer.CustomerSurname + "\nTelefon Numarası: " + customer.PhoneNumber);
        }
    }
}
