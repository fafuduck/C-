using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public delegate void DelegateAdd(int a, int b);


    public class Dog
    { 
    //事件的本质,就是一个委托对象
    //事件的调用执行只能在类的内部完成
    //在类的外部只能进行+=、-=操作
    public event Action HelloEvent; //事件

        public void SayHello()
        {
            HelloEvent();
        }
    }
}
