using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Core.Log;
using GGZY.Services.Base;

namespace ZxtsSuperviseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Logger.Info("监察机关-纪委-智能监察-在线投诉 开始");
            ServicesFactory.GGZYJD.TSuperviseResultService.ZxtsSuperviseTask(20);
            Logger.Info("监察机关-纪委-智能监察-在线投诉 结束");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            Logger.Error($"监察机关-纪委-智能监察-在线投诉任务异常:{ex?.Message}", ex);
        }
    }
}
