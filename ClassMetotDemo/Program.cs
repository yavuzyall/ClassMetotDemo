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
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = 30403454766;
            musteri1.CustomerName = "Yavuz";
            musteri1.CustomerSurname = "Yalçın";
            musteri1.PhoneNumber = 5423467596;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = 30998880476;
            musteri2.CustomerName = "Jennifer";
            musteri2.CustomerSurname = "Aldis";
            musteri2.PhoneNumber = 204563548;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcNo = 52224197462;
            musteri3.CustomerName = "Anıl";
            musteri3.CustomerSurname = "Efesus";
            musteri3.PhoneNumber = 5368521467;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddCustomer(musteri1,musteri2,musteri3);
            musteriManager.ListCustomer();
            musteriManager.RemoveCustomer(musteri2);
            Console.WriteLine("Thank You...");

        }
    }
}
