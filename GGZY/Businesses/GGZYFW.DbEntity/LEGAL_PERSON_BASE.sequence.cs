using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类LEGAL_PERSON_BASE。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class LEGAL_PERSON_BASE 
    {
        public override Field GetIdentityField()
        {
            return _.M_ID;
        }

        public override string GetSequence()
        {
            return "SEQ_LEGAL_PERSON_BASE";
        }
    }
}