using SocketTestLib;
using System.Timers;
using System.Windows.Forms;

namespace SocketTestApp
{
    public partial class Form1 : Form
    {
        bool Connected { get; set; } = false;
        private readonly SocketClient _socketClient;
        private readonly string _initialSaveOpenDirectory = GetInitialSaveOpenDirectory();
        private const string SOCKET_DATA_SEPARATOR = "_____________________________________________";

        private static string GetInitialSaveOpenDirectory()
        {
            return Application.ExecutablePath;
        }

        public Form1()
        {
            _socketClient = new SocketClient(OnSocketData);

            try
            {
                InitializeComponent();
                SetAllUIEnabledStates();
            }
            catch { }
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
                    TbReceive.Text += SOCKET_DATA_SEPARATOR + Environment.NewLine;
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Connected = _socketClient.Connect();
            if (!Connected)
            {
                MessageBox.Show("Failed to connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetAllUIEnabledStates();
            Cursor.Current = Cursors.Default;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                Connected = false;
                _socketClient.Disconnect();
                SetAllUIEnabledStates();
            }
            catch
            {
            }
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

        private void BtnSaveSend_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON File|*.json",
                Title = "Save send data",
                InitialDirectory = _initialSaveOpenDirectory
            };

            saveFileDialog.ShowDialog();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "JSON File|*.json",
                Title = "Load send data",
                InitialDirectory = _initialSaveOpenDirectory
            };

            openFileDialog.ShowDialog();
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