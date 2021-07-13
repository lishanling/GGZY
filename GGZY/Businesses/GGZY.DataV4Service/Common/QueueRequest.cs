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
using GGZY.DataV4Service.Logger;
using Newtonsoft.Json;

namespace GGZY.DataV4Service.Common
{
    public class QueueRequest
    {
        /// <summary>
        /// 构造函数必须是私有的
        /// 这样在外部便无法使用 new 来创建该类的实例
        /// </summary>
        private QueueRequest()
        { }
        private static readonly object _lock = new object();
        private static Thread childThread;
        /// <summary>
        /// 休眠0.5秒
        /// </summary>
        private static int sleepTime = 100 * 2;
        private static string appid = "";
        private static string url = "";
        private static string datatype = "";
        private static bool isEnableLog = true;
        private static readonly Lazy<QueueRequest> Linstance = new Lazy<QueueRequest>(() =>
        {

            lock (_lock)
            {
                Queue = new ConcurrentQueue<RecordEntity>();
                var logConfig = (NameValueCollection)ConfigurationManager.GetSection("WXAppSections");
                if (null == logConfig)
                {
                    StrongLogger.Debug(system_no, "", "微信订阅号服务配置未启用：web.config 中未找到 WXAppSections 配置节点");
                    isEnableLog = false;
                }
                url = logConfig["api"];
                appid = logConfig["appid"];
                datatype = logConfig["datatype"];
                if (isEnableLog && (String.IsNullOrEmpty(url) || String.IsNullOrEmpty(appid)))
                {
                    StrongLogger.Debug(system_no, "", "微信订阅号服务配置启用失败：WXAppSections 节点 appid/api 配置项为空");
                    isEnableLog = false;
                }

                if (childThread == null || childThread.ThreadState != System.Threading.ThreadState.Running)
                {
                    childThread = new Thread(new ThreadStart(Start));
                    childThread.IsBackground = true;
                    childThread.Start();
                }

            }
            return new QueueRequest();
        });

        public static QueueRequest Instance { get { return Linstance.Value; } }

        private static ConcurrentQueue<RecordEntity> Queue;

        static readonly string system_no = "微信订阅号服务数据推送"; 
        /// <summary>
        /// 加入到队列
        /// </summary>
        /// <param name="requestid">请求id</param>
        /// <param name="data_en">XML 对应英文名称，与接口规范保持一致</param>
        /// <param name="data">XML数据</param>
        public void Enqueue(string requestid,string data_en,string data)
        {
            try
            {
                if(! String.IsNullOrEmpty(datatype))
                {
                    var dataTypes = datatype.Split(new char[] { ',', '，', ';', '；' },StringSplitOptions.RemoveEmptyEntries);
                    if(!dataTypes.Contains(data_en))
                    {
                        return;
                    }
                }
                var dataStruct = new RecordEntity
                {
                    RequestId = requestid,
                    Data = data
                };
                Queue.Enqueue(dataStruct);
                return;
            }
            catch (Exception exception)
            {
                StrongLogger.Error(system_no, "", "转发报文到微信订阅号服务失败", exception);
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
                if (!Queue.IsEmpty)
                {
                    RecordEntity entity;
                    if (Queue.TryDequeue(out entity))
                    {
                        try
                        {
                            ServicePointManager.ServerCertificateValidationCallback =
                       delegate { return true; };
                            StrongLogger.Info(system_no, entity.RequestId, "开始转发报文到微信订阅号服务");
                            StrongLogger.Debug(system_no, entity.RequestId, "请求报文:" + entity.Data);
                            var postString = entity.Data;

                            using (WebClient webClient = new WebClient())
                            {
                                ServicePointManager.DefaultConnectionLimit = 32;
                                webClient.Encoding = Encoding.UTF8;
                                byte[] postData = Encoding.UTF8.GetBytes(postString);
                                webClient.Headers.Add("Content-Type", "application/xml");
                                var responseData =webClient.UploadData(new Uri(url), "POST", postData);
                                var result = Encoding.UTF8.GetString(responseData);
                                StrongLogger.Info(system_no, entity.RequestId, "转发报文到微信订阅号服务完成，响应报文:" + result);
                            }
                        }
                        catch (Exception ex)
                        {
                            StrongLogger.Error(system_no, entity.RequestId, "转发报文到微信订阅号服务失败:" + ex.Message, ex);
                        }
                    }
                }
                Thread.Sleep(sleepTime);
            }
        }
    }

    public class RecordEntity
    {
        public string RequestId { get; set; }
        public string Data { get; set; }
    }
}
