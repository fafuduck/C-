using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Calc : Person<string>
    {
        public TType Minus<TType>(TType a)
            where TType : class //只支持class表示引用类型，如果写struct就表示值类型
        {
            return a;
        }
    }

    public class Person<TKey>
    {
        private TKey a;
        private TKey b;

        public TKey Add<TValue>(TKey a, TKey b, TValue c)
        {
            return a;
        }
    }

    public interface IRunable<TPlane>
    {

    }

    public class Animal
    {

    }

    public class Dog : Animal
    {

    }   

    public class Test<T>
        where T:Animal,new()
    {

    }
}
