using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public class MyTcpServer

    {
        private readonly TcpListener listener = new TcpListener(IPAddress.Any, 8888);
        public void Start_server(string json)
        {
            listener.Start();
            MessageBox.Show("Сервер запущен!");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                byte[] data = Encoding.UTF8.GetBytes(json);
                client.GetStream().Write(data, 0, data.Length);
                client.Close();
            }
        }
    }
}