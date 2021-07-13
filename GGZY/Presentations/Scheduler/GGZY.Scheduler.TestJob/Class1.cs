using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace GGZY.Scheduler.TestJob
{
    public class Class1: IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Factory.StartNew(() =>
            {
                GGZY.Core.Log.Logger.Info("定时任务开始执行--------------");

                GGZY.Core.Log.Logger.Info("定时任务执行结束--------------");
            });
        }
    }
}
