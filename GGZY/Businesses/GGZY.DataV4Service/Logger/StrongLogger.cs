using System;
using System.Collections.Concurrent;
using NLog;

namespace GGZY.DataV4Service.Logger
{
    public class StrongLogger
    {
        public static void Debug(string systemNo, string dataKey, string msg)
        {
            systemNo = string.IsNullOrEmpty(systemNo)?"Global": systemNo;
            LogToSpecially($"{systemNo}|{dataKey}|{msg}", $"{systemNo}\\");
        }

        public static void Error(string systemNo, string dataKey, string msg, Exception ex)
        {
            systemNo = string.IsNullOrEmpty(systemNo) ? "Global" : systemNo;
            LogToSpecially($"{systemNo}|{dataKey}|{msg}|{ex}", "Exception\\");
        }

        private static readonly ConcurrentDictionary<string,ILogger> _specialLoggers 
            = new ConcurrentDictionary<string, ILogger>();
        private static void LogToSpecially(string message, string dirOrPrefix)
        {
            string str = ("SYSEM_NO." + dirOrPrefix).Trim('\\', '/');
            ILogger orAdd = _specialLoggers.GetOrAdd(str, new Func<string, ILogger>(LogManager.GetLogger));
            LogEventInfo logEventInfo = new LogEventInfo(NLog.LogLevel.Debug, str, message);
            if (!string.IsNullOrEmpty(dirOrPrefix))
                logEventInfo.Properties[(object)"DirOrPrefix"] = (object)dirOrPrefix;
            LogEventInfo logEvent = logEventInfo;
            orAdd.Log(logEvent);
        }

        private static void LogToSpeciallyINFO(string message, string dirOrPrefix)
        {
            string str = ("SYSEM_NO." + dirOrPrefix).Trim('\\', '/');
            ILogger orAdd = _specialLoggers.GetOrAdd(str, new Func<string, ILogger>(LogManager.GetLogger));
            LogEventInfo logEventInfo = new LogEventInfo(NLog.LogLevel.Info, str, message);
            if (!string.IsNullOrEmpty(dirOrPrefix))
                logEventInfo.Properties[(object)"DirOrPrefix"] = (object)dirOrPrefix;
            LogEventInfo logEvent = logEventInfo;
            orAdd.Log(logEvent);
        }

        public static void Info(string systemNo, string dataKey, string msg)
        {
            systemNo = string.IsNullOrEmpty(systemNo) ? "Global" : systemNo;
            LogToSpeciallyINFO($"{systemNo}|{dataKey}|{msg}", $"{systemNo}\\");
        }
    }
}