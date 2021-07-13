using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Log;
using GGZY.Services.Base;
using Quartz;

namespace GGZY.Scheduler.AfcProjectSupervise
{
    public class Main:IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() =>
            {
                Logger.Info("监察机关-纪委-智能监察-招标计划 开始");
                ServicesFactory.GGZYJD.TSuperviseResultService.AfcProjectSuperviseTask();
                Logger.Info("监察机关-纪委-智能监察-招标计划 结束");
            });
        }
    }
}
