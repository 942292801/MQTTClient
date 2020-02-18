using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTClient
{
    [Serializable]
    class DoMain
    {

        /// <summary>
        /// 设备请求
        /// </summary>
        [Serializable]
        public class Request
        {
            public string deviceid { get; set; }
            public string code { get; set; }
            public string desc { get; set; }
            public string time { get; set; }
            public string reqid { get; set; }
            public string @params { get; set; }

        }

        /// <summary>
        /// 回应参数
        /// </summary>
        [Serializable]
        public class ResponsePublicKeys
        {
            public string deviceid { get; set; }
            public string code { get; set; }
            public string desc { get; set; }
            public string servertime { get; set; }
            public string reqid { get; set; }
            public string result { get; set; }
            public string result_desc { get; set; }
            public string error_code { get; set; }
            public string outparam { get; set; }

        }

        #region 获取公钥



        /// <summary>
        /// 输出参数 取值
        /// </summary>
        [Serializable]
        public class OutParamRSA
        {
            public string publickey { get; set; }
        }
        #endregion

        #region 获取MQTT配置信息
        /// <summary>
        /// 请求参数
        /// </summary>
        [Serializable]
        public class ParamsMQTTConfig
        {
            public string password { get; set; }
            public string passtype { get; set; }
      

        }

        /// <summary>
        /// 输出参数
        /// </summary>
        [Serializable]
        public class OutParamMQTTConfig
        {
            public string mqttserver { get; set; }
            public string mqttserverport { get; set; }
            public string loginuser { get; set; }
            public string loginpassword { get; set; }
            public string subtopic { get; set; }
            public string pubtopic { get; set; }
            public string msgpassword { get; set; }
            public string msgpasstype { get; set; }

        }
        #endregion


    }
}
