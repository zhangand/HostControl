namespace ChatClient
{
    partial class FTClient
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.gbxServerSetup = new System.Windows.Forms.GroupBox();
            this.btnDisConnectToServer = new System.Windows.Forms.Button();
            this.labelManualCommand = new System.Windows.Forms.Label();
            this.gbxCommand = new System.Windows.Forms.GroupBox();
            this.nupSetEraseNum = new System.Windows.Forms.NumericUpDown();
            this.nupSetSample = new System.Windows.Forms.NumericUpDown();
            this.cboSetPattern = new System.Windows.Forms.ComboBox();
            this.cboSetAlg = new System.Windows.Forms.ComboBox();
            this.btnSetAlg = new System.Windows.Forms.Button();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.btnGetTestStart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSetEraseNum = new System.Windows.Forms.Button();
            this.btnSetBlockMaxETime = new System.Windows.Forms.Button();
            this.btnSetSample = new System.Windows.Forms.Button();
            this.btnSetPattern = new System.Windows.Forms.Button();
            this.btnSetBlockNum = new System.Windows.Forms.Button();
            this.btnSetZone = new System.Windows.Forms.Button();
            this.btnGetChipID = new System.Windows.Forms.Button();
            this.btnSetVcc = new System.Windows.Forms.Button();
            this.btnTestInit = new System.Windows.Forms.Button();
            this.btnResetBoard = new System.Windows.Forms.Button();
            this.gbxSiteSelect = new System.Windows.Forms.GroupBox();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAutoRun = new System.Windows.Forms.Button();
            this.gbxServerSetup.SuspendLayout();
            this.gbxCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSetEraseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSetSample)).BeginInit();
            this.gbxSiteSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMsg
            // 
            this.txtCMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMsg.Location = new System.Drawing.Point(571, 510);
            this.txtCMsg.Margin = new System.Windows.Forms.Padding(5);
            this.txtCMsg.Multiline = true;
            this.txtCMsg.Name = "txtCMsg";
            this.txtCMsg.Size = new System.Drawing.Size(204, 29);
            this.txtCMsg.TabIndex = 40;
            this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
            // 
            // btnCSend
            // 
            this.btnCSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSend.Location = new System.Drawing.Point(795, 510);
            this.btnCSend.Margin = new System.Windows.Forms.Padding(5);
            this.btnCSend.Name = "btnCSend";
            this.btnCSend.Size = new System.Drawing.Size(110, 30);
            this.btnCSend.TabIndex = 38;
            this.btnCSend.Text = "Send";
            this.btnCSend.UseVisualStyleBackColor = true;
            this.btnCSend.Click += new System.EventHandler(this.btnCSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(400, 60);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(5);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(650, 220);
            this.txtMsg.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Communication Log:";
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(20, 194);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(120, 30);
            this.btnConnectToServer.TabIndex = 36;
            this.btnConnectToServer.Text = "Connect";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "IP: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port: ";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(86, 50);
            this.txtIP.Margin = new System.Windows.Forms.Padding(5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(195, 30);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.0.101";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(86, 115);
            this.txtPort.Margin = new System.Windows.Forms.Padding(5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(195, 30);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "30";
            // 
            // gbxServerSetup
            // 
            this.gbxServerSetup.Controls.Add(this.txtPort);
            this.gbxServerSetup.Controls.Add(this.txtIP);
            this.gbxServerSetup.Controls.Add(this.label6);
            this.gbxServerSetup.Controls.Add(this.label5);
            this.gbxServerSetup.Controls.Add(this.btnDisConnectToServer);
            this.gbxServerSetup.Controls.Add(this.btnConnectToServer);
            this.gbxServerSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxServerSetup.Location = new System.Drawing.Point(50, 30);
            this.gbxServerSetup.Margin = new System.Windows.Forms.Padding(5);
            this.gbxServerSetup.Name = "gbxServerSetup";
            this.gbxServerSetup.Padding = new System.Windows.Forms.Padding(5);
            this.gbxServerSetup.Size = new System.Drawing.Size(300, 250);
            this.gbxServerSetup.TabIndex = 49;
            this.gbxServerSetup.TabStop = false;
            this.gbxServerSetup.Text = "Server Setup:";
            // 
            // btnDisConnectToServer
            // 
            this.btnDisConnectToServer.Location = new System.Drawing.Point(161, 193);
            this.btnDisConnectToServer.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisConnectToServer.Name = "btnDisConnectToServer";
            this.btnDisConnectToServer.Size = new System.Drawing.Size(120, 30);
            this.btnDisConnectToServer.TabIndex = 36;
            this.btnDisConnectToServer.Text = "Disconnect";
            this.btnDisConnectToServer.UseVisualStyleBackColor = true;
            this.btnDisConnectToServer.Click += new System.EventHandler(this.btnDisConnectToServer_Click);
            // 
            // labelManualCommand
            // 
            this.labelManualCommand.AutoSize = true;
            this.labelManualCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManualCommand.Location = new System.Drawing.Point(412, 515);
            this.labelManualCommand.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelManualCommand.Name = "labelManualCommand";
            this.labelManualCommand.Size = new System.Drawing.Size(149, 20);
            this.labelManualCommand.TabIndex = 42;
            this.labelManualCommand.Text = "Manual Command:";
            // 
            // gbxCommand
            // 
            this.gbxCommand.Controls.Add(this.nupSetEraseNum);
            this.gbxCommand.Controls.Add(this.nupSetSample);
            this.gbxCommand.Controls.Add(this.cboSetPattern);
            this.gbxCommand.Controls.Add(this.cboSetAlg);
            this.gbxCommand.Controls.Add(this.btnSetAlg);
            this.gbxCommand.Controls.Add(this.btnGetResult);
            this.gbxCommand.Controls.Add(this.btnGetTestStart);
            this.gbxCommand.Controls.Add(this.btnStart);
            this.gbxCommand.Controls.Add(this.btnSetEraseNum);
            this.gbxCommand.Controls.Add(this.btnSetBlockMaxETime);
            this.gbxCommand.Controls.Add(this.btnSetSample);
            this.gbxCommand.Controls.Add(this.btnSetPattern);
            this.gbxCommand.Controls.Add(this.btnSetBlockNum);
            this.gbxCommand.Controls.Add(this.btnSetZone);
            this.gbxCommand.Controls.Add(this.btnGetChipID);
            this.gbxCommand.Controls.Add(this.btnSetVcc);
            this.gbxCommand.Controls.Add(this.btnTestInit);
            this.gbxCommand.Controls.Add(this.btnResetBoard);
            this.gbxCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCommand.Location = new System.Drawing.Point(400, 305);
            this.gbxCommand.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCommand.Name = "gbxCommand";
            this.gbxCommand.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCommand.Size = new System.Drawing.Size(650, 200);
            this.gbxCommand.TabIndex = 51;
            this.gbxCommand.TabStop = false;
            this.gbxCommand.Text = "Command";
            // 
            // nupSetEraseNum
            // 
            this.nupSetEraseNum.Location = new System.Drawing.Point(515, 121);
            this.nupSetEraseNum.Name = "nupSetEraseNum";
            this.nupSetEraseNum.Size = new System.Drawing.Size(110, 27);
            this.nupSetEraseNum.TabIndex = 64;
            // 
            // nupSetSample
            // 
            this.nupSetSample.Location = new System.Drawing.Point(275, 121);
            this.nupSetSample.Name = "nupSetSample";
            this.nupSetSample.Size = new System.Drawing.Size(110, 27);
            this.nupSetSample.TabIndex = 64;
            // 
            // cboSetPattern
            // 
            this.cboSetPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSetPattern.FormattingEnabled = true;
            this.cboSetPattern.Items.AddRange(new object[] {
            "set-pattern:1",
            "set-pattern:4",
            "set-pattern:6",
            "set-pattern:8",
            "set-pattern:11",
            "set-pattern:13",
            "set-pattern:16"});
            this.cboSetPattern.Location = new System.Drawing.Point(35, 121);
            this.cboSetPattern.Name = "cboSetPattern";
            this.cboSetPattern.Size = new System.Drawing.Size(110, 24);
            this.cboSetPattern.TabIndex = 63;
            this.cboSetPattern.Text = "set-pattern:1";
            // 
            // cboSetAlg
            // 
            this.cboSetAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSetAlg.FormattingEnabled = true;
            this.cboSetAlg.Items.AddRange(new object[] {
            "set-alg:1",
            "set-alg:2",
            "set-alg:3",
            "set-alg:4",
            "set-alg:5",
            "set-alg:6",
            "set-alg:11",
            "set-alg:12",
            "set-alg:13",
            "set-alg:14",
            "set-alg:15",
            "set-alg:16",
            "set-alg:17",
            "set-alg:18",
            "set-alg:19",
            "set-alg:20",
            "set-alg:21",
            "set-alg:22"});
            this.cboSetAlg.Location = new System.Drawing.Point(155, 121);
            this.cboSetAlg.Name = "cboSetAlg";
            this.cboSetAlg.Size = new System.Drawing.Size(110, 24);
            this.cboSetAlg.TabIndex = 53;
            this.cboSetAlg.Text = "set-alg:1";
            // 
            // btnSetAlg
            // 
            this.btnSetAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlg.Location = new System.Drawing.Point(155, 80);
            this.btnSetAlg.Name = "btnSetAlg";
            this.btnSetAlg.Size = new System.Drawing.Size(110, 25);
            this.btnSetAlg.TabIndex = 52;
            this.btnSetAlg.Text = "SetAlg";
            this.btnSetAlg.UseVisualStyleBackColor = true;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetResult.Location = new System.Drawing.Point(515, 160);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(110, 25);
            this.btnGetResult.TabIndex = 55;
            this.btnGetResult.Text = "GetResult";
            this.btnGetResult.UseVisualStyleBackColor = true;
            // 
            // btnGetTestStart
            // 
            this.btnGetTestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTestStart.Location = new System.Drawing.Point(395, 160);
            this.btnGetTestStart.Name = "btnGetTestStart";
            this.btnGetTestStart.Size = new System.Drawing.Size(110, 25);
            this.btnGetTestStart.TabIndex = 54;
            this.btnGetTestStart.Text = "GetTestStart";
            this.btnGetTestStart.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(275, 160);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 25);
            this.btnStart.TabIndex = 53;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSetEraseNum
            // 
            this.btnSetEraseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetEraseNum.Location = new System.Drawing.Point(515, 80);
            this.btnSetEraseNum.Name = "btnSetEraseNum";
            this.btnSetEraseNum.Size = new System.Drawing.Size(110, 25);
            this.btnSetEraseNum.TabIndex = 50;
            this.btnSetEraseNum.Text = "SetEraseNum";
            this.btnSetEraseNum.UseVisualStyleBackColor = true;
            // 
            // btnSetBlockMaxETime
            // 
            this.btnSetBlockMaxETime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBlockMaxETime.Location = new System.Drawing.Point(155, 160);
            this.btnSetBlockMaxETime.Name = "btnSetBlockMaxETime";
            this.btnSetBlockMaxETime.Size = new System.Drawing.Size(110, 25);
            this.btnSetBlockMaxETime.TabIndex = 51;
            this.btnSetBlockMaxETime.Text = "SetMaxETime";
            this.btnSetBlockMaxETime.UseVisualStyleBackColor = true;
            // 
            // btnSetSample
            // 
            this.btnSetSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSample.Location = new System.Drawing.Point(275, 80);
            this.btnSetSample.Name = "btnSetSample";
            this.btnSetSample.Size = new System.Drawing.Size(110, 25);
            this.btnSetSample.TabIndex = 49;
            this.btnSetSample.Text = "SetSample";
            this.btnSetSample.UseVisualStyleBackColor = true;
            // 
            // btnSetPattern
            // 
            this.btnSetPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPattern.Location = new System.Drawing.Point(35, 80);
            this.btnSetPattern.Name = "btnSetPattern";
            this.btnSetPattern.Size = new System.Drawing.Size(110, 25);
            this.btnSetPattern.TabIndex = 48;
            this.btnSetPattern.Text = "SetPattern";
            this.btnSetPattern.UseVisualStyleBackColor = true;
            // 
            // btnSetBlockNum
            // 
            this.btnSetBlockNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBlockNum.Location = new System.Drawing.Point(35, 160);
            this.btnSetBlockNum.Name = "btnSetBlockNum";
            this.btnSetBlockNum.Size = new System.Drawing.Size(110, 25);
            this.btnSetBlockNum.TabIndex = 47;
            this.btnSetBlockNum.Text = "SetBlockNum";
            this.btnSetBlockNum.UseVisualStyleBackColor = true;
            // 
            // btnSetZone
            // 
            this.btnSetZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetZone.Location = new System.Drawing.Point(515, 40);
            this.btnSetZone.Name = "btnSetZone";
            this.btnSetZone.Size = new System.Drawing.Size(110, 25);
            this.btnSetZone.TabIndex = 46;
            this.btnSetZone.Text = "SetZone";
            this.btnSetZone.UseVisualStyleBackColor = true;
            // 
            // btnGetChipID
            // 
            this.btnGetChipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetChipID.Location = new System.Drawing.Point(395, 40);
            this.btnGetChipID.Name = "btnGetChipID";
            this.btnGetChipID.Size = new System.Drawing.Size(110, 25);
            this.btnGetChipID.TabIndex = 46;
            this.btnGetChipID.Text = "GetChipID";
            this.btnGetChipID.UseVisualStyleBackColor = true;
            // 
            // btnSetVcc
            // 
            this.btnSetVcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetVcc.Location = new System.Drawing.Point(275, 40);
            this.btnSetVcc.Name = "btnSetVcc";
            this.btnSetVcc.Size = new System.Drawing.Size(110, 25);
            this.btnSetVcc.TabIndex = 45;
            this.btnSetVcc.Text = "SetVccVolt";
            this.btnSetVcc.UseVisualStyleBackColor = true;
            this.btnSetVcc.Click += new System.EventHandler(this.btnSetVcc_Click);
            // 
            // btnTestInit
            // 
            this.btnTestInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestInit.Location = new System.Drawing.Point(155, 40);
            this.btnTestInit.Name = "btnTestInit";
            this.btnTestInit.Size = new System.Drawing.Size(110, 25);
            this.btnTestInit.TabIndex = 44;
            this.btnTestInit.Text = "TestInit";
            this.btnTestInit.UseVisualStyleBackColor = true;
            this.btnTestInit.Click += new System.EventHandler(this.btnTestInit_Click);
            // 
            // btnResetBoard
            // 
            this.btnResetBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBoard.Location = new System.Drawing.Point(35, 40);
            this.btnResetBoard.Name = "btnResetBoard";
            this.btnResetBoard.Size = new System.Drawing.Size(110, 25);
            this.btnResetBoard.TabIndex = 43;
            this.btnResetBoard.Text = "ResetBoard";
            this.btnResetBoard.UseVisualStyleBackColor = true;
            this.btnResetBoard.Click += new System.EventHandler(this.ResetBoard_Click);
            // 
            // gbxSiteSelect
            // 
            this.gbxSiteSelect.Controls.Add(this.btnAllOff);
            this.gbxSiteSelect.Controls.Add(this.btnAllOn);
            this.gbxSiteSelect.Controls.Add(this.listBox1);
            this.gbxSiteSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSiteSelect.Location = new System.Drawing.Point(50, 290);
            this.gbxSiteSelect.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSiteSelect.Name = "gbxSiteSelect";
            this.gbxSiteSelect.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSiteSelect.Size = new System.Drawing.Size(300, 260);
            this.gbxSiteSelect.TabIndex = 52;
            this.gbxSiteSelect.TabStop = false;
            this.gbxSiteSelect.Text = "Site Selector";
            // 
            // btnAllOff
            // 
            this.btnAllOff.Location = new System.Drawing.Point(161, 210);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(120, 30);
            this.btnAllOff.TabIndex = 2;
            this.btnAllOff.Text = "All Off";
            this.btnAllOff.UseVisualStyleBackColor = true;
            this.btnAllOff.Click += new System.EventHandler(this.AllOff_Click);
            // 
            // btnAllOn
            // 
            this.btnAllOn.Location = new System.Drawing.Point(20, 210);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(120, 30);
            this.btnAllOn.TabIndex = 1;
            this.btnAllOn.Text = "All On";
            this.btnAllOn.UseVisualStyleBackColor = true;
            this.btnAllOn.Click += new System.EventHandler(this.AllOn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ColumnWidth = 120;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Site 0",
            "Site 1",
            "Site 2",
            "Site 3",
            "Site 4",
            "Site 5",
            "Site 6",
            "Site 7",
            "Site 8",
            "Site 9",
            "Site 10",
            "Site 11",
            "Site 12",
            "Site 13",
            "Site 14",
            "Site 15"});
            this.listBox1.Location = new System.Drawing.Point(20, 25);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(260, 162);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoRun.Location = new System.Drawing.Point(915, 510);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(110, 30);
            this.btnAutoRun.TabIndex = 62;
            this.btnAutoRun.Text = "AutoRun";
            this.btnAutoRun.UseVisualStyleBackColor = true;
            // 
            // FTClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 574);
            this.Controls.Add(this.gbxCommand);
            this.Controls.Add(this.gbxSiteSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxServerSetup);
            this.Controls.Add(this.btnAutoRun);
            this.Controls.Add(this.btnCSend);
            this.Controls.Add(this.txtCMsg);
            this.Controls.Add(this.labelManualCommand);
            this.Controls.Add(this.txtMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FTClient";
            this.Text = "Flash Testing Client";
            this.gbxServerSetup.ResumeLayout(false);
            this.gbxServerSetup.PerformLayout();
            this.gbxCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupSetEraseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSetSample)).EndInit();
            this.gbxSiteSelect.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox gbxServerSetup;
        private System.Windows.Forms.Label labelManualCommand;
        private System.Windows.Forms.Button btnDisConnectToServer;
        private System.Windows.Forms.GroupBox gbxCommand;
        private System.Windows.Forms.GroupBox gbxSiteSelect;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.Button btnAllOn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAutoRun;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Button btnGetTestStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetEraseNum;
        private System.Windows.Forms.Button btnSetBlockMaxETime;
        private System.Windows.Forms.Button btnSetSample;
        private System.Windows.Forms.Button btnSetBlockNum;
        private System.Windows.Forms.Button btnSetZone;
        private System.Windows.Forms.Button btnGetChipID;
        private System.Windows.Forms.Button btnSetVcc;
        private System.Windows.Forms.Button btnTestInit;
        private System.Windows.Forms.Button btnResetBoard;
        private System.Windows.Forms.ComboBox cboSetAlg;
        private System.Windows.Forms.NumericUpDown nupSetEraseNum;
        private System.Windows.Forms.NumericUpDown nupSetSample;
        private System.Windows.Forms.ComboBox cboSetPattern;
        private System.Windows.Forms.Button btnSetAlg;
        private System.Windows.Forms.Button btnSetPattern;
    }
}

