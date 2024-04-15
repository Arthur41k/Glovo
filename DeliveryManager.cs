using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
    /// <summary>
    /// Клас створений для реалізації логіки доставлення замовлення
    /// </summary>
    class DeliveryManager
    {
        public string Status { get; set; }

        List<Courier> Couriers = new List<Courier>();

        public Courier SelectedCourier { get; set; }

        public DeliveryManager(string status, List<Courier> couriers)
        {
            Status = status;
            Couriers = couriers;
        }
         
        /// <summary>
        /// Метод для вибору кур'єра
        /// </summary>
        /// <param name="Couriers"></param>
     public void CurierChoicesing(List<Courier> Couriers)
        {
            Console.WriteLine("Оберіть кур'єра (всього їх 3)");
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
                }
                else if (Choice == 2) { }
                else 
                {
                    throw new Exception("Ведено неправильне значиння");
                }
            }
            
            
        }
    }
}
