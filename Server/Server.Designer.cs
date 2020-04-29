namespace Client
{
    partial class Server
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.slStatus = new System.Windows.Forms.ToolStripLabel();
            this.l_status = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stStopServer = new System.Windows.Forms.ToolStripButton();
            this.sbStartServer = new System.Windows.Forms.ToolStripButton();
            this.stPortVal = new System.Windows.Forms.ToolStripTextBox();
            this.slPort = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stIpAddressVal = new System.Windows.Forms.ToolStripTextBox();
            this.slIpAddress = new System.Windows.Forms.ToolStripLabel();
            this.bSaveEncryptedImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(316, 503);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(109, 94);
            this.bDecrypt.TabIndex = 2;
            this.bDecrypt.Text = "Decrypt";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // pImage
            // 
            this.pImage.Location = new System.Drawing.Point(3, 1);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(827, 482);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pImage.TabIndex = 3;
            this.pImage.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatus,
            this.l_status,
            this.toolStripSeparator1,
            this.stStopServer,
            this.sbStartServer,
            this.stPortVal,
            this.slPort,
            this.toolStripSeparator2,
            this.stIpAddressVal,
            this.slIpAddress});
            this.toolStrip.Location = new System.Drawing.Point(0, 626);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(830, 27);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // slStatus
            // 
            this.slStatus.Name = "slStatus";
            this.slStatus.Size = new System.Drawing.Size(56, 24);
            this.slStatus.Text = "Status :";
            // 
            // l_status
            // 
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // stStopServer
            // 
            this.stStopServer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stStopServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stStopServer.Image = ((System.Drawing.Image)(resources.GetObject("stStopServer.Image")));
            this.stStopServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stStopServer.Name = "stStopServer";
            this.stStopServer.Size = new System.Drawing.Size(89, 24);
            this.stStopServer.Text = "Stop Server";
            this.stStopServer.Click += new System.EventHandler(this.stStopServer_Click);
            // 
            // sbStartServer
            // 
            this.sbStartServer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sbStartServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbStartServer.Image = ((System.Drawing.Image)(resources.GetObject("sbStartServer.Image")));
            this.sbStartServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbStartServer.Name = "sbStartServer";
            this.sbStartServer.Size = new System.Drawing.Size(89, 24);
            this.sbStartServer.Text = "Start Server";
            this.sbStartServer.Click += new System.EventHandler(this.sbStartServer_Click);
            // 
            // stPortVal
            // 
            this.stPortVal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stPortVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stPortVal.Name = "stPortVal";
            this.stPortVal.Size = new System.Drawing.Size(100, 27);
            // 
            // slPort
            // 
            this.slPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.slPort.Name = "slPort";
            this.slPort.Size = new System.Drawing.Size(42, 24);
            this.slPort.Text = "Port :";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // stIpAddressVal
            // 
            this.stIpAddressVal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stIpAddressVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stIpAddressVal.Name = "stIpAddressVal";
            this.stIpAddressVal.Size = new System.Drawing.Size(100, 27);
            // 
            // slIpAddress
            // 
            this.slIpAddress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.slIpAddress.Name = "slIpAddress";
            this.slIpAddress.Size = new System.Drawing.Size(78, 24);
            this.slIpAddress.Text = "IP Address";
            // 
            // bSaveEncryptedImage
            // 
            this.bSaveEncryptedImage.Location = new System.Drawing.Point(462, 503);
            this.bSaveEncryptedImage.Name = "bSaveEncryptedImage";
            this.bSaveEncryptedImage.Size = new System.Drawing.Size(136, 94);
            this.bSaveEncryptedImage.TabIndex = 7;
            this.bSaveEncryptedImage.Text = "Save Encrypted Image";
            this.bSaveEncryptedImage.UseVisualStyleBackColor = true;
            this.bSaveEncryptedImage.Click += new System.EventHandler(this.bSaveEncryptedImage_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 653);
            this.Controls.Add(this.bSaveEncryptedImage);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pImage);
            this.Controls.Add(this.bDecrypt);
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bDecrypt;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel slStatus;
        private System.Windows.Forms.ToolStripLabel l_status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton sbStartServer;
        private System.Windows.Forms.ToolStripTextBox stPortVal;
        private System.Windows.Forms.ToolStripLabel slPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox stIpAddressVal;
        private System.Windows.Forms.ToolStripLabel slIpAddress;
        private System.Windows.Forms.Button bSaveEncryptedImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton stStopServer;
    }
}

