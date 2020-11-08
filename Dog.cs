using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation_Principle 
{
    class Dog : IDog, IEat, IWalk, ISleep
    {
        public string Name { get; set; }

        public void Bark() 
        {
            Console.WriteLine ("Woof!");
        }
      
        public void Eat()
        {
            Console.WriteLine("Num...Num...Num...");
        }

        public void Sleep(int time)
        {
            Console.WriteLine("Zzzzz...");
        }

        public void Walk(int Yaxis, int Xaxis)
        {
            Console.WriteLine("Stamp...stamp...stamp...");
        }
    }
}