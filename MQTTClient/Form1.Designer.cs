namespace MQTTClient
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnConnet = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonX();
            this.txtClientID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtIP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtAlive = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtConnetName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbClean = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtSubTopic = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tokenEditor1 = new DevComponents.DotNetBar.Controls.TokenEditor();
            this.rbSub1 = new System.Windows.Forms.RadioButton();
            this.btnSubscribe = new DevComponents.DotNetBar.ButtonX();
            this.rbSub2 = new System.Windows.Forms.RadioButton();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.rbSub0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbRcv = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rtbPush = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtPusTopic = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rbPus1 = new System.Windows.Forms.RadioButton();
            this.rbPus2 = new System.Windows.Forms.RadioButton();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.rbPus0 = new System.Windows.Forms.RadioButton();
            this.btnSendFile = new DevComponents.DotNetBar.ButtonX();
            this.expandablePanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.expandablePanel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.btnConnet);
            this.expandablePanel1.Controls.Add(this.groupBox1);
            this.expandablePanel1.Controls.Add(this.groupBox2);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(232, 540);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke;
            this.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 6;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Connections";
            // 
            // btnConnet
            // 
            this.btnConnet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConnet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConnet.Location = new System.Drawing.Point(124, 508);
            this.btnConnet.Name = "btnConnet";
            this.btnConnet.Size = new System.Drawing.Size(88, 24);
            this.btnConnet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConnet.TabIndex = 10;
            this.btnConnet.Text = "Connect";
            this.btnConnet.Click += new System.EventHandler(this.BtnConnet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtClientID);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtAlive);
            this.groupBox1.Controls.Add(this.txtConnetName);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.cbClean);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 319);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connecction Details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnRefresh.FocusCuesEnabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("黑体", 9F);
            this.btnRefresh.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnRefresh.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.HoverImage")));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(189, 194);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(15, 15);
            this.btnRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRefresh.TabIndex = 71;
            this.btnRefresh.Tooltip = "random ID";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtClientID.Border.Class = "TextBoxBorder";
            this.txtClientID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClientID.DisabledBackColor = System.Drawing.Color.White;
            this.txtClientID.Enabled = false;
            this.txtClientID.ForeColor = System.Drawing.Color.Black;
            this.txtClientID.Location = new System.Drawing.Point(7, 190);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.PreventEnterBeep = true;
            this.txtClientID.Size = new System.Drawing.Size(175, 21);
            this.txtClientID.TabIndex = 14;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(13, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(109, 16);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Connection  Name";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(10, 221);
            this.labelX4.Name = "labelX4";
            this.labelX4.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX4.Size = new System.Drawing.Size(144, 16);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Keep  Alive(seconds)";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIP.Border.Class = "TextBoxBorder";
            this.txtIP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIP.DisabledBackColor = System.Drawing.Color.White;
            this.txtIP.ForeColor = System.Drawing.Color.Black;
            this.txtIP.Location = new System.Drawing.Point(7, 92);
            this.txtIP.Name = "txtIP";
            this.txtIP.PreventEnterBeep = true;
            this.txtIP.Size = new System.Drawing.Size(175, 21);
            this.txtIP.TabIndex = 7;
            this.txtIP.TextChanged += new System.EventHandler(this.TxtIP_TextChanged);
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIP_KeyPress);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(13, 168);
            this.labelX7.Name = "labelX7";
            this.labelX7.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX7.Size = new System.Drawing.Size(109, 16);
            this.labelX7.TabIndex = 13;
            this.labelX7.Text = "Client  ID";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(13, 119);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(109, 16);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "Port";
            // 
            // txtAlive
            // 
            this.txtAlive.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAlive.Border.Class = "TextBoxBorder";
            this.txtAlive.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAlive.DisabledBackColor = System.Drawing.Color.White;
            this.txtAlive.ForeColor = System.Drawing.Color.Black;
            this.txtAlive.Location = new System.Drawing.Point(7, 243);
            this.txtAlive.Name = "txtAlive";
            this.txtAlive.PreventEnterBeep = true;
            this.txtAlive.Size = new System.Drawing.Size(175, 21);
            this.txtAlive.TabIndex = 12;
            this.txtAlive.TextChanged += new System.EventHandler(this.TxtAlive_TextChanged);
            this.txtAlive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
            // 
            // txtConnetName
            // 
            this.txtConnetName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtConnetName.Border.Class = "TextBoxBorder";
            this.txtConnetName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtConnetName.DisabledBackColor = System.Drawing.Color.White;
            this.txtConnetName.ForeColor = System.Drawing.Color.Black;
            this.txtConnetName.Location = new System.Drawing.Point(7, 43);
            this.txtConnetName.Name = "txtConnetName";
            this.txtConnetName.PreventEnterBeep = true;
            this.txtConnetName.Size = new System.Drawing.Size(175, 21);
            this.txtConnetName.TabIndex = 5;
            this.txtConnetName.TextChanged += new System.EventHandler(this.TxtConnetName_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPort.Border.Class = "TextBoxBorder";
            this.txtPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPort.DisabledBackColor = System.Drawing.Color.White;
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.Location = new System.Drawing.Point(7, 141);
            this.txtPort.Name = "txtPort";
            this.txtPort.PreventEnterBeep = true;
            this.txtPort.Size = new System.Drawing.Size(175, 21);
            this.txtPort.TabIndex = 9;
            this.txtPort.TextChanged += new System.EventHandler(this.TxtPort_TextChanged);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(13, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX2.Size = new System.Drawing.Size(109, 16);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "IP";
            // 
            // cbClean
            // 
            this.cbClean.AutoSize = true;
            this.cbClean.Location = new System.Drawing.Point(10, 279);
            this.cbClean.Name = "cbClean";
            this.cbClean.Size = new System.Drawing.Size(102, 16);
            this.cbClean.TabIndex = 10;
            this.cbClean.Text = "Clean Session";
            this.cbClean.UseVisualStyleBackColor = true;
            this.cbClean.CheckedChanged += new System.EventHandler(this.CbClear_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Location = new System.Drawing.Point(12, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creadentials";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(7, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(175, 21);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(19, 69);
            this.labelX5.Name = "labelX5";
            this.labelX5.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX5.Size = new System.Drawing.Size(109, 16);
            this.labelX5.TabIndex = 12;
            this.labelX5.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.DisabledBackColor = System.Drawing.Color.White;
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(7, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(175, 21);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(19, 20);
            this.labelX6.Name = "labelX6";
            this.labelX6.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX6.Size = new System.Drawing.Size(109, 16);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Username";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(19, 39);
            this.labelX8.Name = "labelX8";
            this.labelX8.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX8.Size = new System.Drawing.Size(109, 16);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Topic";
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSubTopic.Border.Class = "TextBoxBorder";
            this.txtSubTopic.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSubTopic.DisabledBackColor = System.Drawing.Color.White;
            this.txtSubTopic.ForeColor = System.Drawing.Color.Black;
            this.txtSubTopic.Location = new System.Drawing.Point(13, 61);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.PreventEnterBeep = true;
            this.txtSubTopic.Size = new System.Drawing.Size(192, 21);
            this.txtSubTopic.TabIndex = 7;
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel2.Controls.Add(this.panel10);
            this.expandablePanel2.Controls.Add(this.rbSub1);
            this.expandablePanel2.Controls.Add(this.btnSubscribe);
            this.expandablePanel2.Controls.Add(this.rbSub2);
            this.expandablePanel2.Controls.Add(this.labelX9);
            this.expandablePanel2.Controls.Add(this.rbSub0);
            this.expandablePanel2.Controls.Add(this.labelX8);
            this.expandablePanel2.Controls.Add(this.txtSubTopic);
            this.expandablePanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandablePanel2.Location = new System.Drawing.Point(638, 0);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(217, 540);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 11;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Connections";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.tokenEditor1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 166);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(217, 374);
            this.panel10.TabIndex = 13;
            // 
            // tokenEditor1
            // 
            // 
            // 
            // 
            this.tokenEditor1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tokenEditor1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tokenEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tokenEditor1.EnablePopupResize = false;
            this.tokenEditor1.Location = new System.Drawing.Point(0, 0);
            this.tokenEditor1.Name = "tokenEditor1";
            this.tokenEditor1.Separators.Add(";");
            this.tokenEditor1.Separators.Add(",");
            this.tokenEditor1.Size = new System.Drawing.Size(217, 22);
            this.tokenEditor1.TabIndex = 0;
            this.tokenEditor1.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tokenEditor1.RemovingToken += new DevComponents.DotNetBar.Controls.RemovingTokenEventHandler(this.TokenEditor1_RemovingToken_1);
            // 
            // rbSub1
            // 
            this.rbSub1.AutoSize = true;
            this.rbSub1.BackColor = System.Drawing.Color.Transparent;
            this.rbSub1.Location = new System.Drawing.Point(104, 95);
            this.rbSub1.Margin = new System.Windows.Forms.Padding(5);
            this.rbSub1.Name = "rbSub1";
            this.rbSub1.Size = new System.Drawing.Size(29, 16);
            this.rbSub1.TabIndex = 11;
            this.rbSub1.TabStop = true;
            this.rbSub1.Text = "1";
            this.rbSub1.UseVisualStyleBackColor = false;
            this.rbSub1.CheckedChanged += new System.EventHandler(this.RbSub1_CheckedChanged);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubscribe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubscribe.Location = new System.Drawing.Point(78, 136);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(67, 24);
            this.btnSubscribe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubscribe.TabIndex = 12;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // rbSub2
            // 
            this.rbSub2.AutoSize = true;
            this.rbSub2.BackColor = System.Drawing.Color.Transparent;
            this.rbSub2.Location = new System.Drawing.Point(143, 96);
            this.rbSub2.Margin = new System.Windows.Forms.Padding(5);
            this.rbSub2.Name = "rbSub2";
            this.rbSub2.Size = new System.Drawing.Size(29, 16);
            this.rbSub2.TabIndex = 10;
            this.rbSub2.TabStop = true;
            this.rbSub2.Text = "2";
            this.rbSub2.UseVisualStyleBackColor = false;
            this.rbSub2.CheckedChanged += new System.EventHandler(this.RbSub2_CheckedChanged);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(19, 95);
            this.labelX9.Name = "labelX9";
            this.labelX9.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX9.Size = new System.Drawing.Size(38, 16);
            this.labelX9.TabIndex = 9;
            this.labelX9.Text = "Qos:";
            // 
            // rbSub0
            // 
            this.rbSub0.AutoSize = true;
            this.rbSub0.BackColor = System.Drawing.Color.Transparent;
            this.rbSub0.Location = new System.Drawing.Point(65, 95);
            this.rbSub0.Margin = new System.Windows.Forms.Padding(5);
            this.rbSub0.Name = "rbSub0";
            this.rbSub0.Size = new System.Drawing.Size(29, 16);
            this.rbSub0.TabIndex = 8;
            this.rbSub0.TabStop = true;
            this.rbSub0.Text = "0";
            this.rbSub0.UseVisualStyleBackColor = false;
            this.rbSub0.CheckedChanged += new System.EventHandler(this.RbSub0_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.expandablePanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 540);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbRcv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 406);
            this.panel3.TabIndex = 13;
            // 
            // rtbRcv
            // 
            // 
            // 
            // 
            this.rtbRcv.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtbRcv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtbRcv.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbRcv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRcv.Location = new System.Drawing.Point(0, 0);
            this.rtbRcv.Name = "rtbRcv";
            this.rtbRcv.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\*\\generator Msftedit 5.41.21.2510;}\\viewkind4\\uc1\\par" +
    "d\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rtbRcv.Size = new System.Drawing.Size(638, 406);
            this.rtbRcv.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 134);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 113);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rtbPush);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(543, 113);
            this.panel7.TabIndex = 1;
            // 
            // rtbPush
            // 
            // 
            // 
            // 
            this.rtbPush.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtbPush.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtbPush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPush.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbPush.Location = new System.Drawing.Point(0, 0);
            this.rtbPush.Name = "rtbPush";
            this.rtbPush.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\*\\generator Msftedit 5.41.21.2510;}\\viewkind4\\uc1\\par" +
    "d\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rtbPush.Size = new System.Drawing.Size(543, 113);
            this.rtbPush.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSend);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(543, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 113);
            this.panel6.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 113);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 21);
            this.panel4.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtPusTopic);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(438, 21);
            this.panel9.TabIndex = 1;
            // 
            // txtPusTopic
            // 
            this.txtPusTopic.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPusTopic.Border.Class = "TextBoxBorder";
            this.txtPusTopic.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPusTopic.DisabledBackColor = System.Drawing.Color.White;
            this.txtPusTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPusTopic.ForeColor = System.Drawing.Color.Black;
            this.txtPusTopic.Location = new System.Drawing.Point(0, 0);
            this.txtPusTopic.Name = "txtPusTopic";
            this.txtPusTopic.PreventEnterBeep = true;
            this.txtPusTopic.Size = new System.Drawing.Size(438, 21);
            this.txtPusTopic.TabIndex = 0;
            this.txtPusTopic.Text = "Topictest/";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSendFile);
            this.panel8.Controls.Add(this.rbPus1);
            this.panel8.Controls.Add(this.rbPus2);
            this.panel8.Controls.Add(this.labelX10);
            this.panel8.Controls.Add(this.rbPus0);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(438, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 21);
            this.panel8.TabIndex = 0;
            // 
            // rbPus1
            // 
            this.rbPus1.AutoSize = true;
            this.rbPus1.BackColor = System.Drawing.Color.Transparent;
            this.rbPus1.Location = new System.Drawing.Point(119, 2);
            this.rbPus1.Margin = new System.Windows.Forms.Padding(5);
            this.rbPus1.Name = "rbPus1";
            this.rbPus1.Size = new System.Drawing.Size(29, 16);
            this.rbPus1.TabIndex = 15;
            this.rbPus1.TabStop = true;
            this.rbPus1.Text = "1";
            this.rbPus1.UseVisualStyleBackColor = false;
            this.rbPus1.CheckedChanged += new System.EventHandler(this.RbPus1_CheckedChanged);
            // 
            // rbPus2
            // 
            this.rbPus2.AutoSize = true;
            this.rbPus2.BackColor = System.Drawing.Color.Transparent;
            this.rbPus2.Location = new System.Drawing.Point(158, 3);
            this.rbPus2.Margin = new System.Windows.Forms.Padding(5);
            this.rbPus2.Name = "rbPus2";
            this.rbPus2.Size = new System.Drawing.Size(29, 16);
            this.rbPus2.TabIndex = 14;
            this.rbPus2.TabStop = true;
            this.rbPus2.Text = "2";
            this.rbPus2.UseVisualStyleBackColor = false;
            this.rbPus2.CheckedChanged += new System.EventHandler(this.RbPus2_CheckedChanged);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX10.Location = new System.Drawing.Point(34, 2);
            this.labelX10.Name = "labelX10";
            this.labelX10.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX10.Size = new System.Drawing.Size(38, 16);
            this.labelX10.TabIndex = 13;
            this.labelX10.Text = "Qos:";
            // 
            // rbPus0
            // 
            this.rbPus0.AutoSize = true;
            this.rbPus0.BackColor = System.Drawing.Color.Transparent;
            this.rbPus0.Location = new System.Drawing.Point(80, 2);
            this.rbPus0.Margin = new System.Windows.Forms.Padding(5);
            this.rbPus0.Name = "rbPus0";
            this.rbPus0.Size = new System.Drawing.Size(29, 16);
            this.rbPus0.TabIndex = 12;
            this.rbPus0.TabStop = true;
            this.rbPus0.Text = "0";
            this.rbPus0.UseVisualStyleBackColor = false;
            this.rbPus0.CheckedChanged += new System.EventHandler(this.RbPus0_CheckedChanged);
            // 
            // btnSendFile
            // 
            this.btnSendFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSendFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSendFile.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSendFile.FocusCuesEnabled = false;
            this.btnSendFile.Font = new System.Drawing.Font("黑体", 9F);
            this.btnSendFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnSendFile.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnSendFile.HoverImage")));
            this.btnSendFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSendFile.Image")));
            this.btnSendFile.Location = new System.Drawing.Point(6, -1);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(6);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(24, 20);
            this.btnSendFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSendFile.TabIndex = 68;
            this.btnSendFile.Tooltip = "发送文件";
            this.btnSendFile.Click += new System.EventHandler(this.BtnSendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.expandablePanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MQTTClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.expandablePanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.expandablePanel2.ResumeLayout(false);
            this.expandablePanel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ButtonX btnConnet;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnRefresh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtClientID;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAlive;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.CheckBox cbClean;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPort;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIP;
        private DevComponents.DotNetBar.Controls.TextBoxX txtConnetName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSubTopic;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private System.Windows.Forms.RadioButton rbSub1;
        private DevComponents.DotNetBar.ButtonX btnSubscribe;
        private System.Windows.Forms.RadioButton rbSub2;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.RadioButton rbSub0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbPush;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPusTopic;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.ButtonX btnSend;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rbPus1;
        private System.Windows.Forms.RadioButton rbPus2;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.RadioButton rbPus0;
        private System.Windows.Forms.Panel panel10;
        private DevComponents.DotNetBar.Controls.TokenEditor tokenEditor1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRcv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX btnSendFile;
    }
}

