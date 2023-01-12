using System.Text;
using System.Net.Sockets;
using System.IO;
using System;

namespace Client
{
    class OurClient{
        private TcpClient _client;
        private StreamWriter _reader;

        public OurClient(){
            _client =  new TcpClient("127.0.0.1", 555);
            _reader = new StreamWriter(_client.GetStream(), Encoding.UTF8);
        }

        void HandleCommunication(){
            while (true){
                Console.WriteLine("> ");
                string msg = Console.ReadLine();
                _reader.WriteLine(msg);
                _reader.Flush(); // 47-01
            }
        }
        internal static void Idle()
        {
            Console.WriteLine("...");
        }
    }
}