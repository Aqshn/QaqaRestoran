using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranFinalyProject.Models
{
    public class Food
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public int Count { get; set; }


        public Food(string? name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public Food()
        {

        }

        public override string ToString()
        {
            if (Count != 0)
            {
                return $@"{Name}     {Price}    {Count}";
            }
            return "";
        }

    }
}
