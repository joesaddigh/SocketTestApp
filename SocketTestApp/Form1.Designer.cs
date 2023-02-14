namespace SocketTestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabConnectedTo = new System.Windows.Forms.GroupBox();
            this.GbReceive = new System.Windows.Forms.GroupBox();
            this.BtnClearReceive = new System.Windows.Forms.Button();
            this.TbReceive = new System.Windows.Forms.RichTextBox();
            this.GbSend = new System.Windows.Forms.GroupBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClearSendText = new System.Windows.Forms.Button();
            this.TbSend = new System.Windows.Forms.RichTextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TabConnectTo = new System.Windows.Forms.GroupBox();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TbIPAddress = new System.Windows.Forms.TextBox();
            this.TbPort = new System.Windows.Forms.TextBox();
            this.IPAddress = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabConnectedTo.SuspendLayout();
            this.GbReceive.SuspendLayout();
            this.GbSend.SuspendLayout();
            this.TabConnectTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1457, 718);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TabConnectedTo);
            this.tabPage1.Controls.Add(this.TabConnectTo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1449, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabConnectedTo
            // 
            this.TabConnectedTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabConnectedTo.Controls.Add(this.GbReceive);
            this.TabConnectedTo.Controls.Add(this.GbSend);
            this.TabConnectedTo.Location = new System.Drawing.Point(8, 151);
            this.TabConnectedTo.Name = "TabConnectedTo";
            this.TabConnectedTo.Size = new System.Drawing.Size(1435, 526);
            this.TabConnectedTo.TabIndex = 1;
            this.TabConnectedTo.TabStop = false;
            this.TabConnectedTo.Text = "Connected To";
            // 
            // GbReceive
            // 
            this.GbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbReceive.Controls.Add(this.BtnClearReceive);
            this.GbReceive.Controls.Add(this.TbReceive);
            this.GbReceive.Location = new System.Drawing.Point(727, 34);
            this.GbReceive.Name = "GbReceive";
            this.GbReceive.Size = new System.Drawing.Size(662, 486);
            this.GbReceive.TabIndex = 11;
            this.GbReceive.TabStop = false;
            this.GbReceive.Text = "Receive";
            // 
            // BtnClearReceive
            // 
            this.BtnClearReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearReceive.Enabled = false;
            this.BtnClearReceive.Location = new System.Drawing.Point(562, 26);
            this.BtnClearReceive.Name = "BtnClearReceive";
            this.BtnClearReceive.Size = new System.Drawing.Size(94, 29);
            this.BtnClearReceive.TabIndex = 10;
            this.BtnClearReceive.Text = "Clear";
            this.BtnClearReceive.UseVisualStyleBackColor = true;
            this.BtnClearReceive.Click += new System.EventHandler(this.BtnClearReceiveText_Click);
            // 
            // TbReceive
            // 
            this.TbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbReceive.Location = new System.Drawing.Point(17, 26);
            this.TbReceive.Name = "TbReceive";
            this.TbReceive.ReadOnly = true;
            this.TbReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TbReceive.Size = new System.Drawing.Size(539, 439);
            this.TbReceive.TabIndex = 3;
            this.TbReceive.Text = "";
            this.TbReceive.TextChanged += new System.EventHandler(this.TbReceive_TextChanged);
            // 
            // GbSend
            // 
            this.GbSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbSend.Controls.Add(this.BtnLoad);
            this.GbSend.Controls.Add(this.BtnSave);
            this.GbSend.Controls.Add(this.BtnClearSendText);
            this.GbSend.Controls.Add(this.TbSend);
            this.GbSend.Controls.Add(this.BtnSend);
            this.GbSend.Location = new System.Drawing.Point(6, 34);
            this.GbSend.Name = "GbSend";
            this.GbSend.Size = new System.Drawing.Size(691, 486);
            this.GbSend.TabIndex = 10;
            this.GbSend.TabStop = false;
            this.GbSend.Text = "Send";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoad.Location = new System.Drawing.Point(591, 160);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(94, 29);
            this.BtnLoad.TabIndex = 9;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(591, 125);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 29);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClearSendText
            // 
            this.BtnClearSendText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearSendText.Enabled = false;
            this.BtnClearSendText.Location = new System.Drawing.Point(591, 55);
            this.BtnClearSendText.Name = "BtnClearSendText";
            this.BtnClearSendText.Size = new System.Drawing.Size(94, 29);
            this.BtnClearSendText.TabIndex = 7;
            this.BtnClearSendText.Text = "Clear";
            this.BtnClearSendText.UseVisualStyleBackColor = true;
            this.BtnClearSendText.Click += new System.EventHandler(this.BtnClearSendText_Click);
            // 
            // TbSend
            // 
            this.TbSend.AcceptsTab = true;
            this.TbSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TbSend.Location = new System.Drawing.Point(9, 21);
            this.TbSend.Name = "TbSend";
            this.TbSend.Size = new System.Drawing.Size(576, 444);
            this.TbSend.TabIndex = 0;
            this.TbSend.Text = resources.GetString("TbSend.Text");
            this.TbSend.TextChanged += new System.EventHandler(this.TbSend_TextChanged);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(592, 21);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(93, 29);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TabConnectTo
            // 
            this.TabConnectTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabConnectTo.Controls.Add(this.BtnDisconnect);
            this.TabConnectTo.Controls.Add(this.BtnConnect);
            this.TabConnectTo.Controls.Add(this.TbIPAddress);
            this.TabConnectTo.Controls.Add(this.TbPort);
            this.TabConnectTo.Controls.Add(this.IPAddress);
            this.TabConnectTo.Controls.Add(this.port);
            this.TabConnectTo.Location = new System.Drawing.Point(8, 18);
            this.TabConnectTo.Name = "TabConnectTo";
            this.TabConnectTo.Size = new System.Drawing.Size(1435, 127);
            this.TabConnectTo.TabIndex = 0;
            this.TabConnectTo.TabStop = false;
            this.TabConnectTo.Text = "Connect To";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(550, 33);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(94, 29);
            this.BtnDisconnect.TabIndex = 5;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(437, 33);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(94, 29);
            this.BtnConnect.TabIndex = 4;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TbIPAddress
            // 
            this.TbIPAddress.Location = new System.Drawing.Point(115, 33);
            this.TbIPAddress.Name = "TbIPAddress";
            this.TbIPAddress.Size = new System.Drawing.Size(300, 27);
            this.TbIPAddress.TabIndex = 3;
            this.TbIPAddress.Text = "localhost";
            this.TbIPAddress.TextChanged += new System.EventHandler(this.TbIPAddress_TextChanged);
            // 
            // TbPort
            // 
            this.TbPort.Location = new System.Drawing.Point(115, 70);
            this.TbPort.Name = "TbPort";
            this.TbPort.Size = new System.Drawing.Size(300, 27);
            this.TbPort.TabIndex = 2;
            this.TbPort.Text = "8000";
            this.TbPort.TextChanged += new System.EventHandler(this.TbPort_TextChanged);
            this.TbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPort_KeyPress);
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSize = true;
            this.IPAddress.Location = new System.Drawing.Point(15, 40);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(81, 20);
            this.IPAddress.TabIndex = 1;
            this.IPAddress.Text = "IP Address:";
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(15, 70);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(38, 20);
            this.port.TabIndex = 0;
            this.port.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 718);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1475, 765);
            this.Name = "Form1";
            this.Text = "Socket Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabConnectedTo.ResumeLayout(false);
            this.GbReceive.ResumeLayout(false);
            this.GbSend.ResumeLayout(false);
            this.TabConnectTo.ResumeLayout(false);
            this.TabConnectTo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox TabConnectTo;
        private GroupBox TabConnectedTo;
        private Label IPAddress;
        private Label port;
        private TextBox TbIPAddress;
        private TextBox TbPort;
        private Button BtnDisconnect;
        private Button BtnConnect;
        private RichTextBox TbReceive;
        private RichTextBox TbSend;
        private Button BtnClearSendText;
        private Button BtnSend;
        private Button BtnSave;
        private Button BtnLoad;
        private GroupBox GbReceive;
        private GroupBox GbSend;
        private Button BtnClearReceive;
    }
}