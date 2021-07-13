using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserDepartmentService
    {
        /// <summary>
        /// 返回监管部门的简单列表信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult SelectList(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var condition = PageTableConditionBuilder(model, search);
            var count = Count(condition);
            var pageList = PageList(condition, search, T_USER_DEPARTMENT._.AREACODE.Asc).ToPageTableResult(search, count, c =>
                new
                {
                    c.DEPID,
                    c.DNAME,
                    DCODE = c.DCODE?.Trim(),
                    c.PHONE,
                    c.JGBM,
                    c.AREACODE
                });
            return pageList;
        }
        public int Count(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var condition = PageTableConditionBuilder(model, search);
            return Count(condition);
        }
        protected WhereClipBuilder PageTableConditionBuilder(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (model.ISBA.HasValue)
            {
                condition.And(T_USER_DEPARTMENT._.ISBA == model.ISBA);
            }
            if (model.ISBJ.HasValue)
            {
                condition.And(T_USER_DEPARTMENT._.ISBJ == model.ISBJ);
            }
            if (!string.IsNullOrWhiteSpace(model.JGBM))
            {
                condition.And(T_USER_DEPARTMENT._.JGBM == model.JGBM);
            }
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(T_USER_DEPARTMENT._.DNAME.Contain(search.KeyWord));
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(model.AREACODE))
                {
                    condition.And(T_USER_DEPARTMENT._.AREACODE == model.AREACODE);
                }
            }

            return condition;
        }

        #region 项目报建
        /// <summary>
        /// 审批单位
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult FindSpDepartment(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var condition = new WhereClipBuilder();
            if (model.ISBJ.HasValue)
            {
                condition.And(T_USER_DEPARTMENT._.ISBJ == model.ISBJ);
            }
            if (model.ISBA.HasValue)
            {
                condition.And(T_USER_DEPARTMENT._.ISBA == model.ISBA);
            }
            if (model.ISTS.HasValue)
            {
                condition.And(T_USER_DEPARTMENT._.ISTS == model.ISTS);
            }
           
            if (!string.IsNullOrWhiteSpace(model.DNAME))
            {
                condition.And(T_USER_DEPARTMENT._.DNAME.Contain(model.DNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.AREACODE))
            {
                condition.And(T_USER_DEPARTMENT._.AREACODE.Contain(model.AREACODE));
            }

            if (!string.IsNullOrWhiteSpace(model.JGBM))
            {
                condition.And(T_USER_DEPARTMENT._.JGBM.FieldSplitContain(model.JGBM));
            }

            if (!string.IsNullOrWhiteSpace(model.HY_TYPE))
            {
                condition.And(T_USER_DEPARTMENT._.HY_TYPE.FieldSplitContain(model.HY_TYPE));
            }
            var query = FromWhere(condition.ToWhereClip());
            var count = query.Count();
            var pageTable = PageList(condition, search).ToPageTableResult(search, count);
            return pageTable;

        }

        #endregion

        #region 信息维护-用户管理-组织机构

        public PageTableResult PageTableList(T_USER_DEPARTMENT model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition);
            if (count > 0)
            {
                var list = FromWhere(condition.ToWhereClip())
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == T_USER_DEPARTMENT._.AREACODE)
                    .Page(search.PageSize, search.PageNo)
                    .OrderBy(T_USER_DEPARTMENT._.ORDERID.Desc)
                    .Select(
                        SYS_AREA_QUANGUO._.AREANAME.As("AREACODE_TEXT"),
                        T_USER_DEPARTMENT._.All
                        )
                    .ToList<TUserDepartment>();
                list.ForEach(c =>
                {
                    c.REGIONS = model.GetAttribute<string>(c.DEPID?.ToString(), "REGIONS");
                    c.PARENTIDS = model.GetAttribute<string>(c.DEPID?.ToString(), "PARENTIDS");
                    c.OTHERDEPIDS = model.GetAttribute<string>(c.DEPID?.ToString(), "OTHERDEPIDS");
                });
                return list.ToPageTableResult(search, count);
            }

            return search.ToPageTableResult();
        }

        public GeneralResult ReadJdUserDepartment(decimal DEPID)
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(T_USER_DEPARTMENT._.DEPID == DEPID);

            var dbEntity = FromWhere(condition.ToWhereClip()).First();
            if (dbEntity == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                var dbModel = dbEntity.ConvertTo<TUserDepartment>();
                dbModel.REGIONS = dbEntity.GetAttribute<string>(dbModel.DEPID?.ToString(), "REGIONS");
                dbModel.PARENTIDS = dbEntity.GetAttribute<string>(dbModel.DEPID?.ToString(), "PARENTIDS");
                dbModel.OTHERDEPIDS = dbEntity.GetAttribute<string>(dbModel.DEPID?.ToString(), "OTHERDEPIDS");
                result.SetSuccess(dbModel);
            }
            return result;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult CreateJdUserDepartment(TUserDepartment model)
        {
            var result = new GeneralResult();
            try
            {
                model.OTHERIDS = string.IsNullOrWhiteSpace(model.OTHERIDS) ? model.OTHERDEPIDS?.Replace(";", ",") : model.OTHERIDS;
                var entity = model.ConvertTo<T_USER_DEPARTMENT>();
                if (!entity.PARENTID.HasValue)
                {
                    entity.PARENTID = -1;
                }
                var entityId = Insert(entity);
                Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "REGIONS", model.REGIONS, entityId.ToString(), $"监督平台组织机构归属地");
                Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "PARENTIDS", model.PARENTIDS, entityId.ToString(), $"监督平台组织机构父级机构");
                Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "OTHERDEPIDS", model.OTHERDEPIDS, entityId.ToString(), $"监督平台组织机构可查看其他机构");
                result.SetSuccess(model);
            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }

        public GeneralResult UpdateJdUserDepartment(TUserDepartment model)
        {
            var result = new GeneralResult();
            try
            {
                var entity = FirstOrNull(T_USER_DEPARTMENT._.DEPID == model.DEPID);
                if (entity != null)
                {
                    entity.DEPID = model.DEPID;
                    entity.DNAME = model.DNAME;
                    entity.AREACODE = model.AREACODE;
                    entity.PARENTID = model.PARENTID??-1;
                    entity.DREMARK = model.DREMARK;
                    entity.LONGI = model.LONGI;
                    entity.LATI = model.LATI;
                    entity.DTYPE = model.DTYPE;
                    entity.ORGPROPERTY = model.ORGPROPERTY;
                    entity.ORDERID = model.ORDERID;
                    entity.DEPCODE = model.DEPCODE;
                    entity.ISCK = model.ISCK;
                    entity.CKID = model.CKID;
                    entity.KINDS = model.KINDS;
                    entity.ISALLKIND = model.ISALLKIND;
                    entity.OTHERIDS = string.IsNullOrWhiteSpace(model.OTHERIDS) ? model.OTHERDEPIDS?.Replace(";", ",") : model.OTHERIDS;
                    entity.DCODE = model.DCODE;
                    entity.ISBJ = model.ISBJ;
                    entity.ISBA = model.ISBA;
                    entity.PHONE = model.PHONE;
                    entity.JGBM = model.JGBM;
                    entity.DADDRESS = model.DADDRESS;
                    entity.ISTS = model.ISTS;
                    entity.HY_TYPE = model.HY_TYPE;
                    Update(entity);
                    Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "REGIONS", model.REGIONS, model.DEPID?.ToString(), $"监督平台组织机构归属地");
                    Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "PARENTIDS", model.PARENTIDS, model.DEPID?.ToString(), $"监督平台组织机构监督平台组织机构父级机构");
                    Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "OTHERDEPIDS", model.OTHERDEPIDS, model.DEPID?.ToString(), $"监督平台组织机构可查看其他机构");
                    result.SetSuccess(model);
                }
                else
                {
                    result.SetFail(OBJECT_NOT_EXIST);
                }


            }
            catch (Exception e)
            {
                result.SetFail(e.Message, e);
            }
            return result;
        }
        /// <summary>
        /// 监督平台组织机构树
        /// </summary>
        /// <returns></returns>
        public List<SelectModel> DepartmentTree(decimal? pid = -1)
        {
            var r = new List<SelectModel>();
            var allDepartment = FindAll().OrderBy(c => c.ORDERID).ToList();
            var parents = allDepartment.Where(c => c.PARENTID == pid).ToList();
            foreach (var userDepartment in parents)
            {
                var nameSb = new StringBuilder(userDepartment.DNAME);
                if (userDepartment.ISBJ.HasValue && userDepartment.ISBJ.Value == 1)
                {
                    nameSb.Append($"[报建]");
                }
                if (userDepartment.ISBA.HasValue && userDepartment.ISBA.Value == 1)
                {
                    nameSb.Append($"[备案]");
                }

                if (userDepartment.ISTS.HasValue && userDepartment.ISTS.Value == 1)
                {
                    nameSb.Append($"[投诉]");
                }
                var m = new SelectModel(userDepartment.DEPID?.ToString(), nameSb.ToString());
                ChildrenDepartment(m, allDepartment);
                r.Add(m);
            }

            return r;
        }

        protected void ChildrenDepartment(SelectModel model, List<T_USER_DEPARTMENT> all)
        {
            var children = all.FindAll(c => string.Compare(c.PARENTID?.ToString(), model.Value, StringComparison.CurrentCultureIgnoreCase) == 0);
            if (children.Any())
            {
                foreach (var child in children)
                {
                    var childDepId = child.DEPID?.ToString();
                    var nameSb = new StringBuilder(child.DNAME);
                    if (child.ISBJ.HasValue && child.ISBJ.Value == 1)
                    {
                        nameSb.Append($" [报建]");
                    }
                    if (child.ISBA.HasValue && child.ISBA.Value == 1)
                    {
                        nameSb.Append($" [备案]");
                    }

                    if (child.ISTS.HasValue && child.ISTS.Value == 1)
                    {
                        nameSb.Append($" [投诉]");
                    }
                    var m = new SelectModel(childDepId, nameSb.ToString());
                    ChildrenDepartment(m, all);
                    model.Children.Add(m);
                }
            }
            else
            {
                model.Children = null;
            }
        }

        #endregion

        #region 获取组织机构信息

        public TUserDepartment FindDepartmentByDepid(decimal? depId)
        {
            TUserDepartment department = FromWhere(T_USER_DEPARTMENT._.DEPID == depId)
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == nameof(T_USER_DEPARTMENT)
                                                  && T_GENERAL_ATTRIBUTE_V2._.KEY == "PARENTIDS"
                                                  && T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER_DEPARTMENT._.DEPID)
                .Select(
                    T_GENERAL_ATTRIBUTE_V2._.VALUE.As("PARENTIDS"),
                    T_USER_DEPARTMENT._.All)
                .ToFirst<TUserDepartment>();
            //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "76" && T_USER_DEPARTMENT._.HY_TYPE.FieldSplitContain(SYS_DIC._.VALUE))
            //.Select(T_USER_DEPARTMENT._.All, SYS_DIC._.TEXT.As("HY_TYPE_TEXT")).ToList<TUserDepartment>();
            if (department != null)
            {
                var kinds = Jd.SysDicService.FindDicByType("76");//1-7
                var hyTypes = kinds.FindAll(c => department.HY_TYPE_LIST.Exists(h => h == c.VALUE));
                var hyTypeTexts = hyTypes.Select(c => c.TEXT).ToList();
                department.HY_TYPE_TEXT = string.Join(",", hyTypeTexts);
                var projectTypes = Jd.SysDicService.FindDicByType("63");//A01,A02
                var hyProjectTypes = projectTypes.FindAll(c => hyTypes.Any(h => h.VALUE == c.VALUE2)).ToList();
                department.SYS_DIC_63 = hyProjectTypes;
                //.Select(c => new LabelValueModel
                //{
                //    Id = c.ID?.ToString(),
                //    Label = c.TEXT,
                //    Value = c.VALUE
                //}).ToList();
            }
            return department;
        }

        #endregion

        /// <summary>
        /// 查资行业主管和下级纪委监委 组织机构
        /// </summary>
        /// <param name="model">行业主管部门id</param>
        /// <param name="search">行业主管部门id</param>
        /// <returns></returns>
        public PageTableResult FindJwChildrenDepId(T_USER_DEPARTMENT model, SearchCondition search)
        {

            var hyDepid = model.DEPID;
            model.DEPID = null;
            var departIds = JdUser?.DEPARTIDS;
            var con = ConditionBuilder(model);
            con.And(T_USER_DEPARTMENT._.DTYPE == ConfigHelper.AppSettings.JD_DEP_JIWEI_TYPE && T_GENERAL_ATTRIBUTE_V2._.VALUE.BeginWith(departIds) && T_USER_DEPARTMENT._.DEPID != JdUser?.DEPARTID);
            //var hy = FromWhere(T_USER_DEPARTMENT._.DEPID == hyDepid).ToFirst<TUserDepartment>();
            //if (hy != null)
            //{
            //    var areacode = hy.AREACODE.TrimEnd('0').PadRight(6, '0');
            //    var city = areacode.Substring(0, 4).PadRight(6, '0');
            //    var province = areacode.Substring(0, 2).PadRight(6, '0');
            //    con.And(T_USER_DEPARTMENT._.AREACODE == (city) || T_USER_DEPARTMENT._.AREACODE == (province)|| T_USER_DEPARTMENT._.AREACODE== hy.AREACODE);

            //    if (hy.HY_TYPE_LIST.Any())
            //    {
            //        var hyCon=new WhereClipBuilder();
            //        foreach (var type in hy.HY_TYPE_LIST)
            //        {
            //            hyCon.Or(T_USER_DEPARTMENT._.HY_TYPE.Contain(type));
            //        }
            //        con.And(hyCon.ToWhereClip());
            //    }
            //}

            con.Or(T_USER_DEPARTMENT._.DEPID == hyDepid);
            var query = FromWhere(con.ToWhereClip())
                .LeftJoin<T_GENERAL_ATTRIBUTE_V2>(T_GENERAL_ATTRIBUTE_V2._.ENTITYNAME == nameof(T_USER_DEPARTMENT)
                                                  && T_GENERAL_ATTRIBUTE_V2._.KEY == "PARENTIDS"
                                                  && T_GENERAL_ATTRIBUTE_V2._.ENTITYID == T_USER_DEPARTMENT._.DEPID
                                                 );
            var count = query.Count();
            if (count > 0)
            {
                var orderByClip = T_USER_DEPARTMENT._.DEPID.Asc;
                var jwIds = departIds?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
                if (decimal.TryParse(jwIds, out decimal jwdepId))
                {
                    if (jwdepId < hyDepid)
                    {
                        orderByClip = T_USER_DEPARTMENT._.DEPID.Desc;
                    }
                }
                var list = query
                    .OrderBy(orderByClip)
                    .Page(search.PageSize, search.PageNo)
                    .Select(T_USER_DEPARTMENT._.All)
                    .ToList();
                var plist = list.ToPageTableResult(search, count);
                return plist;
            }

            return search.ToPageTableResult();

        }
    }
}