using System.Net.Sockets;
using System.Text;

namespace SocketTestLib
{
    public class SocketClient
    {
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 8000;

        private readonly Action<string> _onData;

        private TcpClient _tcpClient = new TcpClient();

        public SocketClient(Action<string> onData)
        {
            _onData = onData;
        }

        public bool Connect()
        {
            try
            {
                _tcpClient = new TcpClient();
                _tcpClient.Connect(Host, Port);
                return true;
            }
            catch 
            { 
            }

            return false;
        }

        public void Disconnect()
        {
            _tcpClient.Close();
        }

        async public void Send(string data)
        {
            var dataBytes = Encoding.UTF8.GetBytes(data);
            await _tcpClient.Client.SendAsync(dataBytes, SocketFlags.None);
        }

       async public void Receive()
       {
            var buffer = new byte[1_024];
            var received = await _tcpClient.Client.ReceiveAsync(buffer, SocketFlags.None);
            var response = Encoding.UTF8.GetString(buffer, 0, received);
            _onData(response);
        }
    }
}