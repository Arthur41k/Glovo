using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
    /// <summary>
    /// Клас що описує клієнта
    /// </summary>
     class Client
    {  
        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Adress { get; set; }

        List<Order> OrdersHistory = new List<Order>();
        
        public Client(string Name, int PhoneNumber, string Adress)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Adress = Adress;
        }

     
            
    }
}
