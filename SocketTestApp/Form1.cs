using SocketTestLib;
using System.Timers;

namespace SocketTestApp
{
    public partial class Form1 : Form
    {
        bool Connected { get; set; } = false;
        private readonly SocketClient _socketClient;
        private readonly System.Timers.Timer _timer = new System.Timers.Timer();


        public Form1()
        {
            InitializeComponent();
            _socketClient = new SocketClient(OnSocketData);
            InitialiseTimer();
            SetAllUIEnabledStates();
        }

        private void ReadSocketData(object source, ElapsedEventArgs e)
        {
            if (Connected)
            {
                _socketClient.Receive();
            }
        }

        private void InitialiseTimer()
        {
            _timer.Elapsed += new ElapsedEventHandler(ReadSocketData);
            _timer.Interval += 250;
            _timer.Enabled = true;
        }

        private void OnSocketData(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        OnSocketData(data);
                    });
                    return;
                }
                else
                {
                    TbReceive.Text += data;
                    TbReceive.Text += "_____________________________________________" + Environment.NewLine;
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Connected = _socketClient.Connect();
            //TabConnectedTo.Enabled = Connected;
            SetAllUIEnabledStates();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            Connected = false;
            //TabConnectedTo.Enabled = !Connected;
            _socketClient.Disconnect();
            SetAllUIEnabledStates();
        }

        private void TbIPAddress_TextChanged(object sender, EventArgs e)
        {
            SetConnectButtonEnabled();
        }
        
        private void TbPort_TextChanged(object sender, EventArgs e)
        {
            SetConnectButtonEnabled();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                _socketClient.Send(TbSend.Text);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TbReceive.Clear();
        }

        private void SetAllUIEnabledStates()
        {
            SetIpAddressEnabled();
            SetPortEnabled();
            SetConnectButtonEnabled();
            SetDisconnectButtonEnabled();
            SetSendButtonEnabled();
            SetClearButtonEnabled();
        }

        private void SetIpAddressEnabled()
        {
            TbIPAddress.Enabled = !Connected;
        }

        private void SetPortEnabled()
        {
            TbPort.Enabled = !Connected;
        }

        private void SetConnectButtonEnabled()
        {
            BtnConnect.Enabled =
                !Connected &&
                !string.IsNullOrEmpty(TbIPAddress.Text) &&
                !string.IsNullOrEmpty(TbPort.Text);
        }

        private void SetDisconnectButtonEnabled()
        {
            BtnDisconnect.Enabled = Connected;
        }

        private void SetSendButtonEnabled()
        {
            BtnSend.Enabled =
                Connected &&
                !string.IsNullOrEmpty(TbSend.Text);
        }

        private void SetClearButtonEnabled() 
        {
            BtnClear.Enabled =
                Connected &&
                !string.IsNullOrEmpty(TbReceive.Text);
        }

        private void TbSend_TextChanged(object sender, EventArgs e)
        {
            SetSendButtonEnabled();
        }

        private void TbReceive_TextChanged(object sender, EventArgs e)
        {
            SetClearButtonEnabled();
        }
    }
}