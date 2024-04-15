using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glovo
{
    /// <summary>
    /// Клас що описує страву
    /// </summary>
    class Dish
    {
        internal Dish(string name, string description, int price, double weight )
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.weight = weight;   
        }

        string name {  get; set; }

        string description {  get; set; }

        int price {  get; set; }

        double weight { get; set; }
    }
}
