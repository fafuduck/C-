using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_2
{
    public class GameObjectFactory
    {
        public static GameObject Create(GameObjectEnum gameObjectEnum)
        {
            GameObject go = new GameObject();

            switch (gameObjectEnum)
            {
                case GameObjectEnum.Bullet:
                    go = new Bullet();
                    break;
                case GameObjectEnum.Enemy:
                    go = new Enemy();
                    break;

            }

            return go;

        }


        private static Stack<Bullet> bulletstack = new Stack<Bullet>();
        public static Bullet CreateBuller()
        {
            Bullet bullet;

            if (bulletstack.Count > 0)
            {
                bullet = bulletstack.Pop;
            }
            else
            {
                bullet = new Bullet();
            }

            return bullet;
        }

        public static void Destroy(Bullet bullet)
        {
            bulletstack.Push(bullet);
        }
    }
}
