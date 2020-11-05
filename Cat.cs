using System;

namespace Interface_Segregation_Principle
{
    class Cat : ICat
    {
        public string Name{get; set;}

        public void Meow(){
            Console.WriteLine("Meeeeeow");
        }

    }

}
