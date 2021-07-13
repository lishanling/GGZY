using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TAfcLogService
    {
        #region 门户报建项目查询

        public List<LabelValueModel> JdPortalProjectType(SearchCondition search)
        {
            var con = new WhereClipBuilder();
            con.And(T_AFC_LOG._.ISNEW == 1 && T_AFC_LOG._.APPROVAL_TM.IsNotNull() && T_AFC_LOG._.U_ID != -2);
            //审核通过的才显示
            con.And(T_AFC_LOG._.APPROVAL_STATE == 3);
            if (search.BeginTime.HasValue)
            {
                con.And(T_AFC_LOG._.APPROVAL_TM >= (search.BeginTime));
            }
            if (search.EndTime.HasValue)
            {
                con.And(T_AFC_LOG._.APPROVAL_TM <= (search.EndTime));
            }
            var groups = FromWhere(con.ToWhereClip()).GroupBy(T_AFC_LOG._.PROJECT_TYPE)
                .Select(T_AFC_LOG._.PROJECT_TYPE.As("Label"), T_AFC_LOG._.All.Count().As("Value"))
                .ToList<LabelValueModel>();
            var projectTypes = groups.FindAll(c => String.CompareOrdinal(c.Value, "0") > 0).Select(c => c.Label).ToList();
            var r = new List<LabelValueModel>(){new LabelValueModel{Id="",Label="全部",Value = ""}};
            var sysDic = Jd.SysDicService.FindList(SYS_DIC._.TYPE == "20200830002" &&
                                                   SYS_DIC._.VALUE.In(projectTypes), SYS_DIC._.ORDER_ID.Asc);
            r.AddRange(sysDic.Select(c=>new LabelValueModel
            {
                Id=c.ID?.ToString(),Label=c.TEXT,Value = c.VALUE
            }));
            return r;
        }

        /// <summary>
        /// 注册用户项目报建列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ProjectReportBuildSearch(T_AFC_LOG model, SearchCondition search)
        {
            var notRegionCode = "";
            if (!string.IsNullOrWhiteSpace(model.REGION_CITY))
            {
                if (model.REGION_CITY != "350128")
                {
                    var cityCode = model.REGION_CITY.TrimEnd('0');
                    if (cityCode.Length % 2 > 0)
                    {
                        cityCode += "0";
                    }
                    if (cityCode.Length != 6)
                    {
                        model.REGION_CITY = cityCode;
                        if (cityCode == "3501") //排除福州市底下的平潭（因为两个同处于市级）
                        {
                            notRegionCode = "350128";
                        }
                    }
                    else
                    {
                        model.REGION_COUNTY = cityCode;
                        model.REGION_CITY = String.Empty;
                    }
                }
            }
            var con = ConditionBuilder(model);

            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                con.And(T_AFC_LOG._.CODE.Contain(search.KeyWord)
                        || T_AFC_LOG._.PROJECT_NAME.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                con.And(T_AFC_LOG._.APPROVAL_TM >= (search.BeginTime));
            }
            if (search.EndTime.HasValue)
            {
                con.And(T_AFC_LOG._.APPROVAL_TM <= (search.EndTime));
            }
            if (!string.IsNullOrWhiteSpace(notRegionCode))
            {
                con.And(T_AFC_LOG._.REGION_COUNTY != notRegionCode);

            }
            //这个全网报建，只展示在已通过审批的报建，不包含未通过审批的
            //在线审批平台同步过来的报建 只展示已绑定过账号的报建，未绑定过的报建不展示
            //在线审批平台同步过来的报建 只展示已绑定过账号的报建，未绑定过的报建不展示改成都显示 ysf 20201027 提出修改意见
            con.And(T_AFC_LOG._.ISNEW == 1 && T_AFC_LOG._.APPROVAL_TM.IsNotNull());// && T_AFC_LOG._.U_ID!=-2
            //审核通过的才显示
            con.And(T_AFC_LOG._.APPROVAL_STATE ==3);
            var count = Count(con.ToWhereClip());
            var list = FromWhere(con.ToWhereClip())
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_LOG._.REGION_CITY)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_LOG._.REGION_COUNTY)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_LOG._.PROJECT_TYPE) //工程类别
                .LeftJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_LOG._.CODE) //招标项目编号
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_LOG._.APPROVAL_STATE.ToChar()) //审查状态
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_LOG._.RECORDER_TACHE.ToChar()) //审查环节  
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_LOG._.APPROVAL_DEPID) //审查单位   
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_AFC_LOG._.TM)
                .Select(
                    T_AFC_LOG._.All,
                    SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                    new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                    SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                    new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                    new Field("TEXT", "SYS_DIC3").As("RECORDER_TACHE_NAME"),
                    T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                    T_AFC_LOG._.ID.As("OPRATION")
                ).ToList<TAfcLogModel>().ToPageTableResult(search, count, c => new
                {
                    mid = c.AFC_ID?.DesEncrypt(),
                    c.CODE,
                    c.PROJECT_NAME,
                    c.PROJECT_CODE,
                    c.TZ_CODE,
                    c.PROJECT_TYPE_NAME,
                    c.APPROVAL_STATE_TACHE_NAME,
                    c.REGION,
                    c.TM,
                    c.DEP_NAME,
                    c.APPROVAL_DEPNAME,
                    c.APPROVAL_TM,
                    c.JS_DEP,
                    Buttons=new List<string>() { "VIEW"}
                });
            return list;
        }

        #endregion


        /// <summary>
        /// 项目报建流程状态
        /// </summary>
        /// <param name="mid"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public List<TAfcLogModel> ProjectReportBuildProcess(string mid,Func<string,string>urlBuilder=null)
        {
            var afcId = mid;//.DesDecrypt();
            var list=FromWhere(T_AFC_LOG._.AFC_ID==afcId)
                .LeftJoin<T_USER>(T_USER._.ID==T_AFC_LOG._.RECORDER_UID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66"&&SYS_DIC._.VALUE == T_AFC_LOG._.RECORDER_TACHE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "70" && SYS_DIC._.VALUE == T_AFC_LOG._.RECORDER_OPERATION)
                .OrderBy(T_AFC_LOG._.RECORDER_TM.Desc)
                .Select(T_AFC_LOG._.All,
                    T_USER._.MANAGE_NAME.As("RECORDER_UID_NAME"),
                    SYS_DIC._.TEXT.As("RECORDER_TACHE_NAME"),
                    new Field("TEXT","SYS_DIC2").As("RECORDER_OPERATION_NAME")
                ).ToList<TAfcLogModel>();
            foreach (var m in list)
            {
                m.Attachments = Jd.SysAttachmentService.FindAttachment(m.RECORDER_AIDS, urlBuilder);
            }
            return list;
        }

        /// <summary>
        /// 项目详情-监察痕迹-招标计划
        /// </summary>
        /// <param name="jdTenderProjectCode"></param>
        /// <returns></returns>
        public List<TAfcLogModel> GetAFC_Logs(string jdTenderProjectCode)
        {
        
            var list = Jd.TenderProjectService.FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE==jdTenderProjectCode)
                .InnerJoin<PROJECT>(PROJECT._.PROJECT_CODE==TENDER_PROJECT._.PROJECT_CODE)
                .LeftJoin<T_AFC_LOG>(PROJECT._.CONSTRUCTION_ID == T_AFC_LOG._.CODE)
                .LeftJoin<T_USER>(T_USER._.ID == T_AFC_LOG._.RECORDER_UID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_LOG._.RECORDER_TACHE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "70" && SYS_DIC._.VALUE == T_AFC_LOG._.RECORDER_OPERATION)
                .OrderBy(T_AFC_LOG._.RECORDER_TM.Desc)
                .Select(T_AFC_LOG._.All,
                    T_USER._.MANAGE_NAME.As("RECORDER_UID_NAME"),
                    SYS_DIC._.TEXT.As("RECORDER_TACHE_NAME"),
                    new Field("TEXT", "SYS_DIC2").As("RECORDER_OPERATION_NAME")
                ).ToList<TAfcLogModel>();
            foreach (var m in list)
            {
                m.Attachments = Jd.CommonService.Attachments(m.RECORDER_AIDS, "Sys",true); 
            }
            return list;
        }
    }
}