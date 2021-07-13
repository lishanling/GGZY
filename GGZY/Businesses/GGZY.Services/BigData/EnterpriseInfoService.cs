using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Fields;
using GGZY.Services.Infrastructure.Model.BigData;
using GGZYFW.DbEntity;

namespace GGZY.Services.BigData
{
    /// <summary>
    /// 
    /// </summary>
    public class EnterpriseInfoService : BaseServiceT<FwEntity>
    {
        #region 软硬件数据统计
        /// <summary>
        /// 多企业软硬件信息一致
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult EnterpriseInfoSame(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件

            if (!string.IsNullOrEmpty(search.MAC_ADDRESS))
            {
                condition.And(T_MAC_RESULT_FIRST._.MAC.Like(search.MAC_ADDRESS));
            }
            if (!string.IsNullOrEmpty(search.CPU_ID))
            {
                condition.And(T_MAC_RESULT_FIRST._.CPU_ID.Like(search.CPU_ID));
            }
            if (!string.IsNullOrEmpty(search.HDISK))
            {
                condition.And(T_MAC_RESULT_FIRST._.HDISK.Like(search.HDISK));
            }
            //查询大于两个数量的
            condition.And(T_MAC_RESULT_FIRST._.PCOUNT > 2);
            var model = Fw.TMacResultFirstService.FromWhere(condition.ToWhereClip());

            var total = model.Count();
            if (total > 0)
            {
                var list = model.OrderBy(T_MAC_RESULT_FIRST._.PCOUNT.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<T_MAC_RESULT_FIRST>();
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }
            return search.ToPageTableTResult<T_MAC_RESULT_FIRST>(total);
        }


        /// <summary>
        /// 多企业软硬件信息一致-详情
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public Object EnterpriseInfoSameDetail(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件
            if (string.IsNullOrEmpty(search.MAC_ADDRESS) || string.IsNullOrEmpty(search.CPU_ID) || string.IsNullOrEmpty(search.HDISK))
            {
                return new List<Object>();
            }
            condition.And(T_MAC._.MAC == search.MAC_ADDRESS);
            condition.And(T_MAC._.CPU_ID == search.CPU_ID);
            condition.And(T_MAC._.HDISK == search.HDISK);

            if (search.BeginTime != null)
            {
                condition.And(T_MAC._.TI >= search.BeginTime);
            }
            if (search.EndTime != null)
            {
                condition.And(T_MAC._.TI <= search.EndTime);
            }
            //投标人 tender_list  项目信息gcjsjyxx 视图  win_result_anno   字段tender_project_code 来关联
            List<string> ids = Fw.TMacService.FromWhere(condition.ToWhereClip()).Select(T_MAC._.MID).ToList<string>();//查询符合条件的id
            if (ids.Count == 0)
            {
                return new List<object>();
            }
            var mids = string.Join("','", ids);
            var where1 = new StringBuilder($" AND MID IN('{mids}')");
            var sql = $@"select a.BIDDER_NAME, a.TENDER_PROJECT_CODE,
 g.TENDER_PROJECT_NAME,g.OPEN_TIME, g.REGION_CODE,case when g.WIN_BIDDER_NAME = a.bidder_name then  1 else 0 end as ISWIN,
t.CHECKIN_TIME, a.BIDDER_ORG_CODE from T_MAC a left join tender_list t on t.tender_project_code = a.tender_project_code and t.bidder_name=a.bidder_name  
  left join gcjsjyxx g on a.tender_project_code = g.tender_project_code where 1 = 1 {where1}";
            var models = FromSql(sql).ToList<EnterpriseInfoSameDetailModel>();
            var areas = Jd.SysAreaQuanguoService.FromTable("SYS_AREA_QUANGUO").ToList<SYS_AREA_QUANGUO>();
            var result = models.GroupBy(p => new { p.CHECKIN_TIME.Date }).Select(p => new
            {
                CHECKIN_TIME = p.Key.Date,
                PCOUNT = p.Count(),
                INFO = p.Select(s => new EnterpriseInfoSameDetailModel
                {
                    BIDDER_NAME = s.BIDDER_NAME,
                    ISWIN = s.ISWIN,
                    CHECKIN_TIME = s.CHECKIN_TIME,
                    BIDDER_ORG_CODE = s.BIDDER_ORG_CODE,
                    OPEN_TIME = s.OPEN_TIME,
                    REGION_CODE = areas.Where(a => a.AREACODE == s.REGION_CODE).Select(a => a.AREANAME).FirstOrDefault(),
                    TENDER_PROJECT_CODE = s.TENDER_PROJECT_CODE,
                    TENDER_PROJECT_NAME = s.TENDER_PROJECT_NAME
                })
            }).OrderByDescending(o => o.CHECKIN_TIME).ToList();
            return result;
        }

        /// <summary>
        /// 软硬件信息与别企业重叠
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult EnterpriseInfoOverlap(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件

            if (!string.IsNullOrEmpty(search.BIDDER_NAME))
            {
                condition.And(T_MAC_RESULT_SECOND._.BIDDER_NAME.Like(search.BIDDER_NAME));
            }
            if (!string.IsNullOrEmpty(search.BIDDER_ORG_CODE))
            {
                condition.And(T_MAC_RESULT_SECOND._.BIDDER_ORG_CODE.Like(search.BIDDER_ORG_CODE));
            }
            condition.And(T_MAC_RESULT_SECOND._.PCOUNT > 2);
            var model = Fw.TMacResultSecondService.FromWhere(condition.ToWhereClip());
            var total = model.Count();
            if (total > 0)
            {
                var list = model.OrderBy(T_MAC_RESULT_SECOND._.PCOUNT.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<T_MAC_RESULT_SECOND>();
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }
            return search.ToPageTableTResult<T_MAC_RESULT_SECOND>(total);
        }


        /// <summary>
        /// 软硬件信息与别企业重叠-详情
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public Object EnterpriseInfoOverlapDetail(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件
            if (string.IsNullOrEmpty(search.BIDDER_ORG_CODE) || string.IsNullOrEmpty(search.BIDDER_NAME))
            {
                return new List<Object>();
            }
            condition.And(T_MAC._.BIDDER_ORG_CODE == search.BIDDER_ORG_CODE);
            condition.And(T_MAC._.BIDDER_NAME == search.BIDDER_NAME);

            if (search.BeginTime != null)
            {
                condition.And(T_MAC._.TI >= search.BeginTime);
            }
            if (search.EndTime != null)
            {
                condition.And(T_MAC._.TI <= search.EndTime);
            }
            //投标人 tender_list  项目信息gcjsjyxx 视图  win_result_anno   字段tender_project_code 来关联
            List<string> ids = Fw.TMacService.FromWhere(condition.ToWhereClip()).Select(T_MAC._.MID).ToList<string>();//查询符合条件的id
            if (ids.Count == 0)
            {
                return new List<object>();
            }
            var mids = string.Join("','", ids);
            var where1 = new StringBuilder($" AND MID IN('{mids}')");
            var sql = $@"select a.BIDDER_NAME, a.TENDER_PROJECT_CODE,a.CPU_ID,a.HDISK,a.MAC,
 g.TENDER_PROJECT_NAME,g.OPEN_TIME, g.REGION_CODE,case when g.WIN_BIDDER_NAME = a.bidder_name then  1 else 0 end as ISWIN,
t.CHECKIN_TIME, a.BIDDER_ORG_CODE from T_MAC a left join tender_list t on t.tender_project_code = a.tender_project_code and t.bidder_name=a.bidder_name  
  left join gcjsjyxx g on a.tender_project_code = g.tender_project_code
  where (CPU_ID,HDISK,MAC) in
(select CPU_ID,HDISK,MAC from T_MAC where 1 = 1 {where1})";
            var models = FromSql(sql).ToList<EnterpriseInfoOverlapDetailModel>();
            var areas = Jd.SysAreaQuanguoService.FromTable("SYS_AREA_QUANGUO").ToList<SYS_AREA_QUANGUO>();
            var result = models.GroupBy(p => new { p.CPU_ID, p.HDISK, p.MAC }).Select(p => new
            {
                CPU_ID = p.Key.CPU_ID,
                HDISK = p.Key.HDISK,
                MAC_ADDRESS = p.Key.MAC,
                INFO = p.GroupBy(g => g.CHECKIN_TIME.Date).Select(g => new
                {
                    CHECKIN_TIME = g.Key,
                    PCOUNT = g.Where(w => w.BIDDER_NAME != search.BIDDER_NAME && w.BIDDER_ORG_CODE != search.BIDDER_ORG_CODE).Count(),
                    INFODETAIL = g.Select(s => new EnterpriseInfoOverlapDetailModel
                    {
                        BIDDER_NAME = s.BIDDER_NAME,
                        ISWIN = s.ISWIN,
                        CHECKIN_TIME = s.CHECKIN_TIME,
                        BIDDER_ORG_CODE = s.BIDDER_ORG_CODE,
                        OPEN_TIME = s.OPEN_TIME,
                        REGION_CODE = areas.Where(a => a.AREACODE == s.REGION_CODE).Select(a => a.AREANAME).FirstOrDefault(),
                        TENDER_PROJECT_CODE = s.TENDER_PROJECT_CODE,
                        TENDER_PROJECT_NAME = s.TENDER_PROJECT_NAME,
                        ISSAME = s.BIDDER_NAME == search.BIDDER_NAME && s.BIDDER_ORG_CODE == search.BIDDER_ORG_CODE ? 0 : 1
                    })
                }).OrderByDescending(o => o.CHECKIN_TIME)
            }).ToList();
            return result;
        }

        /// <summary>
        /// 企业使用过的软硬件数量
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult EnterpriseInfoUsered(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件

            if (!string.IsNullOrEmpty(search.BIDDER_NAME))
            {
                condition.And(T_MAC_RESULT_THIRD._.BIDDER_NAME.Like(search.BIDDER_NAME));
            }
            if (!string.IsNullOrEmpty(search.BIDDER_ORG_CODE))
            {
                condition.And(T_MAC_RESULT_THIRD._.BIDDER_ORG_CODE.Like(search.BIDDER_ORG_CODE));
            }
            var model = Fw.TMacResultThirdService.FromWhere(condition.ToWhereClip());
            //投标次数

            var total = model.Count();
            if (total > 0)
            {
                var list = model.OrderBy(T_MAC_RESULT_THIRD._.PCOUNT.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<T_MAC_RESULT_THIRD>();
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }
            return search.ToPageTableTResult<T_MAC_RESULT_THIRD>(total);
        }

        /// <summary>
        /// 企业使用过软硬件数量-详情
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public Object EnterpriseInfoUseredDetail(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件
            if (string.IsNullOrEmpty(search.BIDDER_ORG_CODE) || string.IsNullOrEmpty(search.BIDDER_NAME))
            {
                return new List<Object>();
            }
            condition.And(T_MAC._.BIDDER_ORG_CODE == search.BIDDER_ORG_CODE);
            condition.And(T_MAC._.BIDDER_NAME == search.BIDDER_NAME);

            if (search.BeginTime != null)
            {
                condition.And(T_MAC._.TI >= search.BeginTime);
            }
            if (search.EndTime != null)
            {
                condition.And(T_MAC._.TI <= search.EndTime);
            }
            //投标人 tender_list  项目信息gcjsjyxx 视图  win_result_anno   字段tender_project_code 来关联
            List<string> ids = Fw.TMacService.FromWhere(condition.ToWhereClip()).Select(T_MAC._.MID).ToList<string>();//查询符合条件的id
            if (ids.Count == 0)
            {
                return new List<object>();
            }
            var mids = string.Join("','", ids);
            var where1 = new StringBuilder($" AND MID IN('{mids}')");
            var sql = $@"select a.BIDDER_NAME, a.TENDER_PROJECT_CODE,a.CPU_ID,a.HDISK,a.MAC,
 g.TENDER_PROJECT_NAME,g.OPEN_TIME, g.REGION_CODE,case when g.WIN_BIDDER_NAME = a.bidder_name then  1 else 0 end as ISWIN,
t.CHECKIN_TIME, a.BIDDER_ORG_CODE from T_MAC a left join tender_list t on t.tender_project_code = a.tender_project_code and t.bidder_name=a.bidder_name  
  left join gcjsjyxx g on a.tender_project_code = g.tender_project_code where 1 = 1 {where1}";
            var models = FromSql(sql).ToList<EnterpriseInfoOverlapDetailModel>();
            var areas = Jd.SysAreaQuanguoService.FromTable("SYS_AREA_QUANGUO").ToList<SYS_AREA_QUANGUO>();
            var result = models.GroupBy(p => new { p.TENDER_PROJECT_CODE, p.TENDER_PROJECT_NAME }).Select(s => new
            {
                TENDER_PROJECT_CODE = s.Key.TENDER_PROJECT_CODE,
                TENDER_PROJECT_NAME = s.Key.TENDER_PROJECT_NAME,
                BIDDER_ORG_CODE = search.BIDDER_ORG_CODE,
                BIDDER_NAME = search.BIDDER_NAME,
                ISWIN = s.FirstOrDefault().ISWIN,
                CHECKIN_TIME = s.FirstOrDefault().CHECKIN_TIME,
                OPEN_TIME = s.FirstOrDefault().OPEN_TIME,
                REGION_CODE = areas.Where(a => a.AREACODE == s.FirstOrDefault().REGION_CODE).Select(a => a.AREANAME).FirstOrDefault(),
                PCOUNT = s.Count()
            }).OrderByDescending(o => o.CHECKIN_TIME).ToList();
            return result;
        }

        /// <summary>
        /// 多企业相同项目负责人
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult PersonInfo(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件
            if (!string.IsNullOrEmpty(search.BID_MANAGER))
            {
                condition.And(TENDER_LIST_STATISTICS._.BID_MANAGER.Like(search.BID_MANAGER));
            }
            if (!string.IsNullOrEmpty(search.PM_CODE))
            {
                condition.And(TENDER_LIST_STATISTICS._.PM_CODE.Like(search.PM_CODE));
            }
            condition.And(TENDER_LIST_STATISTICS._.PCOUNT > 2);
            var model = Fw.TenderListStatisticsService.FromWhere(condition.ToWhereClip());
            var total = model.Count();
            if (total > 0)
            {
                var list = model.OrderBy(TENDER_LIST_STATISTICS._.PCOUNT.Desc)
                    .Page(search.PageSize, search.PageNo)
                    .ToList<TENDER_LIST_STATISTICS>();
                var pageList = list.ToPageTableTResult(search, total);
                return pageList;
            }
            return search.ToPageTableTResult<TENDER_LIST_STATISTICS>(total);
        }

        /// <summary>
        /// 多企业相同项目负责人-详情
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public Object PersonInfoDetail(EnterpriseInfoSearchModel search)
        {
            var condition = new WhereClipBuilder();
            //查询条件
            if (string.IsNullOrEmpty(search.BID_MANAGER) || string.IsNullOrEmpty(search.PM_CODE))
            {
                return new List<Object>();
            }
            var where1 = new StringBuilder($" AND BID_MANAGER = '{search.BID_MANAGER}'");
            where1.Append($" AND PM_CODE = '{search.PM_CODE}'");
            var sql = $@"select t.BIDDER_NAME, g.TENDER_PROJECT_CODE,t.CHECKIN_TIME, t.BIDDER_ORG_CODE,
 g.TENDER_PROJECT_NAME,g.OPEN_TIME, g.REGION_CODE,case when g.WIN_BIDDER_NAME = t.bidder_name then  1 else 0 end as ISWIN
  from tender_list t  left join gcjsjyxx g on t.tender_project_code = g.tender_project_code where 1 = 1 {where1}";
            var models = FromSql(sql).ToList<EnterpriseInfoSameDetailModel>();
            var areas = Jd.SysAreaQuanguoService.FromTable("SYS_AREA_QUANGUO").ToList<SYS_AREA_QUANGUO>();
            var result = models.Select(s => new
            {
                BIDDER_NAME = s.BIDDER_NAME,
                ISWIN = s.ISWIN,
                CHECKIN_TIME = s.CHECKIN_TIME,
                BIDDER_ORG_CODE = s.BIDDER_ORG_CODE,
                OPEN_TIME = s.OPEN_TIME,
                REGION_CODE = areas.Where(a => a.AREACODE == s.REGION_CODE).Select(a => a.AREANAME).FirstOrDefault(),
                TENDER_PROJECT_CODE = s.TENDER_PROJECT_CODE,
                TENDER_PROJECT_NAME = s.TENDER_PROJECT_NAME,
                BID_MANAGER=search.BID_MANAGER,
                PM_CODE=search.PM_CODE
            }).OrderByDescending(o => o.CHECKIN_TIME).ToList();
            return result;
        }
        #endregion
    }
}
