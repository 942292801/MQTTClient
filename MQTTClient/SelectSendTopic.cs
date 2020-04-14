using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTTClient
{
    public partial class SelectSendTopic  : MetroForm
    {
        public SelectSendTopic()
        {
            InitializeComponent();
        }

        public event Action<string> SelectTopic;

        internal DoMain.ResourceDTO ResourceDTO { get; set; }

        private bool isServer = false;

        public bool IsServer { get => isServer; set => isServer = value; }

        private void SelectSendTopic_Load(object sender, EventArgs e)
        {
            if (IsServer)
            {
                //管理服务器订阅
                foreach (string certid in ResourceDTO.certids)
                {
                    lbSubTopic.Items.Add(string.Format("{0}/{1}/S2C/{2}/DATA", ResourceDTO.username, ResourceDTO.channel, certid.Substring(certid.Length-16,16)));
                }
                lbSubTopic.Items.Add(string.Format("{0}/{1}/S2C/{2}/DATA", ResourceDTO.username, ResourceDTO.channel, ResourceDTO.certid.Substring(ResourceDTO.certid.Length-16,16)));
                lbSubTopic.Items.Add(string.Format("{0}/{1}/S2C/{2}/STATUS", ResourceDTO.username, ResourceDTO.channel, ResourceDTO.certid.Substring(ResourceDTO.certid.Length - 16, 16)));
            }
            else
            {
                //从设备网关订阅
                lbSubTopic.Items.Add(string.Format("{0}/{1}/C2S/{2}/DATA", ResourceDTO.username, ResourceDTO.channel,ResourceDTO.certid.Substring(ResourceDTO.certid.Length - 16, 16)));
                lbSubTopic.Items.Add(string.Format("{0}/{1}/C2S/{2}/STATUS", ResourceDTO.username, ResourceDTO.channel, ResourceDTO.certid.Substring(ResourceDTO.certid.Length - 16, 16)));
            }
        }


        #region listBox的鼠标停留背景改变
        /// <summary>
        /// 鼠标停留 橙色背景层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbSubTopic_DataItemVisualCreated(object sender, DevComponents.DotNetBar.DataItemVisualEventArgs e)
        {
            
            ListBoxItem item = (ListBoxItem)e.Visual;
            item.HotTracking = true;
        }

        #endregion

        private void SelectSendTopic_Deactivate(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void LbSubTopic_ItemClick(object sender, EventArgs e)
        {
            SelectTopic(lbSubTopic.SelectedItem.ToString());
            this.Close();
        }
    }
}
