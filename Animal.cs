using System;
using System.Collections.Generic;

namespace MyFirstProject
{
 
    public class Animal
    {

        public string Name { get; set; }

         public Animal(string name)
        {
            this.Name = name;
            Console.WriteLine("\nCreated a {0}", name);
        }
        
    }
}