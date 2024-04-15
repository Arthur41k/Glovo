using System.Security.Cryptography;

namespace Glovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Створення ресторану
            Restaurant restaurant = new Restaurant();
            restaurant.AddInfo();

            //Створення кур'єрів
            Console.WriteLine("Додайте трьох кур'єрів");
            List<Courier> Couriers = new List<Courier>();
            string name;
            int rating;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Напишіть імя \n= ");
                name = Console.ReadLine();
                Console.WriteLine("Напишіть рейтинг (від 0 до 100) \n= ");
                int numerics = int.Parse(Console.ReadLine());
                if(numerics >= 0 && numerics <= 100)
                {
                    rating = numerics;
                }
                else
                {
                    throw new Exception("Рейтинг ведено неправильно");
                }
                Courier Courier1 = new Courier(name, rating);
                Couriers.Add(Courier1);

                Courier1.AddCourierInfo();

                Console.Clear();
            }

            foreach(Courier cor in Couriers)
            {
                cor.PrintCurierInfo();
                Console.WriteLine("\n");
            }

            //Створення клієнта
            Console.WriteLine("Додамо клієнта");
            string Name;
            int PhoneNumber;
            string Adress;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Як звати клієнта ? \n= ");
            Name = Console.ReadLine();
            Console.Write("Ведіть номер телефону клієнта (9 цифр) +380 ");
            string Number = Console.ReadLine();
            if (Number.Length == 9)
            {
                if (int.TryParse(Number, out PhoneNumber))
                {
                    PhoneNumber = int.Parse(Number);
                }
                else
                {
                    throw new Exception("Некоректний номер телефону");
                }

            }
            else
            {
                throw new Exception("Некоректний номер телефону");
            }
            Console.Write("Ведіть адресу клієнта\n= ");
            Adress = Console.ReadLine();

            Client client = new Client(Name, PhoneNumber, Adress);
        }
    }
}
