using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordReviewService
    {
        #region 监督平台门户 处长门户 登记备案 招标备案
        /// <summary>
        ///  处长门户 登记备案 招标备案 列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult CzRecordReviews(TAfcProjectModel model, SearchCondition search)
        {
            #region 查询条件

            var con = new WhereClipBuilder();

            #region 行业类型(报建类型)

            if (!string.IsNullOrWhiteSpace(model.KIND))
            {
                con.And(T_AFC_PROJECT._.KIND == model.KIND);
            }

            #endregion

            #region 工程类型

            if (!string.IsNullOrWhiteSpace(model.PROJECT_TYPE))
            {
                con.And(T_AFC_PROJECT._.PROJECT_TYPE == model.PROJECT_TYPE);
            }

            #endregion

            #region 创建时间

            if (search.BeginTime.HasValue)
            {
                con.And(RECORD_REVIEW._.CREATE_TM >= (search.BeginTime));
            }
            if (search.EndTime.HasValue)
            {
                con.And(RECORD_REVIEW._.CREATE_TM <= (search.EndTime));
            }

            #endregion

            #region 地区

            if (!string.IsNullOrWhiteSpace(model.REGION_CITY))
            {
                //con.And(TENDER_PROJECT._.REGION_CODE == model.REGION_CITY);
                con.And(T_AFC_PROJECT._.REGION_CITY == model.REGION_CITY);
            }

            #endregion

            #region 项目类型(发包方式)

            if (!string.IsNullOrWhiteSpace(model.FBFS))
            {
                var field = EntityUtils.GetField<T_AFC_PROJECT>(model.FBFS);
                if (field != null)
                {
                    con.And(field.IsNotNull());
                }
            }

            #endregion

            #region 关键字

            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                con.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(search.KeyWord)
                        || TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(search.KeyWord));
            }

            #endregion

            #region 行业主管(审批单位) 纪委监委 公安厅 默认行业过滤


            var jdUserType = JdUser?.TYPE;
            if (jdUserType==(int)JdTUserType.JiWeiJianWei|| jdUserType == (int)JdTUserType.GongAn)//是纪委或者公安
            {
                if (JdUser?.UserDepartment?.SYS_DIC_63 != null && JdUser.UserDepartment.SYS_DIC_63.Any())
                {
                    var projectTypes = JdUser.UserDepartment.SYS_DIC_63.Select(c => c.VALUE).ToList();
                    con.And(T_AFC_PROJECT._.PROJECT_TYPE.In(projectTypes));
                }
                else
                {
                    con.And(T_AFC_PROJECT._.PROJECT_TYPE == "");
                }

                if (!string.IsNullOrWhiteSpace(JdUser?.UserDepartment?.RootAreaCode))
                {
                    var rootAreaCode = JdUser.UserDepartment.RootAreaCode;
                    con.And(T_AFC_PROJECT._.REGION_COUNTY.BeginWith(rootAreaCode));
                    if (rootAreaCode == "3501")
                    {
                        con.And(T_AFC_PROJECT._.REGION_COUNTY != "350100");
                    }
                }
                else
                {
                    con.And(T_AFC_PROJECT._.REGION_CITY == "");
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
                    con.And(T_AFC_PROJECT._.APPROVAL_DEPID.In(jdUserDepartId));
                }
                else
                {
                    con.And(T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId);
                }
                #endregion
            }


            #endregion

            #endregion

            var count = FromWhere(con.ToWhereClip())
                .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .InnerJoin<PROJECT>(TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                .Count();
            if (count > 0)
            {
                var list = FromWhere(con.ToWhereClip())
                        .InnerJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                        .InnerJoin<PROJECT>(TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                        .InnerJoin<T_AFC_PROJECT>(T_AFC_PROJECT._.CODE == PROJECT._.CONSTRUCTION_ID)
                        .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE) //备案类型
                        .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                        .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                        .LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_STATUS && SYS_DIC._.TYPE == "3028")
                        .Page(search.PageSize, search.PageNo)
                        .OrderByDescending(RECORD_REVIEW._.CREATE_TM)
                        .Select(
                           TENDER_PROJECT._.TENDER_PROJECT_NAME,
                           TENDER_PROJECT._.TENDER_PROJECT_CODE,
                           SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),//备案类型
                           SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),//地区
                            new Field("TEXT", "SYS_DIC2").As("PROJECT_TYPE_NAME"),//工程类型
                           RECORD_REVIEW._.ID,
                           //RECORD_REVIEW._.
                            RECORD_REVIEW._.CREATE_TM,
                           TENDER_PROJECT._.TENDERER_NAME,
                           TENDER_PROJECT._.TENDER_AGENCY_NAME,
                           RECORD_REVIEW._.REVIEW_TYPE,
                           RECORD_REVIEW._.REVIEW_STATUS,
                           new Field("TEXT", "SYS_DIC3").As("REVIEW_STATUS_TEXT")//备案状态

                        ).ToList<dynamic>();
                //var tenderProjectCodes = list.Select(c => c.TENDER_PROJECT_CODE).ToList();
                //var tenderProjectCodeStr = String.Join(",", tenderProjectCodes);
                //var processes = Jd.TenderProjectService.GetRecordReviewProcess(tenderProjectCodeStr);
                var pageList = list.ToPageTableResult(search, count, c =>
                {
                    //c.PROCESS= processes.Where(w => w.TENDER_PROJECT_CODE == c.TENDER_PROJECT_CODE)
                    //    .Select(p => new {
                    //        p.TEXT,
                    //        p.VALUE,
                    //        LABEL = p.PROCESS_STATUS_TEXT,
                    //        p.PROCESS_STATUS
                    //    }).ToList();
                    return c;
                });
                return pageList;
            }

            return search.ToPageTableResult();
        }


        #endregion

        #region 纪委监委
        /// <summary>
        /// 处长门户 纪委监委 发起督查 招标备案 细项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult RecordReviewSuperviseItem(TSuperviseModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(RECORD_REVIEW._.ID == model.ENTITY_ID)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == RECORD_REVIEW._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                .Select(
                    TENDER_PROJECT._.RECORD_DEPID.As("DEPID"),
                    T_USER_DEPARTMENT._.DNAME.As("SCDW"),
                    TENDER_PROJECT._.TENDER_PROJECT_CODE.As("BH"),
                    TENDER_PROJECT._.TENDER_PROJECT_NAME.As("MC"),
                    SYS_AREA_QUANGUO._.AREANAME.As("DQ"),
                    //SYS_DIC._.TEXT.As("TYPE_TEXT"),
                    new Field("'招标备案'").As("SXLX")
                ).ToFirst<object>();
            if (dbModel != null)
            {
                r.SetSuccess(dbModel);
            }
            else
            {
                r.SetFail("未找到对应的招标备案信息");
            }
            return r;
        }


        #endregion
    }
}