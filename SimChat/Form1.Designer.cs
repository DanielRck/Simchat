
namespace SimChat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxMe = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.groupBoxFriend = new System.Windows.Forms.GroupBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.labelRemotePort = new System.Windows.Forms.Label();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.labelRemoteIp = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelChat = new System.Windows.Forms.Label();
            this.labelWriteMessage = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simchatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMe.SuspendLayout();
            this.groupBoxFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMe
            // 
            this.groupBoxMe.Controls.Add(this.textLocalPort);
            this.groupBoxMe.Controls.Add(this.textLocalIp);
            this.groupBoxMe.Controls.Add(this.labelPort);
            this.groupBoxMe.Controls.Add(this.labelIp);
            this.groupBoxMe.Location = new System.Drawing.Point(22, 41);
            this.groupBoxMe.Name = "groupBoxMe";
            this.groupBoxMe.Size = new System.Drawing.Size(200, 100);
            this.groupBoxMe.TabIndex = 0;
            this.groupBoxMe.TabStop = false;
            this.groupBoxMe.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textLocalPort.Location = new System.Drawing.Point(39, 65);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(142, 20);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIp
            // 
            this.textLocalIp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textLocalIp.Location = new System.Drawing.Point(39, 30);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(142, 20);
            this.textLocalIp.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(6, 65);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(6, 30);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(17, 13);
            this.labelIp.TabIndex = 0;
            this.labelIp.Text = "IP";
            // 
            // groupBoxFriend
            // 
            this.groupBoxFriend.Controls.Add(this.textRemotePort);
            this.groupBoxFriend.Controls.Add(this.labelRemotePort);
            this.groupBoxFriend.Controls.Add(this.textRemoteIp);
            this.groupBoxFriend.Controls.Add(this.labelRemoteIp);
            this.groupBoxFriend.Location = new System.Drawing.Point(229, 41);
            this.groupBoxFriend.Name = "groupBoxFriend";
            this.groupBoxFriend.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFriend.TabIndex = 1;
            this.groupBoxFriend.TabStop = false;
            this.groupBoxFriend.Text = "Friend";
            // 
            // textRemotePort
            // 
            this.textRemotePort.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textRemotePort.Location = new System.Drawing.Point(43, 62);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(142, 20);
            this.textRemotePort.TabIndex = 5;
            // 
            // labelRemotePort
            // 
            this.labelRemotePort.AutoSize = true;
            this.labelRemotePort.Location = new System.Drawing.Point(6, 65);
            this.labelRemotePort.Name = "labelRemotePort";
            this.labelRemotePort.Size = new System.Drawing.Size(26, 13);
            this.labelRemotePort.TabIndex = 1;
            this.labelRemotePort.Text = "Port";
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textRemoteIp.Location = new System.Drawing.Point(43, 27);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(142, 20);
            this.textRemoteIp.TabIndex = 4;
            // 
            // labelRemoteIp
            // 
            this.labelRemoteIp.AutoSize = true;
            this.labelRemoteIp.Location = new System.Drawing.Point(7, 30);
            this.labelRemoteIp.Name = "labelRemoteIp";
            this.labelRemoteIp.Size = new System.Drawing.Size(17, 13);
            this.labelRemoteIp.TabIndex = 0;
            this.labelRemoteIp.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.Location = new System.Drawing.Point(435, 68);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(144, 46);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "CONNECT";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(22, 167);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(933, 316);
            this.listMessage.TabIndex = 3;
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textMessage.Location = new System.Drawing.Point(22, 513);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(788, 20);
            this.textMessage.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            this.buttonSend.Location = new System.Drawing.Point(828, 501);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(127, 41);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(764, 87);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(191, 74);
            this.pictureLogo.TabIndex = 6;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelChat
            // 
            this.labelChat.AutoSize = true;
            this.labelChat.Location = new System.Drawing.Point(19, 151);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(29, 13);
            this.labelChat.TabIndex = 8;
            this.labelChat.Text = "Chat";
            // 
            // labelWriteMessage
            // 
            this.labelWriteMessage.AutoSize = true;
            this.labelWriteMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWriteMessage.Location = new System.Drawing.Point(19, 497);
            this.labelWriteMessage.Name = "labelWriteMessage";
            this.labelWriteMessage.Size = new System.Drawing.Size(78, 13);
            this.labelWriteMessage.TabIndex = 9;
            this.labelWriteMessage.Text = "Write Message";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.labelCopyright.Location = new System.Drawing.Point(20, 536);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(70, 12);
            this.labelCopyright.TabIndex = 10;
            this.labelCopyright.Text = "2021 © Simchat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simchatToolStripMenuItem,
            this.editMessageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simchatToolStripMenuItem
            // 
            this.simchatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.simchatToolStripMenuItem.Name = "simchatToolStripMenuItem";
            this.simchatToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.simchatToolStripMenuItem.Text = "Simchat";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click1);
            // 
            // editMessageToolStripMenuItem
            // 
            this.editMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.dateTimeToolStripMenuItem});
            this.editMessageToolStripMenuItem.Name = "editMessageToolStripMenuItem";
            this.editMessageToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.editMessageToolStripMenuItem.Text = "Edit Message";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click1);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click1);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click1);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click1);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dateTimeToolStripMenuItem.Text = "Date / Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(980, 554);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelWriteMessage);
            this.Controls.Add(this.labelChat);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBoxFriend);
            this.Controls.Add(this.groupBoxMe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simchat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMe.ResumeLayout(false);
            this.groupBoxMe.PerformLayout();
            this.groupBoxFriend.ResumeLayout(false);
            this.groupBoxFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMe;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.GroupBox groupBoxFriend;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label labelRemotePort;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.Label labelRemoteIp;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.Label labelWriteMessage;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simchatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
    }
}

