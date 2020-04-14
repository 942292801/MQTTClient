using DevComponents.DotNetBar.Metro;
using Newtonsoft.Json;
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
    public partial class RegisterAndAuthenti : MetroForm
    {

        //地址端口
        private string registerAddress = "47.107.165.103:39393";

        private string authentiAddress = "47.107.165.103:38383";

        private string contentType = "application/json";

        //返回的资源
        DoMain.ResourceDTO resourceDTO;

        bool isServer = false;

        private string certId = string.Empty;

        public string CertId { get => certId; set => certId = value; }

        public RegisterAndAuthenti()
        {
            InitializeComponent();
        }

        private void RegisterAndAuthenti_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            btnRetry.Enabled = false;
            btnCancel.Enabled = false;
            // btnConfirm.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        #region 信息显示
        private void showMsg(string msg)
        {
            this.rtbRcv.SelectionColor = Color.Red;
            rtbRcv.AppendText(DateTime.Now.ToString());

            this.rtbRcv.SelectionColor = Color.DarkGray;
            rtbRcv.AppendText(msg+"\r\n");
            this.rtbRcv.ScrollToCaret();
        }
        #endregion


        #region 申请资源流程 和 进度条 
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //网络回应
                string respone = string.Empty;
                string url = string.Empty;
                DoMain.BaseResult baseResult = null;
                //检查文件夹中是否存在这个CERTID的证书
                string ca = Tools.GetAppConfig(certId);
                if (string.IsNullOrEmpty(ca))
                {
                    
                    //获取register公钥
                    respone = ApiHelper.HttpGet("http://" + registerAddress + "/request/publickey", contentType);
                    baseResult = JsonConvert.DeserializeObject<DoMain.BaseResult>(respone);
                    if (baseResult.status != 200)
                    {
                        backgroundWorker1.ReportProgress(25, baseResult);
                        return;
                    }
                    backgroundWorker1.ReportProgress(25, new DoMain.BaseResult(200, "成功获取注册服务器的公钥") );
                    string registerPublickey = JsonConvert.DeserializeObject<DoMain.OutParamRSA>(baseResult.data.ToString()).publicKey;
                    //加密发送CERTID申请
                    if (certId.Length == 34)
                    {
                        url = "http://" + registerAddress + "/applyca/server?";
                    }
                    else
                    {
                        url = "http://" + registerAddress + "/applyca/device?";
                    }
                    string enCertId = RSAhelper.RsaEncrypt(certId, RSAKeyConverter.RSAPublicKeyJava2DotNet( registerPublickey));
                    string registerPostData = string.Format("certid={0}&publickey={1}", enCertId, RSAKeyConverter.RSAPublicKeyDotNet2Java(Tools.GetAppConfig("xmlPublicKeys")) );
                    //post 请求
                    respone = ApiHelper.Post(url, registerPostData);
                    baseResult = JsonConvert.DeserializeObject<DoMain.BaseResult>(respone);
                    backgroundWorker1.ReportProgress(50, baseResult);
                    if (baseResult.status != 200)
                    {
                        return;
                    }
                    ca = RSAhelper.RsaDecrypt(baseResult.data.ToString(), Tools.GetAppConfig("xmlPrivateKeys"));
                    Tools.UpdateAppConfig(certId, ca);
          

                }
                else
                {
                    //文件夹获取
                    backgroundWorker1.ReportProgress(50,new DoMain.BaseResult(200,"使用本地存储的数字证书！"));
                }

                //认证获取资源 
                //获取authenti公钥
                respone = ApiHelper.HttpGet("http://" + authentiAddress + "/request/publickey", contentType);
                baseResult = JsonConvert.DeserializeObject<DoMain.BaseResult>(respone);
                if (baseResult.status != 200)
                {
                    backgroundWorker1.ReportProgress(75, baseResult);
                    return;
                }
                backgroundWorker1.ReportProgress(75, new DoMain.BaseResult(200, "成功获取认证服务器的公钥"));
                string authentiPublickey = JsonConvert.DeserializeObject<DoMain.OutParamRSA>(baseResult.data.ToString()).publicKey;

                if (ca.Split('&')[0].Split('=')[1].Length == 34)
                {
                    url = "http://" + authentiAddress + "/authenti/server?";
                    isServer = true;
                }
                else
                {
                    url = "http://" + authentiAddress + "/authenti/device?";
                    isServer = false;
                }

                string enCA = RSAhelper.RsaEncrypt(ca, RSAKeyConverter.RSAPublicKeyJava2DotNet(authentiPublickey));
                string authentiPostData = string.Format("ca={0}&publickey={1}", enCA, RSAKeyConverter.RSAPublicKeyDotNet2Java(Tools.GetAppConfig("xmlPublicKeys")));
                //post 请求
                respone = ApiHelper.Post(url, authentiPostData);
                baseResult = JsonConvert.DeserializeObject<DoMain.BaseResult>(respone);
                if (baseResult.status == 500)
                {
                    backgroundWorker1.ReportProgress(100, baseResult);
                    return;
                }
                baseResult.status = 201;
                backgroundWorker1.ReportProgress(100, baseResult);
                string data = RSAhelper.RsaDecrypt(baseResult.data.ToString(), Tools.GetAppConfig("xmlPrivateKeys"));
                resourceDTO = JsonConvert.DeserializeObject<DoMain.ResourceDTO>(data);
            }
            catch (Exception ex)
            {
                backgroundWorker1.ReportProgress(100, new DoMain.BaseResult(500,"发生错误："+ ex.Message));
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //报告进度条
            progressBar1.Value = e.ProgressPercentage;
            DoMain.BaseResult baseResult =(DoMain.BaseResult)e.UserState;
            if (baseResult.status == 200)
            {
                
                errorProvider1.Clear();
            }
            else if (baseResult.status == 201)
            {
                btnConfirm.Enabled = true;
                btnRetry.Enabled = false;
                btnCancel.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {
                btnConfirm.Enabled = false;
                btnRetry.Enabled = true;
                btnCancel.Enabled = true;
                errorProvider1.SetError(lbInfo, baseResult.message);
            }
            lbInfo.Text = baseResult.message;
            showMsg(baseResult.message);


        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //完成
          
        }
        #endregion

        /// <summary>
        /// 完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            
            //完成
            MqttForm mqttForm = new MqttForm();
            this.Hide();
            mqttForm.ResourceDTO = resourceDTO;
            mqttForm.IsServer = isServer;
            mqttForm.ShowDialog();
            Application.ExitThread();
        }


        /// <summary>
        /// 重试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRetry_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            btnRetry.Enabled = false;
            btnCancel.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //上一步
            StartForm mqttForm = new StartForm();
            this.Hide();
            mqttForm.ShowDialog();
            Application.ExitThread();
        }
    }
}
