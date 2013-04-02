using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CH11EX02B
{
    class Animals:DictionaryBase
    {
        // Clear(), RemoveAt() and Count are already included

        public Animals() {

        }
        // Add
        public void Add(string newID, Animal newAnimal) 
        {
            Dictionary.Add(newID, newAnimal);
        }

        // Remove
        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }

        // Indexer
        public Animal this[int animalID]
        {
            get
            {
                return (Animal)Dictionary[animalID];
            }
            set
            {
                Dictionary[animalID] = value;
            }
        }

        // Iterator
        public new IEnumerator GetEnumerator()
        {
            foreach (object animal in Dictionary.Values)
            {
                yield return (Animal)animal;
            }
        }
   
    }
}
