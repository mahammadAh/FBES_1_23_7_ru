
using System.Net.Sockets;
using System.Net;
using System.Globalization;
using System.Text;

public class SocketServer
{
    public static void Main(string[] args)
    {
        Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        IPAddress ip = IPAddress.Parse("127.0.0.1");

        IPEndPoint iep = new IPEndPoint(ip, 8080);

        sc.Bind(iep);

        Console.WriteLine(DateTime.Now.ToString() + "  Waiting...");



     


            byte[] buffer = new byte[1024];



        while (true)
        {

            sc.Listen(10);


            var csc = sc.Accept();


            Task.Run(() =>
            {
                byte[] buffer = new byte[1024];

                int dataSize = csc.Receive(buffer);

                string data = Encoding.ASCII.GetString(buffer, 0, dataSize);

                Console.WriteLine(DateTime.Now.ToString() + "  " + data);
            });

        }
    

        Console.WriteLine(DateTime.Now.ToString() + "  Server Closed");
    }
}