using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Leaf:IComponent
    {
        public int Quantity { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Leaf(string name,int quantity, int weight)
        {
            this.Quantity = quantity;
            this.Name = name;
            this.Weight = weight;
        }

        public void DisplayQuantityAndWeight()
        {
            Console.WriteLine(Name + " Quantity: " + Quantity + " Weight: " + Weight);
        }
    }
}
