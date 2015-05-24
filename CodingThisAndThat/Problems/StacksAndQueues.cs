using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class StacksAndQueues
    {
        
    }

    public class AnimalShelter 
    {
        private LinkedList<Animal> catQueue;
        private LinkedList<Animal> dogQueue;

        private int sequence;
        public AnimalShelter()
        {
            this.catQueue = new LinkedList<Animal>();
            this.dogQueue = new LinkedList<Animal>();

            this.sequence = 1;
        }

        public void enqueue(Animal animal)
        {
            animal.Order = sequence;
            sequence++;

            if (AnimalType.Dog == animal.Type)
            {
                this.dogQueue.AddFirst(animal);
            }
            else
            {
                this.catQueue.AddFirst(animal);
            }

        }

        public Animal dequeueAny()
        {
            Animal dog = this.dogQueue.Last();
            Animal cat = this.catQueue.Last();

            if (cat.Order < dog.Order)
            {
                this.catQueue.RemoveLast();
                return cat;
            }
            else 
            {
                this.dogQueue.RemoveLast();
                return dog;
            }

        }

        public Animal dequeueCat()
        {
            Animal cat = this.catQueue.Last();
            this.catQueue.RemoveLast();
            return cat;
        }

        public Animal dequeueDog()
        {
            Animal dog = this.dogQueue.Last();
            this.dogQueue.RemoveLast();
            return dog;
        }
        public class Animal
        {
            public AnimalType Type { get; set; }
            public int Order { get; set; }  
        }
        
        public enum AnimalType 
        {
            Cat,
            Dog
        }
    }
}
