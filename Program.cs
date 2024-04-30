using System.Collections.Generic;
using System.Security.Cryptography;

namespace Glovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Restaurant> Restaurants = new List<Restaurant>();
            Console.Write("Створимо  ресторани.\nСкільки додати ресторанів до списку ? (не більше 5, і враховуйте що інформація заповнюється довго)\n= ");
            int N = int.Parse(Console.ReadLine());
            if (N < 5 && N > 0)
            {
                string Name;
                int Rating;
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Напишіть імя ресторану\n= ");
                    Name = Console.ReadLine();
                    Console.Write("Напишіть рейтинг (від 0 до 5) \n= ");
                    int numeric = int.Parse(Console.ReadLine());
                    if (numeric >= 0 && numeric <= 5)
                    {
                        Rating = numeric;
                    }
                    else
                    {
                        throw new Exception("Рейтинг ведено неправильно");
                    }

                    Restaurant restaurant = new Restaurant(Name, Rating);
                    restaurant.AddInfo();
                    Restaurants.Add(restaurant);
                }
            }
            else
            {
                throw new Exception("Некоректне число");
            }

           
            Console.WriteLine("Додайте трьох кур'єрів");
            List<Courier> Couriers = new List<Courier>();
            string name;
            int rating;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Напишіть імя \n= ");
                name = Console.ReadLine();
                Console.Write("Напишіть рейтинг (від 0 до 10) \n= ");
                int numerics = int.Parse(Console.ReadLine());
                if(numerics >= 0 && numerics <= 10)
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

           
            Console.WriteLine("Додамо клієнта");
            string ClientName;
            int PhoneNumber;
            string Adress;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Як звати клієнта ? \n= ");
            ClientName = Console.ReadLine();
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

            Console.ResetColor();

            Client client = new Client(ClientName, PhoneNumber, Adress);

            DeliveryManager Delivery = new DeliveryManager ( Restaurants, Couriers, client);

            Delivery.RestaurantChoicesing();
            Delivery.CurierChoicesing();
            Delivery.CreateOrder();
            Delivery.CreatedOrder.OrderUpdate();
            Delivery.ProcessingOrder();
            Delivery.CreatedOrder.OrderUpdate();
            Delivery.ProcessingOrder();
            Delivery.CreatedOrder.OrderUpdate();
            Delivery.ProcessingOrder();
        }
    }
}
