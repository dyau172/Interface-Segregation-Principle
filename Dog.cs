using System;

namespace Interface_Segregation_Principle {
    class Dog : IDog {
        public string Name { get; set; }

        public void Bark () {
            Console.WriteLine ("Woof!");
        }

    }

}