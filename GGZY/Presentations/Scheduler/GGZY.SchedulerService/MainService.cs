using GGZY.SchedulerService.JobFactory;
using log4net;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.SchedulerService
{
    /// <summary>
    /// 调度程序主服务
    /// </summary>
    public class MainService
    {
        private static ILog log = log4net.LogManager.GetLogger(typeof(Logger));
        public void Start()
        {
            JobCollection.Instance.Start();
            GGZY.Core.Log.Logger.Info("调度器开始工作");
        }

        public void Stop()
        {
            JobCollection.Instance.Stop();
        }

        //public async void Start()
        //{
        //    string appDir = AppDomain.CurrentDomain.BaseDirectory;
        //    foreach (var path in Directory.GetFiles(appDir))
        //    {
        //        if (path.Contains(".dll"))
        //        {
        //            Console.WriteLine(path);
        //            Assembly ab = Assembly.LoadFile(path);
        //            foreach (var type in ab.GetTypes())
        //            {
        //                Console.WriteLine("类名：" + type.Name);
        //                Console.WriteLine("名称空间：" + type.Namespace);
        //                var itypes = type.FindInterfaces(new TypeFilter((t, j) => { return t.ToString() == j.ToString(); }), "Quartz.IJob");
        //                foreach (var itype in itypes)
        //                {
        //                    Console.WriteLine("类继续接口：" + itype.Name);
        //                    if (itype.Name == "IJob")
        //                    {
        //                        IJob job = (IJob)ab.CreateInstance(type.Namespace + "." + type.Name);
        //                        //job.Execute(itype.Name);
        //                        JobBuilder.Create(itype);


        //                    }
        //                }
        //            }
        //        }

        //    }

        //    Console.ReadKey();

        //    //Console.WriteLine("开始启动了");

        //    //LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());

        //    //// Grab the Scheduler instance from the Factory
        //    //StdSchedulerFactory factory = new StdSchedulerFactory();
        //    //IScheduler scheduler = await factory.GetScheduler();

        //    //// and start it off
        //    //await scheduler.Start();

        //    //// define the job and tie it to our HelloJob class
        //    //IJobDetail job = JobBuilder.Create<GGZY.Scheduler.TestJob.Class1>()
        //    //    .WithIdentity("job1", "group1")
        //    //    .Build();

        //    //// Trigger the job to run now, and then repeat every 10 seconds
        //    //ITrigger trigger = TriggerBuilder.Create()
        //    //    .WithIdentity("trigger1", "group1")
        //    //    .StartNow()
        //    //    .WithSimpleSchedule(x => x
        //    //        .WithIntervalInSeconds(10)
        //    //        .RepeatForever())
        //    //    .Build();

        //    //// Tell quartz to schedule the job using our trigger
        //    //await scheduler.ScheduleJob(job, trigger);

        //    //// some sleep to show what's happening
        //    //await Task.Delay(TimeSpan.FromSeconds(60));

        //    //// and last shut down the scheduler when you are ready to close your program
        //    //await scheduler.Shutdown();

        //    //Console.WriteLine("Press any key to close the application");
        //    //Console.ReadKey();


        //}
        //private class ConsoleLogProvider : ILogProvider
        //{
        //    public Logger GetLogger(string name)
        //    {
        //        return (level, func, exception, parameters) =>
        //        {
        //            if (level >= LogLevel.Info && func != null)
        //            {
        //                Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters);
        //            }
        //            return true;
        //        };
        //    }

        //    public IDisposable OpenNestedContext(string message)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public IDisposable OpenMappedContext(string key, string value)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //public void Stop()
        //{
        //    Console.WriteLine("服务停止了");
        //}
    }
}
