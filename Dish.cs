using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{

    class Dish
    {
        public Dish(string name, string description, int price, double weight )
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.weight = weight;   
        }

        public string name {  get; set; }

        public string description {  get; set; }

        public int price {  get; set; }

        public double weight { get; set; }

        //Власні зміні
        public bool IsSpicy = false;
        public bool IsHot = true;


    }
}
