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
        
        public Client(string Name, int PhoneNumber, string Adress)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Adress = Adress;
        }

     
            
    }
}
