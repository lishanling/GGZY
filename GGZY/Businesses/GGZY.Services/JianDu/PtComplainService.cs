using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtComplainService
    {
        #region 监督平台门户

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageDataTable(PT_COMPLAIN model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            condition.And(PT_COMPLAIN._.TM < DateTime.Today.AddDays(1));
            condition.And(PT_COMPLAIN._.IS_PUBLIC.IsNull() || PT_COMPLAIN._.IS_PUBLIC == 1);
            var count = Count(condition);
            var pageList = PageList(condition, search, PT_COMPLAIN._.TM.Desc)
                .ToPageTableResult(search, count, c => new
                {
                    ID=c.ID.DesEncrypt(),
                    c.TITLE,
                    c.TM,
                    c.TYPE,
                    c.SOURCES
                });

            //FromWhere(condition.ToWhereClip())
            //    .LeftJoin<T_USER>(T_USER._.ID==PT_COMPLAIN._.USER_ID)
            //    .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID==T_USER._.DEPARTID)
            //    .Select(PT_COMPLAIN._.ID, PT_COMPLAIN._.TITLE, PT_COMPLAIN._.TM, PT_COMPLAIN._.TYPE, T_USER_DEPARTMENT._.DNAME.As())
              
            return pageList;
        }

        #endregion

        #region 监督平台后台
        /// <summary>
        /// 投诉信息发布列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PageList(PtComplainModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);
            if (JdUser.ID != 1)
            {
                condition.And(PT_COMPLAIN._.USER_ID == JdUser.ID);
            }
            var query = FromWhere(condition.ToWhereClip())
                .LeftJoin<T_USER>(T_USER._.ID == PT_COMPLAIN._.USER_ID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "301" && PT_COMPLAIN._.TYPE == SYS_DIC._.VALUE)
                .LeftJoin<PT_ZXTS>(PT_ZXTS._.ID == PT_COMPLAIN._.TS_ID);
            var count = query.Count();
            var page = query.Page(search.PageSize, search.PageNo).OrderBy(PT_COMPLAIN._.CREATE_TM.Desc)
                .Select(PT_COMPLAIN._.All, SYS_DIC._.TEXT.As("TYPE_TEXT"), T_USER._.MANAGE_NAME, PT_ZXTS._.CODE,
                    PT_ZXTS._.TYPE.As("PT_ZXTS_TYPE"))
                .ToList<PtComplainModel>()
                .ToPageTableResult(search, count);
            return page;
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public PtComplainModel Detail(decimal? ID, Func<string, string, string> urlBuilder = null)
        {
            var condition = new WhereClipBuilder();
            condition.And(PT_COMPLAIN._.ID == ID);

            var dbModel = FromWhere(condition.ToWhereClip())
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "301" && PT_COMPLAIN._.TYPE == SYS_DIC._.VALUE)
                .Select(PT_COMPLAIN._.All, SYS_DIC._.TEXT.As("TYPE_TEXT"))
                .First<PtComplainModel>();
            if (dbModel != null)
            {
                if (urlBuilder != null)
                {
                    dbModel.AIDS_ATTACHMENTS = Jd.CommonService.Attachments(dbModel.AIDS, "Sys", true);
                }

            }

            return dbModel;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Edit(PtComplainModel model)
        {
            var result = new GeneralResult();
            try
            {
                var viewResult = ViewByPk(model.ID);

                if (viewResult.Success && viewResult.Data is PT_COMPLAIN entity)
                {
                    using (var trans = GetDbSession().BeginTransaction())
                    {
                        entity.Attach();
                        //entity.ID = model.ID;
                        entity.TITLE = model.TITLE;
                        entity.TYPE = model.TYPE;
                        entity.SOURCES = model.SOURCES;
                        entity.TM = model.TM;
                        entity.USER_ID = JdUser.ID;
                        entity.CONTENTS = model.CONTENTS;
                        //entity.AIDS = model.AIDS;
                        entity.CREATE_TM = model.CREATE_TM;
                        //entity.TS_ID = model.TS_ID;
                        entity.IS_PUBLIC = model.IS_PUBLIC;
                        if (model.AIDS_ATTACHMENTS != null && model.AIDS_ATTACHMENTS.Any())
                        {
                            var modelAids = model.AIDS_ATTACHMENTS.Select(c => c.Id).ToList();
                            var attIds = entity.AIDS?.Split(',').ToList() ?? new List<string>();
                            var aids = attIds.Intersect(modelAids).ToList();
                            var except = model.AIDS_ATTACHMENTS.Where(c => !attIds.Contains(c.Id))
                                .Select(c => c.JdSysAttachment(JdUser.ID)).ToList();
                            trans.Insert(except);
                            aids.AddRange(except.Select(c => c.GUID));
                            entity.AIDS = string.Join(",", aids);
                        }
                        else
                        {
                            entity.AIDS = String.Empty;
                        }

                        trans.Update(entity);
                        trans.Commit();
                        result.SetSuccess(entity);
                    }

                }
                else
                {
                    result.SetFail(viewResult.Msg);
                }
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(PtComplainModel model)
        {
            var result = new GeneralResult();
            try
            {
                using (var trans = GetDbSession().BeginTransaction())
                {
                    var entity = model.ConvertTo<PT_COMPLAIN>();
                    entity.ID = 0;
                    entity.USER_ID = JdUser.ID;
                    entity.CREATE_TM = DateTime.Now;
                    if (model.AIDS_ATTACHMENTS != null && model.AIDS_ATTACHMENTS.Any())
                    {
                        var jdSysAttachments = model.AIDS_ATTACHMENTS.Select(c => c.JdSysAttachment(JdUser?.ID)).ToList();
                        trans.Insert(jdSysAttachments);
                        entity.AIDS = string.Join(",", jdSysAttachments.Select(c => c.GUID));
                    }
                    trans.Insert(entity);
                    trans.Commit();
                    result.SetSuccess(entity);
                }

            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GeneralResult DeleteComplaint(decimal id)
        {
            GeneralResult result = new GeneralResult();
            try
            {
                result = ViewByPk(id);

                if (result.Success && result.Data is PT_COMPLAIN entity)
                {
                    if (entity.TS_ID.HasValue)
                    {
                        result.SetFail("发布类型并非为人工发布，该记录不予许删除！");
                    }
                    else if (entity.USER_ID != JdUser.ID)
                    {
                        result.SetFail("您没有删除当前记录的权限");
                    }
                    else
                    {
                        Delete(entity);
                        result.SetSuccess();
                    }
                }
                else
                {
                    result.SetFail("未找到删除的对象");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                result.SetFail(e.Message, e);
            }
            return result;
        }
        #endregion

    }
}

