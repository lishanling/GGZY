using System;
using System.Threading;
using System.Threading.Tasks;
using Quartz;

namespace GGZY.Core.Schedule
{
    public  class CustomTriggerListener : ITriggerListener
    {
        /// <summary>
        /// Job执行时调用
        /// </summary>
        /// <param name="trigger">触发器</param>
        /// <param name="context">上下文</param>
        /// <param name="cancellationToken"></param>
        public Task TriggerFired(ITrigger trigger, IJobExecutionContext context,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.Run(() =>
            {
                TriggerFireAction?.Invoke(trigger, context);
            }, cancellationToken);
        }

        /// <summary>
        ///  Trigger触发后，job执行时调用本方法。true即否决，job后面不执行。
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<bool> VetoJobExecution(ITrigger trigger, IJobExecutionContext context,
            CancellationToken cancellationToken = new CancellationToken())
        {

            //UpdateRecentRunTime
            return Task.Run(() =>
            {
                VetoJobExecutionAction?.Invoke(trigger, context);
                return false;
            }, cancellationToken);
        }


        /// <summary>
        /// 错过触发时调用
        /// </summary>
        /// <param name="trigger">触发器</param>
        /// <param name="cancellationToken"></param>
        public Task TriggerMisfired(ITrigger trigger, CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.Run(() => TriggerMisfiredAction?.Invoke(trigger), cancellationToken);
        }

        /// <summary>
        /// Job完成时调用
        /// </summary>
        /// <param name="trigger">触发器</param>
        /// <param name="context">上下文</param>
        /// <param name="triggerInstructionCode"></param>
        /// <param name="cancellationToken"></param>
        public Task TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode,
            CancellationToken cancellationToken = new CancellationToken())
        {
            //UpdateLastRunTime
            return Task.Run(() => TriggerCompleteAction?.Invoke(trigger, context), cancellationToken);
        }

        public string Name => "AllTriggerListener";
        /// <summary>
        /// Job完成时调用  ITrigger:触发器  IJobExecutionContext:上下文
        /// </summary>
        public Action<ITrigger, IJobExecutionContext> TriggerCompleteAction;

        public Action<ITrigger, IJobExecutionContext> TriggerFireAction;
        /// <summary>
        /// Trigger触发后，job执行时调用本方法。ITrigger:触发器  IJobExecutionContext:上下文 true即否决，job后面不执行。
        /// </summary>
        public Func<ITrigger, IJobExecutionContext, bool> VetoJobExecutionAction;

        public Action<ITrigger> TriggerMisfiredAction;
    }
}