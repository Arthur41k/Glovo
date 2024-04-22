using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{

     class Courier
    {
        public string Name { get; set; }

        int PhoneNumber;
        public string Email { get; set; }
        public int rating { get; set; }

        public string TransportType { get; set; }
        public Courier (string Name, int rating) 
        { 
            this.Name = Name;
            this.rating = rating;
        }

      
        public void AddCourierInfo ()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Ведіть номер телефону кур'єра (9 цифр) +380 ");
            string Number = Console.ReadLine();
            if (Number.Length == 9) 
            {
                if(int.TryParse(Number, out PhoneNumber))
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
            Console.Write("Ведіть електрону пошту кур'єра \n= ");
            Email = Console.ReadLine();
            Console.Write("Який у кур'єра транспорт ? велосипед(1), авто(2), відсутність транспортного засобу(3) \n= ");
            int Numeric = int.Parse(Console.ReadLine());
            switch(Numeric)
            {
                case 1:
                    TransportType = "Bicycle";
                    break;
                case 2:
                    TransportType = "Car";
                    break;
                case 3:
                    TransportType = "Nothing";
                    break;
                default: throw new Exception("Ведено не правильну цифру");
            }
          
            Console.ResetColor();
            Console.WriteLine("Інформацію про кур'єра додано");
        }

      
        public void PrintCurierInfo ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Кур'єр {Name} має рейтинг {rating}");
            if (TransportType != "" && TransportType == "Bicycle")
            {
                Console.WriteLine("Доставляє замовленя на велосипеді");
            }
            else if (TransportType != "" && TransportType == "Car")
            {
                Console.WriteLine("Доставляє замовленя на машині");
            }
            else if (TransportType != "" && TransportType == "Nothing")
            {
                Console.WriteLine("Доставляє замовленя пішки або на громадському транспорті");
            }
            else { throw new Exception("Дані про кур'єра не заповнено"); }

            Console.WriteLine($"Контактні дані: \nНомер теоефону: +380{PhoneNumber} \nEmail:{Email}");
            Console.ResetColor();
        }

     }
}
