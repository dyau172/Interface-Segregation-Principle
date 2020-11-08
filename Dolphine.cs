using System;

namespace Interface_Segregation_Principle
{
    class Dog : IDog
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
