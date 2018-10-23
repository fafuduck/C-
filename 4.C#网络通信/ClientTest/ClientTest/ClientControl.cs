using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientTest
{
    public class ClientControl
    {
        private Socket clientSocket;


        public ClientControl()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void Connect(string ip, int port)
        {
            clientSocket.Connect(ip, port);
            Console.WriteLine("连接服务器成功");

            Thread threadReceive = new Thread(Receive);
            threadReceive.IsBackground = true;
            threadReceive.Start();
         }

        public void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] msg = new byte[1024];
                    int msgLen = clientSocket.Receive(msg);
                    Console.WriteLine("服务器说: " + Encoding.UTF8.GetString(msg, 0, msgLen));
                }

                catch
                {
                    Console.WriteLine("服务器积极拒绝");
                    break;
                }
            }
            
        }

        public void Send()
        {
            Thread threadSend = new Thread(ReadAndSend);
           // threadSend.IsBackground = true;
           //不能开启后台线程，因为主程序中有一个Console.ReadKey()会执行，如果把这个设置成后台线程的话
           //Send()、ReadAndSend()后面的Console.ReadLine()就无法继续执行，因为主线程关闭了，所以后台线程也就随之关闭
           //所以这个线程不能设置为后台线程。
            threadSend.Start();
        }

        private void ReadAndSend()
        {
            Console.WriteLine("请输入要发送的内容，输入quit退出");
            string msg = Console.ReadLine();
            while (msg != "quit")
            {
                clientSocket.Send(Encoding.UTF8.GetBytes(msg));
                msg = Console.ReadLine();
            }
        }

            
    }
}
