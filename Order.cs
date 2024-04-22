using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Glovo
{
 
    class Order
    {
        public int OrderNumber { get; set; }

        List<string> Dishes = new List<string>();

        public int Sum { get; set; }

        public string Status = "";

        public string RestaurantIndo { get; set; }
        public string CourierIndo { get; set; }
        public string ClientIndo { get; set; }

        public Order(int OrderNumber,List<string> Dishes,string RestaurantIndo, string CourierIndo, string ClientIndo) 
        { 
            this.OrderNumber = OrderNumber;
            this.Dishes = Dishes;
            this.RestaurantIndo = RestaurantIndo;
            this.ClientIndo = ClientIndo;
            this.CourierIndo = CourierIndo;
        }

       
        public void OrderUpdate()
        {
            if(string.IsNullOrEmpty(Status))
            {
                Status = "Створення замовлення";
               
            }
            else if(Status == "Створення замовлення")
            {
                Status = "Замовлення доставляється";
            }
            else if (Status == "Замовлення доставляється")
            {
                Status = "Замовлення доставлено";
            }

            Console.WriteLine("Поточний статус: " + Status);
        }
    }
}
