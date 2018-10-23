using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 值类型参数传递

            //ValueParam p1 = new ValueParam();
            //int a = 5;


            //p1.Add1(a);  //main输出5
            //p1.Add2(ref a); //main输出10
            //p1.Add3(out a); //main输出10
            //Console.WriteLine("main:" + a);

            #endregion

            #region 引用类型的参数传递
            //ClassParam p2 = new ClassParam();
            //Person p = new Person();
            //p.name = "fashi";


            //p2.Say1(p);
            //p2.Say2(ref p);
            //p2.Say3(out p);

            //Console.WriteLine("main:"+p.name);
            #endregion

            #region Params:省略了开发者定义数组的过程
            //int[] array1 = {1,2,3};
            //Add(array1);
            //int[] array2 = {1,2,3,4,5};
            //Add(array2);

            //Add(1, 2, 3);
            //Add(1, 2, 3, 4, 5);
            //关键字params只能用于修饰最后一个参数,并且参数类型是个数组


            #endregion

            #region 扩展方法:无侵入式的开发
            //string str = "123";
            //Console.WriteLine(str.ToInt32());
            #endregion

            #region 委托
            //如果想定义一个委托,首先需要知道方法的签名
            //DelegateAdd delegateAdd = Add1; //相当于 DelegateAdd delegateAdd = new DelegateAdd(Add1);

            //delegateAdd += Add2;  //为delegate添加一个Add2方法
            //delegateAdd -= Add1;  //为delegate删除一个Add1方法

            //delegateAdd(1, 2);  //就相当于Add(1,2)

            //Action<int, int> add = Add1;  // 两个int都表示形式参数列表里面的类型 
            //add += Add2;
            //add(4, 5);  //输出1，2

            //如果委托有返回值,并且委托对象指向了多个方法,最终只能获得最后一个方法的返回值
            //Func<int,string> add2 = Add3;
            //add2 += Add4;
            //add2(5);  //输出3，4


            //Say(Say1);  //输出say1
            //当一个方法只使用一次的时候，可以直接定义匿名方法
            //1
            //Say(delegate ()
            //{
            //    Console.WriteLine("匿名函数");
            //});

            //2
            //Say2(delegate (int a)
            //{
            //    Console.WriteLine("匿名函数");
            //    return a.ToString();
            //});


            //lambda表达式
            //Say2((int a) =>
            //{
            //    Console.WriteLine("lambda表达式");
            //    return a.ToString();
            //});
            //当函数使用委托作为参数时，调用此函数,可以传递一个lambda表达式

            //Dog d1 = new Dog();
            ////d1.HelloEvent();  //error,不能直接调用，只能+=或者-=
            //d1.HelloEvent += Say1;
            //d1.SayHello();

            //DealString(ToUpper,"aBc");
            //DealString(ToLower, "aBc");
            //DealString(Tostar, "aBc");

            #endregion

            #region 线程
            ////Thread thread1 = new Thread(()=>
            ////{
            ////    Console.WriteLine("1");
            ////});
            //Thread thread1 = new Thread(Write1);
            ////后台线程：如果主线程运行完毕，即使此线程没有结束，也会退出
            ////如果主程序执行完毕，但是前台线程没有结束，则不会退出
            ////一般将手动启动的线程，做成后台线程
            //thread1.IsBackground = true; //是否做为后台线程
            //thread1.Start();
            #endregion

            #region 单例模式
            Animal animal1 = Animal.Create();
            #endregion

            Console.ReadKey();

        }

        static void Write1()
        {
            lock("abc")
            {

            }
            Thread.Sleep(1000); //挂起线程，单位是毫秒
            Console.WriteLine(1);
            Write1(); //尾递归
        }

        static string ToUpper(string str1)  //将字母转成大写
        {
            return str1.ToUpper();
        }

        static string ToLower(string str1)//将字母转成小写
        {
            return str1.ToLower();
        }

        static string Tostar(string str1)
        {
            return str1 + "☆";
        }

        static void DealString(Func<string, string> dealFun, string str)
        {
            Console.WriteLine(dealFun(str));
        }


        //2
        static void Say2(Func<int, string> s1)
        {
            s1(1); //调用函数
        }


        //1
        static void Say(Action s1)
        {
            s1();
        }

        //1
        static void Say1()
        {
            Console.WriteLine("say1");
        }

        static void Add1(int a, int b)
        {
            Console.WriteLine("1");
        }

        static void Add2(int a, int b)
        {
            Console.WriteLine("2");
        }

        static string Add3(int a)
        {
            Console.WriteLine(3);
            return (a+1).ToString();
        }
        static string Add4(int a)
        {
            Console.WriteLine(4);
            return (a+2).ToString();
        }

        //static void Add(int a, int b)
        //{

        //}

        //static void Add(int a, int b, int c)
        //{

        //}
        static void Add(params int[] array)
        {
            Console.WriteLine(array.Length);
        }


    }

    public static class StringExtend
    {
        public static int ToInt32(this string str)
        {
            return int.Parse(str);
        }
    }
}
