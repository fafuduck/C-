using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProtocolTest;
using MySql.Data.MySqlClient;

namespace ServerUser
{
    public class SocketServer
    {

        private Socket server;

        public SocketServer()
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void start()  //这一部完成服务器就搭建好了
        {
            server.Bind(new IPEndPoint(IPAddress.Any, 12322));   //使用端口号为12322，任何ip均可以接入
            server.Listen(10);

            Thread threadAccept = new Thread(Accept);//开启一个新线程
            threadAccept.IsBackground = true;//是否后台执行
            threadAccept.Start();
        }

        private void Accept()
        {
            Socket client = server.Accept();
            Thread threadReceive = new Thread(Receive);
            threadReceive.IsBackground = true;
            threadReceive.Start(client);

            Accept(); //尾递归
        }

        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            byte[] msg = new byte[1024 * 1024]; //一个字节数组
            int msgLen = client.Receive(msg);

            MemoryStream stream = new MemoryStream(msg, 0, msgLen);// MemoryStream是内存流的意思
            BinaryFormatter formater = new BinaryFormatter(); //对象转换成二进制的一个东西
            var protocolGame = formater.Deserialize(stream) as ProtocolGame; //Deserialize是反序列的意思
            //这里的ProtocolGame要自己引入命名空间，IDE不会提示

            switch (protocolGame.model)
            {
                case 1://用户
                    switch (protocolGame.ope)
                    {
                        case 1://注册
                            var userInfo = protocolGame.date as UserInfo;

                            string sql = "insert into userinfo(uname,upwd) values(@name,@pwd)";
                            int result = MySqlHelper.Insert(sql,
                                new MySqlParameter("@name", userInfo.Name),
                                new MySqlParameter("@pwd", userInfo.Pwd));
                            if (result == 1)
                            {
                                client.Send(Encoding.UTF8.GetBytes("成功"));
                            }

                            break;
                        case 2://登陆

                            break;
                        case 3://找回密码

                            break;
                    }




                    break;
                case 2://聊天


                    break;
                case 3://战斗


                    break;
            }


            Receive(obj);
        }
    }
}
