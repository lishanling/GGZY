using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.SchedulerService.JobFactory
{
    public class JobWrapper
    {
        /// <summary>
        /// 任务详情
        /// </summary>
        public IJobDetail JobDetail { get; set; }
        /// <summary>
        /// 任务触发器
        /// </summary>
        public ITrigger Trigger { get; set; }

        /// <summary>
        /// 是否立即触发
        /// </summary>
        public bool TriggerInstantly { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Remark { get; set; }
    }
}
