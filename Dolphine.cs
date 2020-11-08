using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation_Principle
{
    class Dog : IEat, ISleep, ISwim
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("Num...Num...Num...");
        }

        public void Sleep(int time)
        {
            Console.WriteLine("Zzzzz...");
        }

        public void Swiming(int Yaxis, int Xaxis, int Zaxis)
        {
            Console.WriteLine("Plop...plop...plop...");
        }
    }
}
