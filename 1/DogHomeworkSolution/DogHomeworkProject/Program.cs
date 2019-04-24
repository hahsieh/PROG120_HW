using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHomeworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new dog object called dog1
            Dog dog1 = new Dog();

            // instantiate a new dog object called dog2
            Dog dog2 = new Dog();

            Console.WriteLine();

            // call the Wag method on object dog1, passing in a 4
            dog1.Wag(4);

            // call the Bark method on object dog2, passing in a 3
            dog2.Bark(3);

            Console.ReadLine();
        }
    }
}
