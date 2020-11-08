using System;

namespace Interface_Segregation_Principle 
{
    class Cat : ICat, IEat, IWalk, ISleep
    {
        public string Name { get; set; }

        public void Meow() 
        {
            Console.WriteLine ("Meeeeeow");
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