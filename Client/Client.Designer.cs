namespace Server
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.slStatus = new System.Windows.Forms.ToolStripLabel();
            this.l_status = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sbConnect = new System.Windows.Forms.ToolStripButton();
            this.stPortVal = new System.Windows.Forms.ToolStripTextBox();
            this.slPort = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stIpAddressVal = new System.Windows.Forms.ToolStripTextBox();
            this.slIpAddress = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSaveEncryptedImage = new System.Windows.Forms.Button();
            this.lWidthVal = new System.Windows.Forms.Label();
            this.gbImageProperties = new System.Windows.Forms.GroupBox();
            this.lHeightVal = new System.Windows.Forms.Label();
            this.lTypeVal = new System.Windows.Forms.Label();
            this.lSizeVal = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lWidth = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.l_size = new System.Windows.Forms.Label();
            this.lNameVal = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bEncryptImage = new System.Windows.Forms.Button();
            this.gbSelectImage = new System.Windows.Forms.GroupBox();
            this.lPathVal = new System.Windows.Forms.Label();
            this.lPath = new System.Windows.Forms.Label();
            this.bSelectImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.bSendImage = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbImageProperties.SuspendLayout();
            this.gbSelectImage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatus,
            this.l_status,
            this.toolStripSeparator1,
            this.sbConnect,
            this.stPortVal,
            this.slPort,
            this.toolStripSeparator2,
            this.stIpAddressVal,
            this.slIpAddress});
            this.toolStrip.Location = new System.Drawing.Point(0, 626);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(830, 27);
            this.toolStrip.TabIndex = 2;
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
            // sbConnect
            // 
            this.sbConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbConnect.Image = ((System.Drawing.Image)(resources.GetObject("sbConnect.Image")));
            this.sbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbConnect.Name = "sbConnect";
            this.sbConnect.Size = new System.Drawing.Size(67, 24);
            this.sbConnect.Text = "Connect";
            this.sbConnect.Click += new System.EventHandler(this.bConnect_Click);
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
            this.slIpAddress.Size = new System.Drawing.Size(85, 24);
            this.slIpAddress.Text = "IP Address :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSaveEncryptedImage);
            this.panel1.Controls.Add(this.lWidthVal);
            this.panel1.Controls.Add(this.gbImageProperties);
            this.panel1.Controls.Add(this.bEncryptImage);
            this.panel1.Controls.Add(this.gbSelectImage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bSendImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 626);
            this.panel1.TabIndex = 3;
            // 
            // bSaveEncryptedImage
            // 
            this.bSaveEncryptedImage.Location = new System.Drawing.Point(581, 502);
            this.bSaveEncryptedImage.Name = "bSaveEncryptedImage";
            this.bSaveEncryptedImage.Size = new System.Drawing.Size(237, 47);
            this.bSaveEncryptedImage.TabIndex = 4;
            this.bSaveEncryptedImage.Text = "Save Encrypted Image";
            this.bSaveEncryptedImage.UseVisualStyleBackColor = true;
            this.bSaveEncryptedImage.Click += new System.EventHandler(this.bSaveEncryptedImage_Click);
            // 
            // lWidthVal
            // 
            this.lWidthVal.AutoSize = true;
            this.lWidthVal.Location = new System.Drawing.Point(404, 548);
            this.lWidthVal.Name = "lWidthVal";
            this.lWidthVal.Size = new System.Drawing.Size(30, 17);
            this.lWidthVal.TabIndex = 9;
            this.lWidthVal.Text = "null";
            // 
            // gbImageProperties
            // 
            this.gbImageProperties.Controls.Add(this.lHeightVal);
            this.gbImageProperties.Controls.Add(this.lTypeVal);
            this.gbImageProperties.Controls.Add(this.lSizeVal);
            this.gbImageProperties.Controls.Add(this.lHeight);
            this.gbImageProperties.Controls.Add(this.lWidth);
            this.gbImageProperties.Controls.Add(this.lType);
            this.gbImageProperties.Controls.Add(this.l_size);
            this.gbImageProperties.Controls.Add(this.lNameVal);
            this.gbImageProperties.Controls.Add(this.lName);
            this.gbImageProperties.Location = new System.Drawing.Point(345, 437);
            this.gbImageProperties.Name = "gbImageProperties";
            this.gbImageProperties.Size = new System.Drawing.Size(230, 165);
            this.gbImageProperties.TabIndex = 3;
            this.gbImageProperties.TabStop = false;
            this.gbImageProperties.Text = "Image Properties";
            // 
            // lHeightVal
            // 
            this.lHeightVal.AutoSize = true;
            this.lHeightVal.Location = new System.Drawing.Point(59, 138);
            this.lHeightVal.Name = "lHeightVal";
            this.lHeightVal.Size = new System.Drawing.Size(30, 17);
            this.lHeightVal.TabIndex = 10;
            this.lHeightVal.Text = "null";
            // 
            // lTypeVal
            // 
            this.lTypeVal.AutoSize = true;
            this.lTypeVal.Location = new System.Drawing.Point(59, 85);
            this.lTypeVal.Name = "lTypeVal";
            this.lTypeVal.Size = new System.Drawing.Size(30, 17);
            this.lTypeVal.TabIndex = 8;
            this.lTypeVal.Text = "null";
            // 
            // lSizeVal
            // 
            this.lSizeVal.AutoSize = true;
            this.lSizeVal.Location = new System.Drawing.Point(59, 59);
            this.lSizeVal.Name = "lSizeVal";
            this.lSizeVal.Size = new System.Drawing.Size(30, 17);
            this.lSizeVal.TabIndex = 7;
            this.lSizeVal.Text = "null";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(7, 138);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(57, 17);
            this.lHeight.TabIndex = 6;
            this.lHeight.Text = "Height :";
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(7, 111);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(52, 17);
            this.lWidth.TabIndex = 5;
            this.lWidth.Text = "Width :";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(7, 85);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(48, 17);
            this.lType.TabIndex = 4;
            this.lType.Text = "Type :";
            // 
            // l_size
            // 
            this.l_size.AutoSize = true;
            this.l_size.Location = new System.Drawing.Point(7, 59);
            this.l_size.Name = "l_size";
            this.l_size.Size = new System.Drawing.Size(43, 17);
            this.l_size.TabIndex = 3;
            this.l_size.Text = "Size :";
            // 
            // lNameVal
            // 
            this.lNameVal.AutoSize = true;
            this.lNameVal.Location = new System.Drawing.Point(59, 32);
            this.lNameVal.Name = "lNameVal";
            this.lNameVal.Size = new System.Drawing.Size(30, 17);
            this.lNameVal.TabIndex = 2;
            this.lNameVal.Text = "null";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(7, 32);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(53, 17);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name :";
            // 
            // bEncryptImage
            // 
            this.bEncryptImage.Location = new System.Drawing.Point(581, 443);
            this.bEncryptImage.Name = "bEncryptImage";
            this.bEncryptImage.Size = new System.Drawing.Size(237, 53);
            this.bEncryptImage.TabIndex = 3;
            this.bEncryptImage.Text = "Encrypt Image";
            this.bEncryptImage.UseVisualStyleBackColor = true;
            this.bEncryptImage.Click += new System.EventHandler(this.bEncryptImage_Click);
            // 
            // gbSelectImage
            // 
            this.gbSelectImage.Controls.Add(this.lPathVal);
            this.gbSelectImage.Controls.Add(this.lPath);
            this.gbSelectImage.Controls.Add(this.bSelectImage);
            this.gbSelectImage.Location = new System.Drawing.Point(12, 437);
            this.gbSelectImage.Name = "gbSelectImage";
            this.gbSelectImage.Size = new System.Drawing.Size(327, 165);
            this.gbSelectImage.TabIndex = 0;
            this.gbSelectImage.TabStop = false;
            this.gbSelectImage.Text = "Select Image";
            // 
            // lPathVal
            // 
            this.lPathVal.AutoSize = true;
            this.lPathVal.Location = new System.Drawing.Point(59, 32);
            this.lPathVal.Name = "lPathVal";
            this.lPathVal.Size = new System.Drawing.Size(173, 17);
            this.lPathVal.TabIndex = 2;
            this.lPathVal.Text = "Please select any image...";
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(7, 32);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(45, 17);
            this.lPath.TabIndex = 1;
            this.lPath.Text = "Path :";
            // 
            // bSelectImage
            // 
            this.bSelectImage.Location = new System.Drawing.Point(10, 72);
            this.bSelectImage.Name = "bSelectImage";
            this.bSelectImage.Size = new System.Drawing.Size(311, 83);
            this.bSelectImage.TabIndex = 0;
            this.bSelectImage.Text = "Select Image";
            this.bSelectImage.UseVisualStyleBackColor = true;
            this.bSelectImage.Click += new System.EventHandler(this.bSelectImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 377);
            this.panel2.TabIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(830, 377);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // bSendImage
            // 
            this.bSendImage.Location = new System.Drawing.Point(581, 555);
            this.bSendImage.Name = "bSendImage";
            this.bSendImage.Size = new System.Drawing.Size(237, 47);
            this.bSendImage.TabIndex = 1;
            this.bSendImage.Text = "Send Image";
            this.bSendImage.UseVisualStyleBackColor = true;
            this.bSendImage.Click += new System.EventHandler(this.bSendImage_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "Client";
            this.Text = "Client";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbImageProperties.ResumeLayout(false);
            this.gbImageProperties.PerformLayout();
            this.gbSelectImage.ResumeLayout(false);
            this.gbSelectImage.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel slStatus;
        private System.Windows.Forms.ToolStripLabel l_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSelectImage;
        private System.Windows.Forms.Label lPathVal;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Button bSelectImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bSendImage;
        private System.Windows.Forms.Button bEncryptImage;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton sbConnect;
        private System.Windows.Forms.ToolStripTextBox stPortVal;
        private System.Windows.Forms.ToolStripLabel slPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox stIpAddressVal;
        private System.Windows.Forms.ToolStripLabel slIpAddress;
        private System.Windows.Forms.GroupBox gbImageProperties;
        private System.Windows.Forms.Label lHeightVal;
        private System.Windows.Forms.Label lWidthVal;
        private System.Windows.Forms.Label lTypeVal;
        private System.Windows.Forms.Label lSizeVal;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label l_size;
        private System.Windows.Forms.Label lNameVal;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bSaveEncryptedImage;
    }
}

