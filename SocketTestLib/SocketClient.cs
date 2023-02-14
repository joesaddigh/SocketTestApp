﻿using System.Net.Sockets;
using System.Text;

namespace SocketTestLib
{
    public class SocketClient
    {
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 8000;
        private readonly Action<string> _onData;
        private Thread _receiveSocketDataThread;
        private TcpClient _tcpClient = new();
        private bool _stop = false;
        private object dataSync = new object();

        public SocketClient(Action<string> onData)
        {
            _onData = onData;
        }

        public bool Connect()
        {
            try
            {
                if (_tcpClient.Connected)
                {
                    Disconnect();
                }
                _tcpClient = new TcpClient();
                _tcpClient.Connect(Host, Port);
                _stop = false;
                _receiveSocketDataThread = new(Receive);
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
                }

                lock (dataSync)
                {
                    stopping = _stop;
                }
            }
        }
    }
}