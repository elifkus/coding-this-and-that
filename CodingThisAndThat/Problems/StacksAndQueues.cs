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
        private LinkedList<Animal> animalQueue;
        private LinkedListNode<Animal> catPointer;
        private LinkedListNode<Animal> dogPointer;

        public AnimalShelter()
        {
            this.animalQueue = new LinkedList<Animal>();
        }

        public void enqueue(Animal animal)
        {
            this.animalQueue.AddFirst(animal);
        }

        public Animal dequeueAny()
        {
            Animal animal = this.animalQueue.Last();

            if (animal.Type == AnimalType.Cat)
            {
                this.catPointer  = FindNextAnimalNodeWithAnimalType(this.catPointer, AnimalType.Cat);
            }
            else 
            {
                this.dogPointer = FindNextAnimalNodeWithAnimalType(this.dogPointer, AnimalType.Dog);
            }

            this.animalQueue.RemoveLast();
            return animal;
        }

        private LinkedListNode<Animal> FindNextAnimalNodeWithAnimalType(LinkedListNode<Animal> pointer, AnimalType type)
        {
            pointer = pointer.Previous;

            while (pointer.Previous != null && pointer.Previous.Value.Type != type)
            {
                pointer = pointer.Previous;
            }

            return pointer;
        }

        public Animal dequeueCat()
        {
            Animal animal = this.catPointer.Value;

            this.catPointer = FindNextAnimalNodeWithAnimalType(this.catPointer, AnimalType.Cat);

            return animal;
        }

        public Animal dequeueDog()
        {
            Animal animal = this.dogPointer.Value;

            this.dogPointer = FindNextAnimalNodeWithAnimalType(this.dogPointer, AnimalType.Dog);

            return animal;
        }
        class Animal
        {
            public AnimalType Type { get; set; }
        }
        
        enum AnimalType 
        {
            Cat,
            Dog
        }
    }
}
