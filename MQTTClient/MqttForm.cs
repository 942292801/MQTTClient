using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Client.Receiving;
using MQTTnet.Protocol;
using Newtonsoft.Json;

namespace MQTTClient
{
    public partial class MqttForm : MetroForm
    {
        public MqttForm()
        {
            InitializeComponent();
        }

        #region MQTT变量名称
        //Mqtt资源
        internal DoMain.ResourceDTO ResourceDTO { get; set; }
        bool isServer = false;
        public bool IsServer { get => isServer; set => isServer = value; }

       

        private static MqttClient mqttClient = null;
        private static IMqttClientOptions options = null;



        public static bool isCleanSession = true;

        /// <summary>
        /// 保留
        /// </summary>
        public static bool Retained = false;
        /// <summary>
        /// 服务质量
        /// <para>0 - 至多一次</para>
        /// <para>1 - 至少一次</para>
        /// <para>2 - 刚好一次</para>
        /// </summary>
        public static int QualityOfServiceLevel = 0;

        public static int sendQos =0;

        public static Dictionary<string, int> topicDir;

        public static string PrivateKeys = "";
        public static string PublicKeys = "";


        public event Action<string> receviceDelegate;
        public event Action<bool> isConnectDelegate;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            tokenEditor1.EditTextBox.KeyPress += EditTextBox_KeyPress;
            receviceDelegate = new Action<string>(showMsg);
            isConnectDelegate = new Action<bool>(Form1_isConnectDelegete);
            //SaveFileDelegate = new Func<bool>(Form1_SaveFileDelegate);
            Ini();
            
        }

        #region 回调初始化
        private bool Form1_SaveFileDelegate()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择保存路径";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 连接和断开连接 回调
        /// </summary>
        /// <param name="isConnect"></param>
        private void Form1_isConnectDelegete(bool isConnect)
        {
            if (isConnect)
            {
                btnConnet.Text = "DisConnect";
                //推送上线状态
                //Publish("status","onLine",0,true);

            }
            else
            {
                btnConnet.Text = "Connect";
            }
        }
        #endregion


        #region 控件初始化  
        /// <summary>
        /// 控件 信息内容 初始化
        /// </summary>
        private void Ini()
        {

            rbPus0.Checked = true;
            rbSub0.Checked = true;
            //刷新登录ID
            BtnRefresh_Click(btnRefresh,EventArgs.Empty);
            PrivateKeys = Tools.GetAppConfig("xmlPrivateKeys");
            PublicKeys = Tools.GetAppConfig("xmlPublicKeys");
            txtConnetName.Text = Tools.GetAppConfig("ConnetName");
            txtIP.Text = Tools.GetAppConfig("IP");
            txtPort.Text = Tools.GetAppConfig("Port");
            txtAlive.Text = Tools.GetAppConfig("Alive");

            txtUserName.Text = ResourceDTO.username;
            txtPassword.Text = ResourceDTO.passwword;

            if (Tools.GetAppConfig("CleanSession").Equals("0"))
            {
                cbClean.Checked = false;
            }
            else
            {
                cbClean.Checked = true;
            }

            GetTopic();
        }

        /// <summary>
        /// 划分管理服务器和从设备网关的订阅主题
        /// </summary>
        private void GetTopic()
        {
            topicDir = new Dictionary<string, int>();

            if (IsServer)
            {
                //获取管理服务器订阅主题信息
                topicDir.Add(string.Format("{0}/{1}/C2S/#", ResourceDTO.username, ResourceDTO.channel), 1);
                
            }
            else
            {
                string heart = string.Format("{0}/{1}/S2C", ResourceDTO.username, ResourceDTO.channel);
                //获取从设备订阅主题信息
                foreach (string item in ResourceDTO.certids)
                {
                    topicDir.Add(string.Format("{0}/{1}/#",heart,item.Substring(item.Length-16,16)), 0);
                }
                topicDir.Add(string.Format("{0}/{1}/#", heart, ResourceDTO.certid.Substring(ResourceDTO.certid.Length-16,16)), 1);
            }
            AddSubTpoic();
        }

