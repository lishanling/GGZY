using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类PT_COMPLAIN。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class PT_COMPLAIN 
    {
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_PT_COMPLAIN";
        }
    }
}