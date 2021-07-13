using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.FuWu;
using GGZY.Services.Infrastructure.Enums.Jd;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using TzCodeService;

namespace GGZY.Services.JianDu
{
    public partial class TPunishService
    {
        #region  督查情况 - 行政处罚   处罚记录接口方法汇总

        #region 行政处罚  处罚记录列表查询接口
        public PageTableResult<TTPunishModel> CFSearchList(T_PUNISH model, SearchCondition search)
        {

            var condition = new WhereClipBuilder();

            //操作人过滤
            condition.And(T_PUNISH._.USE_OPERATOR == JdUser.ID);


            #region 查询条件

            //处罚编号
            if (!string.IsNullOrWhiteSpace(model.PUNISH_CODE))
            {
                condition.And(T_PUNISH._.PUNISH_CODE.Contain(model.PUNISH_CODE));
            }
            //处罚标题
            if (!string.IsNullOrWhiteSpace(model.PUNISH_TITLE))
            {
                condition.And(T_PUNISH._.PUNISH_TITLE.Contain(model.PUNISH_TITLE));
            }
            //处罚对象
            if (!string.IsNullOrWhiteSpace(model.PUNISH_ID))
            {
                condition.And(T_PUNISH._.PUNISH_ID == model.PUNISH_ID);
            }
            //处罚时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME <= search.EndTime);
            }

            #endregion
            //数据记录条数
            var total = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                .Count();

