using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 三位水仙花数
            /*
            for (int i = 100; i < 1000; i++)
            {
                string temp = i.ToString(); //一个字符串可以当做一个字符数组来看待
                int bai = Convert.ToInt32(temp[0].ToString());
                int shi = Convert.ToInt32(temp[1].ToString());
                int ge = Convert.ToInt32(temp[2].ToString());
                int sum = bai * bai * bai + (int)Math.Pow(shi, 3) + (int)Math.Pow(ge, 3);

                if (sum == i)
                {
                    Console.WriteLine(sum);
                }
            
            }
            */
            #endregion

            #region  数组
            /*
        //定义一个包含50个整数的数组，随机为元素赋值，并按一行n个输出，n可以由用户指定
        // -类Random随机数，方法Next()计算并返回随机数
        int[] array = new int[50];
        Random r = new Random();
        for (int i = 0; i<50; i++)
			{
                array[i] = r.Next(10,100);
			}
            Console.WriteLine("请输入一个数字");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 0; i < 50; i++)
            {
                temp++;
                Console.Write(array[i]+",");
                if (temp == num)
                {
                    Console.WriteLine("");
                    temp = 0;
                }
            }
            */
            #endregion

            #region 求数组的最大值
            /*
            int[] array = {1,3,5,7,90,2,4,6,8,10};
            int max = array[0];
            for (int i = 0; i <array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            */
            #endregion

            #region 九九乘法表
            /*
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j < i)
                    {
                        Console.Write(i + "X" + j + "=" + (i * j) + ",");
                    }
                    if(j==i)
                    {
                        Console.WriteLine(i + "X" + j + "=" + (i * j));
                    }
                }
            }
            */
            #endregion

            #region 咳嗽
            /*
            //有如下字符串【"患者：“大夫，我咳嗽得很重。”大夫：“你多大年纪？”患者：“七十五岁。”大夫：“二十岁咳嗽吗？”患者：“不咳嗽。”大夫：“四十岁时咳嗽吗？”患者：“也不咳嗽。”大夫：“那现在不咳嗽还要等到什么时候咳嗽？”"】
            //需求：请统计出该字符中“咳嗽”二字出现的次数，以及每次“咳嗽”出现的索引位置。
            string str1 = "患者：“大夫，我咳嗽得很重。”大夫：“你多大年纪？”患者：“七十五岁。”大夫：“二十岁咳嗽吗？”患者：“不咳嗽。”大夫：“四十岁时咳嗽吗？”患者：“也不咳嗽。”大夫：“那现在不咳嗽还要等到什么时候咳嗽？”";
            int index = str1.IndexOf("咳嗽", 0);
            int counter = 0; //计数
            while (index != -1)
            { 
                Console.WriteLine(index);
                counter++;
                index = str1.IndexOf("咳嗽",index+1);
            }

            Console.WriteLine("一共出现"+counter+"次");
            */
            #endregion


            #region 去空格
            /*
            //将字符串"hello  world,你 好 世界 !"两端空格去掉，并且将其中的所有其他空格都替换成一个*
            //输出结果为："hello*world,*你*好世界*!"
            string str1 = "hello     world,你 好 世界 !";
            str1 = str1.Trim(); // 一定要记得赋值，因为字符串的不可变性
            while (str1.IndexOf("  ") != -1)
            {
                str1 = str1.Replace("  ", " ");
            }
            str1 = str1.Replace(" ","*");
            Console.WriteLine(str1);
            */

            #endregion

            #region 时间
            /*
            DateTime t1 = new DateTime(2015,11,23,12,12,30);
            DateTime t2 = DateTime.Now;
            TimeSpan span1 = t2 - t1;
            Console.WriteLine(span1.Days);
            */
            #endregion

            #region 面向对象
            //Vector3 v3 = new Vector3(0,0,0);
            //Dog d = new Dog;
            //d.name = "a"; 

            #endregion

            #region 多态

            /*
            Animal a1 = new Animal();
            //Dog d1 = new Dog();
            //Cat c1 = new Cat();
            Animal d1 = new Dog(); //也是成立的
            Animal c1 = new Cat(); //也是成立的

            //bool a1IsAnimal = ai is Animal; //判断a1是否为Animal类型的对象
            //Animal a2 = a1 as Animal; //将a1转换成Animal类型的对象，如果转换失败，则返回null

            //if (a1 is Animal)    //ok
            // if(d1 is Animal)   //ok


            // if(a1 is Dog)         //no
            // {
            //     Console.WriteLine("ok");
            // }
            // else
            // {
            //     Console.WriteLine("no");
            // }

            Dog d2 = d1 as Dog;  //将d1转换成dog类型

            if (d2 != null)
            {
                Console.WriteLine("ok");

                //d1.say
                //d2.say; d2.Dogsay;
                //由上面两行可知， 当声明d1为Animal类型的时候，d1只能访问到Animal里面的方法，也就是只能访问到say，但是将d1转换成Dog类型后的d2，既可以访问Animal中的say，也可以访问Dog中的Dogsay
                //声明变量的类型，决定了变量访问成员的范围   在不用virtual和override的时候
                //d1.say();     // 输出 a
                //d2.say();     // 输出 d
            }
            */


            #endregion

            // Console.WriteLine(Vector3.right);
            //Person p1 = new Employee("");

            #region 接口的多态
            /*
            ISportable s1 = new Employee("");
            ISwimable s2 = new Employee("");
            s2.Swim();
            */
            #endregion

            #region 枚举
            //1.注册 2.登陆 3.选角色 4.选英雄 5.聊天
            //1-Spring 2-Summer 3-Automn 4-Winter
            //Console.WriteLine(Jijie.Dong);
            // Console.WriteLine((int)Jijie.Dong);

            //取到红、蓝两个层
            // Layer layer1 = Layer.blue | Layer.red;

            //判断是否有红色层
            //if ((layer1&Layer.red)>0)
            //{
            //    Console.WriteLine("有红色");
            //}
            //else
            //{
            //    Console.WriteLine("没有红色");
            //}

            //如果当前有红色，则去掉，如果没有红色，则加进来
            //Layer1 = Layer1 ^ Layer.red;

            //字符串与枚举的转换
            string s1 = "red";
            Layer layer2 = (Layer)Enum.Parse(typeof(Layer), s1);
            Console.WriteLine(layer2);

            #endregion

            Console.ReadLine();
        }

        static void WriteJijie(Jijie j)  //: byte //也是可以的,默认是int
        {
            switch (j)
            {
                case Jijie.Chun:
                    Console.WriteLine("播种");
                    break;
                case Jijie.Xia:
                    Console.WriteLine("成长");
                    break;
            }
        }
    }
}
