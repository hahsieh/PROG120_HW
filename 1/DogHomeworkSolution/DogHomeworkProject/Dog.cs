using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHomeworkProject
{
    class Dog
    {
        public double Weight { get; set; }
        public string Color { get; set; }
        public void Wag(int howManyWags)
        {
            for (int i = 0; i < howManyWags; i++)
            {
                Console.Write("wag ");
            }
            Console.WriteLine();
        }
        public void Bark(int howManyBarks)
        {
            for (int i = 0; i < howManyBarks; i++)
            {
                Console.Write("woof ");
            }
            Console.WriteLine();
        }

    }
}
