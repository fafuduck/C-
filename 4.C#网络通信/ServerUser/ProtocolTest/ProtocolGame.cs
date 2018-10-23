using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolTest
{
    [Serializable]
    public class ProtocolGame
    {
        //模块
        public int model;
        //操作
        public int ope;
        //数据
        public object date;
    }
}
