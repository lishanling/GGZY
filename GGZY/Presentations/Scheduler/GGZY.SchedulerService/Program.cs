using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace GGZY.SchedulerService
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HostFactory.Run(c =>
            {
                c.Service<MainService>((x) =>
                {
                    x.ConstructUsing(name => new MainService());
                    x.WhenStarted((t) => t.Start());
                    x.WhenStopped((t) => t.Stop());
                });
                c.RunAsLocalService();
                //服务描述
                c.SetDescription("福建省公共资源交易统一任务调度中心");
                //服务显示名称
                c.SetDisplayName("统一任务调度中心");
                //服务的真实名称
                c.SetServiceName("GGZY.SchedulerService");
            });
        }
    }
}
