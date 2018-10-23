using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    public class ValueParam         //值类型参数传递
    {
        public void Add1(int a)
        {
            //直接将变量a的值代入函数中
            a = 10;
            Console.WriteLine("Add1:"+a);
        }

        public void Add2(ref int a)
        {
            //既可以将变量a的值代入函数中，有可以改写变量a的值
            a = 10;
            Console.WriteLine("Add2:" + a);
        }

        public void Add3(out int a)
        {
            //只能改写变量a的值
            //Console.WriteLine(a);     //报错，因为不能传入a的值，没办法输出
            a = 10;
            Console.WriteLine("Add1:" + a);
        }
    }
}
