namespace MQTTClient
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.txtDevCRC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnDevCRC = new DevComponents.DotNetBar.ButtonX();
            this.txtDevMAC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtDevSN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtDevCRC
            // 
            this.txtDevCRC.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDevCRC.Border.Class = "TextBoxBorder";
            this.txtDevCRC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDevCRC.DisabledBackColor = System.Drawing.Color.White;
            this.txtDevCRC.ForeColor = System.Drawing.Color.Black;
            this.txtDevCRC.Location = new System.Drawing.Point(65, 89);
            this.txtDevCRC.Name = "txtDevCRC";
            this.txtDevCRC.Size = new System.Drawing.Size(46, 21);
            this.txtDevCRC.TabIndex = 45;
            this.txtDevCRC.Text = "266E";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(12, 86);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(47, 23);
            this.labelX5.TabIndex = 46;
            this.labelX5.Text = "校验:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnDevCRC
            // 
            this.btnDevCRC.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDevCRC.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDevCRC.Location = new System.Drawing.Point(127, 89);
            this.btnDevCRC.Name = "btnDevCRC";
            this.btnDevCRC.Size = new System.Drawing.Size(65, 23);
            this.btnDevCRC.TabIndex = 44;
            this.btnDevCRC.Text = "生成校验";
            this.btnDevCRC.Click += new System.EventHandler(this.BtnDevCRC_Click);
            // 
            // txtDevMAC
            // 
            this.txtDevMAC.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDevMAC.Border.Class = "TextBoxBorder";
            this.txtDevMAC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDevMAC.DisabledBackColor = System.Drawing.Color.White;
            this.txtDevMAC.ForeColor = System.Drawing.Color.Black;
            this.txtDevMAC.Location = new System.Drawing.Point(65, 54);
            this.txtDevMAC.Name = "txtDevMAC";
            this.txtDevMAC.Size = new System.Drawing.Size(127, 21);
            this.txtDevMAC.TabIndex = 42;
            this.txtDevMAC.Text = "aabbccddeeff";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(26, 51);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(33, 23);
            this.labelX3.TabIndex = 43;
            this.labelX3.Text = "MAC:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDevSN
            // 
            this.txtDevSN.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDevSN.Border.Class = "TextBoxBorder";
            this.txtDevSN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDevSN.DisabledBackColor = System.Drawing.Color.White;
            this.txtDevSN.ForeColor = System.Drawing.Color.Black;
            this.txtDevSN.Location = new System.Drawing.Point(65, 15);
            this.txtDevSN.Name = "txtDevSN";
            this.txtDevSN.Size = new System.Drawing.Size(127, 21);
            this.txtDevSN.TabIndex = 40;
            this.txtDevSN.Text = "123456789012345678";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(26, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(33, 23);
            this.labelX4.TabIndex = 41;
            this.labelX4.Text = "SN:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Location = new System.Drawing.Point(153, 137);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 23);
            this.btnNext.TabIndex = 48;
            this.btnNext.Text = "下一步";
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 172);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtDevCRC);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnDevCRC);
            this.Controls.Add(this.txtDevMAC);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtDevSN);
            this.Controls.Add(this.labelX4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtDevCRC;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnDevCRC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDevMAC;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDevSN;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnNext;
    }
}