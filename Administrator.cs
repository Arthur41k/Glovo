using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
     class Administrator
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Salary { get; set; }

        public List<Courier> Couriers = new List<Courier>();

        internal Administrator(string Name, string Sex, int Salary) 
        { 
            this.Name = Name;
            this.Sex = Sex; 
            this.Salary = Salary;   
        }

       public void Hiring(Courier courier)
        {
            courier.PrintCurierInfo();
            Console.Write("Взяти цього кур'єра на роботу ? Так(1) Ні(2)\n= ");
            int num = int.Parse(Console.ReadLine());
            if(num == 1)
            {
                Couriers.Add(courier);
            }
           
        }
    }

}
