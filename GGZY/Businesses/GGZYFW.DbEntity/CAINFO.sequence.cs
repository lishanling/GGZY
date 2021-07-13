using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类CAINFO。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class CAINFO 
    {
        public override string GetSequence()
        {
            return "SEQ_CAINFO";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
            //return base.GetIdentityField();
        }
    }
}