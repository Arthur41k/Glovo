using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{

     class Client
    {  
        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Adress { get; set; }

        public List<Order> OrdersHistory = new List<Order>();

        // Свої визначення
        public int Balance = 0;
        public bool IsProfession = false;

        
        public Client(string Name, int PhoneNumber, string Adress)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Adress = Adress;
        }

        //Власні класи
        public void ChoiceWork()
        {
            if(!IsProfession)
            {
                Console.WriteLine("Оберіть професію: \n1)Програміст \n2)Будівельник \n3)Лікар");
                int Number = int.Parse(Console.ReadLine());
                switch(Number)
                {
                    case 1:
                        Balance = 30000;
                    break;

                    case 2:
                        Balance = 15000;
                    break;

                    case 3:
                        Balance = 6000;
                    break;
                        default:
                        throw new Exception("Обрано не правильну цифру");
                }
            }
        }

    }
}
