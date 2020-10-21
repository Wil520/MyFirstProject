using System;
using System.Collections.Generic;

namespace MyFirstProject
{

    public class AnimalShelter
    {


        public string Name { get; set; }


        private List<Animal> animals = new List<Animal>();


        public AnimalShelter(string name)
        {

            Name = name;

        }



        public void Adopt(Animal animal)
        {

            animals.Add(animal);
        }


        public void PrintAnimals()
        {
            Console.WriteLine($"Animals: {String.Join(",", animals)}");

        }
    }
}