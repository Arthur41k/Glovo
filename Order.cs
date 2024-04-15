using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
    /// <summary>
    /// Клас що описує замовлення
    /// </summary>
    class Order
    {
        List<string> Dishes = new List<string>();

        public int Sum { get; set; }

        public string Status { get; set; } = "";

        public string RestaurantIndo { get; set; }
        public string CourierIndo { get; set; }
        public string ClientIndo { get; set; }

        public Order(List<string> Dishes,string RestaurantIndo, string CourierIndo, string ClientIndo) 
        { 
            this.Dishes = Dishes;
            this.RestaurantIndo = RestaurantIndo;
            this.ClientIndo = ClientIndo;
            this.CourierIndo = CourierIndo;
        }

        /// <summary>
        /// Метод що оновлює статус замовлення при кожному використані
        /// </summary>
        public void OrderUpdate()
        {
            if(Status == "")
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
        }
    }
}
