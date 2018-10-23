using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    /// <summary>
    /// 对于引用类型：无论是值传递还是引用传递，在函数内部对于对象的修改，都是有效的
    /// 参数传递，重点讨论的是：栈中变量的值是何种传递方式
    /// 如果栈中变量是值传递，则内部的修改对于外部无效
    /// 如果栈变量中是引用传递,则内部的改写对于外部有效
    /// </summary>
    public class ClassParam
    {
        public void Say1(Person p)
        {
            Console.WriteLine("say1:1"+p.name);
            p = new Person();
            p.name = "xue";
            Console.WriteLine("say1:2"+p.name);
        }

        public void Say2(ref Person p)
        {
            Console.WriteLine("say2:1" + p.name);
            p = new Person();
            p.name = "xue";
            Console.WriteLine("say2:2" + p.name);
        }

        public void Say3(out Person p)
        {
            p = new Person();
            p.name = "xue";
            Console.WriteLine("say3:"+p.name);
        }
    }


    public class Person
    {
        public string name;
    }

}
