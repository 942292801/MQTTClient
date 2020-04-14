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


        #region 获取公钥

        /// <summary>
        /// 公钥信息
        /// </summary>
        [Serializable]
        public class BaseResult
        {
            public int status { get; set; }
            public string message { get; set; }
            public object data { get; set; }

            public BaseResult(int stu,string msg) {
                status = stu;
                message = msg;
            }
        }

        #endregion

        #region 获取公钥



        /// <summary>
        /// 公钥信息
        /// </summary>
        [Serializable]
        public class OutParamRSA
        {
            public string serverName { get; set; }
            public string wpapsk { get; set; }
            public string publicKey { get; set; }
        }

        #endregion


        #region 获取资源



        /// <summary>
        /// 公钥信息
        /// </summary>
        [Serializable]
        public class ResourceDTO
        {
            public string username { get; set; }
            public string passwword { get; set; }
            public string channel { get; set; }
            public string scWpapsk { get; set; }
            public string scPassword { get; set; }
            public string certid { get; set; }
            public List<string> certids { get; set; }
    }

        #endregion



    }
}
