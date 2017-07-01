namespace ChatClient
{
    partial class FClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCMsg = new System.Windows.Forms.TextBox();
            this.btnCSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMsg
            // 
            this.txtCMsg.Location = new System.Drawing.Point(591, 271);
            this.txtCMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMsg.Multiline = true;
            this.txtCMsg.Name = "txtCMsg";
            this.txtCMsg.Size = new System.Drawing.Size(249, 24);
            this.txtCMsg.TabIndex = 40;
            this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
            // 
            // btnCSend
            // 
            this.btnCSend.Location = new System.Drawing.Point(848, 267);
            this.btnCSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnCSend.Name = "btnCSend";
            this.btnCSend.Size = new System.Drawing.Size(56, 31);
            this.btnCSend.TabIndex = 38;
            this.btnCSend.Text = "Send";
            this.btnCSend.UseVisualStyleBackColor = true;
            this.btnCSend.Click += new System.EventHandler(this.btnCSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(461, 64);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(443, 119);
            this.txtMsg.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Communication Log:";
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(50, 150);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(100, 30);
            this.btnConnectToServer.TabIndex = 36;
            this.btnConnectToServer.Text = "Connect";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "IP: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port: ";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(75, 40);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(99, 30);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.0.6";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(804, 317);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "关闭客户端";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(75, 90);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 30);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "6666";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnConnectToServer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(200, 200);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Setup:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Manual Command:";
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCMsg);
            this.Controls.Add(this.btnCSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FClient";
            this.Text = "客户端";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMsg;
        private System.Windows.Forms.Button btnCSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}

