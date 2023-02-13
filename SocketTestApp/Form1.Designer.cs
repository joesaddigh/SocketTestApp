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
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LblReceive = new System.Windows.Forms.Label();
            this.TbReceive = new System.Windows.Forms.RichTextBox();
            this.LblSend = new System.Windows.Forms.Label();
            this.TbSend = new System.Windows.Forms.RichTextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(1457, 717);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TabConnectedTo);
            this.tabPage1.Controls.Add(this.TabConnectTo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1449, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabConnectedTo
            // 
            this.TabConnectedTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabConnectedTo.Controls.Add(this.BtnClear);
            this.TabConnectedTo.Controls.Add(this.BtnSend);
            this.TabConnectedTo.Controls.Add(this.LblReceive);
            this.TabConnectedTo.Controls.Add(this.TbReceive);
            this.TabConnectedTo.Controls.Add(this.LblSend);
            this.TabConnectedTo.Controls.Add(this.TbSend);
            this.TabConnectedTo.Location = new System.Drawing.Point(8, 151);
            this.TabConnectedTo.Name = "TabConnectedTo";
            this.TabConnectedTo.Size = new System.Drawing.Size(1435, 525);
            this.TabConnectedTo.TabIndex = 1;
            this.TabConnectedTo.TabStop = false;
            this.TabConnectedTo.Text = "Connected To";
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.Enabled = false;
            this.BtnClear.Location = new System.Drawing.Point(128, 477);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 29);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSend.Location = new System.Drawing.Point(15, 477);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(94, 29);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LblReceive
            // 
            this.LblReceive.AutoSize = true;
            this.LblReceive.Location = new System.Drawing.Point(743, 34);
            this.LblReceive.Name = "LblReceive";
            this.LblReceive.Size = new System.Drawing.Size(63, 20);
            this.LblReceive.TabIndex = 4;
            this.LblReceive.Text = "Receive:";
            // 
            // TbReceive
            // 
            this.TbReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbReceive.Location = new System.Drawing.Point(743, 75);
            this.TbReceive.Name = "TbReceive";
            this.TbReceive.ReadOnly = true;
            this.TbReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TbReceive.Size = new System.Drawing.Size(663, 376);
            this.TbReceive.TabIndex = 3;
            this.TbReceive.Text = "";
            this.TbReceive.TextChanged += new System.EventHandler(this.TbReceive_TextChanged);
            // 
            // LblSend
            // 
            this.LblSend.AutoSize = true;
            this.LblSend.Location = new System.Drawing.Point(15, 34);
            this.LblSend.Name = "LblSend";
            this.LblSend.Size = new System.Drawing.Size(45, 20);
            this.LblSend.TabIndex = 2;
            this.LblSend.Text = "Send:";
            // 
            // TbSend
            // 
            this.TbSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSend.Location = new System.Drawing.Point(15, 75);
            this.TbSend.Name = "TbSend";
            this.TbSend.Size = new System.Drawing.Size(663, 376);
            this.TbSend.TabIndex = 0;
            this.TbSend.Text = resources.GetString("TbSend.Text");
            this.TbSend.TextChanged += new System.EventHandler(this.TbSend_TextChanged);
            // 
            // TabConnectTo
            // 
            this.TabConnectTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabConnectTo.Controls.Add(this.BtnDisconnect);
            this.TabConnectTo.Controls.Add(this.BtnConnect);
            this.TabConnectTo.Controls.Add(this.TbIPAddress);
            this.TabConnectTo.Controls.Add(this.TbPort);
            this.TabConnectTo.Controls.Add(this.IPAddress);
            this.TabConnectTo.Controls.Add(this.port);
            this.TabConnectTo.Location = new System.Drawing.Point(8, 18);
            this.TabConnectTo.Name = "TabConnectTo";
            this.TabConnectTo.Size = new System.Drawing.Size(1435, 138);
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
            this.ClientSize = new System.Drawing.Size(1457, 717);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Socket Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabConnectedTo.ResumeLayout(false);
            this.TabConnectedTo.PerformLayout();
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
        private Label LblReceive;
        private RichTextBox TbReceive;
        private Label LblSend;
        private RichTextBox TbSend;
        private Button BtnClear;
        private Button BtnSend;
    }
}