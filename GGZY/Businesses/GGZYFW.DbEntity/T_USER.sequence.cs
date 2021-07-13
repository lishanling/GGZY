using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
    /// <summary>
    /// 实体类T_USER。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class T_USER
    {
        /// <summary>
        /// 代理子账号角色ID
        /// </summary>
        public const string AGNET_ROLEID = "11";
        /// <summary>
        /// 个人账号角色ID
        /// </summary>
        public const string PERSON_ROLEID = "3";
        /// <summary>
        /// 企业账号角色ID
        /// </summary>
        public const string COMPANY_ROLEID = "4";

        /// <summary>
        /// 自增长Sequence名称
        /// </summary>
        /// <returns></returns>
        public override string GetSequence()
        {
            return "SEQ_T_USER";
        }
        /// <summary>
        /// 自增长字段
        /// </summary>
        /// <returns></returns>
        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}