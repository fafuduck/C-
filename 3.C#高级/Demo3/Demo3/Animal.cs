using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    //单例模式
    public class Animal
    {
        private string name;

        private static Animal animal;

        public static Animal Create()
        {
            if (animal == null)
            {
                animal = new Animal("fashi");
            }
            return animal;
        }

        private Animal()
        {

        }

        private Animal(string name)
        {
            this.name = name;
        }
    }
}
