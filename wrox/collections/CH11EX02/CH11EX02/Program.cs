using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CH11EX02
{
    /* Custom Collection */
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();

            animalCollection.Add(new Cow("Jack"));
            animalCollection.Add(new Chicken("Vera"));

            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();

                if (myAnimal is Cow)
                {
                   ((Cow)myAnimal).Milk();
                }
                else if (myAnimal is Chicken)
                {
                    ((Chicken)myAnimal).LayEgg();
                }
            }

            Console.ReadKey();
        }
    }
}
