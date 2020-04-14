namespace MQTTClient
{
    partial class SelectSendTopic
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
            this.lbSubTopic = new DevComponents.DotNetBar.ListBoxAdv();
            this.SuspendLayout();
            // 
            // lbSubTopic
            // 
            this.lbSubTopic.AutoScroll = true;
            // 
            // 
            // 
            this.lbSubTopic.BackgroundStyle.Class = "ListBoxAdv";
            this.lbSubTopic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSubTopic.CheckStateMember = null;
            this.lbSubTopic.ContainerControlProcessDialogKey = true;
            this.lbSubTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubTopic.DragDropSupport = true;
            this.lbSubTopic.Location = new System.Drawing.Point(0, 0);
            this.lbSubTopic.Name = "lbSubTopic";
            this.lbSubTopic.Size = new System.Drawing.Size(348, 310);
            this.lbSubTopic.TabIndex = 16;
            this.lbSubTopic.Text = "listBoxAdv3";
            this.lbSubTopic.DataItemVisualCreated += new DevComponents.DotNetBar.DataItemVisualEventHandler(this.LbSubTopic_DataItemVisualCreated);
            this.lbSubTopic.ItemClick += new System.EventHandler(this.LbSubTopic_ItemClick);
            // 
            // SelectSendTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 310);
            this.Controls.Add(this.lbSubTopic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectSendTopic";
            this.Text = "SelectSendTopic";
            this.Deactivate += new System.EventHandler(this.SelectSendTopic_Deactivate);
            this.Load += new System.EventHandler(this.SelectSendTopic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ListBoxAdv lbSubTopic;
    }
}