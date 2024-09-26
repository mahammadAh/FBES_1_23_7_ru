using System.Net;
public class Program
{
    public static void Main(string[] args)
    {

        var server = new HttpListener();
        server.Prefixes.Add("http://127.0.0.1:8080/");
        server.Start();

        while (true)
        {
            var result = server.GetContext();
        

            var url = result.Request.Url.ToString();
            var urlArr = url.Split('/');
            using (var stream = new StreamWriter(result.Response.OutputStream))
            {
                for (int i = 3; i < urlArr.Length; i++)
                {
                    stream.WriteLine($"<h1 style='color:red'>{urlArr[i]}</h1>");
                }

            }
        }
    }
}
