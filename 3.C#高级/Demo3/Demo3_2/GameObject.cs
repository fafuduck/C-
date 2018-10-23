using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_2
{
    public class GameObject
    {
        public Vector3 postion;
        public GameObject()
        {
            postion = new Vector3();
        }

    }

    public class Bullet : GameObject
    {
        public void Destroy()
        {
            GameObjectFactory.Destroy(this);
        }
    }

    public class Enemy : GameObject
    {

    }

    public enum GameObjectEnum
    {
        Bullet,
        Enemy
    }

    public class Vector3
    {
        public float x;
        public float y;
        public float z;
    }
}
