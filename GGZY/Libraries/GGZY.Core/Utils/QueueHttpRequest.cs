using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GGZY.Core.Utils
{
    /// <summary>
    /// 通用队列通知模块，队列数据格式：
    /// {"url":"","requestid":"",data:{}}
    /// </summary>

    public partial class QueueHttpRequest
    { /// <summary>
      /// 构造函数必须是私有的
      /// 这样在外部便无法使用 new 来创建该类的实例
      /// </summary>
        private QueueHttpRequest()
        { }
        private static readonly object _lock = new object();
        private static Thread childThread;
        /// <summary>
        /// 休眠5秒
        /// </summary>
        private static int sleepTime = 1000 * 5;
        private static readonly Lazy<QueueHttpRequest> Linstance = new Lazy<QueueHttpRequest>(() => {

            lock (_lock)
            {
                Queue = new ConcurrentQueue<dynamic>();
               
                if (childThread == null || childThread.ThreadState != System.Threading.ThreadState.Running)
                {
                    childThread = new Thread(new ThreadStart(Start));
                    childThread.IsBackground = true;
                    childThread.Start();
                }

            }
            return new QueueHttpRequest();
        });

        public static QueueHttpRequest Instance { get { return Linstance.Value; } }

        private static ConcurrentQueue<dynamic> Queue;

        public void Enqueue(dynamic requestDic)
        {
            try
            {
                Queue.Enqueue(requestDic);
            }
            catch (Exception exception)
            {
                Log.LoggerR.Error(Guid.NewGuid().ToString(), "添加数据到通知队列失败:" + exception.Message, exception);
            }

        }
        private static void Start()
        {
            while (true)
            {
                WebUtils helper = new WebUtils();
                helper.ContentType = "application/json;charset=utf-8";
                helper.DoLog = true;
                while (!Queue.IsEmpty)
                {
                    dynamic entity;
                    if (Queue.TryDequeue(out entity))
                    {
                        try
                        {
                            Dictionary<string, object> dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(entity));
                            var data = JsonConvert.SerializeObject(dic["data"]);
                            Log.LoggerR.Debug(dic["requestid"].ToString(), " 准备提交数据到：" + dic["url"].ToString());
                            var returnContent = helper.DoPost(dic["url"].ToString(), data);
                            Log.LoggerR.Debug(dic["requestid"].ToString()," 提交数据到："+ dic["url"].ToString() + "成功,请求报文:"+ data + "响应报文:" + returnContent);

                            if(dic.ContainsKey("action") && dic["action"].ToString() =="query")
                            {

                                //TODO:根据查询结果处理业务
                                //Jd.YdpbEvalApplyService.I_Audit(SERIES_NUMBER, STATUS, AREA_CODE, CENTER_NAME, EVAL_ROOM_NAME, EVAL_ROOM_ADDR, SEAT_NUMBER, REMARK);
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.LoggerR.Error("提交数据包失败,数据包内容:" + JsonConvert.SerializeObject(entity) + "，失败原因："+ ex.Message, ex);
                        }
                    }
                }

                Thread.Sleep(sleepTime);
            }
        }
    }
}
