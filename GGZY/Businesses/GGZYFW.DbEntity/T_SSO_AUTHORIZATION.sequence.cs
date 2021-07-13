using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_SSO_AUTHORIZATION。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_SSO_AUTHORIZATION 
    {
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_T_SSO_AUTHORIZATION";
        }
    }
}