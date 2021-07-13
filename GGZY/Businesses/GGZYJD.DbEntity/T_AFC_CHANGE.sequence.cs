using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_AFC_CHANGE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_AFC_CHANGE 
    {
        public override Field GetIdentityField()
        {
            return T_AFC_LOG._.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_T_AFC_CHANGE";
        }
    }
}