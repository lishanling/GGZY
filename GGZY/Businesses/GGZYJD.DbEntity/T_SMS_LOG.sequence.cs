using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_SMS_LOG。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_SMS_LOG : JdEntity
    {
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_T_SMS_LOG";
        }
    }
}