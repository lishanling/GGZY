using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using Aspose.Words;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;


namespace GGZY.Services.JianDu
{
    public partial class TAfcProjectService
    {

        #region 注册用户项目报建

        /// <summary>
        /// 注册用户项目报建列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ProjectReportBuild(T_AFC_PROJECT model, SearchCondition search)
        {
            var notRegionCode = "";

            #region 查询条件构建

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
                con.And(T_AFC_PROJECT._.CODE.Contain(search.KeyWord)
                        || T_AFC_PROJECT._.PROJECT_NAME.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                con.And(T_AFC_PROJECT._.TM >= (search.BeginTime));
            }
            if (search.EndTime.HasValue)
            {
                con.And(T_AFC_PROJECT._.TM <= (search.EndTime));
            }

            if (!string.IsNullOrWhiteSpace(notRegionCode))
            {
                con.And(T_AFC_PROJECT._.REGION_COUNTY != notRegionCode);
            }

            con.And(T_AFC_PROJECT._.U_ID == JdUser.ID);

            #endregion

            var count = Count(con.ToWhereClip());
            var list = FromWhere(con.ToWhereClip())
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE.ToChar()) //审查状态
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_TACHE.ToChar()) //审查环节
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位
                                                                                                          //.LeftJoin<T_TUISONG>(T_TUISONG._.ID == T_AFC_PROJECT._.ID&&T_TUISONG._.TABLENAME== "T_AFC_PROJECT")
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_AFC_PROJECT._.TM)
                .Select(
                    T_AFC_PROJECT._.All,
                    SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                    new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                    SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                    new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                    new Field("TEXT", "SYS_DIC3").As("APPROVAL_TACHE_NAME"),
                    T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                    T_AFC_PROJECT._.ID.As("OPRATION"),
                    new Field("(SELECT COUNT(1) FROM T_TUISONG WHERE T_TUISONG.ID=T_AFC_PROJECT.ID AND T_TUISONG.TABLENAME='T_AFC_PROJECT')").As("SendCount")
                ).ToList<TAfcProjectModel>().ToPageTableResult(search, count, c =>
                 {
                     #region 可操作按钮

                     if (c.APPROVAL_TACHE == 1)
                     {
                         if (c.APPROVAL_STATE == 1)
                         {
                             c.Buttons.Add("DELETE");//初建+提交=删除
                             c.Buttons.Add("UPDATE");//初建+提交=编辑
                         }
                         if (c.APPROVAL_STATE == 4)
                         {
                             c.Buttons.Add("UPDATE");//初建+不通过=编辑
                         }
                     }

                     //if (c.APPROVAL_TACHE == 2 && c.APPROVAL_STATE == 3)
                     //{
                     //    c.Buttons.Add("UPDATE");//变更申请+通过=编辑
                     //}
                     if (c.APPROVAL_TACHE == 3)
                     {
                         if (c.APPROVAL_STATE == 1 || c.APPROVAL_STATE == 4)
                         {
                             c.Buttons.Add("UPDATE");//报建变更+提交=编辑 报建变更+不通过=编辑
                         }
                     }

                     if (c.APPROVAL_TACHE != 4 && c.APPROVAL_DEPID == "99999")
                     {
                         c.Buttons.Add("BULU");
                         c.Buttons.Add("UNBIND");
                     }

                     if (!c.Buttons.Exists(o => o == "UPDATE"))
                     {
                         c.Buttons.Add("VIEW");
                     }
                     //c.MID = c.ID.DesEncrypt();
                     //if (c.APPROVAL_TACHE == 2 && c.APPROVAL_STATE != 3)
                     //{//修改为 报建申请+非通过=变更申请
                     //    c.Buttons.Add("CHANGE");
                     //}
                     if ((c.APPROVAL_TACHE == 1 || c.APPROVAL_TACHE == 3 || c.APPROVAL_TACHE == 4) &&
                         c.APPROVAL_STATE == 3)//初建+通过  报建变更+通过 补录+通过 =变更申请
                     {
                         c.Buttons.Add("CHANGE");
                     }
                     #endregion
                     return c;
                 });

            return list;
        }

        /// <summary>
        /// 报建详情,通过招标项目编号获取
        /// </summary>
        /// <param name="tenderProjectCode">招标项目编号</param>
        /// <returns></returns>
        /// <remarks>
        /// 根据返回的PROJECT_TYPE 工程类别 展示不同的 工程用途
        /// </remarks>
        public TAfcProjectModel ProjectReportBuildDetailByCode(string tenderProjectCode)
        {
            var obj = FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE == tenderProjectCode)
                    .LeftJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.CODE)
                    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE) //审查状态
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_TACHE) //审查环节
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "64" && SYS_DIC._.VALUE == T_AFC_PROJECT._.TENDER_ORGANIZE_FORM) //招标组织形式
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "28" && SYS_DIC._.VALUE1 == T_AFC_PROJECT._.IS_DJZ) //是否采用代建制
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "28" && SYS_DIC._.VALUE1 == T_AFC_PROJECT._.ISMAJOR) //审查环节
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "69" && SYS_DIC._.VALUE == T_AFC_PROJECT._.KIND) //报建类型
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "77" && SYS_DIC._.VALUE == T_AFC_PROJECT._.JSXZ) //建设性质
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "78" && SYS_DIC._.VALUE == T_AFC_PROJECT._.GCYT) //工程用途
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位
                    .Select(T_AFC_PROJECT._.All,
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                        new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                        SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                        new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                        new Field("TEXT", "SYS_DIC3").As("APPROVAL_TACHE_NAME"),
                        new Field("TEXT", "SYS_DIC4").As("TENDER_ORGANIZE_FORM_NAME"),
                        new Field("TEXT", "SYS_DIC5").As("IS_DJZ_NAME"),
                        new Field("TEXT", "SYS_DIC6").As("ISMAJOR_NAME"),
                        new Field("TEXT", "SYS_DIC7").As("KIND_TEXT"),
                        new Field("TEXT", "SYS_DIC8").As("JSXZ_TEXT"),
                        new Field("TEXT", "SYS_DIC9").As("GCYT_TEXT"),
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        T_USER_DEPARTMENT._.PHONE.As("APPROVAL_DEP_PHONE"),
                        T_AFC_PROJECT._.ID.As("OPRATION")
                ).ToFirst<TAfcProjectModel>();

            #region 附件构造

            if (obj != null)
            {
                obj.JS_CODE_ATTACHMENT = Jd.CommonService.Attachments(obj.JS_CODE_AIDS, "Sys", true);
                obj.APPROVAL_ATTACHMENT = Jd.CommonService.Attachments(obj.APPROVAL_AIDS, "Sys", true);
                obj.REGISTER_ATTACHMENT = Jd.CommonService.Attachments(obj.REGISTER_AIDS, "Sys", true);
                obj.OTHER_ATTACHMENT = Jd.CommonService.Attachments(obj.OTHER_AIDS, "Sys", true);
                obj.ZBHZYJS_ATTACHMENT = Jd.CommonService.Attachments(obj.ZBHZYJS_AIDS, "Sys", true);
            }

            #endregion
            return obj;
        }
        /// <summary>
        /// 报建详情
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        /// <remarks>
        /// 根据返回的PROJECT_TYPE 工程类别 展示不同的 工程用途
        /// </remarks>
        public TAfcProjectModel ProjectReportBuildDetail(string mid)
        {
            var id = mid;//.DesDecrypt();
            var obj = FromWhere(T_AFC_PROJECT._.ID == id)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE) //审查状态
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_TACHE) //审查环节
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "64" && SYS_DIC._.VALUE == T_AFC_PROJECT._.TENDER_ORGANIZE_FORM) //招标组织形式
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "28" && SYS_DIC._.VALUE1 == T_AFC_PROJECT._.IS_DJZ) //是否采用代建制
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "28" && SYS_DIC._.VALUE1 == T_AFC_PROJECT._.ISMAJOR) //审查环节
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "69" && SYS_DIC._.VALUE == T_AFC_PROJECT._.KIND) //报建类型
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "77" && SYS_DIC._.VALUE == T_AFC_PROJECT._.JSXZ) //建设性质
                    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "78" && SYS_DIC._.VALUE == T_AFC_PROJECT._.GCYT) //工程用途
                    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位
                    .Select(T_AFC_PROJECT._.All,
                        SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                        new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                        SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                        new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                        new Field("TEXT", "SYS_DIC3").As("APPROVAL_TACHE_NAME"),
                        new Field("TEXT", "SYS_DIC4").As("TENDER_ORGANIZE_FORM_NAME"),
                        new Field("TEXT", "SYS_DIC5").As("IS_DJZ_NAME"),
                        new Field("TEXT", "SYS_DIC6").As("ISMAJOR_NAME"),
                        new Field("TEXT", "SYS_DIC7").As("KIND_TEXT"),
                        new Field("TEXT", "SYS_DIC8").As("JSXZ_TEXT"),
                        new Field("TEXT", "SYS_DIC9").As("GCYT_TEXT"),
                        T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                        T_USER_DEPARTMENT._.PHONE.As("APPROVAL_DEP_PHONE"),
                        T_AFC_PROJECT._.ID.As("OPRATION")
                ).ToFirst<TAfcProjectModel>();

            #region 附件构造

            if (obj != null)
            {
                #region 附件处理

                obj.JS_CODE_ATTACHMENT = Jd.CommonService.Attachments(obj.JS_CODE_AIDS, "Sys", true);
                obj.APPROVAL_ATTACHMENT = Jd.CommonService.Attachments(obj.APPROVAL_AIDS, "Sys", true);
                obj.REGISTER_ATTACHMENT = Jd.CommonService.Attachments(obj.REGISTER_AIDS, "Sys", true);
                obj.OTHER_ATTACHMENT = Jd.CommonService.Attachments(obj.OTHER_AIDS, "Sys", true);
                obj.ZBHZYJS_ATTACHMENT = Jd.CommonService.Attachments(obj.ZBHZYJS_AIDS, "Sys", true);

                #endregion
                #region 操作按钮

                if (JdUser != null)
                {

                    #region 报建用户操作按钮

                    if (obj.U_ID == JdUser.ID && JdUser.TYPE == (int)JdTUserType.BaoJianBeiAnYongHu)//当前用户为填报人
                    {
                        if (obj.APPROVAL_TACHE == 1 && obj.APPROVAL_STATE == 2)//初建+待审批=撤回
                        {
                            obj.Buttons.Add("REVOKE");
                        }

                        #region 修改为 报建申请+非通过=变更申请

                        //if (obj.APPROVAL_TACHE == 2 && obj.APPROVAL_STATE == 4)//变更申请+不通过=变更申请
                        //{
                        //    obj.Buttons.Add("CHANGE");
                        //}
                        //if (obj.APPROVAL_TACHE == 2 && obj.APPROVAL_STATE != 3)
                        //{//报建申请+非通过=暂存|提交
                        //    obj.Buttons.Add("TEMP");
                        //    obj.Buttons.Add("SAVE");
                        //}

                        #endregion
                        if (obj.APPROVAL_TACHE == 2 && obj.APPROVAL_STATE != 3)
                        {//修改为 报建申请+非通过=变更申请
                            obj.Buttons.Add("CHANGE");
                        }
                        if ((obj.APPROVAL_TACHE == 1 || obj.APPROVAL_TACHE == 3 || obj.APPROVAL_TACHE == 4) &&
                            obj.APPROVAL_STATE == 3)//初建+通过  报建变更+通过 补录+通过 =变更申请
                        {
                            obj.Buttons.Add("CHANGE");
                        }

                        if (!obj.Buttons.Exists(c => c.Equals("CHANGE", StringComparison.CurrentCultureIgnoreCase)))
                        {

                            if ((obj.APPROVAL_TACHE == 1 || obj.APPROVAL_TACHE == 3) && (obj.APPROVAL_STATE == 1 || obj.APPROVAL_STATE == 4))
                            {//初建+提交=暂存|提交  初建+不通过=暂存|提交  报建变更+提交=暂存|提交  报建变更+不通过=暂存|提交
                             //todo 住建报建没有暂存 http://114.115.162.43:8900/redmine/issues/192
                                if (obj.KIND != "1")
                                {
                                    obj.Buttons.Add("TEMP");
                                }

                                obj.Buttons.Add("SAVE");
                            }


                            if (obj.APPROVAL_TACHE != 4 && obj.APPROVAL_DEPID == "99999")//补录
                            {//报建申请+非通过=暂存|提交
                                obj.Buttons.Add("TEMP");
                                obj.Buttons.Add("SAVE");
                            }

                        }

                        if (obj.APPROVAL_TACHE != 4 && obj.APPROVAL_DEPID == "99999")
                        {
                            obj.Buttons.Add("UNBIND");
                        }
                    }

                    #endregion

                    #region 审批用户操作按钮

                    if (obj.APPROVAL_DEPID == JdUser.DEPARTID?.ToString())//当前用户为审批单位
                    {
                        if (obj.APPROVAL_STATE == 2)//待审批
                        {
                            if ((obj.APPROVAL_TACHE == 1 || obj.APPROVAL_TACHE == 3) && JdUser.HasPermission("JdTAfcProject", "Approval"))//待审批+初建 待审批+报建变更  报建审批//
                            {
                                obj.Buttons.Add("PASS");//通过
                                obj.Buttons.Add("UNPASS");//不通过
                            }

                            if ((obj.APPROVAL_TACHE == 2) && JdUser.HasPermission("JdTAfcProject", "ChangeApproval"))//待审批+变更申请 =变更审批
                            {
                                obj.Buttons.Add("CENSOR");

                                obj.AfcChange =
                                    Jd.TAfcChangeService.FirstOrNull(T_AFC_CHANGE._.AFC_ID == obj.ID &&
                                                                     T_AFC_CHANGE._.APPROVAL_STATE == 1);
                                if (obj.AfcChange != null)
                                {
                                    obj.CHANGE_AIDS = obj.AfcChange.AIDS;
                                    obj.CHANGE_AIDS_ATTACHMENT = Jd.CommonService.Attachments(obj.CHANGE_AIDS, "Sys", true);

                                }
                            }
                        }

                        if (obj.APPROVAL_TACHE == 2 && obj.APPROVAL_STATE == 4)//变更申请+不通过=报建作废
                        {
                            obj.Buttons.Add("VOIDED");
                        }
                        else if ((obj.APPROVAL_TACHE == 1 || obj.APPROVAL_TACHE == 3 || obj.APPROVAL_TACHE == 4) && obj.APPROVAL_STATE == 3)
                        {//初建+通过  报建变更+通过 补录+通过 =报建作废
                            obj.Buttons.Add("VOIDED");
                        }
                    }

                    #endregion
                }

                obj.Buttons.Add("PREVIEW");//预览
                obj.Buttons.Add("PROCESS");//流程状态
                //obj.MID = obj.ID?.ToString().DesEncrypt();

                #endregion

            }

            #endregion
            return obj;
        }
        /// <summary>
        /// 报建项目删除
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public GeneralResult DeleteAfcProject(string mid)
        {
            var r = new GeneralResult();
            var id = mid;//.DesDecrypt();
            var entity = FirstOrNull(T_AFC_PROJECT._.ID == id);
            if (entity == null || !(entity.APPROVAL_TACHE == 1 && entity.APPROVAL_STATE == 1))
            {
                r.SetFail("未找到该报建或该报建无法删除");
            }
            else
            {
                Delete(entity);
                r.SetSuccess();
            }
            return r;
        }

        #region 预览

        /// <summary>
        /// 预览
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public GeneralResult PreviewAfcProject(string mid)
        {
            var entity = ProjectReportBuildDetail(mid);
            entity.REGION_CITY = entity.REGION_CITY_NAME;
            entity.REGION_COUNTY = entity.REGION_COUNTY_NAME;
            entity.TENDER_ORGANIZE_FORM = entity.TENDER_ORGANIZE_FORM_NAME;

            return AfcProjectStream(entity);
        }


        /// <summary>
        /// 生成pdf文件
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public GeneralResult AfcProjectStream(TAfcProjectModel entity)
        {
            var r = new GeneralResult();
            var fileName = string.Empty;
            var kind = (TAfcProjectKind)Enum.Parse(typeof(TAfcProjectKind), entity.KIND);
            switch (kind)
            {
                case TAfcProjectKind.ZhuJian:
                    fileName = "工程建设项目报建登记表";
                    break;
                case TAfcProjectKind.ShuiLi:
                    fileName = "水利工程项目报建登记表";
                    break;
                case TAfcProjectKind.JiaoTong:
                    fileName = "交通工程建设项目报建登记表";
                    break;
                case TAfcProjectKind.NongYe:
                    fileName = "农业工程项目报建登记表";
                    break;
                case TAfcProjectKind.HangYangYuGang:
                    fileName = "海洋渔港项目报建登记表";
                    break;
                case TAfcProjectKind.XinXi:
                    fileName = "信息化项目报建登记表";
                    break;
                case TAfcProjectKind.GongYe:
                    fileName = "工业项目报建登记表";
                    break;
            }
            var version = entity.IsV9527 ? "v9527" : String.Empty;
            var fullPath =
                HttpContext.Current?.Server.MapPath($"~/Infrastructure/Templates/XMZBJH/{fileName}{version}.doc");
            if (!File.Exists(fullPath))
            {
                r.SetFailEx($"获取文件模板失败", $"Kind={entity.KIND},Version={version},Path={fullPath}");
                return r;
            }

            var ms = new MemoryStream();
            var word = new AsposeWord(fullPath);

            #region 模板生成

            var props = entity.GetPropertyInfos();
            foreach (var prop in props)
            {
                var valueStr = string.Empty;
                var key = prop.Name;
                if (prop.GetValue(entity) != null)
                {
                    valueStr = prop.GetValue(entity).ToString();
                    //if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                    //{
                    //    valueStr = ((DateTime) prop.GetValue(entity)).ToString("yyyy-MM-dd");
                    //}
                }
                #region 文本替换

                switch (prop.Name)
                {
                    case "PROJECT_TYPE": //工程类别
                        var dic63 = Jd.SysDicService.FindDicByType("63");
                        foreach (var item in dic63)
                        {
                            var oleText = $"{{{key}_{item.VALUE}}}";
                            var newText = "□";
                            if (!string.IsNullOrWhiteSpace(valueStr) && valueStr.Contains(item.VALUE))
                            {
                                newText = "√";
                            }
                            word.ReplaceText(oleText, newText);
                        }
                        break;
                    case "CONTRIBUTION_SCALE_SB": //数办批复资金投资比例
                        if (!entity.CONTRIBUTION_SCALE_SB.HasValue)
                        {
                            valueStr = "-";
                        }
                        word.ReplaceText($"{{{key}}}", valueStr);
                        break;
                    case "JSXZ": //建设性质
                        var dic77 = Jd.SysDicService.FindDicByType("77");
                        foreach (var item in dic77)
                        {
                            var oleText = $"{{{key}_{item.VALUE}}}";
                            var newText = "□";
                            if (!string.IsNullOrWhiteSpace(valueStr) && valueStr.Contains(item.VALUE))
                            {
                                newText = "√";
                            }
                            word.ReplaceText(oleText, newText);
                        }
                        break;
                    case "GCYT": //工程用途
                        var dic78 = Jd.SysDicService.FindDicByType("78");
                        var dic = dic78.FindAll(c => c.VALUE2 == entity.PROJECT_TYPE);
                        var valStr = "";
                        foreach (var sysDic in dic)
                        {
                            valStr += $"{{GCYT_{sysDic.VALUE}}}{sysDic.TEXT} ";
                        }
                        word.ReplaceText("{GCYT}", valStr);
                        foreach (var item in dic78)
                        {
                            var oleText = $"{{{key}_{item.VALUE}}}";
                            var newText = "□";
                            if (!string.IsNullOrWhiteSpace(valueStr) && valueStr.Contains(item.VALUE))
                            {
                                newText = "√";
                            }
                            word.ReplaceText(oleText, newText);
                        }

                        break;
                    case "FBFS_SURVEY":       //勘察
                    case "FBFS_DESIGN":       //设计
                    case "FBFS_CONSTRUCT":    //施工
                    case "FBFS_SUPERVISION":  //监理
                    case "FBFS_SBCL":         //重要设备和材料
                    case "FBFS_CONTRACT":     //工程总承包
                    case "FBFS_CKSJ":         //勘察设计
                    case "FBFS_SYJC":         //试验检测
                    case "FBFS_SJZX":         //设计咨询
                    case "FBFS_OTHER":        //其他
                        word.ReplaceText($"{{{key}_CHECK}}", valueStr != "" ? "√" : "□");
                        var textValue62 = Jd.SysDicService.FindDicByType("62");
                        foreach (var item in textValue62)
                        {
                            var oleText = $"{{{key}_{item.VALUE}}}";
                            var newText = "□";
                            if (!string.IsNullOrWhiteSpace(valueStr) && valueStr.Contains(item.VALUE))
                            {
                                newText = "√";
                            }
                            word.ReplaceText(oleText, newText);
                        }
                        break;
                    case "APPROVAL_LEVEL":
                        var textValue9527 = Jd.SysDicService.FindDicByType("9527");
                        foreach (var item in textValue9527)
                        {
                            var oleText = $"{{{key}_{item.VALUE}}}";
                            var newText = "□";
                            if (!string.IsNullOrWhiteSpace(valueStr) && valueStr.Contains(item.VALUE))
                            {
                                newText = "√";
                            }
                            word.ReplaceText(oleText, newText);
                        }
                        break;
                    case "IS_DJZ":
                        if (string.IsNullOrWhiteSpace(entity.IS_DJZ_NAME))
                        {
                            entity.IS_DJZ_NAME = entity.IS_DJZ == 1 ? "是" : "否";
                        }
                        word.ReplaceText($"{{{key}}}", entity.IS_DJZ_NAME);
                        break;
                    case "ISMAJOR":
                        if (string.IsNullOrWhiteSpace(entity.ISMAJOR_NAME))
                        {
                            entity.ISMAJOR_NAME = entity.ISMAJOR == 1 ? "是" : "否";
                        }
                        word.ReplaceText($"{{{key}}}", entity.ISMAJOR_NAME);
                        break;
                    case "DEP_NAME":
                        if (string.IsNullOrWhiteSpace(entity.DEP_NAME) && !entity.ID.HasValue)
                        {
                            entity.DEP_NAME = JdUser?.UserExtend?.DEP_NAME;
                        }
                        word.ReplaceText($"{{{key}}}", entity.DEP_NAME);
                        break;
                    case "REGION_CITY":
                        if (string.IsNullOrWhiteSpace(entity.REGION_CITY_NAME))
                        {
                            entity.REGION_CITY = Jd.SysAreaQuanguoService
                                .FirstOrNull(SYS_AREA_QUANGUO._.AREACODE == entity.REGION_CITY)?.AREANAME;
                        }
                        word.ReplaceText($"{{{key}}}", entity.REGION_CITY);
                        break;
                    case "REGION_COUNTY":
                        if (string.IsNullOrWhiteSpace(entity.REGION_COUNTY_NAME))
                        {
                            entity.REGION_COUNTY = Jd.SysAreaQuanguoService
                                .FirstOrNull(SYS_AREA_QUANGUO._.AREACODE == entity.REGION_COUNTY)?.AREANAME;
                        }
                        word.ReplaceText($"{{{key}}}", entity.REGION_COUNTY);
                        break;
                    case "TENDER_ORGANIZE_FORM":
                        if (string.IsNullOrWhiteSpace(entity.TENDER_ORGANIZE_FORM_NAME))
                        {
                            entity.TENDER_ORGANIZE_FORM_NAME = Jd.SysDicService.FindDicByType("64").FirstOrDefault(c => c.VALUE == entity.TENDER_ORGANIZE_FORM)?.TEXT;
                        }
                        word.ReplaceText($"{{{key}}}", entity.TENDER_ORGANIZE_FORM_NAME);
                        break;
                    case "APPROVAL_DATE":
                        if (entity.APPROVAL_DATE.HasValue)
                        {
                            valueStr = entity.APPROVAL_DATE.Value.ToString("yyyy-MM-dd");
                        }
                        word.ReplaceText($"{{{key}}}", valueStr);
                        break;
                    default:
                        word.ReplaceText($"{{{key}}}", valueStr);
                        break;
                }


                #endregion
            }

            #endregion

            word.doc.Save(ms, SaveFormat.Pdf);
            ms.Seek(0, SeekOrigin.Begin);
            var uploadRes = FileHelper.Uploader.UploadStream($"{fileName}_{entity.PROJECT_NAME}.pdf", ms);
            if (uploadRes.Result)
            {
                r.SetSuccess(uploadRes.Data);
            }
            else
            {
                r.SetFail(uploadRes.Msg);
            }
            return r;
        }

        #endregion
        /// <summary>
        /// 【项目报建】撤回[初建/待审查]
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public GeneralResult Revoke(string mid)
        {
            var r = new GeneralResult();
            if (JdUser.TYPE != (int)JdTUserType.BaoJianBeiAnYongHu || JdUser.UserExtend == null || string.IsNullOrWhiteSpace(JdUser.UserExtend.DEP_NAME))
            {
                r.SetFail("权限不足，无法撤回！");
            }
            else
            {
                var model = ProjectReportBuildDetail(mid);
                if (model == null || !(model.APPROVAL_TACHE == 1 && model.APPROVAL_STATE == 2))
                {
                    r.SetFail("未找到该报建或所处流程不正确！");
                }
                else if (model.U_ID != JdUser.ID)
                {
                    r.SetFail("权限不足，报建创建人与当前用户不一致！");
                }
                else
                {
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        #region 修改审查状态

                        var id = mid;//.DesDecrypt();
                        var entity = FirstOrNull(T_AFC_PROJECT._.ID == id);
                        entity.Attach();
                        entity.APPROVAL_STATE = 1;//撤回：将状态改为“暂存”
                        entity.DATA_TIMESTAMP = DateTime.Now;
                        Update(entity);

                        #endregion

                        #region 添加操作日志

                        var log = entity.ConvertTo<T_AFC_LOG>();
                        #region 日志记录信息

                        log.AFC_ID = entity.ID;
                        log.ISNEW = 0;
                        log.RECORDER_UID = JdUser.ID;//记录人ID
                        log.RECORDER_DEPNAME = JdUser.UserExtend?.DEP_NAME;//记录-操作人单位
                        log.RECORDER_TACHE = entity.APPROVAL_TACHE;          //记录-环节
                        log.RECORDER_OPERATION = 5;  //记录-操作 撤回操作5
                        log.RECORDER_TM = entity.DATA_TIMESTAMP;               //记录-时间
                        log.RECORDER_UNAME = String.Empty;          //记录-审查人员
                        log.RECORDER_CONTACT = String.Empty;       //记录-联系方式
                        log.RECORDER_REMARK = String.Empty;        //记录-相关意见
                        log.RECORDER_AIDS = String.Empty;          //记录-附件
                        trans.Insert(log);
                        #endregion

                        #endregion

                        #region 报建撤回时的短信

                        var msgConfig = ConfigHelper.AppSettings.SmsBJRetract;
                        var msg = string.Format(msgConfig, HttpUtility.HtmlDecode(entity.PROJECT_NAME),
                            JdUser.UserExtend.DEP_NAME);
                        SendMsg2ApprovalDep(entity.APPROVAL_DEPID, msg, trans);
                        #endregion
                        trans.Commit();
                    }
                    r.SetSuccess();
                }
            }

            return r;
        }
        /// <summary>
        /// 使用投资在线平台项目代码绑定报建信息到本账号(住建)
        /// lyy
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult CheckProjectFromTZZXPT(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            var entity = FirstOrNull(T_AFC_PROJECT._.CODE == model.CODE
                                     && T_AFC_PROJECT._.TZ_CODE == model.TZ_CODE
                                     && T_AFC_PROJECT._.KIND == 1);
            if (entity != null)
            {
                if (entity.U_ID != -2)
                {
                    r.SetFail("该报建信息已被绑定");
                }
                else
                {
                    r.SetSuccess(true);
                }
            }
            else
            {
                r.SetSuccess(false);
                //r.SetFail("未查询到对应报建编号和投资项目代码数据");
            }
            return r;
        }

        /// <summary>
        /// 使用投资在线平台项目代码绑定报建信息到本账号(住建)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult BindProjectFromTZZXPT(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            using (var trans = GetDbSession().BeginTransaction())
            {
                var entity = FirstOrNull(T_AFC_PROJECT._.CODE == model.CODE
                                         && T_AFC_PROJECT._.TZ_CODE == model.TZ_CODE
                                         && T_AFC_PROJECT._.KIND == 1);
                if (entity != null)
                {
                    if (entity.U_ID != -2)
                    {
                        r.SetFail("该报建信息已被绑定");
                    }
                    else
                    {
                        trans.Update<T_AFC_PROJECT>(T_AFC_PROJECT._.U_ID, JdUser.ID, T_AFC_PROJECT._.CODE == model.CODE && T_AFC_PROJECT._.TZ_CODE == model.TZ_CODE);
                        trans.Update<T_AFC_LOG>(T_AFC_LOG._.U_ID, JdUser.ID, T_AFC_LOG._.CODE == model.CODE && T_AFC_LOG._.TZ_CODE == model.TZ_CODE);
                        trans.Commit();
                        r.SetSuccess(msg: "绑定成功");
                    }
                }
                else
                {
                    r.SetFail("未查询到对应报建编号和投资项目代码数据");
                }
            }

            return r;
        }
        /// <summary>
        /// 解除绑定
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult UnBindProjectOfTZZXPT(string mid)
        {

            var r = new GeneralResult();
            var id = mid;//.DesDecrypt();
            using (var trans = GetDbSession().BeginTransaction())
            {
                var entity = FirstOrNull(T_AFC_PROJECT._.ID == id
                                         && T_AFC_PROJECT._.KIND == 1
                                         && T_AFC_PROJECT._.APPROVAL_TACHE != 4
                                         && T_AFC_PROJECT._.APPROVAL_DEPID == "99999");
                if (entity != null)
                {
                    entity.Attach();
                    entity.U_ID = -2;
                    entity.DATA_TIMESTAMP = DateTime.Now;
                    trans.Update(entity);
                    //trans.Update<T_AFC_LOG>(T_AFC_LOG._.U_ID, JdUser.ID, T_AFC_LOG._.AFC_ID == entity.ID);
                    trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == entity.ID);

                    var log = entity.ConvertTo<T_AFC_LOG>();
                    log.AFC_ID = entity.ID;
                    log.ISNEW = 1;
                    log.RECORDER_UID = JdUser?.ID;               //记录人ID
                    log.RECORDER_DEPNAME = JdUser?.UserExtend?.DEP_NAME;       //记录-操作人单位
                    log.RECORDER_TACHE = entity.APPROVAL_TACHE;           //记录-环节
                    log.RECORDER_OPERATION = entity.APPROVAL_STATE;   //记录-操作
                    log.RECORDER_TM = entity.DATA_TIMESTAMP;                 //记录-时间
                    log.RECORDER_UNAME = String.Empty;           //记录-审查人员
                    log.RECORDER_CONTACT = String.Empty;       //记录-联系方式
                    log.RECORDER_REMARK = $"{JdUser?.ID}解除绑定";         //记录-相关意见
                    log.RECORDER_AIDS = String.Empty;             //记录-附件
                    log.APPROVAL_DEPID = entity.APPROVAL_DEPID;
                    trans.Insert(log);
                    trans.Commit();
                    r.SetSuccess(msg: "解除绑定成功");
                }
                else
                {
                    r.SetFail("未查询到对应报建信息或该报建信息不可解绑");
                }
            }

            return r;
        }
        /// <summary>
        /// 通过统一代码查询项目信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult CheckTzCodeFromTZZXPT(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            var p = TzCodeService.Main.CheckGdCode(model.CODE);
            if (p.result && p.errcode == null)
            {
                r.SetSuccess(p.datas, "查询成功，已导入信息");
            }
            else
            {
                //查询是否二装项目或厦门的项目
                var secondary = Jd.TAfcSecondaryService.FindAfcSecondaryByTzCode(model.CODE)
                    .FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE));
                if (secondary != null)
                {
                    r.SetSuccess(new
                    {
                        code = secondary.CODE,
                        project_name = secondary.PROJECT_NAME
                    }, "查询成功，已导入信息");
                }
                else
                {
                    //查询是否厦门的项目
                    var xiamenCode = Jd.TAfcXmcodeService.FindAfcXmCodeByTzCode(model.CODE).FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE));
                    if (xiamenCode != null)
                    {
                        r.SetSuccess(new
                        {
                            code = xiamenCode.CODE,
                            project_name = xiamenCode.PROJECT_NAME
                        }, "查询成功，已导入信息");
                    }
                    else
                    {
                        //r.SetFail(p.GetErrMsg());
                        r.SetFailEx("未查询到该项目代码的项目信息", p.GetErrMsg());
                    }
                }
            }
            return r;

        }

        private static readonly object locker = new object();
        /// <summary>
        /// 报建编号序列生成（使用锁）
        /// 报建编号=6位行政区划-6位工程项目日期-2位工程项目分类-2位工程项目序列码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string ProjectReportBuildSequence(TAfcProjectModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                return model.CODE;
            }
            lock (locker)
            {
                // 6位行政区划
                string areaCode = model.REGION_COUNTY;
                if (string.IsNullOrWhiteSpace(areaCode))
                    areaCode = model.REGION_CITY;
                //6位当前日期
                string tm = DateTime.Now.ToString("yyMMdd");
                //2位工程项目分类
                string gcType = model.PROJECT_TYPE.Substring(0, 2);

                string hardCode = areaCode + tm + gcType; //拼接固定编码
                //2位工程项目序列码
                string maxId = "01";
                var seq = FromSql(
                        @"SELECT MAX(TO_NUMBER(SUBSTR(CODE, 15, 2)))+1 AS MAXID FROM T_AFC_PROJECT T WHERE SUBSTR(CODE,1,14)=:code")
                    .AddInParameter(":code", DbType.AnsiString, hardCode).ToFirst<string>();
                if (!string.IsNullOrWhiteSpace(seq))
                {
                    maxId = seq.PadLeft(2, '0');
                }
                return hardCode + maxId.Replace("0", "9");//将0替换成9避免与投资在线平台生成的重复
            }
        }

        public bool IsExistProjectName(TAfcProjectModel model)
        {
            var condition = new WhereClipBuilder(T_AFC_PROJECT._.APPROVAL_STATE != 6 && T_AFC_PROJECT._.PROJECT_NAME == model.PROJECT_NAME);
            if (model.ID.HasValue)
            {
                condition.And(T_AFC_PROJECT._.ID != model.ID);
            }
            return GetDbSession().Exists<T_AFC_PROJECT>(condition.ToWhereClip());
        }

        /// <summary>
        /// 项目报建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ProjectReportBuild(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            #region 判断用户是否是报建人

            if (JdUser.TYPE != (int)JdTUserType.BaoJianBeiAnYongHu || string.IsNullOrWhiteSpace(JdUser.UserExtend?.DEP_NAME))
            {
                r.SetFail("权限不足，无法提交！");
                return r;
            }

            #endregion

            #region 只允许暂存和提交操作

            if (model.APPROVAL_STATE != 1 && model.APPROVAL_STATE != 2)//1暂存(保存)  //2待审批(提交)
            {
                r.SetFail("非法请求");
                return r;
            }

            #endregion

            #region 项目名称唯一校验

            if (IsExistProjectName(model))
            {
                r.SetFail($"该项目名称在系统中已经存在");
                return r;
            }

            #endregion


            #region 附件必传校验 提交操作

            if (model.APPROVAL_STATE == 2)
            {
                if (model.JS_CODE_ATTACHMENT == null || !model.JS_CODE_ATTACHMENT.Any())
                {
                    r.SetFail($"组织机构代码证书必传");
                    return r;
                }
                if (model.APPROVAL_ATTACHMENT == null || !model.APPROVAL_ATTACHMENT.Any())
                {
                    r.SetFail($"项目立项或批准文件必传");
                    return r;
                }
                if (model.REGISTER_ATTACHMENT == null || !model.REGISTER_ATTACHMENT.Any())
                {
                    r.SetFail($"工程项目立项登记表必传");
                    return r;
                }
            }

            #endregion

            #region 属性赋值

            if (model.APPROVAL_STATE == 2) //待审批(提交)
            {
                #region 初建、报建变更，提交审批时必须提交【审批单位】

                if (String.IsNullOrWhiteSpace(model.APPROVAL_DEPID))
                {  //初建、报建变更，提交审批时必须提交【审批单位】
                    r.SetFail("审批单位非空！");
                    return r;
                }

                #endregion
                #region 附件必传

                if (model.APPROVAL_ATTACHMENT == null || !model.APPROVAL_ATTACHMENT.Any())
                {
                    r.SetFail($"请上传项目立项或批准文件");
                    return r;
                }
                if (model.REGISTER_ATTACHMENT == null || !model.REGISTER_ATTACHMENT.Any())
                {
                    r.SetFail($"请上传工程项目立项登记表");
                    return r;
                }
                if (model.JS_CODE_ATTACHMENT == null || !model.JS_CODE_ATTACHMENT.Any())
                {
                    r.SetFail($"请上传组织机构代码证书");
                    return r;
                }

                #endregion
                model.OVER_TM = Jd.THolidayService.OverTime(DateTime.Today, 3);//计算出后3个工作日所在的日期(即超期日期，两个工作日后超期,当天不算)
                model.DEP_NAME = JdUser.UserExtend.DEP_NAME;
            }
            model.APPROVAL_TACHE = 1;//环节：1初建、2变更申请、3报建变更
            model.DATA_TIMESTAMP = DateTime.Now;
            model.TM = model.DATA_TIMESTAMP;
            model.U_ID = JdUser.ID;
            if (model.JS_CODE_ATTACHMENT != null)
            {
                model.JS_CODE_AIDS = string.Join(",", model?.JS_CODE_ATTACHMENT.Select(c => c.Id));
            }
            if (model.APPROVAL_ATTACHMENT != null)
            {
                model.APPROVAL_AIDS = string.Join(",", model?.APPROVAL_ATTACHMENT.Select(c => c.Id));
            }
            if (model.APPROVAL_ATTACHMENT != null)
            {
                model.REGISTER_AIDS = string.Join(",", model?.APPROVAL_ATTACHMENT.Select(c => c.Id));
            }



            #endregion

            #region 到在线投资平抬头查询数据并填充数据并自动审批通过

            if ((model.KIND == ((int)TAfcProjectKind.ZhuJian).ToString() || (model.KIND == ((int)TAfcProjectKind.ShuiLi).ToString() || model.KIND == ((int)TAfcProjectKind.JiaoTong).ToString()) && model.REGION_CITY == "350200") && !string.IsNullOrWhiteSpace(model.TZ_CODE))
            {
                var code = string.Empty;
                var p = TzCodeService.Main.CheckGdCode(model.TZ_CODE);
                if (p.result && string.IsNullOrWhiteSpace(p.errcode))
                {
                    if (p.datas != null && !string.IsNullOrWhiteSpace(p.datas.REPORT_CODE))
                    {
                        code = p.datas.REPORT_CODE;//报建编号
                    }
                    else if (model.APPROVAL_STATE == 2)
                    {
                        code = ProjectReportBuildSequence(model);  //将0替换成9避免与投资在线平台生成的重复
                    }
                }
                else
                {
                    //查询是否二装项目或厦门的项目
                    var secondary = Jd.TAfcSecondaryService.FindAfcSecondaryByTzCode(model.TZ_CODE);
                    if (secondary.Any())
                    {
                        code = secondary.FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE))?.CODE;
                    }
                    else
                    {
                        //查询是否厦门的项目
                        var xiamenCodes = Jd.TAfcXmcodeService.FindAfcXmCodeByTzCode(model.TZ_CODE);
                        if (xiamenCodes.Any())
                        {
                            code = xiamenCodes.FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE))?.CODE;
                            if (string.IsNullOrWhiteSpace(code))
                            {
                                code = ProjectReportBuildSequence(model);//将0替换成9避免与投资在线平台生成的重复
                            }

                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(code))
                {
                    model.CODE = code;
                }
                else
                {
                    r.SetFail("通过在线投资平台查询报建编号信息失败");
                    return r;
                }
            }

            #endregion

            #region 如果是提交则自动审核通过

            int isNew = 0;
            if ((model.KIND == ((int)TAfcProjectKind.ZhuJian).ToString() || (model.KIND == ((int)TAfcProjectKind.ShuiLi).ToString() || model.KIND == ((int)TAfcProjectKind.JiaoTong).ToString()) && model.REGION_CITY == "350200") && model.APPROVAL_STATE == 2 && !string.IsNullOrWhiteSpace(model.TZ_CODE) &&
                model.APPROVAL_TACHE == 1)
            {
                model.APPROVAL_STATE = 3;
                model.APPROVAL_UID = -1;
                model.APPROVAL_TM = model.DATA_TIMESTAMP;
                isNew = 1;
            }

            #endregion

            #region 使用事务入库

            using (var trans = GetDbSession().BeginTransaction())
            {

                #region 附件处理

                var attachments = new List<SYS_ATTACHMENT>();

                if (model.APPROVAL_ATTACHMENT != null && model.APPROVAL_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.APPROVAL_ATTACHMENT
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.APPROVAL_AIDS = string.Join(",", model.APPROVAL_ATTACHMENT.Select(c => c.Id));
                }
                if (model.REGISTER_ATTACHMENT != null && model.REGISTER_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.REGISTER_ATTACHMENT
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.REGISTER_AIDS = string.Join(",", model.REGISTER_ATTACHMENT.Select(c => c.Id));
                }
                if (model.JS_CODE_ATTACHMENT != null && model.JS_CODE_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.JS_CODE_ATTACHMENT
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.JS_CODE_AIDS = string.Join(",", model.JS_CODE_ATTACHMENT.Select(c => c.Id));
                }
                if (model.OTHER_ATTACHMENT != null && model.OTHER_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.OTHER_ATTACHMENT
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.OTHER_AIDS = string.Join(",", model.OTHER_ATTACHMENT.Select(c => c.Id));
                }
                if (model.ZBHZYJS_ATTACHMENT != null && model.ZBHZYJS_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.ZBHZYJS_ATTACHMENT
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.ZBHZYJS_AIDS = string.Join(",", model.ZBHZYJS_ATTACHMENT.Select(c => c.Id));
                }
                trans.Insert(attachments);

                #endregion

                #region 添加报建信息

                var afcProject = model.ConvertTo<T_AFC_PROJECT>();
                afcProject.ID = 0;

                model.ID = trans.Insert(afcProject);

                #endregion

                #region 发送新建提醒短信
               


                if ((model.APPROVAL_STATE == 2 || model.APPROVAL_STATE == 3) && model.KIND != ((int)TAfcProjectKind.ZhuJian).ToString() && ((model.KIND != ((int)TAfcProjectKind.ShuiLi).ToString() && model.KIND != ((int)TAfcProjectKind.JiaoTong).ToString()) || model.REGION_CITY != "350200"))
                {
                    var msgConfig = ConfigHelper.AppSettings.SmsBJSubmitContext;
                    var msg = string.Format(msgConfig, 1);
                    SendMsg2ApprovalDep(model.APPROVAL_DEPID, msg, trans);
                }

                #endregion

                #region 添加日志

                var log = model.ConvertTo<T_AFC_LOG>();
                /*-----------日志记录信息----------*/
                log.AFC_ID = model.ID;
                log.ISNEW = isNew;
                log.RECORDER_UID = JdUser.ID;               //记录人ID
                log.RECORDER_DEPNAME = JdUser.UserExtend?.DEP_NAME;       //记录-操作人单位
                log.RECORDER_TACHE = model.APPROVAL_TACHE;           //记录-环节
                log.RECORDER_OPERATION = model.APPROVAL_STATE;   //记录-操作
                log.RECORDER_TM = model.DATA_TIMESTAMP;                 //记录-时间
                log.RECORDER_UNAME = String.Empty;           //记录-审查人员
                log.RECORDER_CONTACT = String.Empty;       //记录-联系方式
                log.RECORDER_REMARK = String.Empty;         //记录-相关意见
                log.RECORDER_AIDS = String.Empty;             //记录-附件
                log.APPROVAL_DEPID = model.APPROVAL_DEPID;
                if (isNew > 0)
                { //如果是最新数据，则将其他的设为旧数据
                    trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == model.ID);
                }
                trans.Insert(log);

                #endregion
                trans.Commit();
                //model.MID = model.ID.DesEncrypt();
                r.SetSuccess(model);
            }

            #endregion
            return r;
        }
        /// <summary>
        /// 项目报建重新提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ProjectReportReBuild(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            #region 判断用户是否是报建人

            if (JdUser.TYPE != (int)JdTUserType.BaoJianBeiAnYongHu || JdUser.UserExtend == null || string.IsNullOrWhiteSpace(JdUser.UserExtend.DEP_NAME))
            {
                r.SetFail("权限不足，无法提交！");
                return r;
            }

            #endregion

            #region 只允许暂存和提交操作

            if (model.APPROVAL_STATE != 1 && model.APPROVAL_STATE != 2)//1暂存(保存)  //2待审批(提交)
            {
                r.SetFail("非法请求");
                return r;
            }

            #endregion

            model.ID = model.MID.ToNullableDecimal();
            var dataModel = FirstOrNull(T_AFC_PROJECT._.ID == model.ID);

            #region 报建创建人与当前用户一致性校验

            if (dataModel == null)
            {
                r.SetFail($"未找到项目报建信息,ID={model.ID}");
                return r;
            }

            if (dataModel.U_ID != JdUser.ID)
            {
                r.SetFail("权限不足，报建创建人与当前用户不一致！");
                return r;
            }

            #endregion

            #region 判断当前报建是否可以【暂存】或【提交】,获取下个环节

            if (dataModel.APPROVAL_TACHE != 1 && dataModel.APPROVAL_TACHE != 2 && dataModel.APPROVAL_TACHE != 3)
            {
                r.SetFail("该报建所处流程不正确！");
                return r;
            }
            if (model.APPROVAL_TACHE == 1)
            {  //初建：暂存、不通过； 下个环节为：初建
                if (dataModel.APPROVAL_STATE != 1 && dataModel.APPROVAL_STATE != 4)
                {
                    r.SetFail("该报建所处流程不正确！");
                    return r;
                }
                if (dataModel.APPROVAL_DEPID == "99999")//投资项目代码那边获取的数据,可以补录一次，补录之后审查单位不是99999就无法继续补录
                {
                    model.APPROVAL_TACHE = 4;//设置流程为补录流程
                }
            }
            else if (model.APPROVAL_TACHE == 2)
            {     //变更申请：通过；   下个环节为：报建变更
                if (dataModel.APPROVAL_STATE != 3)
                {
                    r.SetFail("该报建所处流程不正确！");
                    return r;
                }
                model.APPROVAL_TACHE = 3;//设置流程为补录流程
            }
            else if (model.APPROVAL_TACHE == 3)
            {     //报建变更：暂存、不通过； 下个环节为：报建变更
                if (dataModel.APPROVAL_STATE != 1 && dataModel.APPROVAL_STATE != 4)
                {
                    r.SetFail("该报建所处流程不正确！");
                    return r;
                }
            }

            #endregion

            #region 项目名称唯一校验

            if (IsExistProjectName(model))
            {
                r.SetFail($"该项目名称在系统中已经存在");
                return r;
            }

            #endregion

            #region 附件必传校验 提交操作

            if (model.APPROVAL_STATE == 2)
            {
                if (model.JS_CODE_ATTACHMENT == null || !model.JS_CODE_ATTACHMENT.Any())
                {
                    r.SetFail($"组织机构代码证书必传");
                    return r;
                }
                if (model.APPROVAL_ATTACHMENT == null || !model.APPROVAL_ATTACHMENT.Any())
                {
                    r.SetFail($"项目立项或批准文件必传");
                    return r;
                }
                if (model.REGISTER_ATTACHMENT == null || !model.REGISTER_ATTACHMENT.Any())
                {
                    r.SetFail($"工程项目立项登记表必传");
                    return r;
                }
            }

            #endregion

            #region 属性赋值

            if (model.APPROVAL_STATE == 2) //待审批(提交)
            {
                #region 初建、报建变更，提交审批时必须提交【审批单位】

                if ((model.APPROVAL_TACHE == 1 || model.APPROVAL_TACHE == 3) &&
                    String.IsNullOrWhiteSpace(model.APPROVAL_DEPID))
                {  //初建、报建变更，提交审批时必须提交【审批单位】
                    r.SetFail("审批单位非空！");
                    return r;
                }

                #endregion
                #region 附件必传

                if (model.APPROVAL_ATTACHMENT == null || !model.APPROVAL_ATTACHMENT.Any())
                {
                    r.SetFail($"请上传项目立项或批准文件");
                    return r;
                }
                if (model.REGISTER_ATTACHMENT == null || !model.REGISTER_ATTACHMENT.Any())
                {
                    r.SetFail($"请上传工程项目立项登记表");
                    return r;
                }
                if (model.JS_CODE_ATTACHMENT == null || !model.JS_CODE_ATTACHMENT.Any())
                {
                    r.SetFail($"请上传组织机构代码证书");
                    return r;
                }

                #endregion
                model.OVER_TM = Jd.THolidayService.OverTime(DateTime.Today, 3);//计算出后3个工作日所在的日期(即超期日期，两个工作日后超期,当天不算)
                model.DEP_NAME = JdUser.UserExtend.DEP_NAME;
            }
            model.DATA_TIMESTAMP = DateTime.Now;
            model.TM = model.DATA_TIMESTAMP;
            model.U_ID = JdUser.ID;
            if (model.JS_CODE_ATTACHMENT != null)
            {
                model.JS_CODE_AIDS = string.Join(",", model?.JS_CODE_ATTACHMENT.Select(c => c.Id));
            }
            if (model.APPROVAL_ATTACHMENT != null)
            {
                model.APPROVAL_AIDS = string.Join(",", model?.APPROVAL_ATTACHMENT.Select(c => c.Id));
            }
            if (model.APPROVAL_ATTACHMENT != null)
            {
                model.REGISTER_AIDS = string.Join(",", model?.APPROVAL_ATTACHMENT.Select(c => c.Id));
            }
            #endregion

            #region 到在线投资平抬头查询数据并填充数据并自动审批通过

            if ((model.KIND == ((int)TAfcProjectKind.ZhuJian).ToString() || (model.KIND == ((int)TAfcProjectKind.ShuiLi).ToString() || model.KIND == ((int)TAfcProjectKind.JiaoTong).ToString()) && model.REGION_CITY == "350200") && !string.IsNullOrWhiteSpace(model.TZ_CODE) && model.APPROVAL_TACHE != 4)
            {
                var code = string.Empty;
                var p = TzCodeService.Main.CheckGdCode(model.TZ_CODE);
                if (p.result && string.IsNullOrWhiteSpace(p.errcode))
                {
                    if (p.datas != null && !string.IsNullOrWhiteSpace(p.datas.REPORT_CODE))
                    {
                        code = p.datas.REPORT_CODE;//报建编号
                    }
                    else if (model.APPROVAL_STATE == 2 && string.IsNullOrWhiteSpace(dataModel.CODE))
                    {
                        code = ProjectReportBuildSequence(model);  //将0替换成9避免与投资在线平台生成的重复
                    }
                }
                else
                {
                    //查询是否二装项目或厦门的项目
                    var secondary = Jd.TAfcSecondaryService.FindAfcSecondaryByTzCode(model.TZ_CODE);
                    if (secondary.Any())
                    {
                        code = secondary.FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE))?.CODE;
                    }
                    else
                    {
                        //查询是否厦门的项目
                        var xiamenCodes = Jd.TAfcXmcodeService.FindAfcXmCodeByTzCode(model.TZ_CODE);
                        if (xiamenCodes.Any())
                        {
                            code = xiamenCodes.FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE))?.CODE;
                            if (string.IsNullOrWhiteSpace(code) && string.IsNullOrWhiteSpace(dataModel.CODE))
                            {
                                code = ProjectReportBuildSequence(model);//将0替换成9避免与投资在线平台生成的重复
                            }

                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(code))
                {
                    model.CODE = code;
                }
                else
                {
                    r.SetFail("通过在线投资平台查询报建编号信息失败");
                    return r;
                }
            }

            #endregion

            #region 如果是提交则自动审核通过

            int isNew = 0;
            if (((model.KIND == ((int)TAfcProjectKind.ZhuJian).ToString() || (model.KIND == ((int)TAfcProjectKind.ShuiLi).ToString() || model.KIND == ((int)TAfcProjectKind.JiaoTong).ToString()) && model.REGION_CITY == "350200") && model.APPROVAL_STATE == 2 && !string.IsNullOrWhiteSpace(model.TZ_CODE) &&
                 model.APPROVAL_TACHE == 1) || model.APPROVAL_TACHE == 4)//APPROVAL_TACHE==4 补录数据的话直接修改数据
            {
                model.APPROVAL_STATE = 3;
                if (model.APPROVAL_TACHE == 1)
                {
                    model.APPROVAL_UID = -1;
                }
                model.APPROVAL_TM = model.DATA_TIMESTAMP;
                isNew = 1;
            }

            #endregion

            #region 使用事务入库

            using (var trans = GetDbSession().BeginTransaction())
            {
                #region 附件处理

                var attachments = new List<SYS_ATTACHMENT>();

                if (model.APPROVAL_ATTACHMENT != null && model.APPROVAL_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.APPROVAL_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.APPROVAL_AIDS = string.Join(",", model.APPROVAL_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.REGISTER_ATTACHMENT != null && model.REGISTER_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.REGISTER_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.REGISTER_AIDS = string.Join(",", model.REGISTER_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.JS_CODE_ATTACHMENT != null && model.JS_CODE_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.JS_CODE_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.JS_CODE_AIDS = string.Join(",", model.JS_CODE_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.OTHER_ATTACHMENT != null && model.OTHER_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.OTHER_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.OTHER_AIDS = string.Join(",", model.OTHER_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.ZBHZYJS_ATTACHMENT != null && model.ZBHZYJS_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.ZBHZYJS_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.ZBHZYJS_AIDS = string.Join(",", model.ZBHZYJS_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                trans.Insert(attachments);

                #endregion

                #region 更新报建信息

                dataModel = model.ConvertTo<T_AFC_PROJECT>();
                dataModel.AttachAll();
                trans.Update(dataModel);

                #endregion

                #region 发送新建提醒短信

                if ((model.APPROVAL_STATE == 2 || model.APPROVAL_STATE == 3) && model.KIND != ((int)TAfcProjectKind.ZhuJian).ToString() && ((model.KIND != ((int)TAfcProjectKind.ShuiLi).ToString() && model.KIND != ((int)TAfcProjectKind.JiaoTong).ToString()) || model.REGION_CITY != "350200"))
                {
                    var msgConfig = ConfigHelper.AppSettings.SmsBJSubmitContext;
                    var msg = string.Format(msgConfig, 1);
                    SendMsg2ApprovalDep(model.APPROVAL_DEPID, msg, trans);
                }

                #endregion

                #region 添加日志

                var log = model.ConvertTo<T_AFC_LOG>();
                /*-----------日志记录信息----------*/
                log.AFC_ID = model.ID;
                log.ISNEW = isNew;
                log.RECORDER_UID = JdUser.ID;               //记录人ID
                log.RECORDER_DEPNAME = JdUser.UserExtend?.DEP_NAME;       //记录-操作人单位
                log.RECORDER_TACHE = model.APPROVAL_TACHE;           //记录-环节
                log.RECORDER_OPERATION = model.APPROVAL_STATE;   //记录-操作
                log.RECORDER_TM = model.DATA_TIMESTAMP;                 //记录-时间
                log.RECORDER_UNAME = String.Empty;           //记录-审查人员
                log.RECORDER_CONTACT = String.Empty;       //记录-联系方式
                log.RECORDER_REMARK = String.Empty;         //记录-相关意见
                log.RECORDER_AIDS = String.Empty;             //记录-附件
                log.APPROVAL_DEPID = model.APPROVAL_DEPID;
                if (isNew > 0)
                { //如果是最新数据，则将其他的设为旧数据
                    trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == model.ID);
                }
                trans.Insert(log);

                #endregion
                trans.Commit();
                //model.MID = model.ID.DesEncrypt();
                r.SetSuccess(model);
            }

            #endregion
            return r;
        }

        /// <summary>
        /// 项目报建变更
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ProjectReportBuildChange(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            #region 判断用户是否是报建人

            if (JdUser.TYPE != (int)JdTUserType.BaoJianBeiAnYongHu || JdUser.UserExtend == null || string.IsNullOrWhiteSpace(JdUser.UserExtend.DEP_NAME))
            {
                r.SetFail("权限不足，无法提交！");
                return r;
            }

            #endregion

            #region 只允许暂存和提交操作

            if (model.APPROVAL_STATE != 2)//1暂存(保存)  //2待审批(提交)
            {
                r.SetFail("非法请求");
                return r;
            }

            #endregion

            model.ID = model.MID.ToNullableDecimal();
            var dataModel = FirstOrNull(T_AFC_PROJECT._.ID == model.ID);

            #region 报建创建人与当前用户一致性校验

            if (dataModel == null)
            {
                r.SetFail($"未找到项目报建信息,ID={model.ID}");
                return r;
            }

            if (dataModel.U_ID != JdUser.ID)
            {
                r.SetFail("权限不足，报建创建人与当前用户不一致！");
                return r;
            }

            #endregion

            if (!dataModel.APPROVAL_TACHE.HasValue
                || ((dataModel.APPROVAL_TACHE == 1 || dataModel.APPROVAL_TACHE == 3) && dataModel.APPROVAL_STATE != 3)
                || (dataModel.APPROVAL_TACHE == 2 && dataModel.APPROVAL_STATE == 4))
            {
                r.SetFail("无效的项目报建变更申请！");
                return r;
            }



            #region 项目名称唯一校验

            if (IsExistProjectName(model))
            {
                r.SetFail($"该项目名称在系统中已经存在");
                return r;
            }

            #endregion



            #region 属性赋值
            model.APPROVAL_STATE = 2;//状态-待审批
            model.APPROVAL_TACHE = 3;//环节-变更报建
            #region 初建、报建变更，提交审批时必须提交【审批单位】

            if (String.IsNullOrWhiteSpace(model.APPROVAL_DEPID))
            {  //初建、报建变更，提交审批时必须提交【审批单位】
                r.SetFail("审批单位非空！");
                return r;
            }

            #endregion
            #region 附件必传

            if (model.APPROVAL_ATTACHMENT == null || !model.APPROVAL_ATTACHMENT.Any())
            {
                r.SetFail($"请上传项目立项或批准文件");
                return r;
            }
            if (model.REGISTER_ATTACHMENT == null || !model.REGISTER_ATTACHMENT.Any())
            {
                r.SetFail($"请上传工程项目立项登记表");
                return r;
            }
            if (model.JS_CODE_ATTACHMENT == null || !model.JS_CODE_ATTACHMENT.Any())
            {
                r.SetFail($"请上传组织机构代码证书");
                return r;
            }

            #endregion
            model.OVER_TM = Jd.THolidayService.OverTime(DateTime.Today, 3);//计算出后3个工作日所在的日期(即超期日期，两个工作日后超期,当天不算)
            model.DEP_NAME = JdUser.UserExtend.DEP_NAME;
            model.DATA_TIMESTAMP = DateTime.Now;
            model.TM = model.DATA_TIMESTAMP;
            model.U_ID = JdUser.ID;

            #endregion

            #region 到在线投资平抬头查询数据并填充数据并自动审批通过

            if ((model.KIND == ((int)TAfcProjectKind.ZhuJian).ToString() || (model.KIND == ((int)TAfcProjectKind.ShuiLi).ToString() || model.KIND == ((int)TAfcProjectKind.JiaoTong).ToString()) && model.REGION_CITY == "350200") && !string.IsNullOrWhiteSpace(model.TZ_CODE) && model.APPROVAL_TACHE != 4)
            {
                var code = string.Empty;
                var p = TzCodeService.Main.CheckGdCode(model.TZ_CODE);
                if (p.result && string.IsNullOrWhiteSpace(p.errcode))
                {
                    if (p.datas != null && !string.IsNullOrWhiteSpace(p.datas.project_code))
                    {
                        code = p.datas.REPORT_CODE;//报建编号
                    }
                    else if (model.APPROVAL_STATE == 2 && string.IsNullOrWhiteSpace(dataModel.CODE))
                    {
                        code = ProjectReportBuildSequence(model);  //将0替换成9避免与投资在线平台生成的重复
                    }
                }
                else
                {
                    //查询是否二装项目或厦门的项目
                    var secondary = Jd.TAfcSecondaryService.FindAfcSecondaryByTzCode(model.TZ_CODE);
                    if (secondary.Any())
                    {
                        code = secondary.FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE))?.CODE;
                    }
                    else
                    {
                        //查询是否厦门的项目
                        var xiamenCodes = Jd.TAfcXmcodeService.FindAfcXmCodeByTzCode(model.TZ_CODE);
                        if (xiamenCodes.Any())
                        {
                            code = xiamenCodes.FirstOrDefault(c => !string.IsNullOrWhiteSpace(c.CODE))?.CODE;
                            if (string.IsNullOrWhiteSpace(code) && string.IsNullOrWhiteSpace(dataModel.CODE))
                            {
                                code = ProjectReportBuildSequence(model);//将0替换成9避免与投资在线平台生成的重复
                            }

                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(code))
                {
                    model.CODE = code;
                }
                else
                {
                    r.SetFail("通过在线投资平台查询报建编号信息失败");
                    return r;
                }
            }

            #endregion

            #region 如果是提交则自动审核通过

            int isNew = 0;
            if (((model.KIND == ((int)TAfcProjectKind.ZhuJian).ToString() || (model.KIND == ((int)TAfcProjectKind.ShuiLi).ToString() || model.KIND == ((int)TAfcProjectKind.JiaoTong).ToString()) && model.REGION_CITY == "350200") && model.APPROVAL_STATE == 2 && !string.IsNullOrWhiteSpace(model.TZ_CODE) &&
                 model.APPROVAL_TACHE == 1) || model.APPROVAL_TACHE == 4)//APPROVAL_TACHE==4 补录数据的话直接修改数据
            {
                model.APPROVAL_STATE = 3;
                if (model.APPROVAL_TACHE == 1)
                {
                    model.APPROVAL_UID = -1;
                }
                model.APPROVAL_TM = model.DATA_TIMESTAMP;
                isNew = 1;
            }

            #endregion

            #region 使用事务入库

            using (var trans = GetDbSession().BeginTransaction())
            {
                #region 项目变更申请信息

                var change = new T_AFC_CHANGE
                {
                    ID = 0,
                    U_ID = JdUser.ID,
                    TM = DateTime.Now,
                    APPROVAL_STATE = 1,
                    AFC_ID = dataModel.ID,
                    REMARK = model.CHANGE_REMARK,
                    AIDS = model.CHANGE_AIDS
                };
                if (model.CHANGE_AIDS_ATTACHMENT != null && model.CHANGE_AIDS_ATTACHMENT.Any())
                {
                    var changeAttachments = model.CHANGE_AIDS_ATTACHMENT.Select(c =>
                            c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList();
                    trans.Insert(changeAttachments);
                    change.AIDS = string.Join(",", model.CHANGE_AIDS_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                trans.Insert(change);

                #endregion

                #region 附件处理

                var attachments = new List<SYS_ATTACHMENT>();

                if (model.APPROVAL_ATTACHMENT != null && model.APPROVAL_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.APPROVAL_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.APPROVAL_AIDS = string.Join(",", model.APPROVAL_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.REGISTER_ATTACHMENT != null && model.REGISTER_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.REGISTER_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.REGISTER_AIDS = string.Join(",", model.REGISTER_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.JS_CODE_ATTACHMENT != null && model.JS_CODE_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.JS_CODE_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.JS_CODE_AIDS = string.Join(",", model.JS_CODE_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.OTHER_ATTACHMENT != null && model.OTHER_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.OTHER_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.OTHER_AIDS = string.Join(",", model.OTHER_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                if (model.ZBHZYJS_ATTACHMENT != null && model.ZBHZYJS_ATTACHMENT.Any())
                {
                    attachments.AddRange(model.ZBHZYJS_ATTACHMENT.Where(c => !string.IsNullOrWhiteSpace(c.Md5))
                        .Select(c => c.JdSysAttachment(model.U_ID, Jd.SysAttachmentService.MaxOrderId))
                        .ToList());
                    model.ZBHZYJS_AIDS = string.Join(",", model.ZBHZYJS_ATTACHMENT.Select(c => c.Id).Distinct());
                }
                trans.Insert(attachments);

                #endregion

                #region 更新报建信息

                dataModel = model.ConvertTo<T_AFC_PROJECT>();
                dataModel.AttachAll();
                trans.Update(dataModel);

                #endregion

                #region 发送新建提醒短信

                if ((model.APPROVAL_STATE == 2 || model.APPROVAL_STATE == 3) && model.KIND != ((int)TAfcProjectKind.ZhuJian).ToString() && ((model.KIND != ((int)TAfcProjectKind.ShuiLi).ToString() && model.KIND != ((int)TAfcProjectKind.JiaoTong).ToString()) || model.REGION_CITY != "350200"))
                {
                    var msgConfig = ConfigHelper.AppSettings.SmsBJSubmitContext;// AppSettingUtils.GetString("SmsBJSubmitContext", "<报建>您有新的【{0}】条报建需要审查，请及时完成审查。");
                    var msg = string.Format(msgConfig, 1);
                    SendMsg2ApprovalDep(model.APPROVAL_DEPID, msg, trans);
                }

                #endregion

                #region 添加日志

                var log = model.ConvertTo<T_AFC_LOG>();
                /*-----------日志记录信息----------*/
                log.AFC_ID = model.ID;
                log.ISNEW = isNew;
                log.RECORDER_UID = JdUser.ID;               //记录人ID
                log.RECORDER_DEPNAME = JdUser.UserExtend?.DEP_NAME;       //记录-操作人单位
                log.RECORDER_TACHE = model.APPROVAL_TACHE;           //记录-环节
                log.RECORDER_OPERATION = model.APPROVAL_STATE;   //记录-操作
                log.RECORDER_TM = change.TM;                 //记录-时间
                log.RECORDER_UNAME = String.Empty;           //记录-审查人员
                log.RECORDER_CONTACT = String.Empty;       //记录-联系方式
                log.RECORDER_REMARK = change.REMARK;         //记录-相关意见
                log.RECORDER_AIDS = change.AIDS;             //记录-附件
                log.APPROVAL_DEPID = model.APPROVAL_DEPID;
                if (isNew > 0)
                { //如果是最新数据，则将其他的设为旧数据
                    trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == model.ID);
                }
                trans.Insert(log);

                #endregion
                trans.Commit();
                r.SetSuccess();
            }

            #endregion
            return r;
        }



        #endregion

        #region 审批单位项目报建

        /// <summary>
        /// 注册用户项目报建列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult ProjectReportBuild4Approval(TAfcProjectModel model, SearchCondition search)
        {
            var notRegionCode = "";
            var hasCensor = JdUser != null && (JdUser.HasPermission("JdTAfcProject", "Approval") ||
                            JdUser.HasPermission("JdTAfcProject", "ChangeApproval"));

            #region 归属地参数处理

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


            #endregion
            var entity = model.ConvertTo<T_AFC_PROJECT>();
            var con = ConditionBuilder(entity);
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                con.And(T_AFC_PROJECT._.CODE.Contain(search.KeyWord)
                        || T_AFC_PROJECT._.PROJECT_NAME.Contain(search.KeyWord));
            }
            if (search.BeginTime.HasValue)
            {
                con.And(T_AFC_PROJECT._.TM >= (search.BeginTime));
            }
            if (search.EndTime.HasValue)
            {
                con.And(T_AFC_PROJECT._.TM <= (search.EndTime));
            }

            if (!string.IsNullOrWhiteSpace(model.IS_FROM_TZZXPT))
            {
                if (model.IS_FROM_TZZXPT == "1")
                {
                    con.And(T_AFC_PROJECT._.APPROVAL_DEPID == "99999");//是否投资平台同步项目 是
                }
                else
                {
                    con.And(T_AFC_PROJECT._.APPROVAL_DEPID != "99999");//是否投资平台同步项目 否
                }
            }

            if (!string.IsNullOrWhiteSpace(notRegionCode))
            {
                con.And(T_AFC_PROJECT._.REGION_COUNTY != notRegionCode);
            }
            var otherIds = JdUser?.UserDepartment.OTHERIDS?.Split(',').ToList() ?? new List<string>();//可查看部门id
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();
            #region 20200522 业务修改
            switch (search.Type)
            {
                //4超期 只显示当前审查单位账号具有审查权限的报建信息
                case "4":
                    {
                        otherIds.Clear();
                        otherIds.Add(jdUserDepartId);
                        con.And(T_AFC_PROJECT._.APPROVAL_STATE == 2 && T_AFC_PROJECT._.OVER_TM < DateTime.Now);
                        if (!hasCensor)//当前审查单位账号不具有审查权限 返回空
                        {
                            return search.ToPageTableResult(0);
                        }

                        break;
                    }

                //已办
                case "3":
                    otherIds.Add(jdUserDepartId);
                    con.And(T_AFC_PROJECT._.APPROVAL_STATE.In(3, 4, 6));
                    break;
                //2待办 4超期 只显示当前审查单位账号具有审查权限的报建信息
                case "2":
                    {
                        otherIds.Clear();
                        otherIds.Add(jdUserDepartId);
                        con.And(T_AFC_PROJECT._.APPROVAL_STATE == 2);
                        if (!hasCensor)//当前审查单位账号不具有审查权限 返回空
                        {
                            return search.ToPageTableResult(0);
                        }

                        break;
                    }
                case "5":
                    otherIds.Clear();
                    otherIds.Add("99999");//投资在线平台
                    con.And(T_AFC_PROJECT._.APPROVAL_STATE.In(3, 4, 6));
                    break;
                //全部
                default:
                    otherIds.Add("99999");//投资在线平台
                    otherIds.Add(jdUserDepartId);
                    con.And(T_AFC_PROJECT._.APPROVAL_STATE.In(2, 3, 4, 6));
                    break;
            }

            #endregion
            con.And(T_AFC_PROJECT._.APPROVAL_DEPID.In(otherIds));

            var count = Count(con.ToWhereClip());



            var list = FromWhere(con.ToWhereClip())
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "61" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_STATE.ToChar()) //审查状态
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "66" && SYS_DIC._.VALUE == T_AFC_PROJECT._.APPROVAL_TACHE.ToChar()) //审查环节
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_AFC_PROJECT._.APPROVAL_DEPID) //审查单位 
                .LeftJoin<T_AFC_LOG>(T_AFC_LOG._.AFC_ID == T_AFC_PROJECT._.ID && T_AFC_LOG._.ISNEW == 1)
                .LeftJoin<PROJECT>(PROJECT._.CONSTRUCTION_ID == T_AFC_PROJECT._.ID)
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_AFC_PROJECT._.TM)
                .Select(
                    T_AFC_PROJECT._.All,
                    SYS_AREA_QUANGUO._.AREANAME.As("REGION_CITY_NAME"),
                    new Field("AREANAME", "SYS_AREA_QUANGUO2").As("REGION_COUNTY_NAME"),
                    SYS_DIC._.TEXT.As("PROJECT_TYPE_NAME"),
                    new Field("TEXT", "SYS_DIC2").As("APPROVAL_STATE_NAME"),
                    new Field("TEXT", "SYS_DIC3").As("APPROVAL_TACHE_NAME"),
                    T_USER_DEPARTMENT._.DNAME.As("APPROVAL_DEPNAME"),
                    T_AFC_PROJECT._.ID.As("OPRATION"),
                    new Field("(SELECT COUNT(1) FROM T_TUISONG WHERE T_TUISONG.ID=T_AFC_PROJECT.ID AND T_TUISONG.TABLENAME='T_AFC_PROJECT')").As("SendCount"),
                    new Field("(CASE WHEN T_AFC_LOG.ID IS NULL THEN '否' ELSE '是' END)").As("IS_GET"),
                    PROJECT._.PROJECT_CODE.As("JD_PROJECT_CODE"),
                    TENDER_PROJECT._.TENDER_PROJECT_CODE.As("JD_TENDER_PROJECT_CODE"),
                    TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1.As("FW_TENDER_PROJECT_CODE"),
                    new Field("(CASE WHEN TENDER_PROJECT.TENDER_PROJECT_CODE_OLD1 IS NULL THEN 0 ELSE 1 END)").As("HAS_DATA")
                ).ToList<TAfcProjectModel>();

            var pageList = list.ToPageTableResult(search, count, c =>
              {
                  //c.MID = c.ID.DesEncrypt();
                  var isCensor = (c.APPROVAL_DEPID == jdUserDepartId && (hasCensor)) ? 1 : 0;
                  c.IS_CENSOR = isCensor;
                  //c.HAS_DATA = projects.FirstOrDefault(p => p.PROJECT_NAME == c.PROJECT_NAME) != null ? "1" : "0";
                  //c.PROJECT_CODE = projects.FirstOrDefault(p => p.PROJECT_NAME == c.PROJECT_NAME)?.PROJECT_CODE;
                  c.Buttons.Add(isCensor == 1 ? "CENSOR" : "VIEW");
                  return c;
              });
            return pageList;
        }

        /// <summary>
        /// 注册用户项目报建列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<object> ProjectReportBuild4ApprovalCount()
        {
            var hasCensor = JdUser != null && (JdUser.HasPermission("JdTAfcProject", "Approval") ||
                            JdUser.HasPermission("JdTAfcProject", "ChangeApproval"));
            var jdUserDepartId = JdUser?.DEPARTID?.ToString();

            var count = !hasCensor ? 0 : Count(T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId && T_AFC_PROJECT._.APPROVAL_STATE == 2);
            var overTimeCount = !hasCensor ? 0 : Count(T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId && T_AFC_PROJECT._.APPROVAL_STATE == 2 && T_AFC_PROJECT._.OVER_TM < DateTime.Now);

            var tzzxptCount = !hasCensor ? 0 : Count(T_AFC_PROJECT._.APPROVAL_DEPID == "99999" && T_AFC_PROJECT._.APPROVAL_STATE.In(3, 4, 6));
            return new List<object>
            {
                new {label = "全部",value = 0,type=1},
                new {label = "待办审查",value = count,type=2},
                new {label = "已办审查",value = 0,type=3},
                new {label = "超期未处理",value = overTimeCount,type=4},
                new {label = "投资平台推送项目",value = tzzxptCount,type=5},
            };

        }
        /// <summary>
        /// 报建作废
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ProjectReportBuildVoided(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            model.ID = model.MID.ToNullableDecimal();
            var entity = FirstOrNull(T_AFC_PROJECT._.ID == model.ID);
            if (entity == null)
            {
                r.SetFail("未找到该报建");
                return r;
            }

            if (((entity.APPROVAL_TACHE == 3 || entity.APPROVAL_TACHE == 1) && entity.APPROVAL_STATE != 3) ||
                (entity.APPROVAL_TACHE == 2 && entity.APPROVAL_STATE != 4))
            {
                r.SetFail("该报建无法作废");
                return r;
            }

            if (entity.APPROVAL_DEPID != JdUser.DEPARTID?.ToString())
            {
                r.SetFail("权限不足，无法作废该报建！");
                return r;
            }

            if (string.IsNullOrWhiteSpace(model.APPROVAL_REMARK))
            {
                r.SetFail("请填写作废原因");
                return r;
            }

            using (var trans = GetDbSession().BeginTransaction())
            {
                #region 报建作废更新

                entity.APPROVAL_STATE = 6;
                entity.APPROVAL_REMARK = model.APPROVAL_REMARK;
                entity.APPROVAL_UID = JdUser.ID;
                entity.APPROVAL_TM = DateTime.Now;
                entity.DATA_TIMESTAMP = entity.APPROVAL_TM;
                trans.Update(entity);

                #endregion
                #region 添加日志

                var log = entity.ConvertTo<T_AFC_LOG>();
                /*-----------日志记录信息----------*/
                log.AFC_ID = entity.ID;
                log.ISNEW = 0;
                log.RECORDER_UID = JdUser.ID;               //记录人ID
                log.RECORDER_DEPNAME = JdUser.UserExtend?.DEP_NAME;       //记录-操作人单位
                log.RECORDER_TACHE = entity.APPROVAL_TACHE;           //记录-环节
                log.RECORDER_OPERATION = entity.APPROVAL_STATE;   //记录-操作
                log.RECORDER_TM = entity.DATA_TIMESTAMP;                 //记录-时间
                log.RECORDER_UNAME = JdUser.MANAGE_NAME;           //记录-审查人员
                log.RECORDER_CONTACT = JdUser.PHONE;       //记录-联系方式
                log.RECORDER_REMARK = model.APPROVAL_REMARK;         //记录-相关意见
                log.RECORDER_AIDS = String.Empty;             //记录-附件

                trans.Insert(log);
                trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == model.ID);
                #endregion

                SendMsg2AfcProjectReporter(trans, entity);
                trans.Commit();
            }
            r.SetSuccess();
            return r;
        }
        /// <summary>
        /// 报建审批 MID APPROVAL_STATE 3 | 4 APPROVAL_REMARK APPROVAL_UNAME APPROVAL_CONTACT_INFORMATION
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult ProjectReportBuildApproval(TAfcProjectModel model)
        {
            var r = new GeneralResult();
            model.ID = model.MID.ToNullableDecimal();
            var entity = FirstOrNull(T_AFC_PROJECT._.ID == model.ID);
            if (entity == null)
            {
                r.SetFail("未找到该报建");
                return r;
            }

            if (entity.APPROVAL_STATE != 2 && model.APPROVAL_STATE != 7)
            {
                r.SetFail("所处流程不正确");
                return r;
            }

            if (entity.APPROVAL_DEPID != JdUser.DEPARTID?.ToString())
            {
                r.SetFail("权限不足，无法审查该报建！");
                return r;
            }

            if (model.APPROVAL_STATE != 3 && model.APPROVAL_STATE != 4)
            {
                r.SetFail("无效的请求！");
                return r;
            }
            entity.Attach();
            entity.APPROVAL_STATE = model.APPROVAL_STATE;
            if (model.APPROVAL_STATE == 3)//通过
            {
                //报建编号=6位行政区划-6位工程项目日期-2位工程项目分类-2位工程项目序列码
                if (string.IsNullOrWhiteSpace(entity.CODE))
                {
                    var m = entity.ConvertTo<TAfcProjectModel>();
                    entity.CODE = ProjectReportBuildSequence(m);
                }

            }
            if (model.APPROVAL_STATE == 4)//不通过
            {
                if (string.IsNullOrWhiteSpace(model.APPROVAL_REMARK))
                {
                    r.SetFail("请填写审查意见！");
                    return r;
                }
                entity.APPROVAL_REMARK = model.APPROVAL_REMARK;//审查意见
                if (!string.IsNullOrWhiteSpace(model.APPROVAL_UNAME))
                {
                    entity.APPROVAL_UNAME = model.APPROVAL_UNAME;//审查人员-姓名
                }
                if (!string.IsNullOrWhiteSpace(model.APPROVAL_CONTACT_INFORMATION))
                {
                    entity.APPROVAL_CONTACT_INFORMATION = model.APPROVAL_CONTACT_INFORMATION; //审查人员-联系方式
                }
            }

            entity.APPROVAL_UID = JdUser.ID;
            entity.APPROVAL_TM = DateTime.Now;
            entity.DATA_TIMESTAMP = entity.APPROVAL_TM;
            using (var trans = GetDbSession().BeginTransaction())
            {
                trans.Update(entity);

                #region 更新备案项目表的项目名称

                if (entity.APPROVAL_STATE == 3)
                {
                    var projects = Jd.ProjectService.FindList(PROJECT._.CONSTRUCTION_ID == entity.CODE);
                    if (projects != null && projects.Any())
                    {
                        foreach (var item in projects)
                        {
                            item.Attach();
                            item.PROJECT_NAME = entity.PROJECT_NAME;
                            ////item.PROJECT_CODE = entity.PROJECT_CODE;
                            ////item.REGION_CODE = entity.REGION_CODE;
                            item.INVEST_PROJECT_CODE = entity.TZ_CODE;
                            item.ADDRESS = entity.PROJECT_ADDRESS;
                            item.LEGAL_PERSON = entity.JS_DEP;
                            ////item.INDUSTRIES_TYPE = entity.INDUSTRIES_TYPE;
                            item.FUND_SOURCE = entity.FUND_SOURCE;
                            if (entity.KIND == ((int)TAfcProjectKind.XinXi).ToString())
                            {
                                item.CONTRIBUTION_SCALE = $"数办批复资金投资比例:{entity.CONTRIBUTION_SCALE_SB}(%), 财政资金投资比例：{entity.CONTRIBUTION_SCALE_CZ}(%),自筹资金投资比例：{entity.CONTRIBUTION_SCALE_ZC}(%)，其他资金投资比例：{entity.CONTRIBUTION_SCALE_QT}(%)，其中,国有资金出资比例：{entity.GOVERNMENT_INVEST_FINANCE}(%)";
                            }
                            else
                            {
                                item.CONTRIBUTION_SCALE = $"财政资金投资比例：{entity.CONTRIBUTION_SCALE_CZ}(%),自筹资金投资比例：{entity.CONTRIBUTION_SCALE_ZC}(%)，其他资金投资比例：{entity.CONTRIBUTION_SCALE_QT}(%)，其中,国有资金出资比例：{entity.GOVERNMENT_INVEST_FINANCE}(%)";
                            }


                            item.PROJECT_SCALE = entity.GCGMJNR;
                            item.CONTACTOR = entity.MANAGER;
                            item.CONTACT_INFORMATION = entity.MANAGER_PHONE;
                            item.APPROVAL_NAME = entity.APPROVAL_NAME;
                            item.APPROVAL_NUMBER = entity.APPROVAL_NUMBER;
                            item.APPROVAL_AUTHORITY = entity.APPROVAL_AUTHORITY;
                            ////item.CREATE_TIME = entity.CREATE_TIME;
                            ////item.PLATFORM_CODE = entity.PLATFORM_CODE;
                            ////item.PUB_SERVICE_PLAT_CODE = entity.PUB_SERVICE_PLAT_CODE;
                            ////item.DATA_TIMESTAMP = entity.DATA_TIMESTAMP;
                            ////item.CONSTRUCTION_ID = entity.CONSTRUCTION_ID;
                            ////item.M_ID = entity.M_ID;
                            ////item.M_PROJECT_TYPE = entity.M_PROJECT_TYPE;
                            ////item.M_JYCS = entity.M_JYCS;
                            ////item.M_ISFR = entity.M_ISFR;
                            ////item.M_ATT_PROJECT_APPROVAL_FILE = entity.M_ATT_PROJECT_APPROVAL_FILE;
                            ////item.M_ATT_LICENSE_FILE = entity.M_ATT_LICENSE_FILE;
                            ////item.M_REMARK = entity.M_REMARK;
                            ////item.M_CREATOR = entity.M_CREATOR;
                            ////item.M_CREATE_TM = entity.M_CREATE_TM;
                            item.REGION_CITY = entity.REGION_CITY;
                            item.REGION_COUNTY = entity.REGION_COUNTY;
                        }
                        trans.Update(projects);
                    }
                }

                #endregion

                #region 添加日志

                var log = entity.ConvertTo<T_AFC_LOG>();
                /*-----------日志记录信息----------*/
                log.AFC_ID = entity.ID;
                log.ISNEW = entity.APPROVAL_STATE == 3 ? 1 : 0;
                log.RECORDER_UID = JdUser.ID;               //记录人ID
                log.RECORDER_DEPNAME = JdUser?.UserExtend?.DEP_NAME;       //记录-操作人单位
                log.RECORDER_TACHE = entity.APPROVAL_TACHE;           //记录-环节
                log.RECORDER_OPERATION = entity.APPROVAL_STATE;   //记录-操作
                log.RECORDER_TM = entity.DATA_TIMESTAMP;                 //记录-时间
                if (entity.APPROVAL_STATE == 4)
                {
                    log.RECORDER_UNAME = entity.APPROVAL_UNAME;           //记录-审查人员
                    log.RECORDER_CONTACT = entity.APPROVAL_CONTACT_INFORMATION;       //记录-联系方式
                    log.RECORDER_REMARK = entity.APPROVAL_REMARK;         //记录-相关意见
                }
                log.RECORDER_AIDS = String.Empty;             //记录-附件
                if (entity.APPROVAL_STATE == 3)
                { //如果是最新数据，则将其他的设为旧数据
                    trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == model.ID);
                }
                trans.Insert(log);

                #endregion

                SendMsg2AfcProjectReporter(trans, entity);
                trans.Commit();
            }
            r.SetSuccess();
            return r;
        }
        public GeneralResult ProjectReportBuildChangeApproval(TAfcProjectModel model)
        {
            var r = new GeneralResult();

            var entity = FirstOrNull(T_AFC_PROJECT._.ID == model.AFC_ID);
            if (entity == null)
            {
                r.SetFail("未找到该报建");
                return r;
            }

            if (entity.APPROVAL_STATE != 2 || (entity.APPROVAL_TACHE != 2))
            {
                r.SetFail("所处流程不正确");
                return r;
            }

            if (entity.APPROVAL_DEPID != JdUser.DEPARTID.ToString())
            {
                r.SetFail("权限不足，无法审查该报建！");
                return r;
            }

            if (model.APPROVAL_STATE != 3 && model.APPROVAL_STATE != 4)
            {
                r.SetFail("无效的请求！");
                return r;
            }

            var change = Jd.TAfcChangeService.FirstOrNull(T_AFC_PROJECT._.ID == model.ID);
            if (change == null)
            {
                r.SetFail("未找到该变更申请！");
                return r;
            }

            if (change.APPROVAL_STATE != 1)
            {
                r.SetFail("变更申请所处流程不正确！");
                return r;
            }
            change.Attach();
            entity.Attach();
            change.APPROVAL_STATE = model.APPROVAL_STATE - 1;
            entity.APPROVAL_STATE = model.APPROVAL_STATE;
            entity.APPROVAL_TACHE = 3;
            if (model.APPROVAL_STATE == 3)//通过
            {
                //报建编号=6位行政区划-6位工程项目日期-2位工程项目分类-2位工程项目序列码
                if (string.IsNullOrWhiteSpace(entity.CODE))
                {
                    var m = entity.ConvertTo<TAfcProjectModel>();
                    entity.CODE = ProjectReportBuildSequence(m);
                }
            }
            if (model.APPROVAL_STATE == 4)//不通过
            {
                if (string.IsNullOrWhiteSpace(model.APPROVAL_REMARK))
                {
                    r.SetFail("请填写审查意见！");
                    return r;
                }
                entity.APPROVAL_REMARK = model.APPROVAL_REMARK;//审查意见
                change.APPROVAL_REMARK = model.APPROVAL_REMARK;
                if (!string.IsNullOrWhiteSpace(model.APPROVAL_UNAME))
                {
                    entity.APPROVAL_UNAME = model.APPROVAL_UNAME;//审查人员-姓名
                    change.APPROVAL_UNAME = model.APPROVAL_UNAME;
                }
                if (!string.IsNullOrWhiteSpace(model.APPROVAL_CONTACT_INFORMATION))
                {
                    entity.APPROVAL_CONTACT_INFORMATION = model.APPROVAL_CONTACT_INFORMATION; //审查人员-联系方式
                    change.APPROVAL_CONTACT_INFORMATION = model.APPROVAL_CONTACT_INFORMATION;
                }
            }

            change.APPROVAL_TM = DateTime.Now;
            change.APPROVAL_UID = JdUser.ID;

            entity.APPROVAL_UID = JdUser.ID;
            entity.APPROVAL_TM = DateTime.Now;
            entity.DATA_TIMESTAMP = entity.APPROVAL_TM;
            using (var trans = GetDbSession().BeginTransaction())
            {
                trans.Update(entity);
                trans.Update(change);

                #region 更新备案项目表的项目名称

                if (entity.APPROVAL_STATE == 3)
                {
                    var projects = Jd.ProjectService.FindList(PROJECT._.CONSTRUCTION_ID == entity.CODE);
                    if (projects != null && projects.Any())
                    {
                        foreach (var item in projects)
                        {
                            item.Attach();
                            item.PROJECT_NAME = entity.PROJECT_NAME;
                            ////item.PROJECT_CODE = entity.PROJECT_CODE;
                            ////item.REGION_CODE = entity.REGION_CODE;
                            item.INVEST_PROJECT_CODE = entity.TZ_CODE;
                            item.ADDRESS = entity.PROJECT_ADDRESS;
                            item.LEGAL_PERSON = entity.JS_DEP;
                            ////item.INDUSTRIES_TYPE = entity.INDUSTRIES_TYPE;
                            item.FUND_SOURCE = entity.FUND_SOURCE;
                            if (entity.KIND == ((int)TAfcProjectKind.XinXi).ToString())
                            {
                                item.CONTRIBUTION_SCALE = $"数办批复资金投资比例:{entity.CONTRIBUTION_SCALE_SB}(%), 财政资金投资比例：{entity.CONTRIBUTION_SCALE_CZ}(%),自筹资金投资比例：{entity.CONTRIBUTION_SCALE_ZC}(%)，其他资金投资比例：{entity.CONTRIBUTION_SCALE_QT}(%)，其中,国有资金出资比例：{entity.GOVERNMENT_INVEST_FINANCE}(%)";
                            }
                            else
                            {
                                item.CONTRIBUTION_SCALE = $"财政资金投资比例：{entity.CONTRIBUTION_SCALE_CZ}(%),自筹资金投资比例：{entity.CONTRIBUTION_SCALE_ZC}(%)，其他资金投资比例：{entity.CONTRIBUTION_SCALE_QT}(%)，其中,国有资金出资比例：{entity.GOVERNMENT_INVEST_FINANCE}(%)";
                            }

                            item.PROJECT_SCALE = entity.GCGMJNR;
                            item.CONTACTOR = entity.MANAGER;
                            item.CONTACT_INFORMATION = entity.MANAGER_PHONE;
                            item.APPROVAL_NAME = entity.APPROVAL_NAME;
                            item.APPROVAL_NUMBER = entity.APPROVAL_NUMBER;
                            item.APPROVAL_AUTHORITY = entity.APPROVAL_AUTHORITY;
                            ////item.CREATE_TIME = entity.CREATE_TIME;
                            ////item.PLATFORM_CODE = entity.PLATFORM_CODE;
                            ////item.PUB_SERVICE_PLAT_CODE = entity.PUB_SERVICE_PLAT_CODE;
                            ////item.DATA_TIMESTAMP = entity.DATA_TIMESTAMP;
                            ////item.CONSTRUCTION_ID = entity.CONSTRUCTION_ID;
                            ////item.M_ID = entity.M_ID;
                            ////item.M_PROJECT_TYPE = entity.M_PROJECT_TYPE;
                            ////item.M_JYCS = entity.M_JYCS;
                            ////item.M_ISFR = entity.M_ISFR;
                            ////item.M_ATT_PROJECT_APPROVAL_FILE = entity.M_ATT_PROJECT_APPROVAL_FILE;
                            ////item.M_ATT_LICENSE_FILE = entity.M_ATT_LICENSE_FILE;
                            ////item.M_REMARK = entity.M_REMARK;
                            ////item.M_CREATOR = entity.M_CREATOR;
                            ////item.M_CREATE_TM = entity.M_CREATE_TM;
                            item.REGION_CITY = entity.REGION_CITY;
                            item.REGION_COUNTY = entity.REGION_COUNTY;
                        }
                        trans.Update(projects);
                    }
                }

                #endregion

                #region 添加日志

                var log = entity.ConvertTo<T_AFC_LOG>();
                /*-----------日志记录信息----------*/
                log.AFC_ID = entity.ID;
                log.ISNEW = entity.APPROVAL_STATE == 3 ? 1 : 0;
                log.RECORDER_UID = JdUser.ID;               //记录人ID
                log.RECORDER_DEPNAME = JdUser.UserExtend?.DEP_NAME;       //记录-操作人单位
                log.RECORDER_TACHE = entity.APPROVAL_TACHE;           //记录-环节
                log.RECORDER_OPERATION = entity.APPROVAL_STATE;   //记录-操作
                log.RECORDER_TM = entity.DATA_TIMESTAMP;                 //记录-时间
                if (entity.APPROVAL_STATE == 4)
                {
                    log.RECORDER_UNAME = entity.APPROVAL_UNAME;           //记录-审查人员
                    log.RECORDER_CONTACT = entity.APPROVAL_CONTACT_INFORMATION;       //记录-联系方式
                    log.RECORDER_REMARK = entity.APPROVAL_REMARK;         //记录-相关意见
                }
                log.RECORDER_AIDS = String.Empty;             //记录-附件
                log.APPROVAL_DEPID = entity.U_ID?.ToString();
                if (entity.APPROVAL_STATE == 3)
                { //如果是最新数据，则将其他的设为旧数据
                    trans.Update<T_AFC_LOG>(T_AFC_LOG._.ISNEW, 0, T_AFC_LOG._.AFC_ID == model.ID);
                }
                trans.Insert(log);

                #endregion

                SendMsg2AfcProjectReporter(trans, entity);
                trans.Commit();
            }
            r.SetSuccess();
            return r;
        }

        /// <summary>
        /// 交易数据-招标项目列表
        /// </summary>
        /// <param name="projectCode"></param>
        /// <returns></returns>
        public List<dynamic> TradeList(string projectCode)
        {
            var r = Fw.CommonService.FromSql(@"SELECT ROW_NUMBER() OVER(ORDER BY A.CREATE_TIME DESC) AS RN,
             A.TENDER_PROJECT_CODE,
             A.TENDER_PROJECT_NAME,
             TO_CHAR(A.CREATE_TIME,'yyyy-mm-dd hh24:mi:ss') AS CREATE_TIME,
             A.TENDERER_NAME,
             A.TENDER_AGENCY_NAME,
             TO_CHAR((SELECT MAX(BID_OPEN_TIME) FROM TENDER_ANN_QUA_INQUERY_ANN WHERE NOTICE_NATURE IN ('1','2','3') AND BULLETIN_TYPE=1 AND  TENDER_PROJECT_CODE=A.TENDER_PROJECT_CODE),'yyyy-mm-dd hh24:mi:ss') AS BID_OPEN_TIME
        FROM TENDER_PROJECT A
       WHERE A.PROJECT_CODE=:PROJECT_CODE").AddInParameter(":PROJECT_CODE", DbType.AnsiString, projectCode)
                .ToList<dynamic>();
            return r;
        }
        #endregion

        #region 【报建审查】消息提醒方法
        /// <summary>
        /// 新报建项目消息
        /// </summary>
        /// <returns></returns>
        public int ProjectNewCount()
        {
            //计算出前1个工作日所在的日期
            DateTime now = DateTime.Now;
            DateTime beginTm = DateTime.Today, endTm = beginTm;
            int count = 0;
            while (count != 1)
            {
                beginTm = beginTm.AddDays(-1);
                if (Jd.THolidayService.IsWorkTime(beginTm)) count++; //是工作日,+1
            }

            while (Jd.THolidayService.IsWorkTime(endTm))
            {
                endTm = endTm.AddDays(1);//当天如果不是工作日，添加一天，直到是工作日
            }
            TimeSpan ts = endTm - beginTm;
            int days = ts.Days;
            var d = now.AddDays(-days).AddHours(-6);
            var departId = JdUser?.DEPARTID;
            var condition = T_AFC_PROJECT._.APPROVAL_TACHE.In(1, 2, 3) //提交审核（初建）变更申请 报建变更
                            && T_AFC_PROJECT._.APPROVAL_STATE == 2 //待审查
                            && T_AFC_PROJECT._.APPROVAL_DEPID == departId //审查单位
                            && T_AFC_PROJECT._.DATA_TIMESTAMP >= d
            ;
            return Count(condition);
        }

        /// <summary>
        /// 旧报建项目消息（快过期提醒：超过第二个工作日的前15时，即下午3点）==>获取将超期数据统计（提交日期大于前两个工作日，小于前一个工作日）
        /// </summary>
        /// <returns></returns>
        public int ProjectExpiringSoon()
        {
            //计算出前两个工作日所在的日期
            DateTime twoWorkDayAgo = DateTime.Now.Date, endTm = DateTime.Now;
            if (!Jd.THolidayService.IsWorkTime(endTm) || endTm.Hour < 15)
            {//非工作日或者当前时间小于15点，不统计将超期
                return 0;
            }
            int count = 0;
            while (count != 2)
            {
                twoWorkDayAgo = twoWorkDayAgo.AddDays(-1);
                if (count < 1)
                {
                    endTm = endTm.AddDays(-1);
                }
                if (Jd.THolidayService.IsWorkTime(twoWorkDayAgo)) count++;  //是工作日,+1
            }
            var departId = JdUser?.DEPARTID;
            var condition = T_AFC_PROJECT._.APPROVAL_TACHE.In(1, 2, 3) //提交审核（初建）变更申请 报建变更
                            && T_AFC_PROJECT._.APPROVAL_STATE == 2 //待审查
                            && T_AFC_PROJECT._.APPROVAL_DEPID == departId //审查单位
                            && T_AFC_PROJECT._.DATA_TIMESTAMP >= twoWorkDayAgo
                            && T_AFC_PROJECT._.DATA_TIMESTAMP < endTm;
            ;
            return Count(condition);
        }

        /// <summary>
        /// 过期报建项目消息（过期提醒：超过两个工作日）==>DATA_TIMESTAMP 比2个工作日前的日期更早
        /// </summary>
        /// <returns></returns>
        public int ProjectExpired()
        {
            //过期报建项目消息（过期提醒：超过两个工作日）==>DATA_TIMESTAMP 比2个工作日前的日期更早
            var twoWorkDayAgo = DateTime.Now;
            int count = 0;
            while (count != 2)
            {
                twoWorkDayAgo = twoWorkDayAgo.AddDays(-1);
                if (Jd.THolidayService.IsWorkTime(twoWorkDayAgo)) count++;
            }

            var departId = JdUser?.DEPARTID;
            var condition = T_AFC_PROJECT._.APPROVAL_TACHE.In(1, 2, 3) //提交审核（初建）变更申请 报建变更
                    && T_AFC_PROJECT._.APPROVAL_STATE == 2 //待审查
                    && T_AFC_PROJECT._.APPROVAL_DEPID == departId //审查单位
                    && T_AFC_PROJECT._.DATA_TIMESTAMP < twoWorkDayAgo;
            ;
            return Count(condition);
        }
        #endregion

        #region 监督首页-报建审查
        /// <summary>
        /// 监督首页-报建审查
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object GetBJ_Data(MonitorHomePageModel model)
        {
            #region 查询条件

            var whereBuilder = new WhereClipBuilder(T_AFC_PROJECT._.APPROVAL_STATE != 1);
            var regionBuilder = new WhereClipBuilder();
            var industryBuilder = new WhereClipBuilder();
            if (model.BeginTime.HasValue)
            {
                whereBuilder.And(T_AFC_PROJECT._.TM >= model.BeginTime);
            }
            if (model.EndTime.HasValue)
            {
                whereBuilder.And(T_AFC_PROJECT._.TM <= model.EndTime);
            }

            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {

                if (model.REGION_CODE.Equals("3501"))
                {
                    whereBuilder.And(T_AFC_PROJECT._.REGION_CITY.Contain(model.REGION_CODE) && T_AFC_PROJECT._.REGION_CITY != "350128");
                }
                else
                {
                    whereBuilder.And(T_AFC_PROJECT._.REGION_CITY.Contain(model.REGION_CODE));
                }
                if (model.REGION_CODE.Equals("35"))
                {
                    regionBuilder.And($"SYS_AREA_QUANGUO.AREACODE LIKE '{model.REGION_CODE}__00' OR AREACODE='350128'");
                }
                else if (model.REGION_CODE.Equals("350128"))
                {
                    regionBuilder.And(SYS_AREA_QUANGUO._.AREACODE == "350128");
                }
                else
                {
                    regionBuilder.And($"SYS_AREA_QUANGUO.AREACODE LIKE '{model.REGION_CODE}__' And AREACODE='350128'");
                }

            }

            var kinds = JdUser?.UserDepartment?.HY_TYPE_LIST ?? new List<string> { "1", "2", "3" };
            if (kinds != null && kinds.Any())
            {
                whereBuilder.And(T_AFC_PROJECT._.KIND.In(kinds));
                if (string.IsNullOrWhiteSpace(model.HY_TYPE))
                {
                    industryBuilder.And(SYS_DIC._.VALUE.In(kinds) && SYS_DIC._.TYPE == 76);
                }
            }

            if (!string.IsNullOrWhiteSpace(model.HY_TYPE))
            {
                whereBuilder.And(T_AFC_PROJECT._.KIND == model.HY_TYPE);
                industryBuilder.And(SYS_DIC._.VALUE2 == model.HY_TYPE && SYS_DIC._.TYPE == 63);
            }

            var where = whereBuilder.ToWhereClip();

            var tAfcProjectSection = FromWhere(where);
            #endregion

            #region 状态统计 GZGK_MANAGE.Get_BJ_ZT

            var stateData = FromWhere(where)
                .Select(
                    Field.All.Count().As("ZS_NUM")
                    , new Field(" NVL(SUM(CASE WHEN APPROVAL_STATE = '2' THEN 1 ELSE 0 END),0)").As("DB_NUM")
                    , new Field("NVL(SUM(CASE WHEN APPROVAL_STATE IN ('3','4','6') THEN 1 ELSE 0 END),0)").As("YB_NUM")
                    , new Field(" NVL(SUM(CASE WHEN APPROVAL_STATE = '2' AND OVER_TM <= SYSDATE THEN 1 ELSE 0 END),0)").As("CQ_NUM")
                )
                .ToFirst<MonitorHomePageSummaryStatisticsModel>();

            #endregion

            #region 区域统计 GZGK_MANAGE.Get_BJ_DQ

            var regionTmp = Jd.SysAreaQuanguoService.FromWhere(regionBuilder.ToWhereClip());
            if ("35".Equals(model.REGION_CODE))
            {
                regionTmp.InnerJoinTmp<T_AFC_PROJECT>(tAfcProjectSection, SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_CITY);
            }
            else
            {
                regionTmp.InnerJoinTmp<T_AFC_PROJECT>(tAfcProjectSection, SYS_AREA_QUANGUO._.AREACODE == T_AFC_PROJECT._.REGION_COUNTY);
            }

            regionTmp = regionTmp.GroupBy(SYS_AREA_QUANGUO._.AREACODE).Select(SYS_AREA_QUANGUO._.AREACODE.As("Label"),
                T_AFC_PROJECT._.All.Count().As("Value"));
            var regionData = Jd.SysAreaQuanguoService.FromWhere(regionBuilder.ToWhereClip())
                .LeftJoinTmp("Tmp", regionTmp, SYS_AREA_QUANGUO._.AREACODE == new Field("Label"))
                .OrderBy(SYS_AREA_QUANGUO._.ORDER_BY.Asc)
                .Select(SYS_AREA_QUANGUO._.AREANAME.As("Label"), new Field("Value").Nvl(0).As("Value"))
                .ToList<LabelValueModel>();
            #endregion

            #region 报建审查：类型统计 GZGK_MANAGE.Get_BJ_LX

            var industryTmp = Jd.SysDicService.FromWhere(industryBuilder.ToWhereClip())
                .InnerJoinTmp<T_AFC_PROJECT>(tAfcProjectSection, SYS_DIC._.VALUE == T_AFC_PROJECT._.KIND)
                .GroupBy(SYS_DIC._.VALUE)
                .Select(SYS_DIC._.VALUE.As("Label"), T_AFC_PROJECT._.All.Count().As("CountValue"));

            var industry = Jd.SysDicService.FromWhere(industryBuilder.ToWhereClip())
                .LeftJoinTmp("Tmp", industryTmp, SYS_DIC._.VALUE == new Field("Label"))
                .OrderBy(SYS_DIC._.VALUE.Asc)
                .Select(SYS_DIC._.TEXT.As("Label"), new Field("CountValue").Nvl(0).As("Value"))
                .ToList<LabelValueModel>();
            #endregion

            return new
            {
                stateData = new List<LabelValueModel>
                {
                    new LabelValueModel{Label= "报建总数",Value=stateData.ZS_NUM.ToString()},
                    new LabelValueModel{Label= "待办件数",Value=stateData.DB_NUM.ToString()},
                    new LabelValueModel{Label= "已办件数",Value=stateData.YB_NUM.ToString()},
                    new LabelValueModel{Label= "处理超期数",Value=stateData.CQ_NUM.ToString()},
                },
                regionData = new
                {
                    xAxis = regionData.Select(c => c.Label),
                    data = regionData.Select(c => c.Value),
                },
                industry = industry.Select(c => new { name = c.Label, value = c.Value }).ToList()
            };
        }

        /// <summary>
        /// 项目类型统计
        /// </summary>
        /// <param name="jdUserDepartId"></param>
        /// <returns></returns>
        public List<object> StatProjectType(decimal? jdUserDepartId = null)
        {
            if (!jdUserDepartId.HasValue)
            {
                jdUserDepartId = JdUser?.DEPARTID;
            }
            var condition = T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId;
            var r = FromWhere(condition)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && SYS_DIC._.VALUE == T_AFC_PROJECT._.PROJECT_TYPE) //工程类别
                .GroupBy(SYS_DIC._.TEXT)
                .Select(
                    SYS_DIC._.TEXT.As("name")
                    , Field.All.Count().As("value")
                ).ToList<object>();
            return r;
        }
        /// <summary>
        /// 项目归属地统计
        /// </summary>
        /// <param name="jdUserDepartId"></param>
        /// <returns></returns>
        public object StatRegion(decimal? jdUserDepartId = null)
        {
            if (!jdUserDepartId.HasValue)
            {
                jdUserDepartId = JdUser?.DEPARTID;
            }

            var condition = T_AFC_PROJECT._.APPROVAL_DEPID == jdUserDepartId;
            var regionField = new Field("(CASE WHEN SYS_AREA_QUANGUO.AREANAME IS NULL THEN SYS_AREA_QUANGUO2.AREANAME ELSE SYS_AREA_QUANGUO.AREANAME END)");
            var r = FromWhere(condition)
                .LeftJoin<SYS_AREA_QUANGUO>(T_AFC_PROJECT._.REGION_COUNTY == SYS_AREA_QUANGUO._.AREACODE)
                .LeftJoin<SYS_AREA_QUANGUO>(T_AFC_PROJECT._.REGION_CITY == SYS_AREA_QUANGUO._.AREACODE)
                .GroupBy(regionField)
                .Select(
                    regionField.As("Label")
                    , Field.All.Count().As("Value")
                ).ToList<LabelValueModel>();
            var xAxis = r.Select(c => c.Label);
            var data = r.Select(c => c.Value);
            return new
            {
                xAxis,
                data
            };
        }
        #endregion

        #region 项目报建-短信消息


        /// <summary>
        /// 发送短信给审查单位
        /// </summary>
        /// <param name="approvalDepId">审查单位id</param>
        /// <param name="msg">短信内容</param>
        /// <param name="trans"></param>
        protected void SendMsg2ApprovalDep(string approvalDepId, string msg, DbTrans trans)
        {
            var userList = Jd.TUserService.FindProjectReportBuildApproverByDepartId(approvalDepId);
            if (userList.Any())
            {
                var mobile = userList.FindAll(c => !string.IsNullOrWhiteSpace(c.TELPHONE)).Select(c => c.TELPHONE)
                    .Distinct().ToList();
                var mobiles = string.Join(",", mobile);
                var smsModel = new SmsCommon
                {
                    Mobile = mobiles,
                    Content = msg
                };
                var rsp = smsModel.SendSms();

                var smsLog = new T_SMS_LOG
                {
                    ID = 0,
                    OPER_BY = JdUser.ID,
                    RESPONSE_TEXT = rsp.Serializer(),
                    STATUS = rsp.Success.ToString(),
                    SYSNAME = "行政监督平台",
                    TEL_PHONE = mobiles,
                    SMS_PLATFORM = "中国网建",
                    SEND_TM = DateTime.Now,
                    SMS_CONTENT = msg
                };
                trans.Insert(smsLog);
            }
        }

        /// <summary>
        /// 发送短信给审查单位
        /// </summary>
        /// <param name="entity">短信内容</param>
        /// <param name="trans"></param>
        protected void SendMsg2AfcProjectReporter(DbTrans trans, T_AFC_PROJECT entity)
        {
            var stateName = entity.APPROVAL_STATE == 3 ? "通过" : entity.APPROVAL_STATE == 4 ? "不通过" : entity.APPROVAL_STATE == 6 ? "作废" : "";
            if (!string.IsNullOrWhiteSpace(stateName))
            {
                var msgConfig = ConfigHelper.AppSettings.SmsBJAudit;
                var msg = string.Format(msgConfig, entity.DEP_NAME, HttpUtility.HtmlDecode(entity.PROJECT_NAME), JdUser.UserDepartment.DNAME, stateName);
                var userList = Jd.TUserService.FindProjectReportBuilderByUid(entity.U_ID);
                if (userList.Any())
                {
                    var mobile = userList.FindAll(c => !string.IsNullOrWhiteSpace(c.TELPHONE)).Select(c => c.TELPHONE)
                        .Distinct().ToList();
                    var mobiles = string.Join(",", mobile);
                    var smsModel = new SmsCommon
                    {
                        Mobile = mobiles,
                        Content = msg
                    };
                    var rsp = smsModel.SendSms();

                    var smsLog = new T_SMS_LOG
                    {
                        ID = 0,
                        OPER_BY = JdUser.ID,
                        RESPONSE_TEXT = rsp.Serializer(),
                        STATUS = rsp.Success.ToString(),
                        SYSNAME = "行政监督平台",
                        TEL_PHONE = mobiles,
                        SMS_PLATFORM = "中国网建",
                        SEND_TM = DateTime.Now,
                        SMS_CONTENT = msg
                    };
                    trans.Insert(smsLog);
                }
            }
        }
        #endregion

        #region  首页统计-招标计划登记(报建审查)
        /// <summary>
        ///  报建审查-计数接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<LabelValueModel<int>> ProjectCount(TAfcProjectStatisticsModel model)
        {
            if (JdUser?.DEPARTID == null)
            {
                return new List<LabelValueModel<int>>
                {
                    new LabelValueModel<int> {Label = "报建总数", Value = 0},
                    new LabelValueModel<int> {Label = "待办件数", Value = 0},
                    new LabelValueModel<int> {Label = "已办件数", Value = 0},
                    new LabelValueModel<int> {Label = "处理超期数", Value = 0},
                };
            }
            var departId = JdUser?.DEPARTID;
            var hasCensor = JdUser != null && (JdUser.HasPermission("JdTAfcProject", "Approval") ||
                                               JdUser.HasPermission("JdTAfcProject", "ChangeApproval"));
            var condition = new WhereClipBuilder();
            condition.And(T_AFC_PROJECT._.APPROVAL_DEPID == departId);
            if (model.BeginTime != null)
            {
                condition.And(T_AFC_PROJECT._.TM >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(T_AFC_PROJECT._.TM <= model.EndTime);
            }
            if (model.TENDER_PROJECT_TYPES!=null&&model.TENDER_PROJECT_TYPES.Any())
            {
                condition.And(T_AFC_PROJECT._.PROJECT_TYPE.In(model.TENDER_PROJECT_TYPES));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                if (model.REGION_CODE.Length < 6)
                {
                    condition.And(T_AFC_PROJECT._.REGION_CITY.BeginWith(model.REGION_CODE)|| T_AFC_PROJECT._.REGION_COUNTY.BeginWith(model.REGION_CODE));
                    if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                    {
                        condition.And(T_AFC_PROJECT._.REGION_CITY != "350128"&&T_AFC_PROJECT._.REGION_COUNTY != "350128");//平潭综合试验区 350100 福州市
                    }
                }
                else
                {
                    condition.And(T_AFC_PROJECT._.REGION_CITY == model.REGION_CODE||T_AFC_PROJECT._.REGION_COUNTY==model.REGION_CODE);
                }
            }
            var con = condition.ToWhereClip();
            var waitToDo = !hasCensor ? 0 : Count(con && T_AFC_PROJECT._.APPROVAL_STATE == 2);//代办
            var total = Count(condition);//总数
            var done = Count(con && T_AFC_PROJECT._.APPROVAL_STATE.In(3, 4, 6));//已办
            var overtime = !hasCensor ? 0 : Count(con && T_AFC_PROJECT._.APPROVAL_STATE == 2 && T_AFC_PROJECT._.OVER_TM < DateTime.Now);
            return new List<LabelValueModel<int>>
            {
                new LabelValueModel<int>{Id="T_AFC_PROJECT_TOTAL",Label = "招标计划登记总数",Value = total},
                new LabelValueModel<int>{Id="T_AFC_PROJECT_TODO",Label = "待办件数",Value = waitToDo},
                new LabelValueModel<int>{Id="T_AFC_PROJECT_DONE",Label = "已办件数",Value = done},
                new LabelValueModel<int>{Id="T_AFC_PROJECT_OVERTIME",Label = "处理超期数",Value = overtime},
            };

        }
        /// <summary>
        ///  报建审查-根据类型统计接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<Object> ProjectGroupByType(TAfcProjectStatisticsModel model)
        {
            if (JdUser == null || !JdUser.DEPARTID.HasValue)
            {
                return new List<Object> { };
            }
            var departId = JdUser?.DEPARTID;
            var condition = new WhereClipBuilder();
            condition.And(T_AFC_PROJECT._.APPROVAL_DEPID == departId);
            condition.And(T_AFC_PROJECT._.APPROVAL_DEPID == departId);
            if (model.BeginTime != null)
            {
                condition.And(T_AFC_PROJECT._.TM >= model.BeginTime);
            }
            if (model.EndTime != null)
            {
                condition.And(T_AFC_PROJECT._.TM <= model.EndTime);
            }
            if (model.TENDER_PROJECT_TYPES != null && model.TENDER_PROJECT_TYPES.Any())
            {
                condition.And(T_AFC_PROJECT._.PROJECT_TYPE.In(model.TENDER_PROJECT_TYPES));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
            }
            if (!string.IsNullOrWhiteSpace(model.REGION_CODE))
            {
                if (model.REGION_CODE.Length < 6)
                {
                    condition.And(T_AFC_PROJECT._.REGION_CITY.BeginWith(model.REGION_CODE) || T_AFC_PROJECT._.REGION_COUNTY.BeginWith(model.REGION_CODE));
                    if (model.REGION_CODE == "35" || model.REGION_CODE == "3501")
                    {
                        condition.And(T_AFC_PROJECT._.REGION_CITY != "350128" && T_AFC_PROJECT._.REGION_COUNTY != "350128");//350128 平潭综合试验区 350100 福州市
                    }
                }
                else
                {
                    condition.And(T_AFC_PROJECT._.REGION_CITY == model.REGION_CODE || T_AFC_PROJECT._.REGION_COUNTY == model.REGION_CODE);
                }
            }
            var result = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "63" && T_AFC_PROJECT._.PROJECT_TYPE == SYS_DIC._.VALUE)
                .GroupBy(SYS_DIC._.TEXT)
                .Select(
                   SYS_DIC._.TEXT.As("Name"),
                   Field.All.Count().As("Value")
                ).ToList<Object>();
            return result;
        }
        /// <summary>
        /// 报建审查-项目归属地统计
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object ProjectGroupByRegion(TAfcProjectStatisticsModel model)
        {
            var xAxis = new List<string>();
            var data = new List<string>();
            var departRootAreaCode = JdUser?.UserDepartment?.RootAreaCode;//350100
            var condition1 = new WhereClipBuilder();
            var hyList = JdUser?.UserDepartment?.HY_TYPE_LIST;
            if (!string.IsNullOrWhiteSpace(departRootAreaCode) && hyList != null && hyList.Any())
            {
                var pcode = departRootAreaCode.PadRight(6, '0');//默认查询当前这个账号的归属地
                var region = new Field("(CASE WHEN REGION_COUNTY IS NULL THEN REGION_CITY ELSE REGION_COUNTY END)");
                var departId = JdUser?.DEPARTID;
                var condition = new WhereClipBuilder(T_AFC_PROJECT._.APPROVAL_DEPID == departId);
                condition.And(region.BeginWith(departRootAreaCode));//当前账号 归属地
                condition.And(T_AFC_PROJECT._.KIND.In(hyList));//当前账号 行业
                if (!string.IsNullOrEmpty(model.PROJECT_TYPE))
                {
                    var projectType = model.PROJECT_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    condition.And(T_AFC_PROJECT._.PROJECT_TYPE.In(projectType));// 01 02 03 TENDER_PROJECT(A01,A02) PT_ZXTS  RECORD_REVIEW 
                }
                if (!string.IsNullOrWhiteSpace(model.REGION_CODE))//有查询条件的时候
                {
                    pcode = model.REGION_CODE.PadRight(6, '0');//补6位
                }
                if (model.BeginTime != null)
                {
                    condition.And(T_AFC_PROJECT._.TM >= model.BeginTime);
                }
                if (model.EndTime != null)
                {
                    condition.And(T_AFC_PROJECT._.TM <= model.EndTime);
                }
                bool isCity = false; //判断当前查询的归属地是否省市
                var mod = Jd.SysAreaQuanguoService;
                var ppCode = mod.FromWhere(SYS_AREA_QUANGUO._.AREACODE == pcode).First().PCODE;
                if (ppCode == pcode)
                {
                    isCity = true;
                }
                else
                {
                    var temp = mod.FromWhere(SYS_AREA_QUANGUO._.AREACODE == ppCode).ToFirstDefault();
                    if (temp.PCODE == temp.AREACODE)
                    {
                        isCity = true;
                    }
                }

                if (isCity)//省市 归属地编码0结尾
                {
                    if (pcode == "350000" || pcode == "350100")
                    {
                        condition1.And(SYS_AREA_QUANGUO._.AREACODE.NotIn("350128", "350000"));//平潭综合试验区 350100 福建省
                    }
                    condition1.And(SYS_AREA_QUANGUO._.PCODE == pcode);
                }
                else //归属地是区县
                {
                    condition1.And(SYS_AREA_QUANGUO._.AREACODE == pcode);
                }
                var mo = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip()).ToList();
                //关联查询 查询有数据的
                var r = Jd.SysAreaQuanguoService.FromWhere(condition1.ToWhereClip())
                    .InnerJoin<T_AFC_PROJECT>(region == SYS_AREA_QUANGUO._.AREACODE && condition.ToWhereClip()).
                    GroupBy(SYS_AREA_QUANGUO._.AREANAME)
                    .Select(
                        SYS_AREA_QUANGUO._.AREANAME.As("Label")
                        , Field.All.Count().As("Value"))
                    .ToList<LabelValueModel>();
                var Labels = r.Select(c => c.Label).ToList();
                var rs = mo.Where(p => !Labels.Contains(p.AREANAME)).Select(p => new LabelValueModel
                {
                    Label = p.AREANAME,
                    Value = "0",
                });
                r.AddRange(rs);
                xAxis = r.Select(c => c.Label).ToList();
                data = r.Select(c => c.Value).ToList();
            }
            return new
            {
                xAxis,
                data
            };
        }
        #endregion

    }
}