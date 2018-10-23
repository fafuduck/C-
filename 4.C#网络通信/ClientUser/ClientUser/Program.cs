using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtocolTest;

namespace ClientUser
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientControl client = new ClientControl();
            client.Connet("172.28.16.37", 12322);

            UserInfo userInfo = new UserInfo();

            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();

            ProtocolGame game = new ProtocolGame();
            game.model = 1;
            game.ope = 1;
            game.date = userInfo;

            client.Send(game);

            Console.ReadKey();
        }
    }
}
