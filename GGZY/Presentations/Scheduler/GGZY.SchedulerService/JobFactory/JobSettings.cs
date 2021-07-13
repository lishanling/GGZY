using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.SchedulerService.JobFactory
{
    /// <summary>
    /// 定时任务配置类
    /// </summary>
    public class JobSettings : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public JobTypeElementCollection JobTypes
        {
            get { return (JobTypeElementCollection)this[""]; }
        }

        public static JobSettings GetSection()
        {
            return ConfigurationManager.GetSection("JobSettings") as JobSettings;
        }
    }

    /// <summary>
    /// 定时任务配置集合
    /// </summary>
    public class JobTypeElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new JobTypeElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            JobTypeElement serviceTypeElement = (JobTypeElement)element;
            return MD5Encrypt(serviceTypeElement.JobType.FullName + serviceTypeElement.Remark);
        }
        /// <summary>
        /// MD5字符串加密
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>加密后字符串</returns>
        public static string MD5Encrypt(string txt)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(txt);
                //开始加密
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }

    /// <summary>
    /// 单个定时任务配置类
    /// </summary>
    public class JobTypeElement : ConfigurationElement
    {
        /// <summary>
        /// cron表达式
        /// </summary>
        [ConfigurationProperty("cron", IsRequired = true)]
        public string CronExpression
        {
            get { return this["cron"] as string; }
            set { this["cron"] = value; }
        }

        /// <summary>
        /// 是否立即触发
        /// </summary>
        [ConfigurationProperty("triggerInstantly", IsRequired = true)]
        public bool TriggerInstantly
        {
            get { return (bool)this["triggerInstantly"]; }
            set { this["triggerInstantly"] = value; }
        }

        /// <summary>
        /// 定时job的类型
        /// </summary>
        [ConfigurationProperty("type", IsRequired = true)]
        [TypeConverter(typeof(AssemblyQualifiedTypeNameConverter))]
        public Type JobType
        {
            get { return (Type)this["type"]; }
            set { this["type"] = value; }
        }
        [ConfigurationProperty("remark", IsRequired = false)]
        public string Remark
        {
            get { return (string)this["remark"]; }
            set { this["remark"] = value; }
        }
    }
}
