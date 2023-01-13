using System.Text;
using System.Net.Sockets;
using System.IO;
using System;

namespace Client
{
    class OurClient{
        private TcpClient _client;
        private StreamWriter _writer;

        public OurClient(){
            _client =  new TcpClient("127.0.0.1", 5555);
            _writer = new StreamWriter(_client.GetStream(), Encoding.UTF8);
            HandleCommunication();
        }

        void HandleCommunication(){
            while (true){
                Console.WriteLine("> ");
                string msg = Console.ReadLine();
                _writer.WriteLine(msg);
                _writer.Flush(); // 47-01
            }
        }
        internal static void Idle()
        {
            Console.WriteLine("...");
        }
    }
}