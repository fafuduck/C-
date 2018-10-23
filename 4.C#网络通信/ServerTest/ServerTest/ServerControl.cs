using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerTest
{
    public class ServerControl
    {
        private Socket serverSocket;

        private List<Socket> clientList;

        public ServerControl()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            clientList = new List<Socket>();

        }

        public void start()
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 12321));
            serverSocket.Listen(10);
            Console.WriteLine("服务器启成功");

            Thread threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();     
       
        }

        private void Accept()
        {
            //接收客户端方法，会挂起当前线程
            Socket client = serverSocket.Accept(); //接收一个客户端
            IPEndPoint point = client.RemoteEndPoint as IPEndPoint; //把RemoteEndPoint 转换成 IPEndPoint
            Console.WriteLine(point.Address + "[" + point.Port + "]连接成功");
            clientList.Add(client);

            Thread threadReceive = new Thread(Receive);
            threadReceive.IsBackground = true;
            threadReceive.Start(client);

            Accept();
        }

        private void Receive(object obj)
        {
            Socket client = obj as Socket;

            IPEndPoint point = client.RemoteEndPoint as IPEndPoint;


            try
            {
                byte[] msg = new byte[1024];
                int msgLen = client.Receive(msg);
                string msgStr = point.Address + "[" + point.Port + "]:" + Encoding.UTF8.GetString(msg, 0, msgLen);
                Console.WriteLine(msgStr);
                //     client.Send(Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(msg,0,msgLen)+"楼上说的对"));

                Broadcast(client,msgStr);

                Receive(client);
            }
            catch
            {
                Console.WriteLine(point.Address + "[" + point.Port + "]积极断开");
                clientList.Remove(client);
            }
        

            
        }

        private void Broadcast(Socket clientOther, string msg)//广播消息
        {
            foreach (var client in clientList)
            {
                if (client == clientOther)
                {
                    //当前消息是由client发来的，不需要有任何响应
                }
                else
                {
                    client.Send(Encoding.UTF8.GetBytes(msg));
                }
            }
        }
    }
}
