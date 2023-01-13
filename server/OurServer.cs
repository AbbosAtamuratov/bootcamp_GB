using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Server
{
    class OurServer{
        TcpListener _server;

        OurServer(){
            TcpListener _server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);
            _server.Start();
            LoopClients();
        }

        void LoopClients(){
            while (true){
                TcpClient _client = _server.AcceptTcpClient();

                Thread thread = new Thread(() => HandleClient(_client));
                thread.Start;
            }
        
        }

        void HandleClient(TcpClient client){
            StreamReader _reader = new StreamReader (client.GetStream(), Encoding.UTF8);
            while (true)
            {
                string messege = _reader.ReadLine();
                Console.WriteLine("Клиент написал: " + messege);
            }
        }
    }
}