        /// <summary>
        /// 添加主题名到 显示框
        /// </summary>
        private void AddSubTpoic()
        {
            try
            {
                /*原来的添加到tokenEditor1里面的代码
                 * tokenEditor1.SelectedTokens.Clear();
                DevComponents.DotNetBar.Controls.EditToken editToken = null;

                foreach (KeyValuePair<string, int> kvp in topicDir)
                {
                    editToken = new DevComponents.DotNetBar.Controls.EditToken(string.Format("{0} QOS:{1}", kvp.Key, kvp.Value));
                    tokenEditor1.SelectedTokens.Add(editToken);
                    Console.WriteLine("Connected >>Subscribe " + kvp.Key);
                }*/
                foreach (KeyValuePair<string, int> kvp in topicDir)
                {
                    lbSubTopic.Items.Add(string.Format("{0} QOS:{1}", kvp.Key, kvp.Value));
                    Console.WriteLine("Connected >>Subscribe " + kvp.Key);
                }
                



            }
            catch { }
        }

        #endregion.

        #region 限制输入
        private void EditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        #endregion

        #region 保存信息到config
        private void TxtConnetName_TextChanged(object sender, EventArgs e)
        {
            Tools.UpdateAppConfig("ConnetName", txtConnetName.Text);
        }

        private void TxtIP_TextChanged(object sender, EventArgs e)
        {
            Tools.UpdateAppConfig("IP", txtIP.Text);
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            Tools.UpdateAppConfig("Port", txtPort.Text);
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtClientID.Text = string.Format("mqttyc_{0}", Tools.Str(16));
            Tools.UpdateAppConfig("ClientID", txtClientID.Text);
        }

        private void TxtAlive_TextChanged(object sender, EventArgs e)
        {
            Tools.UpdateAppConfig("Alive", txtAlive.Text);
        }

