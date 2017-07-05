namespace FTClient
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
            this.chkSetFast1 = new System.Windows.Forms.CheckBox();
            this.chkSetFast = new System.Windows.Forms.CheckBox();
            this.chkSet4Byte = new System.Windows.Forms.CheckBox();
            this.chkSetAlg = new System.Windows.Forms.CheckBox();
            this.chkSetMaxETime = new System.Windows.Forms.CheckBox();
            this.chkSetEraseNum = new System.Windows.Forms.CheckBox();
            this.chkSetBlackNum = new System.Windows.Forms.CheckBox();
            this.chkSetSample = new System.Windows.Forms.CheckBox();
            this.chkSetClock = new System.Windows.Forms.CheckBox();
            this.nudSetMaxETime = new System.Windows.Forms.NumericUpDown();
            this.txtSetSample = new System.Windows.Forms.TextBox();
            this.nudSetAlg = new System.Windows.Forms.NumericUpDown();
            this.nudSetPattern = new System.Windows.Forms.NumericUpDown();
            this.nudSetBlockNumHigh = new System.Windows.Forms.NumericUpDown();
            this.nudSetBlockNumLow = new System.Windows.Forms.NumericUpDown();
            this.nudSetEraseNum = new System.Windows.Forms.NumericUpDown();
            this.nudSetClock = new System.Windows.Forms.NumericUpDown();
            this.nudSetVioVolt = new System.Windows.Forms.NumericUpDown();
            this.nudSetVccVolt = new System.Windows.Forms.NumericUpDown();
            this.btnSetFast1 = new System.Windows.Forms.Button();
            this.btnSetFast = new System.Windows.Forms.Button();
            this.btnSet4Byte = new System.Windows.Forms.Button();
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
            this.btnSetClock = new System.Windows.Forms.Button();
            this.btnSetVioVolt = new System.Windows.Forms.Button();
            this.btnSetVcc = new System.Windows.Forms.Button();
            this.btnTestInit = new System.Windows.Forms.Button();
            this.btnResetBoard = new System.Windows.Forms.Button();
            this.gbxSiteSelect = new System.Windows.Forms.GroupBox();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gbxServerSetup.SuspendLayout();
            this.gbxCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetMaxETime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetAlg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetBlockNumHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetBlockNumLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetEraseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetVioVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetVccVolt)).BeginInit();
            this.gbxSiteSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCMsg
            // 
            this.txtCMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMsg.Location = new System.Drawing.Point(486, 501);
            this.txtCMsg.Margin = new System.Windows.Forms.Padding(5);
            this.txtCMsg.Multiline = true;
            this.txtCMsg.Name = "txtCMsg";
            this.txtCMsg.Size = new System.Drawing.Size(274, 29);
            this.txtCMsg.TabIndex = 40;
            this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
            // 
            // btnCSend
            // 
            this.btnCSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSend.Location = new System.Drawing.Point(820, 500);
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
            this.txtMsg.Location = new System.Drawing.Point(50, 559);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(5);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(900, 220);
            this.txtMsg.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 534);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Communication Log:";
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Location = new System.Drawing.Point(20, 174);
            this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(5);
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
            this.txtIP.Size = new System.Drawing.Size(161, 30);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.0.101";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(86, 115);
            this.txtPort.Margin = new System.Windows.Forms.Padding(5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(161, 30);
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
            this.gbxServerSetup.Size = new System.Drawing.Size(260, 227);
            this.gbxServerSetup.TabIndex = 49;
            this.gbxServerSetup.TabStop = false;
            this.gbxServerSetup.Text = "Server Setup:";
            // 
            // btnDisConnectToServer
            // 
            this.btnDisConnectToServer.Location = new System.Drawing.Point(142, 174);
            this.btnDisConnectToServer.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisConnectToServer.Name = "btnDisConnectToServer";
            this.btnDisConnectToServer.Size = new System.Drawing.Size(105, 30);
            this.btnDisConnectToServer.TabIndex = 36;
            this.btnDisConnectToServer.Text = "Disconnect";
            this.btnDisConnectToServer.UseVisualStyleBackColor = true;
            this.btnDisConnectToServer.Click += new System.EventHandler(this.btnDisConnectToServer_Click);
            // 
            // labelManualCommand
            // 
            this.labelManualCommand.AutoSize = true;
            this.labelManualCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManualCommand.Location = new System.Drawing.Point(327, 506);
            this.labelManualCommand.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelManualCommand.Name = "labelManualCommand";
            this.labelManualCommand.Size = new System.Drawing.Size(149, 20);
            this.labelManualCommand.TabIndex = 42;
            this.labelManualCommand.Text = "Manual Command:";
            // 
            // gbxCommand
            // 
            this.gbxCommand.Controls.Add(this.chkSetFast1);
            this.gbxCommand.Controls.Add(this.chkSetFast);
            this.gbxCommand.Controls.Add(this.chkSet4Byte);
            this.gbxCommand.Controls.Add(this.chkSetAlg);
            this.gbxCommand.Controls.Add(this.chkSetMaxETime);
            this.gbxCommand.Controls.Add(this.chkSetEraseNum);
            this.gbxCommand.Controls.Add(this.chkSetBlackNum);
            this.gbxCommand.Controls.Add(this.chkSetSample);
            this.gbxCommand.Controls.Add(this.chkSetClock);
            this.gbxCommand.Controls.Add(this.nudSetMaxETime);
            this.gbxCommand.Controls.Add(this.txtSetSample);
            this.gbxCommand.Controls.Add(this.nudSetAlg);
            this.gbxCommand.Controls.Add(this.nudSetPattern);
            this.gbxCommand.Controls.Add(this.nudSetBlockNumHigh);
            this.gbxCommand.Controls.Add(this.nudSetBlockNumLow);
            this.gbxCommand.Controls.Add(this.nudSetEraseNum);
            this.gbxCommand.Controls.Add(this.nudSetClock);
            this.gbxCommand.Controls.Add(this.nudSetVioVolt);
            this.gbxCommand.Controls.Add(this.nudSetVccVolt);
            this.gbxCommand.Controls.Add(this.btnSetFast1);
            this.gbxCommand.Controls.Add(this.btnSetFast);
            this.gbxCommand.Controls.Add(this.btnSet4Byte);
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
            this.gbxCommand.Controls.Add(this.btnSetClock);
            this.gbxCommand.Controls.Add(this.btnSetVioVolt);
            this.gbxCommand.Controls.Add(this.btnSetVcc);
            this.gbxCommand.Controls.Add(this.btnTestInit);
            this.gbxCommand.Controls.Add(this.btnResetBoard);
            this.gbxCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCommand.Location = new System.Drawing.Point(320, 30);
            this.gbxCommand.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCommand.Name = "gbxCommand";
            this.gbxCommand.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCommand.Size = new System.Drawing.Size(630, 460);
            this.gbxCommand.TabIndex = 51;
            this.gbxCommand.TabStop = false;
            this.gbxCommand.Text = "Command";
            // 
            // chkSetFast1
            // 
            this.chkSetFast1.AutoSize = true;
            this.chkSetFast1.Location = new System.Drawing.Point(305, 404);
            this.chkSetFast1.Name = "chkSetFast1";
            this.chkSetFast1.Size = new System.Drawing.Size(18, 17);
            this.chkSetFast1.TabIndex = 65;
            this.chkSetFast1.UseVisualStyleBackColor = true;
            // 
            // chkSetFast
            // 
            this.chkSetFast.AutoSize = true;
            this.chkSetFast.Location = new System.Drawing.Point(305, 364);
            this.chkSetFast.Name = "chkSetFast";
            this.chkSetFast.Size = new System.Drawing.Size(18, 17);
            this.chkSetFast.TabIndex = 65;
            this.chkSetFast.UseVisualStyleBackColor = true;
            // 
            // chkSet4Byte
            // 
            this.chkSet4Byte.AutoSize = true;
            this.chkSet4Byte.Location = new System.Drawing.Point(305, 324);
            this.chkSet4Byte.Name = "chkSet4Byte";
            this.chkSet4Byte.Size = new System.Drawing.Size(18, 17);
            this.chkSet4Byte.TabIndex = 65;
            this.chkSet4Byte.UseVisualStyleBackColor = true;
            // 
            // chkSetAlg
            // 
            this.chkSetAlg.AutoSize = true;
            this.chkSetAlg.Location = new System.Drawing.Point(305, 284);
            this.chkSetAlg.Name = "chkSetAlg";
            this.chkSetAlg.Size = new System.Drawing.Size(18, 17);
            this.chkSetAlg.TabIndex = 65;
            this.chkSetAlg.UseVisualStyleBackColor = true;
            // 
            // chkSetMaxETime
            // 
            this.chkSetMaxETime.AutoSize = true;
            this.chkSetMaxETime.Location = new System.Drawing.Point(305, 243);
            this.chkSetMaxETime.Name = "chkSetMaxETime";
            this.chkSetMaxETime.Size = new System.Drawing.Size(18, 17);
            this.chkSetMaxETime.TabIndex = 65;
            this.chkSetMaxETime.UseVisualStyleBackColor = true;
            // 
            // chkSetEraseNum
            // 
            this.chkSetEraseNum.AutoSize = true;
            this.chkSetEraseNum.Location = new System.Drawing.Point(305, 203);
            this.chkSetEraseNum.Name = "chkSetEraseNum";
            this.chkSetEraseNum.Size = new System.Drawing.Size(18, 17);
            this.chkSetEraseNum.TabIndex = 65;
            this.chkSetEraseNum.UseVisualStyleBackColor = true;
            // 
            // chkSetBlackNum
            // 
            this.chkSetBlackNum.AutoSize = true;
            this.chkSetBlackNum.Location = new System.Drawing.Point(305, 163);
            this.chkSetBlackNum.Name = "chkSetBlackNum";
            this.chkSetBlackNum.Size = new System.Drawing.Size(18, 17);
            this.chkSetBlackNum.TabIndex = 65;
            this.chkSetBlackNum.UseVisualStyleBackColor = true;
            // 
            // chkSetSample
            // 
            this.chkSetSample.AutoSize = true;
            this.chkSetSample.Location = new System.Drawing.Point(305, 123);
            this.chkSetSample.Name = "chkSetSample";
            this.chkSetSample.Size = new System.Drawing.Size(18, 17);
            this.chkSetSample.TabIndex = 65;
            this.chkSetSample.UseVisualStyleBackColor = true;
            // 
            // chkSetClock
            // 
            this.chkSetClock.AutoSize = true;
            this.chkSetClock.Location = new System.Drawing.Point(20, 203);
            this.chkSetClock.Name = "chkSetClock";
            this.chkSetClock.Size = new System.Drawing.Size(18, 17);
            this.chkSetClock.TabIndex = 65;
            this.chkSetClock.UseVisualStyleBackColor = true;
            // 
            // nudSetMaxETime
            // 
            this.nudSetMaxETime.Location = new System.Drawing.Point(450, 238);
            this.nudSetMaxETime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSetMaxETime.Name = "nudSetMaxETime";
            this.nudSetMaxETime.Size = new System.Drawing.Size(110, 27);
            this.nudSetMaxETime.TabIndex = 64;
            this.nudSetMaxETime.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // txtSetSample
            // 
            this.txtSetSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetSample.Location = new System.Drawing.Point(450, 122);
            this.txtSetSample.Margin = new System.Windows.Forms.Padding(5);
            this.txtSetSample.Multiline = true;
            this.txtSetSample.Name = "txtSetSample";
            this.txtSetSample.Size = new System.Drawing.Size(160, 25);
            this.txtSetSample.TabIndex = 40;
            this.txtSetSample.Text = "1,3,5,7,9,11,13,15,17,19,21";
            this.txtSetSample.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
            // 
            // nudSetAlg
            // 
            this.nudSetAlg.Location = new System.Drawing.Point(450, 278);
            this.nudSetAlg.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSetAlg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetAlg.Name = "nudSetAlg";
            this.nudSetAlg.Size = new System.Drawing.Size(110, 27);
            this.nudSetAlg.TabIndex = 64;
            this.nudSetAlg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSetPattern
            // 
            this.nudSetPattern.Location = new System.Drawing.Point(450, 78);
            this.nudSetPattern.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSetPattern.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetPattern.Name = "nudSetPattern";
            this.nudSetPattern.Size = new System.Drawing.Size(110, 27);
            this.nudSetPattern.TabIndex = 64;
            this.nudSetPattern.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSetBlockNumHigh
            // 
            this.nudSetBlockNumHigh.Location = new System.Drawing.Point(550, 158);
            this.nudSetBlockNumHigh.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSetBlockNumHigh.Name = "nudSetBlockNumHigh";
            this.nudSetBlockNumHigh.Size = new System.Drawing.Size(60, 27);
            this.nudSetBlockNumHigh.TabIndex = 64;
            this.nudSetBlockNumHigh.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // nudSetBlockNumLow
            // 
            this.nudSetBlockNumLow.Location = new System.Drawing.Point(450, 158);
            this.nudSetBlockNumLow.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSetBlockNumLow.Name = "nudSetBlockNumLow";
            this.nudSetBlockNumLow.Size = new System.Drawing.Size(60, 27);
            this.nudSetBlockNumLow.TabIndex = 64;
            // 
            // nudSetEraseNum
            // 
            this.nudSetEraseNum.Location = new System.Drawing.Point(450, 198);
            this.nudSetEraseNum.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSetEraseNum.Name = "nudSetEraseNum";
            this.nudSetEraseNum.Size = new System.Drawing.Size(110, 27);
            this.nudSetEraseNum.TabIndex = 64;
            // 
            // nudSetClock
            // 
            this.nudSetClock.Location = new System.Drawing.Point(166, 198);
            this.nudSetClock.Name = "nudSetClock";
            this.nudSetClock.Size = new System.Drawing.Size(110, 27);
            this.nudSetClock.TabIndex = 64;
            this.nudSetClock.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudSetVioVolt
            // 
            this.nudSetVioVolt.Location = new System.Drawing.Point(166, 158);
            this.nudSetVioVolt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSetVioVolt.Name = "nudSetVioVolt";
            this.nudSetVioVolt.Size = new System.Drawing.Size(110, 27);
            this.nudSetVioVolt.TabIndex = 64;
            this.nudSetVioVolt.Value = new decimal(new int[] {
            3300,
            0,
            0,
            0});
            // 
            // nudSetVccVolt
            // 
            this.nudSetVccVolt.Location = new System.Drawing.Point(166, 118);
            this.nudSetVccVolt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSetVccVolt.Name = "nudSetVccVolt";
            this.nudSetVccVolt.Size = new System.Drawing.Size(110, 27);
            this.nudSetVccVolt.TabIndex = 64;
            this.nudSetVccVolt.Value = new decimal(new int[] {
            3300,
            0,
            0,
            0});
            // 
            // btnSetFast1
            // 
            this.btnSetFast1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFast1.Location = new System.Drawing.Point(330, 400);
            this.btnSetFast1.Name = "btnSetFast1";
            this.btnSetFast1.Size = new System.Drawing.Size(110, 25);
            this.btnSetFast1.TabIndex = 52;
            this.btnSetFast1.Text = "SetFast1";
            this.btnSetFast1.UseVisualStyleBackColor = true;
            this.btnSetFast1.Click += new System.EventHandler(this.btnSetFast1_Click);
            // 
            // btnSetFast
            // 
            this.btnSetFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFast.Location = new System.Drawing.Point(330, 360);
            this.btnSetFast.Name = "btnSetFast";
            this.btnSetFast.Size = new System.Drawing.Size(110, 25);
            this.btnSetFast.TabIndex = 52;
            this.btnSetFast.Text = "SetFast";
            this.btnSetFast.UseVisualStyleBackColor = true;
            this.btnSetFast.Click += new System.EventHandler(this.btnSetFast_Click);
            // 
            // btnSet4Byte
            // 
            this.btnSet4Byte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet4Byte.Location = new System.Drawing.Point(330, 320);
            this.btnSet4Byte.Name = "btnSet4Byte";
            this.btnSet4Byte.Size = new System.Drawing.Size(110, 25);
            this.btnSet4Byte.TabIndex = 52;
            this.btnSet4Byte.Text = "Set-4Byte";
            this.btnSet4Byte.UseVisualStyleBackColor = true;
            this.btnSet4Byte.Click += new System.EventHandler(this.btnSet4Byte_Click);
            // 
            // btnSetAlg
            // 
            this.btnSetAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlg.Location = new System.Drawing.Point(330, 280);
            this.btnSetAlg.Name = "btnSetAlg";
            this.btnSetAlg.Size = new System.Drawing.Size(110, 25);
            this.btnSetAlg.TabIndex = 52;
            this.btnSetAlg.Text = "SetAlg";
            this.btnSetAlg.UseVisualStyleBackColor = true;
            this.btnSetAlg.Click += new System.EventHandler(this.btnSetAlg_Click);
            // 
            // btnGetResult
            // 
            this.btnGetResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetResult.Location = new System.Drawing.Point(45, 400);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(110, 25);
            this.btnGetResult.TabIndex = 55;
            this.btnGetResult.Text = "GetResult";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // btnGetTestStart
            // 
            this.btnGetTestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTestStart.Location = new System.Drawing.Point(45, 360);
            this.btnGetTestStart.Name = "btnGetTestStart";
            this.btnGetTestStart.Size = new System.Drawing.Size(110, 25);
            this.btnGetTestStart.TabIndex = 54;
            this.btnGetTestStart.Text = "GetTestStart";
            this.btnGetTestStart.UseVisualStyleBackColor = true;
            this.btnGetTestStart.Click += new System.EventHandler(this.btnGetTestStart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(45, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 25);
            this.btnStart.TabIndex = 53;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSetEraseNum
            // 
            this.btnSetEraseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetEraseNum.Location = new System.Drawing.Point(330, 200);
            this.btnSetEraseNum.Name = "btnSetEraseNum";
            this.btnSetEraseNum.Size = new System.Drawing.Size(110, 25);
            this.btnSetEraseNum.TabIndex = 50;
            this.btnSetEraseNum.Text = "SetEraseNum";
            this.btnSetEraseNum.UseVisualStyleBackColor = true;
            this.btnSetEraseNum.Click += new System.EventHandler(this.btnSetEraseNum_Click);
            // 
            // btnSetBlockMaxETime
            // 
            this.btnSetBlockMaxETime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBlockMaxETime.Location = new System.Drawing.Point(330, 240);
            this.btnSetBlockMaxETime.Name = "btnSetBlockMaxETime";
            this.btnSetBlockMaxETime.Size = new System.Drawing.Size(110, 25);
            this.btnSetBlockMaxETime.TabIndex = 51;
            this.btnSetBlockMaxETime.Text = "SetMaxETime";
            this.btnSetBlockMaxETime.UseVisualStyleBackColor = true;
            this.btnSetBlockMaxETime.Click += new System.EventHandler(this.btnSetBlockMaxETime_Click);
            // 
            // btnSetSample
            // 
            this.btnSetSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSample.Location = new System.Drawing.Point(330, 120);
            this.btnSetSample.Name = "btnSetSample";
            this.btnSetSample.Size = new System.Drawing.Size(110, 25);
            this.btnSetSample.TabIndex = 49;
            this.btnSetSample.Text = "SetSample";
            this.btnSetSample.UseVisualStyleBackColor = true;
            this.btnSetSample.Click += new System.EventHandler(this.btnSetSample_Click);
            // 
            // btnSetPattern
            // 
            this.btnSetPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPattern.Location = new System.Drawing.Point(330, 80);
            this.btnSetPattern.Name = "btnSetPattern";
            this.btnSetPattern.Size = new System.Drawing.Size(110, 25);
            this.btnSetPattern.TabIndex = 48;
            this.btnSetPattern.Text = "SetPattern";
            this.btnSetPattern.UseVisualStyleBackColor = true;
            this.btnSetPattern.Click += new System.EventHandler(this.btnSetPattern_Click);
            // 
            // btnSetBlockNum
            // 
            this.btnSetBlockNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBlockNum.Location = new System.Drawing.Point(330, 160);
            this.btnSetBlockNum.Name = "btnSetBlockNum";
            this.btnSetBlockNum.Size = new System.Drawing.Size(110, 25);
            this.btnSetBlockNum.TabIndex = 47;
            this.btnSetBlockNum.Text = "SetBlockNum";
            this.btnSetBlockNum.UseVisualStyleBackColor = true;
            this.btnSetBlockNum.Click += new System.EventHandler(this.btnSetBlockNum_Click);
            // 
            // btnSetZone
            // 
            this.btnSetZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetZone.Location = new System.Drawing.Point(330, 40);
            this.btnSetZone.Name = "btnSetZone";
            this.btnSetZone.Size = new System.Drawing.Size(110, 25);
            this.btnSetZone.TabIndex = 46;
            this.btnSetZone.Text = "SetZone";
            this.btnSetZone.UseVisualStyleBackColor = true;
            this.btnSetZone.Click += new System.EventHandler(this.btnSetZone_Click);
            // 
            // btnGetChipID
            // 
            this.btnGetChipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetChipID.Location = new System.Drawing.Point(45, 240);
            this.btnGetChipID.Name = "btnGetChipID";
            this.btnGetChipID.Size = new System.Drawing.Size(110, 25);
            this.btnGetChipID.TabIndex = 46;
            this.btnGetChipID.Text = "GetChipID";
            this.btnGetChipID.UseVisualStyleBackColor = true;
            this.btnGetChipID.Click += new System.EventHandler(this.btnGetChipID_Click);
            // 
            // btnSetClock
            // 
            this.btnSetClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetClock.Location = new System.Drawing.Point(45, 200);
            this.btnSetClock.Name = "btnSetClock";
            this.btnSetClock.Size = new System.Drawing.Size(110, 25);
            this.btnSetClock.TabIndex = 45;
            this.btnSetClock.Text = "SetClock";
            this.btnSetClock.UseVisualStyleBackColor = true;
            this.btnSetClock.Click += new System.EventHandler(this.btnSetClock_Click);
            // 
            // btnSetVioVolt
            // 
            this.btnSetVioVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetVioVolt.Location = new System.Drawing.Point(45, 160);
            this.btnSetVioVolt.Name = "btnSetVioVolt";
            this.btnSetVioVolt.Size = new System.Drawing.Size(110, 25);
            this.btnSetVioVolt.TabIndex = 45;
            this.btnSetVioVolt.Text = "SetVioVolt";
            this.btnSetVioVolt.UseVisualStyleBackColor = true;
            this.btnSetVioVolt.Click += new System.EventHandler(this.btnSetVio_Click);
            // 
            // btnSetVcc
            // 
            this.btnSetVcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetVcc.Location = new System.Drawing.Point(45, 120);
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
            this.btnTestInit.Location = new System.Drawing.Point(45, 80);
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
            this.btnResetBoard.Location = new System.Drawing.Point(45, 40);
            this.btnResetBoard.Name = "btnResetBoard";
            this.btnResetBoard.Size = new System.Drawing.Size(110, 25);
            this.btnResetBoard.TabIndex = 43;
            this.btnResetBoard.Text = "ResetBoard";
            this.btnResetBoard.UseVisualStyleBackColor = true;
            this.btnResetBoard.Click += new System.EventHandler(this.ResetBoard_Click);
            // 
            // gbxSiteSelect
            // 
            this.gbxSiteSelect.Controls.Add(this.checkedListBox1);
            this.gbxSiteSelect.Controls.Add(this.btnAllOff);
            this.gbxSiteSelect.Controls.Add(this.btnAllOn);
            this.gbxSiteSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSiteSelect.Location = new System.Drawing.Point(50, 270);
            this.gbxSiteSelect.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSiteSelect.Name = "gbxSiteSelect";
            this.gbxSiteSelect.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSiteSelect.Size = new System.Drawing.Size(260, 260);
            this.gbxSiteSelect.TabIndex = 52;
            this.gbxSiteSelect.TabStop = false;
            this.gbxSiteSelect.Text = "Site Selector";
            // 
            // btnAllOff
            // 
            this.btnAllOff.Location = new System.Drawing.Point(142, 215);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(105, 30);
            this.btnAllOff.TabIndex = 2;
            this.btnAllOff.Text = "All Off";
            this.btnAllOff.UseVisualStyleBackColor = true;
            this.btnAllOff.Click += new System.EventHandler(this.AllOff_Click);
            // 
            // btnAllOn
            // 
            this.btnAllOn.Location = new System.Drawing.Point(20, 215);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(100, 30);
            this.btnAllOn.TabIndex = 1;
            this.btnAllOn.Text = "All On";
            this.btnAllOn.UseVisualStyleBackColor = true;
            this.btnAllOn.Click += new System.EventHandler(this.AllOn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 100;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
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
            this.checkedListBox1.Location = new System.Drawing.Point(20, 28);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(227, 180);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // FTClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 807);
            this.Controls.Add(this.gbxCommand);
            this.Controls.Add(this.gbxSiteSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxServerSetup);
            this.Controls.Add(this.btnCSend);
            this.Controls.Add(this.txtCMsg);
            this.Controls.Add(this.labelManualCommand);
            this.Controls.Add(this.txtMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FTClient";
            this.Text = "Flash Testing Client";
            this.gbxServerSetup.ResumeLayout(false);
            this.gbxServerSetup.PerformLayout();
            this.gbxCommand.ResumeLayout(false);
            this.gbxCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetMaxETime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetAlg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetPattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetBlockNumHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetBlockNumLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetEraseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetVioVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetVccVolt)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudSetEraseNum;
        private System.Windows.Forms.Button btnSetAlg;
        private System.Windows.Forms.Button btnSetPattern;
        private System.Windows.Forms.NumericUpDown nudSetVccVolt;
        private System.Windows.Forms.NumericUpDown nudSetVioVolt;
        private System.Windows.Forms.Button btnSetVioVolt;
        private System.Windows.Forms.NumericUpDown nudSetClock;
        private System.Windows.Forms.Button btnSetClock;
        private System.Windows.Forms.NumericUpDown nudSetMaxETime;
        private System.Windows.Forms.CheckBox chkSetClock;
        private System.Windows.Forms.Button btnSetFast1;
        private System.Windows.Forms.Button btnSetFast;
        private System.Windows.Forms.Button btnSet4Byte;
        private System.Windows.Forms.CheckBox chkSetSample;
        private System.Windows.Forms.CheckBox chkSetEraseNum;
        private System.Windows.Forms.CheckBox chkSetBlackNum;
        private System.Windows.Forms.TextBox txtSetSample;
        private System.Windows.Forms.NumericUpDown nudSetBlockNumLow;
        private System.Windows.Forms.CheckBox chkSetFast1;
        private System.Windows.Forms.CheckBox chkSetFast;
        private System.Windows.Forms.CheckBox chkSet4Byte;
        private System.Windows.Forms.CheckBox chkSetAlg;
        private System.Windows.Forms.CheckBox chkSetMaxETime;
        private System.Windows.Forms.NumericUpDown nudSetAlg;
        private System.Windows.Forms.NumericUpDown nudSetPattern;
        private System.Windows.Forms.NumericUpDown nudSetBlockNumHigh;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

