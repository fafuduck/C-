using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameObject bullet = GameObjectFactory.Create(GameObjectEnum.Bullet); 

            Bullet bullet = GameObjectFactory.CreateBuller();
            bullet.Destroy;
        }
    }
}