        private void CbClear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClean.Checked)
            {
                Tools.UpdateAppConfig("CleanSession", "1");
                isCleanSession = true;
            }
            else
            {
                Tools.UpdateAppConfig("CleanSession", "0");
                isCleanSession = false;
            }
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            //Tools.UpdateAppConfig("UserName", txtUserName.Text);
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            //Tools.UpdateAppConfig("Password", txtPassword.Text);
        }


        private void RbSub0_CheckedChanged(object sender, EventArgs e)
        {
            QualityOfServiceLevel = 0;
        }

        private void RbSub1_CheckedChanged(object sender, EventArgs e)
        {
            QualityOfServiceLevel = 1;
        }

        private void RbSub2_CheckedChanged(object sender, EventArgs e)
        {
            QualityOfServiceLevel = 2;
        }

        private void RbPus0_CheckedChanged(object sender, EventArgs e)
        {
            sendQos = 0;
        }

        private void RbPus1_CheckedChanged(object sender, EventArgs e)
        {
            sendQos = 1;
        }

        private void RbPus2_CheckedChanged(object sender, EventArgs e)
        {
            sendQos = 2;
        }

        private void CbRetain_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClean.Checked)
            {
                //Tools.UpdateAppConfig("CleanSession", "1");
                Retained = true;
            }
            else
            {
                //Tools.UpdateAppConfig("CleanSession", "0");
                Retained = false;
            }
        }

        #endregion

        #region 信息显示 清除
        private void showMsg(string msg)
        {
            this.rtbRcv.SelectionColor = Color.Red;
            rtbRcv.AppendText(DateTime.Now.ToString()+"\r\n");

            this.rtbRcv.SelectionColor = Color.Black;
            rtbRcv.AppendText(string.Format("{0}\r\n\r\n", msg));
            this.rtbRcv.ScrollToCaret();
        }


        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbRcv.Clear();
        }
        #endregion

        #region 限制输入
        private void TxtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
     
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)46 && e.KeyChar != (char)3 && e.KeyChar != (char)22)
            {
                e.Handled = true;
            }
        }

        private void TxtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)3 && e.KeyChar != (char)22)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 其他设置 刷新和显示公私钥
        private void ButtonX1_Click(object sender, EventArgs e)
        {
            //产生公钥和私钥
            RSAhelper rSAhelper = new RSAhelper();
            rSAhelper.RSAKey(out PrivateKeys, out PublicKeys);
            Tools.UpdateAppConfig("xmlPrivateKeys", PrivateKeys);
            Tools.UpdateAppConfig("xmlPublicKeys", PublicKeys);
            showMsg("Public Key>>" + RSAKeyConverter.RSAPublicKeyDotNet2Java(PublicKeys));
            showMsg("Private Key>>" + RSAKeyConverter.RSAPrivateKeyDotNet2Java(PrivateKeys));
        }

        private void BtnGetPublicKey_Click(object sender, EventArgs e)
        {
            showMsg("Public Key>>" + RSAKeyConverter.RSAPublicKeyDotNet2Java(PublicKeys));
            showMsg("Private Key>>" + RSAKeyConverter.RSAPrivateKeyDotNet2Java(PrivateKeys));
        }
        #endregion


        #region listBox停留特效 
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


        #region 主题发送选择
        private void TxtPusTopic_Click(object sender, EventArgs e)
        {
            SelectSendTopic selectSendTopic = new SelectSendTopic();
            Point pt = MousePosition;
            //把窗口向屏幕中间刷新
            selectSendTopic.StartPosition = FormStartPosition.Manual;
            selectSendTopic.Left = pt.X + 10;
            if (pt.Y + 310 > Screen.PrimaryScreen.WorkingArea.Height)
            {
                selectSendTopic.Top = pt.Y - 310;

            }
            else
            {
                selectSendTopic.Top = pt.Y + 10;

            }
            selectSendTopic.SelectTopic += new Action<string>(TopicSelect);
            selectSendTopic.ResourceDTO = ResourceDTO;
            selectSendTopic.IsServer = IsServer;
            //把窗口向屏幕中间刷新
            selectSendTopic.Show();
        }


        private void TopicSelect(string tmp)
        {
            txtPusTopic.Text = tmp;
        }
        #endregion


        #region MQTT初始化 连接 断开
        /// <summary>
        /// 链接mqtt服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnet_Click(object sender, EventArgs e)
        {
            if (mqttClient == null || !mqttClient.IsConnected)
            {
                
                start();
            }
            else
            {
                stop();


            }
            
        }

        private string RcvFileName = "";
        private long RcvFileLength = 0;
        private long RcvFileLengthTmp = 0;
        private int RcvFileBagCount = 0;
        private int RcvFileBagCountTmp = 0;

       
   

        //private FileStream saveStream = null;
        [STAThreadAttribute]
        private void start()
        {
            try
            {
                MqttApplicationMessage mqttApplicationMessage = new MqttApplicationMessage();
                mqttApplicationMessage.Retain = true;
                mqttApplicationMessage.Topic = "will";
                mqttApplicationMessage.Payload = System.Text.Encoding.UTF8.GetBytes("offLine");

                var factory = new MqttFactory();
                mqttClient = factory.CreateMqttClient() as MqttClient;
                options = new MqttClientOptionsBuilder()
                    .WithTcpServer(txtIP.Text, Convert.ToInt32(txtPort.Text))
                    .WithCredentials(txtUserName.Text, txtPassword.Text)
                    .WithClientId(txtClientID.Text)
                    .WithCleanSession(isCleanSession)
                    .WithKeepAlivePeriod(TimeSpan.FromSeconds(Convert.ToDouble(txtAlive.Text)))
                    .WithWillMessage(mqttApplicationMessage)
                    .Build();

                mqttClient.ConnectAsync(options);
                
                mqttClient.UseConnectedHandler(async ea =>
                {
                    try
                    {

                        List<TopicFilter> listTopic = new List<TopicFilter>();
                        //6.通过KeyValuePair遍历元素
                        foreach (KeyValuePair<string, int> kvp in topicDir)
                        {
                            var topicFilterBulder = new TopicFilterBuilder().WithTopic(kvp.Key).WithQualityOfServiceLevel((MqttQualityOfServiceLevel)Enum.ToObject(typeof(MqttQualityOfServiceLevel), kvp.Value)).Build();
                            listTopic.Add(topicFilterBulder);
                            Console.WriteLine("Connected >>Subscribe " + kvp.Key);
                        }
                        if (listTopic.Count() > 0)
                        {
                            await mqttClient.SubscribeAsync(listTopic.ToArray());
                        }
                        

                        Invoke(isConnectDelegate, true);


                    }
                    catch (Exception exp)
                    {

                        Console.WriteLine(exp.Message);
                    }
                });

                mqttClient.UseDisconnectedHandler(ea =>
                {
                    try
                    {
                        //Invoke(receviceDelegate, "Disconnected >>Disconnected Server");
                        Invoke(isConnectDelegate, false);
                        //await Task.Delay(TimeSpan.FromSeconds(10));
                        /*try
                        {
                            await mqttClient.ConnectAsync(options);
                        }
                        catch (Exception exp)
                        {

                            Console.WriteLine("Disconnected >>Exception " + exp.Message);
                        }*/
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                });

                mqttClient.UseApplicationMessageReceivedHandler(ea =>
                {
                    try
                    {
                        
                        string Topic = ea.ApplicationMessage.Topic;
                        string text = "";
                        if (Topic == "file")
                        {
                            //接收文件
                            text = Encoding.UTF8.GetString(ea.ApplicationMessage.Payload);
                            string[] infos = text.Split(',');
                            if (infos.Length == 3)
                            {
                                RcvFileName = infos[0];
                                RcvFileLength = Convert.ToInt64(infos[1]);
                                RcvFileLengthTmp = 0;
                                RcvFileBagCount = Convert.ToInt32(infos[2]);
                                RcvFileBagCountTmp = 0;
                                Invoke(receviceDelegate, "RcvFileName:" + infos[0] + "; RcvFileLength: " + infos[1] + "; RcvFileBagCount: " + infos[2]);
                                //saveStream = new FileStream(Application.StartupPath + "\\FileRcv\\" + RcvFileName, FileMode.OpenOrCreate, FileAccess.Write);

                            }
                            else
                            {
                                /* byte[] stream = RSAhelper.RsaDecrypt(ea.ApplicationMessage.Payload, xmlPrivateKeys);
                                         RcvFileLengthTmp = RcvFileLengthTmp + stream.Length;
                                         RcvFileBagCountTmp++;
                                         FileStream saveStream = new FileStream(Application.StartupPath + "\\FileRcv\\" + RcvFileName, FileMode.OpenOrCreate, FileAccess.Write);
                                         saveStream.Position = saveStream.Length;
                                         saveStream.Write(stream, 0, ea.ApplicationMessage.Payload.Length);
                                         saveStream.Close();*/
                                RcvFileLengthTmp = RcvFileLengthTmp + ea.ApplicationMessage.Payload.Length;
                                RcvFileBagCountTmp++;
                                FileStream saveStream = new FileStream(Application.StartupPath + "\\FileRcv\\" + RcvFileName, FileMode.OpenOrCreate, FileAccess.Write);
                                saveStream.Position = saveStream.Length;
                                saveStream.Write(ea.ApplicationMessage.Payload, 0, ea.ApplicationMessage.Payload.Length);
                                saveStream.Close();
                                Console.WriteLine(RcvFileLength.ToString() + "==" + RcvFileLengthTmp.ToString() + "---->Payload:" + ea.ApplicationMessage.Payload.Length.ToString());

                            }
                           
                        }
                        else
                        {
                            text = Encoding.UTF8.GetString(ea.ApplicationMessage.Payload);
                            //RSA解密
                            if (!string.IsNullOrEmpty(PrivateKeys))
                            {
                                //text = Encoding.UTF8.GetString(RSAhelper.RsaDecrypt(ea.ApplicationMessage.Payload, xmlPrivateKeys));
                               
                            }
                            string QoS = ea.ApplicationMessage.QualityOfServiceLevel.ToString();
                            string Retained = ea.ApplicationMessage.Retain.ToString();
                            Invoke(receviceDelegate, "Topic:" + Topic + "; QoS: " + QoS + "; Retained: " + Retained + ";\r\n" + text);
                        }
                        
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }
                });
                //Console.WriteLine(mqttClient.IsConnected.ToString());


            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
        }

        private void stop()
        {
            try
            {
                mqttClient.DisconnectAsync();
                //Invoke(receviceDelegate, "Disconnected >>Disconnected Server");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
        }


        #endregion

        #region 订阅操作  已废弃删除不用
        /// <summary>
        /// 订阅按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient == null || mqttClient.IsConnected == false) return;
                if (string.IsNullOrEmpty(txtSubTopic.Text)) return;
                if (!regTopic(txtSubTopic.Text))
                {
                    return;
                }
                if (topicDir.ContainsKey(txtSubTopic.Text))
                {
                    return;
                }
                topicDir.Add(txtSubTopic.Text, QualityOfServiceLevel);
                var topicFilterBulder = new TopicFilterBuilder().WithTopic(txtSubTopic.Text).WithQualityOfServiceLevel((MqttQualityOfServiceLevel)Enum.ToObject(typeof(MqttQualityOfServiceLevel), QualityOfServiceLevel)).Build();
                mqttClient.SubscribeAsync(topicFilterBulder);
                DevComponents.DotNetBar.Controls.EditToken editToken = new DevComponents.DotNetBar.Controls.EditToken(string.Format("{0} QOS:{1}", txtSubTopic.Text, QualityOfServiceLevel));
                tokenEditor1.SelectedTokens.Add(editToken);

      
            }
            catch (Exception exp)
            {
                Console.WriteLine("Publish >>" + exp.Message);
            }
            
           
        }

        /// <summary>
        /// 缺主题格式无误
        /// </summary>
        /// <param name="Topic"></param>
        /// <returns></returns>
        private bool regTopic(string Topic)
        {
            if (Topic.Contains("#"))
            {
                if (Topic.Length == 1)
                {
                    return false;
                }
                if (Topic.Substring(Topic.Length - 1, 1) == "#")
                {
                    if (Topic.Substring(0, Topic.Length - 1).Contains("#"))
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 删除订阅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void TokenEditor1_RemovingToken_1(object sender, DevComponents.DotNetBar.Controls.RemovingTokenEventArgs ea)
        {
            if (mqttClient == null || mqttClient.IsConnected == false) return;
            tokenEditor1.SelectedTokens.Remove(ea.Token);
            topicDir.Remove(ea.Token.Value.Split(' ')[0]);

            //tokenEditor1.Tokens.Remove(ea.Token);
            //var topicFilterBulder = new TopicFilterBuilder().WithTopic(txtSubTopic.Text).WithQualityOfServiceLevel((MqttQualityOfServiceLevel)Enum.ToObject(typeof(MqttQualityOfServiceLevel), QualityOfServiceLevel)).Build();
            mqttClient.UnsubscribeAsync(txtSubTopic.Text);
       
        }

        #endregion

        #region 推送
        
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPusTopic.Text)) return;
            if (txtPusTopic.Text.Contains("#"))
            {
                return;
            }
            
            Publish(txtPusTopic.Text, rtbPush.Text, sendQos, Retained);
        }


        public static void Publish(string Topic, string Message,int Qos,bool Retain)
        {
            try
            {
                if (mqttClient == null) return;
                if (mqttClient.IsConnected == false)
                    mqttClient.ConnectAsync(options);

                if (mqttClient.IsConnected == false)
                {
                    Console.WriteLine("Publish >>Connected Failed! ");
                    return;
                }
                byte[] sendbuff = new byte[2];
                if (!string.IsNullOrEmpty(Message))
                {
                    sendbuff = System.Text.Encoding.UTF8.GetBytes(Message);

                }
                Console.WriteLine("Publish >>Topic: " + Topic + "; QoS: " + Qos + "; Retained: " + Retain + ";");
                Console.WriteLine("Publish >>Message: " + Message);
                MqttApplicationMessageBuilder mamb = new MqttApplicationMessageBuilder()
                 .WithTopic(Topic)
                  .WithPayload(sendbuff)
                 //.WithPayload(RSAhelper.RsaEncrypt(System.Text.Encoding.UTF8.GetBytes(Message), xmlPublicKeys))
                 .WithRetainFlag(Retain);
                if (Qos == 0)
                {
                    mamb = mamb.WithAtMostOnceQoS();
                }
                else if (sendQos == 1)
                {
                    mamb = mamb.WithAtLeastOnceQoS();
                }
                else if (sendQos == 2)
                {
                    mamb = mamb.WithExactlyOnceQoS();
                }

                mqttClient.PublishAsync(mamb.Build());
            }
            catch (Exception exp)
            {
                Console.WriteLine("Publish >>" + exp.Message);
            }
        }




        #endregion

        #region 测试 发送文件
        /// <summary>
        /// 测试 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient == null) return;
                if (mqttClient.IsConnected == false)
                    mqttClient.ConnectAsync(options);

                if (mqttClient.IsConnected == false)
                {
                    Console.WriteLine("Publish >>Connected Failed! ");
                    return;
                }
                if (string.IsNullOrEmpty(txtPusTopic.Text)) return;
                if (txtPusTopic.Text.Contains("#"))
                {
                    return;
                }

                OpenFileDialog op = new OpenFileDialog();
                string historyPath = Tools.GetAppConfig("FilePath");
                if (!string.IsNullOrEmpty( historyPath))
                {
                    //设置此次默认目录为上一次选中目录  
                    op.InitialDirectory = historyPath;

                }
                op.Title = "请打开工程文件";
                //op.Filter = "All files(*.*) | *.* ";//"项目文件（*.yc）|*.yc|压缩文件（*.zip）|*.zip|All files(*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    //发送文件前，将文件名和长度发过去
                    long fileLength = new FileInfo(op.FileName).Length;
                    //文件名称 文件长度 
                    string totalMsg = string.Format("{0},{1},{2}", Path.GetFileName(op.FileName), fileLength,Math.Ceiling((double)fileLength/256/1024));
                    //op.FileName
                    Tools.UpdateAppConfig("FilePath", Path.GetDirectoryName(op.FileName) );
                    MqttApplicationMessageBuilder mamb = new MqttApplicationMessageBuilder()
                    .WithTopic("file").WithRetainFlag(Retained).WithExactlyOnceQoS()
                    .WithPayload(totalMsg);
                    //发送文件名称 长度 
                    mqttClient.PublishAsync(mamb.Build());

                    byte[] buffer = new byte[256* 1024];
                    FileStream fs = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                    int readLength = 0;
                    long sentFileLength = 0;
                    int i = 1;
                    while ((readLength = fs.Read(buffer, 0, buffer.Length)) > 0 && sentFileLength < fileLength)
                    {
                        sentFileLength += readLength;
                        Console.WriteLine("Send  >>" + readLength.ToString() + "---------->i:"+i.ToString()) ;
                        //mamb.WithPayload(RSAhelper.RsaEncrypt(buffer.Skip(0).Take(readLength).ToArray(),xmlPublicKeys));
                        mamb.WithPayload(buffer.Skip(0).Take(readLength).ToArray());
                        mqttClient.PublishAsync(mamb.Build());
                        //rcr校验
                        byte[] result = CRC16Helper.CRC16(buffer);
                        Array.Clear(buffer,0,buffer.Length);
                        i++;
                        Tools.DelayMilli(200);
                    }
                    fs.Close();
                }//if
            }
            catch (Exception exp)
            {
                Console.WriteLine("PublishFile >>" + exp.Message);

            }
        }
        #endregion

    

  



    }
}
