using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public abstract class Person
    {

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        //抽象方法必须在抽象类中
        public abstract void Xiaban();

        //抽象类中可以带有方法体的方法
        //抽象类不能被实例化
        //在抽象类中定义构造方法的意义：让子类调用

    }

    public class Employee : Person,ISportable
    {
        public Employee(string name):base(name)
        {

        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public override void Xiaban()
        {
            Console.WriteLine("打卡走人");
        }
    }
}
