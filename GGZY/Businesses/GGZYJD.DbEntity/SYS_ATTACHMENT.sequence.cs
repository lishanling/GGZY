using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类SYS_ATTACHMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
  
    public partial class SYS_ATTACHMENT
    {
        /// <summary>
        /// 统一文件服务器 AOBJTYPE
        /// </summary>
        public const string FILE_CENTER = "FC";//FILE_CENTER
        public override string GetSequence()
        {
            return "Seq_Sys_Attachment";
        }

        public override Field GetIdentityField()
        {
            return _.AID;
        }
    }
}