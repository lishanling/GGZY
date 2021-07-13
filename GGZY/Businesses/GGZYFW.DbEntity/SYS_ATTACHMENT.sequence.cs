using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    
    public partial class SYS_ATTACHMENT
    {
        /// <summary>
        /// 统一文件服务器 AOBJTYPE
        /// </summary>
        public const string FILE_CENTER = "FC";//FILE_CENTER

        public override Field GetIdentityField()
        {
            return _.AID;
        }

        public override string GetSequence()
        {
            return "Seq_Sys_Attachment";
        }
    }
}