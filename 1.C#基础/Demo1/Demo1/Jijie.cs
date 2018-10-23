using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public enum Jijie
    {
        Chun,   //int值默认为0
        Xia,    //int值默认为1
        Qiu,    //int值默认为2
        Dong    //int值默认为3

        //Chun=50,   
        //Xia=110,
        //Qiu=200,
        //Dong  //此时此刻的Dong为201
    }

    [Flags]        //标志枚举的意思,标志枚举的意思就是让某一位为1，其他位都为0
    public enum Layer
    {
        //default1 = 1,  //让第一位取1，其他位均为0  2的零次方
        //red = 2,        //让第二位取1，其他位均为0  2的一次方
        //blue = 4        //让第三位取1，其他位均为0  2的平方
        //也可以用下面这种方法来表示
        default1 = 1<<0,
        red = 1<<1,
        blue = 1<<2,
        green = 1<<3


    }
}
