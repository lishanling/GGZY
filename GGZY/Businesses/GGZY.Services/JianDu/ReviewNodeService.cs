using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 审查节点
    /// </summary>
    public partial class ReviewNodeService 
    {
        /// <summary>
        /// 根据审查类型获取审查节点
        /// </summary>
        /// <param name="sc_type"></param>
        /// <returns></returns>
		public REVIEW_NODE GetBySCType(int sc_type)
        {
            var entity = FromWhere<REVIEW_NODE>(REVIEW_NODE._.MAIN_ID.SubQueryIn(
                FromWhere<REVIEW_MAIN>().Where(REVIEW_MAIN._.SC_TYPE == sc_type
                && REVIEW_MAIN._.IS_ENABLE ==1)
                .Select(REVIEW_MAIN._.ID)))
                .ToFirst();
            return entity;
                
        }
	}
}