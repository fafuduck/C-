using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Animal
    {
        public string name;

        public Animal()
        {
            name = "a";
           // Console.WriteLine("a0");
        }
        public Animal(string name)
        {
            //Console.WriteLine("a1");
            this.name = name;
        }
        public virtual void say()
        {
            Console.WriteLine("a");
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            //Console.WriteLine("d0");
        }
        public Dog(string name):base(name)
        {
            //Console.WriteLine("d1");
        }
        public void Dogsay()
        {
            Console.WriteLine("d");
        }

        public override void say()
        {
            Console.WriteLine("d");
        }

    }

    public class Cat:Animal
    {
        
    }
}
