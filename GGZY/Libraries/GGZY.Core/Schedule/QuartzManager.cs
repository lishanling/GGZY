using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using Quartz.Impl.Triggers;
using Quartz.Spi;

namespace GGZY.Core.Schedule
{
    public class QuartzManager
    {
        private IScheduler _scheduler = null;

        private ITriggerListener _customTriggerListener = null;
        private List<QuartzTaskModel> _listTask = null;
        private static QuartzManager _instance;
        public static QuartzManager Instance => _instance ?? (_instance = new QuartzManager());

        /// <summary>
        /// 缓存任务所在程序集信息
        /// </summary>
        private readonly Dictionary<string, Assembly> _assemblyDict = new Dictionary<string, Assembly>();
        /// <summary>
        /// 任务程序集根目录
        /// </summary>
        private static string TaskRootPath
        {
            get
            {
                //判断是Web程序还是window程序
                var dir = HttpContext.Current != null ? HttpRuntime.AppDomainAppPath : AppDomain.CurrentDomain.BaseDirectory;
                return $"{dir}Task";
            }
        }
        /// <summary>
        /// 预读取任务列表
        /// </summary>
        public Func<List<QuartzTaskModel>> ReadTaskFun;
        /// <summary>
        /// 更新任务最近运行时间
        /// </summary>
        public Action<string, DateTime> UpdateRecentRunTimeAction;
        /// <summary>
        /// 更新任务下次运行时间
        /// </summary>
        public Action<string, DateTime> UpdateLastRunTimeAction;
        /// <summary>
        /// 初始化任务调度对象
        /// </summary>
        public async void InitScheduler()
        {
            try
            {
                if (_scheduler == null)
                {
                    var properties = new NameValueCollection
                    {
                        ["quartz._scheduler.instanceName"] = "ExampleDefaultQuartzScheduler",
                        ["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz",
                        ["quartz.threadPool.threadCount"] = "10",
                        ["quartz.threadPool.threadPriority"] = "Normal",
                        ["quartz.jobStore.misfireThreshold"] = "60000",
                        ["quartz.jobStore.type"] = "Quartz.Simpl.RAMJobStore, Quartz"
                    };
                    ISchedulerFactory factory = new StdSchedulerFactory(properties);
                    await factory.GetScheduler().ContinueWith(task =>
                    {
                        _scheduler = task.Result;
                        _scheduler.Clear();
                    });

                    Logger.Info("任务调度初始化成功！");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("任务调度初始化失败！", ex);
            }
        }
        /// <summary>
        /// 添加全局监听
        /// </summary>
        public void AddTriggerListener()
        {
            _customTriggerListener = new CustomTriggerListener
            {
                TriggerFireAction = ((trigger, context) => { }),
                TriggerMisfiredAction = (trigger => { }),
                TriggerCompleteAction = ((trigger, context) =>
                {
                    var dt = TimeZoneInfo.ConvertTimeFromUtc(context.NextFireTimeUtc.Value.DateTime,
                        TimeZoneInfo.Local);
                    UpdateLastRunTimeAction?.Invoke(trigger.JobKey.Name, dt);
                }),
                VetoJobExecutionAction = ((trigger, context) =>
                {
                    var dt = TimeZoneInfo.ConvertTimeFromUtc(context.NextFireTimeUtc.Value.DateTime,
                        TimeZoneInfo.Local);
                    UpdateRecentRunTimeAction?.Invoke(trigger.JobKey.Name, dt);
                    return false;
                }),
            };
            _scheduler.ListenerManager.AddTriggerListener(_customTriggerListener, GroupMatcher<TriggerKey>.AnyGroup());
        }

        /// <summary>
        /// 启动任务调度器
        /// </summary>
        public void StartScheduler()
        {
            try
            {
                if (!_scheduler.IsStarted)
                {

                    _scheduler.Start();
                    if (_listTask == null || !_listTask.Any())
                    {
                        _listTask = ReadTaskFun?.Invoke();
                    }
                    if (_listTask != null && _listTask.Count > 0)
                    {
                        foreach (var taskUtil in _listTask)
                        {
                            try
                            {
                                ScheduleJob(taskUtil);
                            }
                            catch (Exception e)
                            {
                                Logger.Error($"任务“{taskUtil.TASNNAME}”启动失败！", e);
                            }
                        }
                    }
                    Logger.Info("任务调度启动成功！");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("任务调度启动失败！", ex);
            }
        }


        /// <summary>
        /// 删除现有任务
        /// </summary>
        /// <param name="jobKey"></param>
        public async void DeleteJob(string jobKey)
        {
            JobKey jk = new JobKey(jobKey);
            await _scheduler.CheckExists(jk).ContinueWith((task =>
            {
                if (task.Result)
                {
                    _scheduler.DeleteJob(jk);
                    Logger.Info($"任务“{jobKey}”已经删除");
                }
            }));
        }

        /// <summary>
        /// 启用任务
        /// <param name="taskUtil">任务信息</param>
        /// <param name="isDeleteOldTask">是否删除原有任务</param>
        /// <returns>返回任务trigger</returns>
        /// </summary>
        public async void ScheduleJob(QuartzTaskModel taskUtil, bool isDeleteOldTask = false)
        {
            if (isDeleteOldTask)
            {
                //先删除现有已存在任务
                DeleteJob(taskUtil.TASKID);
            }
            //验证是否正确的Cron表达式
            if (ValidExpression(taskUtil.CRONEXPRESSIONSTRING))
            {
                var jobType = GetClassInfo(taskUtil.ASSEMBLYNAME, taskUtil.CLASSNAME);
                IJobDetail job = new JobDetailImpl(taskUtil.TASKID, jobType);
                CronTriggerImpl trigger = new CronTriggerImpl
                {
                    CronExpressionString = taskUtil.CRONEXPRESSIONSTRING,
                    Name = taskUtil.TASKID,
                    Description = taskUtil.TASNNAME
                };
                //添加任务执行参数
                job.JobDataMap.Add("TASKPARAM", taskUtil.TASKPARAM);
                await _scheduler.ScheduleJob(job, trigger);
                if (taskUtil.STATE == (decimal)QuartzTaskModel.TaskState.STOP)
                {
                    JobKey jk = new JobKey(taskUtil.TASKID);
                    await _scheduler.PauseJob(jk);
                }
                else
                {
                    List<DateTime> list = GetTaskFireTime(taskUtil.CRONEXPRESSIONSTRING, 5);
                    Logger.Info($"任务“{taskUtil.TASNNAME}”启动成功,未来5次运行时间如下:{string.Join(" ; ", list.Select(c => c.ToString("yyyy-MM-dd HH:mm:ss")))}");
                }
            }
            else
            {
                throw new Exception(taskUtil.CRONEXPRESSIONSTRING + "不是正确的Cron表达式,无法启动该任务!");
            }
        }

        /// <summary>
        /// 暂停任务
        /// </summary>
        /// <param name="jobKey"></param>
        public async void PauseJob(string jobKey)
        {
            JobKey jk = new JobKey(jobKey);
            await _scheduler.CheckExists(jk).ContinueWith(t =>
            {
                if (t.Result)
                {
                    _scheduler.PauseJob(jk);
                    var jobDetail = _scheduler.GetJobDetail(jk);
                    if (jobDetail.Result.JobType.GetInterface("IInterruptableJob") != null)
                    {
                        _scheduler.Interrupt(jk);
                    }
                    Logger.Info($"任务“{jobKey}”已经暂停");
                }
            });
        }

        /// <summary>
        /// 恢复运行暂停的任务
        /// </summary>
        /// <param name="jobKey">任务key</param>
        public async void ResumeJob(string jobKey)
        {
            JobKey jk = new JobKey(jobKey);
            await _scheduler.CheckExists(jk).ContinueWith(t =>
            {
                if (t.Result)
                {
                    //任务已经存在则暂停任务
                    _scheduler.ResumeJob(jk);
                    Logger.Info($"任务“{jobKey}”恢复运行");
                }
            });
        }

        /// <summary>  
        /// 获取类的属性、方法  
        /// </summary>  
        /// <param name="assemblyName">程序集</param>  
        /// <param name="className">类名</param>  
        private Type GetClassInfo(string assemblyName, string className)
        {
            try
            {
                string assemblyPath = $@"{TaskRootPath}\{assemblyName}.dll";
                string hashCode = assemblyPath.Md5HashFromFile();
                Assembly assembly = null;
                if (!_assemblyDict.TryGetValue(hashCode, out assembly))
                {
                    //修改程序集Assembly.LoadForm 导致程序集被占用问题
                    assembly = Assembly.Load(File.ReadAllBytes(assemblyPath));
                    _assemblyDict[hashCode] = assembly;
                }
                Type type = assembly.GetType(className, true, true);
                return type;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 停止任务调度
        /// </summary>
        public async void StopSchedule()
        {
            try
            {
                //判断调度是否已经关闭
                if (!_scheduler.IsShutdown)
                {
                    //等待任务运行完成
                    await _scheduler.Shutdown(true);
                    _listTask.Clear();
                    Logger.Info("任务调度停止！");
                }
            }
            catch (Exception ex)
            {
                Logger.Error("任务调度停止失败！", ex);
            }
        }

        /// <summary>
        /// 校验字符串是否为正确的Cron表达式
        /// </summary>
        /// <param name="cronExpression">带校验表达式</param>
        /// <returns></returns>
        public bool ValidExpression(string cronExpression)
        {
            return CronExpression.IsValidExpression(cronExpression);
        }

        /// <summary>
        /// 获取任务在未来周期内哪些时间会运行
        /// </summary>
        /// <param name="cronExpressionString">Cron表达式</param>
        /// <param name="numTimes">运行次数</param>
        /// <returns>运行时间段</returns>
        public List<DateTime> GetTaskFireTime(string cronExpressionString, int numTimes)
        {
            if (numTimes < 0)
            {
                throw new Exception("参数numTimes值大于等于0");
            }
            //时间表达式
            ITrigger trigger = TriggerBuilder.Create().WithCronSchedule(cronExpressionString).Build();
            var dates = TriggerUtils.ComputeFireTimes(trigger as IOperableTrigger, null, numTimes);
            return dates.Select(dtf => TimeZoneInfo.ConvertTimeFromUtc(dtf.DateTime, TimeZoneInfo.Local)).ToList();
        }

    }
}