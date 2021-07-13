using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvTjAllresultXzjdService
    {
        public PageTableResult PageDataTable(MV_TJ_ALLRESULT_XZJD model, SearchCondition search)
        {
            var condition =ConditionBuilder(model);
            condition.And(MV_TJ_ALLRESULT_XZJD._.KIND=="GCJS");//MV_TJ_ALLRESULT_XZJD._.KIND.IsNotNull()&& 
            if (!string.IsNullOrWhiteSpace(search.KeyWord))
            {
                condition.And(MV_TJ_ALLRESULT_XZJD._.PROJECT_NAME.Contain(search.KeyWord) ||
                              MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE.Contain(search.KeyWord));
            }

            if (search.BeginTime.HasValue)
            {
                condition.And(MV_TJ_ALLRESULT_XZJD._.M_TM >= search.BeginTime);
            }

            if (search.EndTime.HasValue)
            {
                condition.And(MV_TJ_ALLRESULT_XZJD._.M_TM <= search.EndTime);
            }

            var query = FromWhere(condition.ToWhereClip())
                .GroupBy(MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE, MV_TJ_ALLRESULT_XZJD._.PROJECT_NAME);
            var count = FromWhere(condition.ToWhereClip())
                .GroupBy(MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE, MV_TJ_ALLRESULT_XZJD._.PROJECT_NAME).Select(MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE, MV_TJ_ALLRESULT_XZJD._.PROJECT_NAME).Count();
            var list = query.Page(search.PageSize,search.PageNo).Select(
                MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE, MV_TJ_ALLRESULT_XZJD._.PROJECT_NAME,
                MV_TJ_ALLRESULT_XZJD._.AMOUNT.Sum(), MV_TJ_ALLRESULT_XZJD._.M_TM.Max()
            ).OrderBy(new Field("M_TM").Desc).ToList<object>();
            var pageList = list.ToPageTableResult(search, count);
            //var count = Count(condition);
            //var fields = model.GetFields().ToList();
            //fields.RemoveAll(c => c.Name == "KIND");
            //fields.Add(SYS_DIC._.TEXT.As("PROJECT_CATEGORY_TEXT"));
            //fields.Add(SYS_DIC._.VALUE1.As("KIND"));
            //fields.Add(new Field("TEXT", "SYS_DIC2").As("PROJECT_TYPE_NAME"));
            //fields.Add(TENDER_PROJECT._.TENDERER_NAME);
            //fields.Add(TENDER_PROJECT._.TENDER_AGENCY_NAME);
            //fields.Add(TENDER_PROJECT._.TENDER_AGENCY_CODE);
            //fields.Add(TENDER_PROJECT._.OWNER_NAME);
            ////var pageList = PageList(condition, search, MV_TJ_ALLRESULT_XZJD._.CREATE_TIME.Desc).ToDataTable(search);
            //var list = FromWhere(condition.ToWhereClip())
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" &&
            //                       MV_TJ_ALLRESULT_XZJD._.KIND.ToChar() ==
            //                       SYS_DIC._.VALUE) //"to_char(PROJECT_CATEGORY)=SYS_DIC.VALUE"
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "10" && SYS_DIC._.VALUE == MV_TJ_ALLRESULT_XZJD._.PROJECT_TYPE)
            //    .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE == MV_TJ_ALLRESULT_XZJD._.PROJECT_CODE)
            //    .Page(search.PageSize, search.PageNo)
            //    .OrderBy(MV_TJ_ALLRESULT_XZJD._.M_TM.Desc)
            //    .Select(fields.ToArray())
            //    .ToList<MvTjAllresultXzjdModel>();
            //var areaCodes = list.Select(c => c.AREACODE).Distinct().ToList();
            //var pRegions = Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.AREACODE.In(areaCodes)).ToList();
            //var pcodes = pRegions.Select(c => c.PCODE).ToList();
            //var parentRegions = Fw.SysAreaQuanguoService.FindList(SYS_AREA_QUANGUO._.AREACODE.In(pcodes));
            //var pageList = list.ToDataTableResult(search, count, c =>
            //{
            //    var pRegion = pRegions.FirstOrDefault(o => o.AREACODE == c.AREACODE);
            //    var p = parentRegions.FirstOrDefault(r => r.AREACODE == pRegion?.PCODE);

            //    c.P_AREACODE = p?.AREACODE ?? "";
            //    c.P_AREANAME = string.IsNullOrWhiteSpace(p?.AREANAME) || p.AREANAME == "福建省" ? "" : p.AREANAME;
            //    return c;
            //});
            return pageList;
        }
    }
}