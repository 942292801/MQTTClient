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
    public partial class StartForm : MetroForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            string crc = crc16(txtDevSN.Text, txtDevMAC.Text);
            if (string.IsNullOrEmpty(crc))
            {
                return;
            }
            if (crc != txtDevCRC.Text)
            {
                MessageBox.Show("校验值错误！");
                //crc校验不通过
                return;
            }
            RegisterAndAuthenti registerAndAuthenti = new RegisterAndAuthenti();
            this.Hide();
            registerAndAuthenti.CertId = txtDevSN.Text + txtDevMAC.Text + txtDevCRC.Text;
            registerAndAuthenti.ShowDialog();
            Application.ExitThread();

        }

        private void BtnDevCRC_Click(object sender, EventArgs e)
        {
            txtDevCRC.Text = crc16(txtDevSN.Text, txtDevMAC.Text);
        }

        /// <summary>
        /// 产生crc校验
        /// </summary>
        /// <param name="sn"></param>
        /// <param name="mac"></param>
        /// <param name="isMaster">是否为主服务器</param>
        /// <returns></returns>
        private string crc16(string sn, string mac)
        {
            try
            {
                if (string.IsNullOrEmpty(sn) || string.IsNullOrEmpty(mac))
                {
                    MessageBox.Show("sn 或 mac 不能为空");
                    return null;
                }
                if (txtDevSN.Text.Length != 16 && txtDevSN.Text.Length != 18)
                {
                    MessageBox.Show("sn 值错误");
                    return null;
                }
                if ( txtDevMAC.Text.Length != 12)
                {
                    MessageBox.Show("mac 值错误");
                    return null;
                }
                return CRC16Helper.CRC16(sn + mac);

            }
            catch
            {
                return null;
            }

        }


    }
}
