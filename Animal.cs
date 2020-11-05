using System;

namespace Interface_Segregation_Principle {
    class Animal {
        public void Eat(){
            Console.WriteLine("Nom nom");
        }

        public void Sleep(){
            Console.WriteLine("Zzzzz");
        }
        public void Walk () {
            Console.WriteLine ("Walking..");
        }

    }

}