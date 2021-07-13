using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_NOTICE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_NOTICE 
    {
        public override string GetSequence()
        {
            return "SEQ_T_NOTICE";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}