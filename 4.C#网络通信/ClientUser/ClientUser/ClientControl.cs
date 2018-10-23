using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProtocolTest;

namespace ClientUser
{
    public class ClientControl
    {
        private Socket client;
        public ClientControl()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connet(string ip, int port)  //连接
        {
            client.Connect(ip, port);

            Thread threadReceive = new Thread(Receive);
            threadReceive.IsBackground = true;
            threadReceive.Start();
        }

        public void Send(ProtocolGame game)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, game);
            byte[] msg = stream.GetBuffer();
            client.Send(msg);
        }

        public void Receive()
        {
            try
            {
                byte[] msg = new byte[1024 * 1024]; //1MB的大小
                int msgLen = client.Receive(msg);
                Console.WriteLine(Encoding.UTF8.GetString(msg, 0, msgLen));
                Receive();
            }
            catch
            {

            }


        }
    }
}
