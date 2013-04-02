using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CH11EX02
{
    class Animals:CollectionBase
    {
        // Clear(), RemoveAt() and Count are already included

        public Animals() {

        }
        // Add
        public void Add(Animal newAnimal) 
        {
            List.Add(newAnimal);
        }

        // Remove
        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }

        // Indexer
        public Animal this[int animalIndex]
        {
            get
            {
                return (Animal)List[animalIndex];
            }
            set
            {
                List[animalIndex] = value;
            }
        }
   
    }
}
