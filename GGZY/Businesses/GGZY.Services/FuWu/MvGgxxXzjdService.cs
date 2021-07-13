using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class MvGgxxXzjdService
    {
        #region 监督服务-公告公示(旧:交易监督-公告公示)

        public PageTableResult<MvGgxxXzjdModel> GetGGGSList_GGFW(MvGgxxXzjdModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);

            var query = FromWhere();
            if (search.BeginTime.HasValue && (DateTime.Now - search.BeginTime.Value).TotalDays > 91)
            {
                //项目公告公示数据源90天外（公共服务平台）
                query = FromWhere().UnionAll(FromWhere<MV_GGXX_HISTORY_XZJD>());
            }
            //query.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" && SYS_DIC._.VALUE == MvGgxxXzjdModel._.PROJECT_CATEGORY);
            query = query.Where(condition.ToWhereClip()).LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" && "(CASE PROJECT_CATEGORY WHEN 5 THEN 4 ELSE PROJECT_CATEGORY END)= SYS_DIC.VALUE");
            var total = query.Count();
            var list = query.OrderBy(MvGgxxXzjdModel._.TM.Desc)
                .Select(
                    MvGgxxXzjdModel._.M_ID,
                    MvGgxxXzjdModel._.TITLE,
                    MvGgxxXzjdModel._.GGTYPE,
                    MvGgxxXzjdModel._.PROJECT_CODE,
                    MvGgxxXzjdModel._.PROJECT_NAME,
                    MvGgxxXzjdModel._.NAME,
                    MvGgxxXzjdModel._.AREANAME,
                    MvGgxxXzjdModel._.PLATFORM_NAME,
                    MvGgxxXzjdModel._.PROJECT_CATEGORY,
                    SYS_DIC._.TEXT.As("PROJECT_CATEGORY_TEXT"),
                    MvGgxxXzjdModel._.PROJECT_TYPE,
                    MvGgxxXzjdModel._.PROTYPE_TEXT,
                    MvGgxxXzjdModel._.KIND,
                    MvGgxxXzjdModel._.TM
                )
                .Page(search.PageSize, search.PageNo)
                .ToList<MvGgxxXzjdModel>();
            var fwTenderProjectCodes = list.Select(c => c.PROJECT_CODE).ToArray();
            var jdTenderProject = Jd.TenderProjectService.GetJdTenderProjectsFwTpCodes(fwTenderProjectCodes);

            var pageList = list.ToPageTableTResult(search, total, c =>
            {
                c.JD_TENDER_PROJECT_CODE = jdTenderProject
                    .FirstOrDefault(o => o.TENDER_PROJECT_CODE_OLD1 == c.PROJECT_CODE)?.TENDER_PROJECT_CODE;
                return c;
            });
            return pageList;
        }
        public GeneralResult<UploadResData> GetGGGSList_GGFWExport(MvGgxxXzjdModel model, SearchCondition search)
        {
            search.PageSize = int.MaxValue;
            var r = new GeneralResult<UploadResData>();
            var d = GetGGGSList_GGFW(model, search);
            if (d.Total > 0)
            {
                var data = new UploadResData
                {
                    FullUrl = $"/Temp/Export/{DateTime.Today:yyyyMMdd}/行政监督信息_公告公示_{DateTime.Now:HHmmssfff}_{Guid.NewGuid():N}.xls"
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

        public List<LabelValueModel> GetGGGSList_GGFW_Stat(MvGgxxXzjdModel model, SearchCondition search)
        {
            var condition = model.ConditionBuilder(search);
            var query = FromWhere();
            if (search.BeginTime.HasValue && (DateTime.Now - search.BeginTime.Value).TotalDays > 91)
            {
                //项目公告公示数据源90天外（公共服务平台）
                query = FromWhere().UnionAll(FromWhere<MV_GGXX_HISTORY_XZJD>());
            }
            //query.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" && SYS_DIC._.VALUE == MvGgxxXzjdModel._.PROJECT_CATEGORY);
            query = query.Where(condition.ToWhereClip());
            var list = query
                .Select(
                    MvGgxxXzjdModel._.GGTYPE.As("Label"),
                    MvGgxxXzjdModel._.GGTYPE.Count().As("Value")
                ).GroupBy(MvGgxxXzjdModel._.GGTYPE)
                .ToList<LabelValueModel>();
            var ggTypes = Fw.SysDicService
                .FromWhere(SYS_DIC._.TYPE == "2020120820" && SYS_DIC._.PID.SubQueryEqual(Fw.SysDicService
                               .FromWhere(SYS_DIC._.TYPE == "20201208" && SYS_DIC._.VALUE == model.PROJECT_CATEGORY?.ToString())
                               .Select(SYS_DIC._.ID))).OrderBy(SYS_DIC._.ORDER_ID).ToList();
            var stat = ggTypes.Select(c => new LabelValueModel
            {
                Id = c.ID?.ToString(),
                Label = c.TEXT,
                Value = list.FirstOrDefault(v=>v.Label==c.VALUE)?.Value??"0"
            }).ToList();
          
            return stat;
        }
        public GeneralResult GetGGGSList_GGFW_Chart(MvGgxxXzjdModel model, SearchCondition search)
        {
            var r = new GeneralResult();
            var option = new ChartOptionModel();
            if (search.EndTime.HasValue && search.BeginTime.HasValue)
            {
                var condition = model.ConditionBuilder(search);
                var query = FromWhere();

                if ((DateTime.Now - search.BeginTime.Value).TotalDays > 91)
                {
                    //项目公告公示数据源90天外（公共服务平台）
                    query = FromWhere().UnionAll(FromWhere<MV_GGXX_HISTORY_XZJD>());
                }

                var format = "yyyy-mm";
                var format1= "yyyy-MM";
                var days = (search.EndTime.Value - search.BeginTime.Value).Duration().TotalDays;
                if (days < 2)
                {
                    format = "yyyy-mm-dd HH";
                     format1 = "yyyy-MM-dd HH";
                }
                else if (days <= 90)
                {
                    format = "yyyy-mm-dd";
                     format1 = "yyyy-MM-dd";
                }
                //query.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "300" && SYS_DIC._.VALUE == MvGgxxXzjdModel._.PROJECT_CATEGORY);
                query = query.Where(condition.ToWhereClip());
                var list = query
                    .Select(
                        MvGgxxXzjdModel._.TM.ToChar(format,"TM"),
                        MvGgxxXzjdModel._.GGTYPE,
                        MvGgxxXzjdModel._.GGTYPE.Count().As("Count")
                    ).GroupBy(MvGgxxXzjdModel._.GGTYPE, MvGgxxXzjdModel._.TM.ToChar(format))
                    .ToList<MvGgxxXzjdChartModel>();
              
                var begin = search.BeginTime.Value;
                var end = search.EndTime.Value;
                while (string.Compare(begin.ToString(format1),end.ToString(format1),StringComparison.CurrentCultureIgnoreCase)<=0)
                {
                    var tm = begin.ToString(format1);

                    option.XAxis.Data.Add(tm);
                    //zbgg.Add(list.FirstOrDefault(c => c.TM == tm && c.GGTYPE == "1")?.Count );//?? 0
                    //bggg.Add(list.FirstOrDefault(c => c.TM == tm && c.GGTYPE == "2")?.Count );
                    //zbhxrgs.Add(list.FirstOrDefault(c => c.TM == tm && c.GGTYPE == "3")?.Count );
                    //zbjggg.Add(list.FirstOrDefault(c => c.TM == tm && c.GGTYPE == "4")?.Count );
                    if (days < 2)
                    {
                        begin = begin.AddHours(1);
                    }
                    else if (days <= 90)
                    {
                        begin = begin.AddDays(1);
                    }
                    else
                    {
                        begin = begin.AddMonths(1);
                    }
                }
               
                var ggTypes = Fw.SysDicService
                    .FromWhere(SYS_DIC._.TYPE == "2020120820" && SYS_DIC._.PID.SubQueryEqual(Fw.SysDicService
                                   .FromWhere(SYS_DIC._.TYPE == "20201208" && SYS_DIC._.VALUE == model.PROJECT_CATEGORY?.ToString())
                                   .Select(SYS_DIC._.ID))).OrderBy(SYS_DIC._.ORDER_ID).ToList();
               
                var lineBarSeries = ggTypes.Select(c => new LineBarSeries
                {
                    Name = c.TEXT,
                    Data = option.XAxis.Data.Select(o=>list.FirstOrDefault(d=>d.TM==o&&d.GGTYPE==c.VALUE)?.Count).ToList()
                }).ToList();
                option.Series.AddRange(lineBarSeries);
            }
            r.SetSuccess(option);
            return r;
        }
        #endregion

    }
}