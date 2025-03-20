using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task6
    {
        public void Run()
        {
            Address myAddress = new Address();

            
            myAddress.Index = "38900";
            myAddress.Country = "Україна";
            myAddress.City = "Кременчук";
            myAddress.Street = "Київська";
            myAddress.House = "233";
            myAddress.Apartment = "23244";

            
            Console.WriteLine("Адреса:");
            Console.WriteLine($"Індекс: {myAddress.Index}");
            Console.WriteLine($"Країна: {myAddress.Country}");
            Console.WriteLine($"Місто: {myAddress.City}");
            Console.WriteLine($"Вулиця: {myAddress.Street}");
            Console.WriteLine($"Будинок: {myAddress.House}");
            Console.WriteLine($"Квартира: {myAddress.Apartment}");
        }

        class Address
        {
            
            private string index;
            private string country;
            private string city;
            private string street;
            private string house;
            private string apartment;

            
            public string Index
            {
                get { return index; }
                set { index = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string Street
            {
                get { return street; }
                set { street = value; }
            }

            public string House
            {
                get { return house; }
                set { house = value; }
            }

            public string Apartment
            {
                get { return apartment; }
                set { apartment = value; }
            }
        }


    }
}
