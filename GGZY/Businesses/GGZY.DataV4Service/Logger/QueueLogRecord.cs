using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GGZY.DataV4Service.Logger
{
    public class QueueLogRecord
    {
        /// <summary>
        /// 构造函数必须是私有的
        /// 这样在外部便无法使用 new 来创建该类的实例
        /// </summary>
        private QueueLogRecord()
        { }
        private static readonly object _lock = new object();
        private static Thread childThread;
        /// <summary>
        /// 休眠0.5秒
        /// </summary>
        private static int sleepTime = 100 * 5;
        private static string appid = "";
        private static string url = "";
        private static bool isEnableLog = true;
        private static readonly Lazy<QueueLogRecord> Linstance = new Lazy<QueueLogRecord>(() =>
        {

            lock (_lock)
            {
                Queue = new ConcurrentQueue<dynamic>();
                var logConfig = (NameValueCollection)ConfigurationManager.GetSection("LogServiceSections");
                if (null == logConfig)
                {
                    StrongLogger.Debug("0000", "", "统一日志配置未启用：web.config 中未找到 LogServiceSections 配置节点");
                    isEnableLog = false;
                }
                url = logConfig["api"];
                appid = logConfig["appid"];
                if (isEnableLog && (String.IsNullOrEmpty(url) || String.IsNullOrEmpty(appid)))
                {
                    StrongLogger.Debug("0000", "", "统一日志配置启用失败：LogServiceSections 节点 appid/api 配置项为空");
                    isEnableLog = false;
                }

                if (childThread == null || childThread.ThreadState != System.Threading.ThreadState.Running)
                {
                    childThread = new Thread(new ThreadStart(Start));
                    childThread.IsBackground = true;
                    childThread.Start();
                }

            }
            return new QueueLogRecord();
        });

        public static QueueLogRecord Instance { get { return Linstance.Value; } }

        private static ConcurrentQueue<dynamic> Queue;

        public void Enqueue(string requestid, string level, object msg, Exception ex)
        {
            try
            {
                //var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(msg));
                var data = new
                {
                    requestid = requestid,
                    appid = appid,
                    level = level.ToUpper(),
                    data = new
                    {
                        msg = msg,
                        exception = null == ex ? "" : ex.StackTrace
                    }
                };
                Queue.Enqueue(data);
                return;
            }
            catch (Exception exception)
            {
                var data = new
                {
                    requestid = requestid,
                    appid = appid,
                    level = level.ToUpper(),
                    data = new
                    {
                        msg = msg,
                        exception = null == exception ? "" : exception.StackTrace
                    }
                };
                Queue.Enqueue(data);
                return;
            }

        }
        private static void Start()
        {
            if (!isEnableLog)
            {
                return;
            }
            while (true)
            {
                /*WebUtils helper = new WebUtils();
                helper.ContentType = "application/json";
                helper.DoLog = false;*/
                if (!Queue.IsEmpty)
                {
                    dynamic entity;
                    if (Queue.TryDequeue(out entity))
                    {
                        try
                        {
                            var postString = JsonConvert.SerializeObject(entity);
                            WebClient webClient = new WebClient();
                            webClient.Encoding = Encoding.UTF8;
                            byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
                            webClient.Headers.Add("Content-Type", "application/json");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                            var responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流 
                            var result = Encoding.UTF8.GetString(responseData);
                            //var returnContent = helper.DoPost(url, JsonConvert.SerializeObject(entity));
                            //Logger.Debug("提交日志到统一日志服务成功,requestid:" + entity.requestid + ",响应报文:" + returnContent);
                        }
                        catch (Exception ex)
                        {
                            StrongLogger.Error("0000", "", "提交日志到统一日志服务失败:" + ex.Message, ex);
                        }
                    }
                }
                Thread.Sleep(sleepTime);
            }
        }
    }
}
