using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    /// <summary>
    /// 监督平台门户 处长版
    /// </summary>
    public partial class TAfcProjectService
    {

        /// <summary>
        /// 招标计划登记 行业类型 报建类别 1-7 
        /// </summary>
        /// <returns></returns>
        public List<LabelValueModel> AfcProjectKind()
        {
            var dic = Jd.SysDicService.FindDicByType("76");
            var r = new List<LabelValueModel>();
            if (JdUser?.UserDepartment?.HY_TYPE_LIST != null && JdUser.UserDepartment.HY_TYPE_LIST.Any())
            {
                r = dic.FindAll(c => JdUser.UserDepartment.HY_TYPE_LIST.Any(h => h == c.VALUE)).Select(c => new LabelValueModel { Id = c.ID?.ToString(), Value = c.VALUE, Label = c.TEXT.Replace("行业", "") })
                    .ToList();
            }
            return r;
        }
        /// <summary>
        /// 项目类型 发包方式
        /// </summary>
        /// <param name="kind"></param>
        /// <returns></returns>
        public List<LabelValueModel> AfcProjectFBFS(string kind = "")
        {
            var r = new List<LabelValueModel>
            {
                new LabelValueModel {Id = "", Label = "全部", Value = ""},
                new LabelValueModel {Id = "", Label = "勘察", Value = "FBFS_SURVEY"},
                new LabelValueModel {Id = "", Label = "设计", Value = "FBFS_DESIGN"},
                new LabelValueModel {Id = "", Label = "施工", Value = "FBFS_CONSTRUCT"},
                new LabelValueModel {Id = "", Label = "监理", Value = "FBFS_SUPERVISION"},
                new LabelValueModel {Id = "", Label = "重要设备和材料", Value = "FBFS_SBCL"},
                new LabelValueModel {Id = "", Label = "工程总承包", Value = "FBFS_CONTRACT"}
            };
            if (kind == "3")
            {
                r.Add(new LabelValueModel { Id = "", Label = "勘察设计", Value = "FBFS_CKSJ" });
                r.Add(new LabelValueModel { Id = "", Label = "试验检测", Value = "FBFS_SYJC" });
                r.Add(new LabelValueModel { Id = "", Label = "设计咨询", Value = "FBFS_SJZX" });
                r.Add(new LabelValueModel { Id = "", Label = "其他", Value = "FBFS_OTHER" });
            }
            return r;
        }
        /// <summary>
        /// 招标计划登记 工程类型
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 【行业部门】
        /// 该标签内容，根据当前账号所属的行业，对应展示标签
        /// 【纪委】
        /// 该标签内容，根据当前账号所属的行业，对应展示标签
        /// 如配置时管辖行业设置为多个行业，则可见多个行业，该标签对应展示多个行业子项内容
        /// 【公安】
        /// 该标签内容，根据当前账号所属的行业，对应展示标签
        /// 如配置时管辖行业设置为多个行业，则可见多个行业，该标签对应展示多个行业子项内容
        /// </remarks>
        public List<LabelValueModel> AfcProjectType(string kind = "")
        {

            var r = new List<LabelValueModel>();
            if (JdUser?.UserDepartment?.SYS_DIC_63 != null && JdUser.UserDepartment.SYS_DIC_63.Any())
            {
                var projectTypes = JdUser.UserDepartment.SYS_DIC_63;
                if (!string.IsNullOrWhiteSpace(kind))
                {
                    projectTypes = projectTypes.FindAll(c => c.VALUE2 == kind);
                }
                r = projectTypes.Select(c => new LabelValueModel { Id = c.ID?.ToString(), Value = c.VALUE, Label = c.TEXT })
                    .ToList();
            }

            //var allValue = "-";
            //if (r.Any())
            //{
            //    allValue = string.Join(",", r.Select(o => o.Value));
            //}
            r.Insert(0, new LabelValueModel { Label = "全部", Value = "", Id = String.Empty });
            return r;
        }

        

        /// <summary>
        /// 招标计划登记列表 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult AfcProjects(TAfcProjectModel model, SearchCondition search)
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
                con.And(T_AFC_PROJECT._.TM >= (search.BeginTime));
            }
            if (search.EndTime.HasValue)
            {
                con.And(T_AFC_PROJECT._.TM <= (search.EndTime));
            }

            #endregion

            #region 地区

            if (!string.IsNullOrWhiteSpace(model.REGION_CITY))
            {
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
                con.And(T_AFC_PROJECT._.CODE.Contain(search.KeyWord)
                        || T_AFC_PROJECT._.PROJECT_NAME.Contain(search.KeyWord));
            }

            #endregion

            #region 行业主管(审批单位) 纪委监委 公安厅 默认行业过滤

            var jdUserType = JdUser?.TYPE;
            if (jdUserType == (int)JdTUserType.JiWeiJianWei || jdUserType == (int)JdTUserType.GongAn)//是纪委或者公安
            {
                if (JdUser?.UserDepartment?.SYS_DIC_63 != null && JdUser.UserDepartment.SYS_DIC_63.Any())
                {
                    var projectTypes = JdUser.UserDepartment.SYS_DIC_63.Select(c => c.VALUE).ToList();
                    con.And(T_AFC_PROJECT._.PROJECT_TYPE.In(projectTypes));
                }
                else
                {
                    con.And(T_AFC_PROJECT._.PROJECT_TYPE=="");
                }

                if (!string.IsNullOrWhiteSpace(JdUser?.UserDepartment?.RootAreaCode))
                {
                    var rootAreaCode = JdUser.UserDepartment.RootAreaCode;
                    con.And(T_AFC_PROJECT._.REGION_COUNTY.BeginWith(rootAreaCode));
                    if (rootAreaCode == "3501")
                    {
                        con.And(T_AFC_PROJECT._.REGION_COUNTY!="350100");
                    }
                }
                else
                {
                    con.And(T_AFC_PROJECT._.REGION_CITY=="");
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


            var count = Count(con.ToWhereClip());
            if (count > 0)
            {
                var list = FromWhere(con.ToWhereClip())
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE.ToChar()) //审查状态
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_TACHE.ToChar()) //审查环节
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位                                                                      
                    .Page(search.PageSize, search.PageNo)
                    .OrderByDescending(T_AFC_PROJECT._.TM)
                    .Select(
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                        new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                        SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                        new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                        new Field("TEXT", "SYS_DIC3").As("APPROVAL_TACHE_NAME"),
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        T_AFC_PROJECT._.ID.As("OPRATION"),
                        //new Field("(SELECT COUNT(1) FROM T_TUISONG WHERE T_TUISONG.ID=T_AFC_PROJECT.ID AND T_TUISONG.TABLENAME='T_AFC_PROJECT')").As("SendCount"),
                        T_AFC_PROJECT._.All
                    ).ToList<TAfcProjectModel>();
                var pageList = list.ToPageTableResult(search, count, c =>
                {
                    //c.MID = c.ID.DesEncrypt();
                    return c;
                });
                return pageList;
            }


            return search.ToPageTableResult();

        }

        /// <summary>
        /// 纪委监委 发起督查 招标计划登记 细项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult AfcSuperviseItem(TSuperviseModel model)
        {
            var r = new GeneralResult();
            var dbModel=FromWhere(T_AFC_PROJECT._.ID==model.ENTITY_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE==T_AFC_PROJECT._.REGION_CITY)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                .Select(
                    T_AFC_PROJECT._.APPROVAL_DEPID.As("DEPID"),
                    SYS_AREA_QUANGUO._.AREANAME.OracleConcat(new Field("AREANAME", "SYS_AREA_QUANGUO2")).As("DQ"),
                    //SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                    T_USER_DEPARTMENT._.DNAME.As("SCDW"),
                    T_AFC_PROJECT._.CODE.As("BH"),
                    T_AFC_PROJECT._.PROJECT_NAME.As("MC"),
            new Field("'招标计划登记'").As("SXLX")).ToFirst<TAfcProjectModel>();
            if (dbModel != null)
            {
                r.SetSuccess(dbModel);
            }
            else
            {
                r.SetFail("未找到对应的招标计划登记信息");
            }
            return r;
        }
    }
}