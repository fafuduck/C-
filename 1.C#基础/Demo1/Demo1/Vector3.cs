using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Vector3
    {
        private float x;
        private float y;
        private float z;

        //在类中,默认存在一个无参的构造函数；
        //一旦手动定义了构造函数，则不再生成无参的构造函数
        //如果需要无参的构造函数，则要明确的写出了

        public Vector3()
        {

        }

        public static Vector3 right = new Vector3(1, 0, 0);
        public static Vector3 up = new Vector3(0, 1, 0);
        public static Vector3 front = new Vector3(0, 0, 1);



        public  Vector3(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3(float x,float y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
        }

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public override string ToString()  //Object默认的ToString()
        {
            return "("+x+","+y+","+z+")";
        }
    }
}
