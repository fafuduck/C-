using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientControl client = new ClientControl();
            client.Connect("192.168.1.2",12321);

            client.Send();

            Console.ReadKey();
        }
    }
}
