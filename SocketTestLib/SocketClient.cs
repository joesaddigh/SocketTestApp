using System.Net.Sockets;
using System.Text;

namespace SocketTestLib
{
    public class SocketClient
    {
        private readonly Action<string> _onData;
        private readonly Action _onDisconnect;
        private Thread _receiveSocketDataThread;
        private TcpClient _tcpClient = new();
        private bool _stop = false;
        private object dataSync = new object();

        public SocketClient(
            Action<string> onData,
            Action onDisconnect
        )
        {
            _onData = onData;
            _onDisconnect = onDisconnect;
        }

        public bool Connect(string host, int port)
        {
            try
            {
                if (_tcpClient.Connected)
                {
                    Disconnect();
                }
                _tcpClient = new TcpClient();
                _tcpClient.Connect(host, port);
                _stop = false;
                _receiveSocketDataThread = new(Receive);
                _receiveSocketDataThread.IsBackground = true;
                _receiveSocketDataThread.Start();
                return true;
            }
            catch
            {
            }

            return false;
        }

        public void Disconnect()
        {
            lock (dataSync)
            {
                _stop = true;
            }
            _tcpClient?.Close();
        }

        async public void Send(string data)
        {
            var dataBytes = Encoding.UTF8.GetBytes(data);
            await _tcpClient.Client.SendAsync(dataBytes, SocketFlags.None);
        }

        public void Receive()
        {
            var stopping = _stop;

            while (!stopping)
            {
                var buffer = new byte[1_024];
                try
                {
                    var received = _tcpClient.Client.Receive(buffer, SocketFlags.None);
                    if (received > 0)
                    {
                        var response = Encoding.UTF8.GetString(buffer, 0, received);
                        _onData(response);
                    }
                }
                catch (SocketException)
                {
                    _onDisconnect?.Invoke();
                    break;
                }

                lock (dataSync)
                {
                    stopping = _stop;
                }
            }
        }
    }
}