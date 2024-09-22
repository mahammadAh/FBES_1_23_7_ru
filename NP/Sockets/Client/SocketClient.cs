

using System.Net;
using System.Net.Sockets;
using System.Text;

public class SocketClient
{
    public static void Main(string[] args)
    {
        Socket sc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        IPAddress ip = IPAddress.Parse("127.0.0.1");

        IPEndPoint iep = new IPEndPoint(ip, 8080);

        sc.Connect(iep);

        try
        {
            if(sc.Connected)
            {
                Console.WriteLine(DateTime.Now.ToString() + "  Successefuly Connected to Server");

                while (true)
                {
                    byte[] buffer;

                    string data = Console.ReadLine();

                    buffer = Encoding.ASCII.GetBytes(data);

                    sc.Send(buffer);

                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
