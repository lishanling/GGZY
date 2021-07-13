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
    /// 移送公职人员信息
    /// </summary>
    public partial class JcTransPersonService
    {
        /// <summary>
        /// 处长门户 纪委监委 项目监督 详情 行业部门移送的公职人员信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult DepTransStaff(JC_TRANS_PERSON model, SearchCondition search)
        {
            var departId = JdUser?.DEPARTID;


            if (departId != null)
            {
                var con = ConditionBuilder(model);
                con.And(JC_TRANS_PERSON._.IS_DELETE!=1);
                con.And(JC_TRANS_RECORD._.RECEIVER_UNIT_ID==departId);//移送单位为当前账号对应的单位
                con.And(JC_TRANS_RECORD._.TRANS_TYPE==3&&JC_TRANS_RECORD._.IS_DELETE!=1);//公职人员
                var query = FromWhere(con.ToWhereClip())
                    .InnerJoin<JC_TRANS_RECORD>(JC_TRANS_RECORD._.ID == JC_TRANS_PERSON._.RECORD_ID)
                    ;
                var count = query.Count();
                if (count > 0)
                {
                    var list = query
                        .OrderByDescending(JC_TRANS_RECORD._.TRANS_TIME)
                        .Page(search.PageSize, search.PageNo)
                        .Select(
                            JC_TRANS_PERSON._.TENDER_PROJECT_NAME,
                            JC_TRANS_PERSON._.PERSON_NAME,
                            JC_TRANS_PERSON._.ENTITY_NAME,
                            JC_TRANS_RECORD._.TRANS_UNIT,
                            JC_TRANS_RECORD._.TRANS_TIME
                        ).ToList<object>();
                    var plist = list.ToPageTableResult(search, count);
                    return plist;
                }

            }
            


            return search.ToPageTableResult();
        }

    }
}