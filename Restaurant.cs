using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
   
    class Restaurant
    {

        public string name { get; set; }

        public string address { get; set; }

        public string RestaurantType { get; set; }

        public int Rating { get; set; }

        public List<Dish> Dishes = new List<Dish>();

        //Власні зміні

        public bool IsHavePermissions;

        bool IsDebt;

        public Restaurant(string name, int Rating)
        {
            this.name = name;
            this.Rating = Rating;
        }
        public void AddInfo()
        { 
            Console.Write($"Ведіть адресу {name} \n= ");
            address = Console.ReadLine();
            Console.Write($"Оберіть тип ресторану. Кафе(1), Фаст-Фуд(2), Звичайний ресторан(3) \n= ");
            int Numeric = int.Parse(Console.ReadLine());
            switch (Numeric)
            {
                case 1:
                    RestaurantType = "Cafe";
                    Console.Write("Скільки буде видів кави у вашому кафе (не більше 10) ? \n= ");
                    int Number = int.Parse(Console.ReadLine());
                    if (Number > 10)
                    {
                        throw new Exception("Забагато видів кави");
                    }
                    else
                    {
                        for (int i = 0; i < Number; i++)
                        {
                            Console.Write("Ведіть назву кави \n= ");
                            string Coffee = Console.ReadLine();
                            Console.Write("Ведіть опис кави \n= ");
                            string Description = Console.ReadLine();
                            Console.Write("Ведіть ціну кави (у гривнях)\n= ");
                            int Price = int.Parse(Console.ReadLine());
                            Console.Write("Ведіть об'єм кави (у мілілітрах) \n= ");
                            int weight = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Каву додано");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Наступна кава:");
                            Console.ResetColor();
                            Dish dish = new Dish(Coffee, Description, Price, weight);
                            Dishes.Add(dish);
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Меню завершено");
                        Console.ResetColor();
                    }
                    break;
                case 2:
                    RestaurantType = "Fast-Food";
                    Console.Write("Скільки буде страв у вашому Фаст-Фуді (не більше 10) ? \n= ");
                    int Num = int.Parse(Console.ReadLine());
                    if (Num > 10)
                    {
                        throw new Exception("Забагато страв");
                    }
                    else
                    {
                        for (int i = 0; i < Num; i++)
                        {
                            Console.Write("Ведіть назву страви \n= ");
                            string name = Console.ReadLine();
                            Console.Write("Ведіть опис страви \n= ");
                            string Description = Console.ReadLine();
                            Console.Write("Ведіть ціну страви (у гривнях) \n= ");
                            int Price = int.Parse(Console.ReadLine());
                            Console.Write("Ведіть вагу страви (у грамах) \n= ");
                            int weight = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Страву додано");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Наступна страва:");
                            Console.ResetColor();
                            Dish dish = new Dish(name, Description, Price, weight);
                            Dishes.Add(dish);
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Меню завершено");
                        Console.ResetColor();
                    }
            
                    break;
                case 3:
                    RestaurantType = "ClassicRestourant";
                    Console.Write("Скільки буде страв у вашому Ресторані (не більше 10) ? \n= ");
                    int N = int.Parse(Console.ReadLine());
                    if (N > 10)
                    {
                        throw new Exception("Забагато страв");
                    }
                    else
                    {
                        for (int i = 0; i < N; i++)
                        {
                            Console.Write("Ведіть назву страви \n= ");
                            string name = Console.ReadLine();
                            Console.Write("Ведіть опис страви \n= ");
                            string Description = Console.ReadLine();
                            Console.Write("Ведіть ціну страви (у гривнях)\n= ");
                            int Price = int.Parse(Console.ReadLine());
                            Console.Write("Ведіть вагу страви (у грамах)\n= ");
                            int weight = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Страву додано");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Наступна страва:");
                            Console.ResetColor();
                            Dish dish = new Dish(name, Description, Price, weight);
                            Dishes.Add(dish);
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Меню завершено");
                        Console.ResetColor();
                        Console.WriteLine("Інформацію про ресторан додано");
                    }
                    break;
                default:
                    throw new ArgumentException("Обрано не правильний варіант");
                    
            }

        }

        public void PrintRestourantInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ресторан {name} типу {RestaurantType} за дресою {address} має рейтинг {Rating}");
            Console.WriteLine("Меню ресторана:");
            foreach ( var dish in Dishes )
            {
                Console.WriteLine($"Назва: {dish.name}\n ");
            }
            Console.ResetColor();
        }

        public void HavePermissions()
        {
            Random rnd = new Random();
            if ( rnd.Next(1,2)==1 )
            {
                Console.WriteLine( "У вас немає дозвалів");
                IsHavePermissions = false;
            }
            else
            {
                Console.WriteLine("У вас є дозволи");
                IsHavePermissions = true;
            }
        }

        public void DestroyRestaurant()
        {
            if( IsHavePermissions )
            {
                Console.WriteLine("У вас є всі дозволи");
            }
            else if( !IsHavePermissions )
            {
                Console.WriteLine("У вас немає дозвалів");
                Random rnd = new Random();
                if (rnd.Next(1, 2) == 1)
                {
                    IsDebt = true;
                    Console.WriteLine("У вас були гроші аби заплатити хабар");
                }
                else
                {
                    IsDebt = false;
                    Console.WriteLine("У вас не було грошей аби заплатити хабар. Ваш ресторан знесено");
                    name = null;
                    address = null;

                }
            }
        }




    }
}

