using System;

namespace Classes_01
{
    class Program
    {
        class Address
        {
            private int index = 0, house = 0, apartment = 0;
            private string country = null, city = null, street = null;

            public int Index
            {
                set
                {
                    index = value;
                }
                get
                {
                    return index;
                }
            }
            public int House
            {
                set
                {
                    house = value;
                }
                get
                {
                    return house;
                }
            }
            public int Apartment
            {
                set
                {
                    apartment = value;
                }
                get
                {
                    return apartment;
                }
            }
            public string Country
            {
                set
                {
                    country = value;
                }
                get
                {
                    return country;
                }
            }
            public string City
            {
                set
                {
                    city = value;
                }
                get
                {
                    return city;
                }
            }
            public string Street
            {
                set
                {
                    street = value;
                }
                get
                {
                    return street;
                }
            }
        }


        static void Main(string[] args)
        {
            Address myAddress = new Address();
            Console.Write("Введите страну вашего проживания: ");
            myAddress.Country = Console.ReadLine();
            Console.Write("Введите ваш город проживания: ");
            myAddress.City = Console.ReadLine();
            Console.Write("Введите индекс вашего города: ");
            myAddress.Index = int.Parse(Console.ReadLine());
            Console.Write("Введите название улицы: ");
            myAddress.Street = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            myAddress.House = int.Parse(Console.ReadLine());
            Console.Write("Введите номер квартиры: ");
            myAddress.Apartment = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВаш адрес проживания:");
            Console.WriteLine("Страна: " + myAddress.Country);
            Console.WriteLine("Город: " + myAddress.City);
            Console.WriteLine("Индекс: " + myAddress.Index);
            Console.WriteLine("Улица: " + myAddress.Street);
            Console.WriteLine("Номер дома: " + myAddress.House);
            Console.WriteLine("Квартира: " + myAddress.Apartment);
        }
    }
}
