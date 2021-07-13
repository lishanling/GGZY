using GGZY.Core.Log;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.SchedulerService.JobFactory
{
    public class JobCollection : Collection<JobWrapper>
    {
        

        #region Fields & Properties

        /// <summary>
        /// 作业调度器工厂
        /// </summary>
        private static ISchedulerFactory schedulerFactory;

        /// <summary>
        /// 作业调度器
        /// </summary>
        private static IScheduler scheduler;

        #endregion

        private class Nested
        {
            static Nested() { }
            internal static readonly JobCollection Instance = new JobCollection();
        }

        public static JobCollection Instance
        {
            get { return Nested.Instance; }
        }

        /// <summary>
        /// 静态构造器
        /// </summary>
        static JobCollection()
        {
            try
            {
                schedulerFactory = new StdSchedulerFactory();
                scheduler = schedulerFactory.GetScheduler().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Logger.Error("初始化调度器失败:" + ex.Message, ex);
            }

        }


        /// <summary>
        /// 私有构造器
        /// </summary>
        /// <param name="serviceTypes"></param>
        private JobCollection()
        {
            JobSettings settings = JobSettings.GetSection();
            if (settings == null)
            {
                Logger.Error("读取定时任务配置信息失败");
                return;
            }

            foreach (JobTypeElement element in settings.JobTypes)
            {
                if (string.IsNullOrWhiteSpace(element.CronExpression))
                {
                    continue;
                }
                try
                {
                    string jobName = element.JobType.FullName;
                    JobKey jobKey = new JobKey("job_" + jobName);
                    IJobDetail jobDetail = JobBuilder.Create(element.JobType)
                                            .WithIdentity(jobKey)
                                            .Build();

                    //触发器
                    /* WithMisfireHandlingInstructionDoNothing()方法与DisallowConcurrentExecution特性配合使用，
                     * 可以起到如下作用：同一Job如果上一轮执行还未完成，则本次不触发。
                     */
                    ITrigger trigger = TriggerBuilder.Create()
                                        .WithIdentity(string.Format("trigger_{0}", jobName))
                                        .WithSchedule(CronScheduleBuilder.CronSchedule(element.CronExpression).WithMisfireHandlingInstructionDoNothing())
                                        .Build();

                    JobWrapper job = new JobWrapper { JobDetail = jobDetail, Trigger = trigger, TriggerInstantly = element.TriggerInstantly };
                    this.Add(job);
                }
                catch (Exception ex)
                {
                    string msg = string.Format("加载定时任务{0}时发生异常:{1}", element.JobType.Name, ex.Message);
                    Logger.Error(msg);
                }
            }
        }

        /// <summary>
        /// 启动集合中所有定时任务
        /// </summary>
        public void Start()
        {
            scheduler.Start();

            foreach (JobWrapper job in this)
            {
                try
                {
                    scheduler.ScheduleJob(job.JobDetail, job.Trigger);
                    if (job.TriggerInstantly)
                    {
                        scheduler.TriggerJob(job.JobDetail.Key);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error("启动定时任务"+job?.JobDetail?.Key+"失败:" + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// 关闭集合中所有定时任务
        /// </summary>
        public void Stop()
        {
            foreach (JobWrapper job in this)
            {
                try
                {
                    JobKey jobKey = job.JobDetail.Key;
                    string treggerName = "trigger_" + jobKey.Name.Substring(jobKey.Name.IndexOf("_") + 1);
                    TriggerKey triggerKey = new TriggerKey(treggerName);
                    scheduler.PauseTrigger(triggerKey);
                    scheduler.UnscheduleJob(triggerKey);
                    scheduler.DeleteJob(jobKey);
                }
                catch (Exception ex)
                {
                    Logger.Error("停止定时任务失败:"+ex.Message,ex);
                }
            }
            scheduler.Shutdown(false);
        }



    }
}
