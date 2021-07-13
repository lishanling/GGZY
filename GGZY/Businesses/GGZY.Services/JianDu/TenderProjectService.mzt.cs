using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TenderProjectService
    {
        #region 闽政通 登记备案 招标备案
        /// <summary>
        ///  处长门户 登记备案 招标备案 列表
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult MztRecordReviews( SearchCondition search)
        {
            #region 查询条件

            var con = new WhereClipBuilder();

            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                con.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(search.KeyWord)
                        || TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(search.KeyWord));
            }

            #endregion

            #region 行业主管(审批单位) 纪委监委 公安厅 默认行业过滤



            var jdUserType = JdUser?.TYPE;
            if (jdUserType == (int)JdTUserType.JiWeiJianWei || jdUserType == (int)JdTUserType.GongAn)//是纪委或者公安
            {
                var projectTypes = JdUser?.UserDepartment?.TENDER_PROJECT_TYPES;
                if (projectTypes != null && projectTypes.Any())
                {
                    con.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE.In(projectTypes));
                }
                else
                {
                    con.And(TENDER_PROJECT._.TENDER_PROJECT_TYPE == "");
                }
                var rootAreaCode = JdUser?.UserDepartment?.RootAreaCode;
                if (!string.IsNullOrWhiteSpace(rootAreaCode))
                {
                    con.And(TENDER_PROJECT._.REGION_CODE.BeginWith(rootAreaCode));
                    if (rootAreaCode == "3501")
                    {
                        con.And(TENDER_PROJECT._.REGION_CODE != "350100");
                    }
                }
                else
                {
                    con.And(TENDER_PROJECT._.REGION_CODE == "");
                }
            }
            else
            {
                #region 行业部门（审批单位）

                var jdUserDepartId = JdUser?.DEPARTID?.ToString();

                if (!string.IsNullOrWhiteSpace(JdUser?.UserDepartment?.OTHERIDS))
                {
                    var otherIds = JdUser.UserDepartment.OTHERIDS.Split(',').ToList();
                    if (!string.IsNullOrWhiteSpace(jdUserDepartId))
                    {
                        otherIds.Add(jdUserDepartId);
                    }
                    con.And(TENDER_PROJECT._.RECORD_DEPID.In(jdUserDepartId));
                }
                else
                {
                    con.And(TENDER_PROJECT._.RECORD_DEPID == jdUserDepartId);
                }
                #endregion
            }

            #endregion


            var count = Count(con.ToWhereClip());
            if (count > 0)
            {
                var list = FromWhere(con.ToWhereClip())
                        .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                        .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                        .Page(search.PageSize, search.PageNo)
                        .OrderByDescending(TENDER_PROJECT._.CREATE_TIME)
                        .Select(
                           TENDER_PROJECT._.TENDER_PROJECT_NAME,
                           TENDER_PROJECT._.TENDER_PROJECT_CODE,
                           SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),//工程类型
                           SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),//地区
                           TENDER_PROJECT._.M_ID.As("ID"),
                            //RECORD_REVIEW._.
                           TENDER_PROJECT._.CREATE_TIME.As("CREATE_TM"),
                           TENDER_PROJECT._.TENDERER_NAME,
                           TENDER_PROJECT._.TENDER_AGENCY_NAME
                        ).ToList<dynamic>();
                var tenderProjectCodes = list.Select(c => c.TENDER_PROJECT_CODE).ToList();
                var tenderProjectCodeStr = String.Join(",", tenderProjectCodes);
                var processes = Jd.TenderProjectService.GetRecordReviewProcess(tenderProjectCodeStr);
                var pageList = list.ToPageTableResult(search, count, c =>
                {
                    c.PROCESS = processes.Where(w => w.TENDER_PROJECT_CODE == c.TENDER_PROJECT_CODE)
                        .Select(p => new {
                            p.TEXT,
                            p.VALUE,
                            LABEL = p.PROCESS_STATUS_TEXT,
                            p.PROCESS_STATUS
                        }).ToList();
                    return c;
                });
                return pageList;
            }

            return search.ToPageTableResult();
        }

        #endregion

   
    }
}