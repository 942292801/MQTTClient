namespace MQTTClient
{
    partial class RegisterAndAuthenti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAndAuthenti));
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnRetry = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.rtbRcv = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Location = new System.Drawing.Point(350, 260);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 24);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirm.TabIndex = 55;
            this.btnConfirm.Text = "完成";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(14, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(424, 23);
            this.progressBar1.TabIndex = 56;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.White;
            this.lbInfo.ForeColor = System.Drawing.Color.Black;
            this.lbInfo.Location = new System.Drawing.Point(12, 18);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(101, 12);
            this.lbInfo.TabIndex = 57;
            this.lbInfo.Text = "正在操作，请稍后";
            // 
            // btnRetry
            // 
            this.btnRetry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRetry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRetry.Location = new System.Drawing.Point(256, 260);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(88, 24);
            this.btnRetry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRetry.TabIndex = 58;
            this.btnRetry.Text = "重试";
            this.btnRetry.Click += new System.EventHandler(this.BtnRetry_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(162, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 24);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "上一步";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // rtbRcv
            // 
            // 
            // 
            // 
            this.rtbRcv.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtbRcv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtbRcv.Enabled = false;
            this.rtbRcv.ForeColor = System.Drawing.Color.DimGray;
            this.rtbRcv.Location = new System.Drawing.Point(12, 100);
            this.rtbRcv.Name = "rtbRcv";
            this.rtbRcv.Rtf = resources.GetString("rtbRcv.Rtf");
            this.rtbRcv.Size = new System.Drawing.Size(426, 154);
            this.rtbRcv.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "操作信息：";
            // 
            // RegisterAndAuthenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbRcv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnConfirm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterAndAuthenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterAndAuthenti";
            this.Load += new System.EventHandler(this.RegisterAndAuthenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevComponents.DotNetBar.ButtonX btnRetry;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbRcv;
    }
}