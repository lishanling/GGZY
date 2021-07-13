using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 实体类T_USER_DEPARTMENT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_USER_DEPARTMENT
    {
        public override string GetSequence()
        {
            return "Seq_T_User_Department";
        }

        public override Field GetIdentityField()
        {
            return _.DEPID;
        }
    }
}