            //列表返回值
            var list = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_PUNISH._.PUNISH_ID)
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_PUNISH._.PUNISH_TIME)
                .Select(
                T_PUNISH._.ID,
                T_PUNISH._.PUNISH_CODE,
                T_PUNISH._.PUNISH_TITLE,
                T_USER_DEPARTMENT._.DNAME.As("PUNISH_DNAME"),
                T_USER_DEPARTMENT._.PHONE.As("PUNISH_PHONE"),
                T_PUNISH._.PUNISH_TIME,
                T_PUNISH._.TENDER_PROJECT_CODE,
                new Field($"'{JdUser?.MANAGE_NAME}'").As("USE_OPERATOR")
                )
                .ToList<TTPunishModel>();

            //返回列表值
            var pageList = list.ToPageTableTResult(search, total);
            return pageList;

        }
        /// <summary>
        /// 处罚记录
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> CFSearchExport(T_PUNISH model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = CFSearchList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/督查情况_处罚记录_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }
        #endregion

        #region   行政处罚——新增处罚记录接口

        public GeneralResult AddCFRecord(TPunishModel model)
        {
            var r = new GeneralResult();
            //实现存储主键自增
            model.ID = Guid.NewGuid().ToString();
            var tm = model.ID;
            model.USE_OPERATOR = JdUser.ID.ToString();
            model.PUNISH_TIME = DateTime.Now;
            

            if (string.IsNullOrWhiteSpace(model.PUNISH_ID))
            {
                r.SetFail("请选择处罚对象");
                return r;
            }
            if (string.IsNullOrWhiteSpace(model.PUNISH_TITLE))
            {
                r.SetFail("请选择处罚标题");//todo 修改提示
                return r;
            }
            if (string.IsNullOrWhiteSpace(model.PUNISH_CONTENT))
            {
                r.SetFail("请选择处罚内容");//todo 修改提示
                return r;
            }

            if (!string.IsNullOrWhiteSpace(model.PUNISH_ID) && !string.IsNullOrWhiteSpace(model.PUNISH_TITLE) &&
                !string.IsNullOrWhiteSpace(model.PUNISH_CONTENT))
            {
                var idxStr = "-1";
                var key = $"SUPERVISE:CODE";
                if (Cache.IsSet(key) == false)
                {
                    idxStr = Cache.Get<string>(key);
                }
                var idx = Convert.ToInt32(idxStr) + 1;
                var dep = Jd.TUserDepartmentService.FirstOrNull(T_USER_DEPARTMENT._.DEPID == model.PUNISH_ID);
                //用于生成处罚编号      
                var code = dep?.AREACODE;
                var time = string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
                var p = "E" + code + time + idx;//todo 修改 参照 督查编号
                model.PUNISH_CODE = p;
                //数据存储
                using (var trans = GetDbSession().BeginTransaction())
                {
                    if (model.FILES_ATTACHMENT != null && model.FILES_ATTACHMENT.Any())
                    {
                        //附件
                        var attachments = model.FILES_ATTACHMENT.Select(c => c.JdSysAttachment()).ToList();
                        trans.Insert(attachments);
                        model.PUNISH_FILE = string.Join(",", attachments.Select(c => c.GUID));
                    }

                    var entity = model.ConvertTo<T_PUNISH>();
                    #region 
                    //增加数据到抄送表                   
                    trans.Insert(entity);
                    model.ID = Guid.NewGuid().ToString();
                    model.CS_TIME = DateTime.Now;
                    model.CS_PUNISH_ID = tm;
                    model.CS_ID = dep?.PARENTID?.ToString();
                    model.CS_CONTENT = model.PUNISH_CONTENT;
                    var CS = model.ConvertTo<T_COPYSEND>();
                    trans.Insert(CS);
                    #endregion
                    trans.Commit();
                }
                r.SetSuccess("新建数据成功");
            }
            else
            {
                r.SetFail("参数缺失");
            }

            return r;

        }


        #endregion

        #region   行政处罚-新增处罚记录 —处罚对象查询接口    关联项目-弹窗
        public PageTableResult CFProject(TENDER_PROJECT model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();

            #region 查询条件

            //招标项目编号
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_CODE.Contain(model.TENDER_PROJECT_CODE));
            }
            //招标项目名称
            if (!string.IsNullOrWhiteSpace(model.TENDER_PROJECT_NAME))
            {
                condition.And(TENDER_PROJECT._.TENDER_PROJECT_NAME.Contain(model.TENDER_PROJECT_NAME));
            }
            #endregion
            //数据记录条数
            var total = Jd.TenderProjectService.FromWhere(condition.ToWhereClip())
                .Count();
            //列表返回值
            var list = Jd.TenderProjectService.FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == TENDER_PROJECT._.REGION_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(TENDER_PROJECT._.CREATE_TIME)
                .Select(
                TENDER_PROJECT._.TENDER_PROJECT_CODE,
                TENDER_PROJECT._.TENDER_PROJECT_NAME,
                SYS_AREA_QUANGUO._.AREANAME.As("REGION_CODE"),
                TENDER_PROJECT._.TENDERER_NAME,
                TENDER_PROJECT._.CREATE_TIME
                )
                .ToList<object>();

            //返回列表值
            var pageList = list.ToPageTableResult(search, total);
            return pageList;
        }
        #endregion

        #region   行政处罚-新增处罚记录 —处罚对象查询接口    处罚对象-选择弹窗
        public PageTableResult CFPeople(TTPunishModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();

            #region 查询条件
            //部门名称
            if (!string.IsNullOrWhiteSpace(model.DNAME))
            {
                condition.And(T_USER_DEPARTMENT._.DNAME.Contain(model.DNAME));
            }
            //行业类型
            if (!string.IsNullOrWhiteSpace(model.HY_TYPE))
            {
                condition.And(T_USER_DEPARTMENT._.HY_TYPE.Contain(model.HY_TYPE));
            }
            //地区
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(T_USER_DEPARTMENT._.AREACODE == model.AREACODE);
            }
            #endregion
            //数据记录条数
            var total = Jd.TUserDepartmentService.FromWhere(condition.ToWhereClip())
                .Count();
            //列表返回值
            var list = Jd.TUserDepartmentService.FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_USER_DEPARTMENT._.AREACODE)
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_USER_DEPARTMENT._.DEPID)
                .Select(
                  T_USER_DEPARTMENT._.DNAME,
                  T_USER_DEPARTMENT._.PHONE.As("PHONE"),
                  T_USER_DEPARTMENT._.DEPID.As("PUNISH_ID"),
                  T_USER_DEPARTMENT._.KINDS,
                  T_USER_DEPARTMENT._.AREACODE,
                  SYS_AREA_QUANGUO._.AREANAME,
                  T_USER_DEPARTMENT._.HY_TYPE,
                  T_USER_DEPARTMENT._.PARENTID
                )
                .ToList<TTPunishModel>();
            //KINS行业字段拆分
            var kinds = list.Select(c => c.HY_TYPE).ToList();//先查找list集合中的KINDS集合的值["A01,A02","A03,A04"]
            var kindStr = string.Join(",", kinds);//A01,A02,A03,A04
            var kindList = kindStr.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);//["A01","A02"]
            var dics = Jd.SysDicService.FromWhere(SYS_DIC._.VALUE.In(kindList) && SYS_DIC._.TYPE == "69").ToList();
            list.ForEach(ist =>
           {
               //TENDER_PROJECT_TYPE A01 A02 
               //list Kinds  sys_dic  value in kinds  .ist.foreach  kind dics A01-房建 A01,A02 
               if (ist.HY_TYPE != null)
               {
                   var k = ist.HY_TYPE.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                   var dic = dics.FindAll(c => k.Contains(c.VALUE));
                   var kTxt = string.Join(",", dic.Select(m => m.TEXT));
                   ist.KIND_TEXT = kTxt;
               }
           });
            //返回列表值
            var pageList = list.ToPageTableResult(search, total);
            return pageList;

        }
        #endregion

        #region 行政处罚  处罚记录列表详情接口 处罚信息接口
        public GeneralResult CFDetailed(TPunisnDataModel searchModel, SearchCondition search)
        {

            var r = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_PUNISH._.ID == searchModel.ID);


            var obj = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == T_PUNISH._.TENDER_PROJECT_CODE)
                .LeftJoin<T_USER_DEPARTMENT>(T_PUNISH._.PUNISH_ID == T_USER_DEPARTMENT._.DEPID)
                 .LeftJoin<T_USER>(T_USER._.ID == T_PUNISH._.USE_OPERATOR)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER._.DEPARTID == T_USER_DEPARTMENT._.DEPID)
                .Select
                (
                   T_PUNISH._.ID,
                   T_PUNISH._.PUNISH_CODE,
                   T_PUNISH._.PUNISH_TITLE,
                   T_PUNISH._.PUNISH_ID,
                   T_USER_DEPARTMENT._.DNAME.As("PUNISH_DNAME"),
                   T_USER_DEPARTMENT._.PHONE.As("PUNISH_PHONE"),
                   TENDER_PROJECT._.TENDER_PROJECT_CODE,
                   TENDER_PROJECT._.TENDER_PROJECT_NAME,
                   T_PUNISH._.PUNISH_TIME,
                   T_PUNISH._.PUNISH_FILE,
                   T_PUNISH._.PUNISH_CONTENT,
                   T_USER._.MANAGE_NAME.As("USE_OPERATOR"),
                   new Field("DNAME", "T_USER_DEPARTMENT2"),
                   new Field("PHONE", "T_USER_DEPARTMENT2").As("CF_PHONE")
                 )
                  .ToFirst<TPunisnDataModel>();
            if (obj != null)
            {//附件               
                obj.FILES_ATTACHMENT = Jd.CommonService.Attachments(obj.PUNISH_FILE, "Sys",true);
                //obj.USE_OPERATOR = JdUser?.MANAGE_NAME;
                //obj.DNAME = JdUser?.UserDepartment?.DNAME;
                //obj.CF_PHONE = JdUser?.TELPHONE ?? JdUser?.PHONE ?? "";
                r.SetSuccess(obj);
            }
            else
            {
                r.SetFail("未找到对应的信息");
            }

            return r;

        }

        #endregion

        #region 行政处罚  处罚记录列表详情接口 抄送信息接口
        public GeneralResult CFDetailedRecored(TCopySendModel searchModel, SearchCondition search)
        {
            var r = new GeneralResult();
            var condition = new WhereClipBuilder();

            if (!string.IsNullOrWhiteSpace(searchModel.ID.ToString()))
            {
                condition.And(T_COPYSEND._.CS_PUNISH_ID == searchModel.ID);
            }
            var list = Jd.TCopysendService.FromWhere(condition.ToWhereClip())
                 .LeftJoin<T_USER_DEPARTMENT>(T_COPYSEND._.CS_ID == T_USER_DEPARTMENT._.DEPID)
                 .OrderByDescending(T_COPYSEND._.CS_TIME)
                .Select
                (
                  T_COPYSEND._.ID,
                  T_COPYSEND._.CS_ID,
                  T_USER_DEPARTMENT._.DNAME.As("CS_NAME"),
                  T_COPYSEND._.CS_TIME,
                  T_COPYSEND._.CS_CONTENT
                 )
                .ToList<TCopySendModel>();

            if (list != null)
            {
                r.SetSuccess(list);
            }
            else
            {
                r.SetFail("未找到对应的信息");
            }

            return r;
            #endregion

            #endregion
        }


        #region 处罚信息 

        #region 处罚记录列表查询接口
        public PageTableResult<TTPunishRecordModel> CFSearchRecordList(TPunisnDataModel model, SearchCondition search)
        {

            var condition = new WhereClipBuilder(T_PUNISH._.PUNISH_ID == JdUser?.DEPARTID);//

            #region 查询条件
            //处罚来源
            if (!string.IsNullOrWhiteSpace(model.USE_OPERATOR))
            {
                condition.And(T_PUNISH._.USE_OPERATOR == model.USE_OPERATOR);
            }
            //处罚编号
            if (!string.IsNullOrWhiteSpace(model.PUNISH_CODE))
            {
                condition.And(T_PUNISH._.PUNISH_CODE.Contain(model.PUNISH_CODE));
            }
            //处罚标题
            if (!string.IsNullOrWhiteSpace(model.PUNISH_TITLE))
            {
                condition.And(T_PUNISH._.PUNISH_TITLE.Contain(model.PUNISH_TITLE));
            }
            //处罚时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_PUNISH._.PUNISH_TIME <= search.EndTime);
            }

            #endregion
            //数据记录条数
            var total = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                .Count();

            //列表返回值
            var list = Jd.TPunishService.FromWhere(condition.ToWhereClip())
                .LeftJoin<T_USER>(T_USER._.ID == T_PUNISH._.USE_OPERATOR)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_USER._.DEPARTID)
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_PUNISH._.PUNISH_TIME)
                .Select(
                T_PUNISH._.ID,
                T_PUNISH._.PUNISH_CODE,
                T_PUNISH._.PUNISH_TITLE,
                T_USER_DEPARTMENT._.DNAME.As("USE_OPERATOR"),
                T_USER_DEPARTMENT._.PHONE.As("PUNISH_PHONE"),
                T_PUNISH._.PUNISH_TIME
                )
                .ToList<TTPunishRecordModel>();

            //返回列表值
            var pageList = list.ToPageTableTResult(search, total);
            return pageList;

        }
        /// <summary>
        /// 处罚记录-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> CFSearchRecordExport(TPunisnDataModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = CFSearchRecordList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/督查服务_处罚记录_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }
        #endregion

        #region 下级被处罚抄送接口
        public PageTableResult<TCopySendModel> DownCFList(TCopySendModel model, SearchCondition search)
        {

            var condition = new WhereClipBuilder(T_COPYSEND._.CS_ID==JdUser?.DEPARTID);

            #region 查询条件
            //处罚对象
            if (!string.IsNullOrWhiteSpace(model.PUNISH_ID))
            {
                condition.And(T_PUNISH._.PUNISH_ID == model.PUNISH_ID);
            }
            //处罚编号
            if (!string.IsNullOrWhiteSpace(model.PUNISH_CODE))
            {
                condition.And(T_PUNISH._.PUNISH_CODE.Contain(model.PUNISH_CODE));
            }
            //处罚标题
            if (!string.IsNullOrWhiteSpace(model.PUNISH_TITLE))
            {
                condition.And(T_PUNISH._.PUNISH_TITLE.Contain(model.PUNISH_TITLE));
            }
            //处罚时间
            if (search.BeginTime.HasValue)
            {
                condition.And(T_COPYSEND._.CS_TIME >= search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(T_COPYSEND._.CS_TIME <= search.EndTime);
            }

            #endregion
            //数据记录条数
            var total = Jd.TCopysendService.FromWhere(condition.ToWhereClip())
                .LeftJoin<T_PUNISH>(T_PUNISH._.ID == T_COPYSEND._.CS_PUNISH_ID)
                .Count();

            //列表返回值
            var list = Jd.TCopysendService.FromWhere(condition.ToWhereClip())
                .LeftJoin<T_PUNISH>(T_PUNISH._.ID == T_COPYSEND._.CS_PUNISH_ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_PUNISH._.PUNISH_ID)
                .LeftJoin<T_USER>(T_USER._.ID == T_PUNISH._.USE_OPERATOR)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == T_USER._.DEPARTID)
                .Page(search.PageSize, search.PageNo)
                .OrderByDescending(T_COPYSEND._.CS_TIME)
                .Select(
                T_COPYSEND._.ID,
                T_COPYSEND._.CS_PUNISH_ID.As("M_ID"),
                T_PUNISH._.PUNISH_CODE,
                T_PUNISH._.PUNISH_TITLE,
                T_USER_DEPARTMENT._.DNAME.As("PUNISH_DNAME"),
                new Field($"DNAME", "T_USER_DEPARTMENT2").As("USE_OPERATOR"),
                T_COPYSEND._.CS_TIME
                )
                .ToList<TCopySendModel>();

            //返回列表值
            var pageList = list.ToPageTableTResult(search, total);
            return pageList;

        }

        /// <summary>
        /// 下级被处罚抄送-导出
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult<UploadResData> DownCFExport(TCopySendModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = DownCFList(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/督查服务_下级被处罚抄送_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
                };
                NpoiUtils.GenerateExcelPath(d.TData, HttpContext.Current?.Server.MapPath($"~{data.FullUrl}"));
                r.SetSuccess(data);
            }
            else
            {
                r.SetFail("导出数据为空");
            }


            return r;
        }
        #endregion

        #region 处罚来源
        public PageTableResult CFSource(TTPunishModel model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();

            #region 查询条件
            //部门名称
            if (!string.IsNullOrWhiteSpace(model.DNAME))
            {
                condition.And(T_USER_DEPARTMENT._.DNAME.Contain(model.DNAME));
            }
            //部门地区
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(T_USER_DEPARTMENT._.AREACODE.Contain(model.AREACODE));
            }
            //condition.And(T_USER_DEPARTMENT._.DNAME.Contain("纪委"));
            condition.And(T_USER_DEPARTMENT._.DTYPE == ((int)JdTUserDepartmentDType.JiWeiJianWei).ToString());
            #endregion
            //数据记录条数
            var total = Jd.TUserDepartmentService.FromWhere(condition.ToWhereClip())
                .Count();
            //列表返回值
            var list = Jd.TUserDepartmentService.FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_USER_DEPARTMENT._.AREACODE)
                .Page(search.PageSize, search.PageNo)
                .OrderBy(T_USER_DEPARTMENT._.DEPID)
                .Select(
                T_USER_DEPARTMENT._.DEPID.As("ID"),
                T_USER_DEPARTMENT._.DNAME,
                SYS_AREA_QUANGUO._.AREANAME.As("AREANAME"),
                T_USER_DEPARTMENT._.PHONE
                )
                .ToList<TTPunishModel>();
            //todo 这里把行业给信息拼接上去
            //返回列表值
            var pageList = list.ToPageTableResult(search, total);
            return pageList;

        }

        #endregion

        #endregion

    }
}