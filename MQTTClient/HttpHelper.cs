using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MQTTClient
{
    class HttpHelper
    {
        //contentType application/json or application/xml
        public static string HttpGet(string Url, string contentType)
        {
            try
            {
                string retString = string.Empty;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "GET";
                request.ContentType = contentType;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(myResponseStream);
                retString = streamReader.ReadToEnd();
                streamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static string HttpPost(string Url, string postDataStr, string contentType, out bool isOK)
        {
            string retString = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = contentType;
                request.Timeout = 600000;//设置超时时间
                request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
                Stream requestStream = request.GetRequestStream();
                StreamWriter streamWriter = new StreamWriter(requestStream);
                streamWriter.Write(postDataStr);
                streamWriter.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                retString = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();

                isOK = true;
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(WebException))//捕获400错误
                {
                    var response = ((WebException)ex).Response;
                    Stream responseStream = response.GetResponseStream();
                    StreamReader streamReader = new StreamReader(responseStream);
                    retString = streamReader.ReadToEnd();
                    streamReader.Close();
                    responseStream.Close();
                }
                else
                {
                    retString = ex.ToString();
                }
                isOK = false;
            }

            return retString;
        }
    }
}
