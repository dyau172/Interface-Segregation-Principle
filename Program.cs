using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation_Principle 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            Dog spot = new Dog ();
            spot.Bark ();

            Cat garfield = new Cat();
            garfield.Meow();
        }
    }
}