using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
  
    class DeliveryManager
    {
        public Order CreatedOrder { get; set; }

        List<Courier> Couriers = new List<Courier>();

        List<Restaurant> Restaurants = new List<Restaurant>();

        Client client;
        public Courier SelectedCourier { get; set; }

        public Restaurant SelectedRestaurant { get; set; }
        public DeliveryManager(List<Restaurant> restaurants, List<Courier> couriers, Client Client)
        {
            Restaurants = restaurants;
            Couriers = couriers;
            client = Client;
        }
         
       
     public void CurierChoicesing()
        {
            Console.WriteLine("Оберіть кур'єра: ");
            int i = 1;
            foreach(Courier co in Couriers) 
            {
                Console.WriteLine(i+")");
                co.PrintCurierInfo();

                Console.Write("Цей кур'єр вам підходить ? Так(1) Ні(2) \n= ");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1) 
                {
                    SelectedCourier = co;
                    break;
                }
                else if (Choice == 2) { }
                else 
                {
                    throw new Exception("Ведено неправильне значиння");
                }
            }
     }

        public void RestaurantChoicesing()
        {
            Console.WriteLine("Оберіть ресторан: ");
            int i = 1;
            foreach (Restaurant rest in Restaurants)
            {
                Console.WriteLine(i + ")");
                rest.PrintRestourantInfo();

                Console.Write("Цей ресторан вам підходить ? Так(1) Ні(2) \n= ");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    SelectedRestaurant = rest;
                    break;
                }
                else if (Choice != 2 && Choice != 1) 
                {
                    throw new Exception("Ведено неправильне значиння");
                }
            }
        }

        public void CreateOrder()
        {
            Random random = new Random();
            int OrderNumber = random.Next(1, 100);
            string RestaurantIndo = SelectedRestaurant.name;
            string CourierIndo = SelectedCourier.Name;
            string ClientIndo = client.Name;
            List<Dish> SelectedDishes = new List<Dish>();
            int Sums = 0;
            Console.WriteLine("Оберіть те що ви будете замовляти");
            foreach (Dish dish in SelectedRestaurant.Dishes)
            {
                Console.Write($"Додати до замовлення {dish.name} ? \nВага: {dish.weight} грам/мілілітрів \nЦіна: {dish.price} грн \nТак(1) Ні(2)\n= ");
                int Cho = int.Parse(Console.ReadLine());
                if (Cho == 1) 
                {
                    SelectedDishes.Add(dish);
                    Sums += dish.price;
                }
                else if (Cho != 2 &&Cho != 1)
                {
                    throw new Exception("Введино неправильне число");
                }
            }
            if(SelectedDishes.Count > 0) 
            {
                Order order = new Order(OrderNumber,SelectedDishes, RestaurantIndo, CourierIndo, ClientIndo);
                CreatedOrder = order;
                CreatedOrder.Sum = Sums;
                Console.WriteLine("Замовлення зроблено"); 
            }
            else
            {
                Console.WriteLine("Ви не додали жодної страви до замовлення");
            }
            
        }

        public void StatusInfo()
        {   
            Console.WriteLine($"Замовлення Glovo номер {CreatedOrder.OrderNumber}");
            CreatedOrder.OrderUpdate();
        }

        public void ProcessingOrder ()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (CreatedOrder.Status == "Створення замовлення")
            {
                if (SelectedRestaurant.Rating < 3)
                {
                    Thread.Sleep(3000);
                }
                else
                {
                    Thread.Sleep(1500);
                }
            }
            else if (CreatedOrder.Status == "Замовлення доставляється")
            {
                if (SelectedCourier.rating < 5)
                {
                    Thread.Sleep(5000);
                    CreatedOrder.Sum += 100;
                }
                else
                {
                    Thread.Sleep(3000);
                    CreatedOrder.Sum += 150;
                }
            }
            else
            {
                StatusInfo();
                Console.Write($"Доставку на {client.Adress} завершено. \n До сплати {CreatedOrder.Sum} грн\n Оплатити Так(1) Ні(2)\n= ");
                int number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Замовлення буде додано до вашої історії замовлень\nДякую що обрали сервіс Glovo :)");
                    client.OrdersHistory.Add(CreatedOrder);
                }
                else if (number == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ДЕСЯТЬ ГОД ТЮРМИ");
                }
                
            }
            Console.ResetColor();
        }
    }
}
