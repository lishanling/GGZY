/*
9.8.7	标段（包）分类
编码规则：采用组合码，编码长度7位。此编码参考了《评标专家专业分类标准（试行）》（发改法规[2010]1538号），并在此基础上进行了扩展，排列顺序从左至右依次为：
（1）第一级1位，A -工程、B-货物、C-服务、D-产权、E-土地；
（2）第二级2位，对应《评标专家专业分类标准》中的一级类别；
01 规划
02 投资策划与决策
03 勘察
04 设计
05 监理
06 工程造价
07 项目管理(含代建)
08 工程施工
09 其他工程
10工程总承包（含设计采购施工一体化，设计施工一体化）
全过程工程咨询
*/

using System;
using System.Collections.Generic;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{

    public partial class VGongChengTongJiService
    {
        #region MyRegion

        protected Dictionary<string, string> ClassifyCode => new Dictionary<string, string>
        {
            {"A08", "建设工程施工招标统计"},
            {"A05", "建设工程监理招标统计"},
            {"A03_A04", "建设工程勘察、设计招标统计"},
            {"A10", "EPC总承包招标统计"},
        };
        public GeneralResult<GongChengTongJiModel> TongJi(SearchCondition condition)
        {
            var r = DateValidate(condition);
            if (r.Success)
            {
                var classifyCodes = condition.Type.Split('_');
                var c = V_GONGCHENG_TONGJI._.TM >= condition.BeginTime
                        && V_GONGCHENG_TONGJI._.TM < condition.EndTime;
                var c1 = new WhereClipBuilder();
                foreach (var classifyCode in classifyCodes)
                {
                    c1.Or(V_GONGCHENG_TONGJI._.TENDER_PROJECT_CLASSIFY_CODE.BeginWith(classifyCode));
                }
                r.TData.List = FindList(c && c1.ToWhereClip());
                r.TData.ClissifyCode = condition.Type;
                if (ClassifyCode.ContainsKey(condition.Type))
                {
                    r.TData.Name = $"{ClassifyCode[condition.Type]}";
                }
            }
            return r;
        }
        protected GeneralResult<GongChengTongJiModel> DateValidate(SearchCondition condition)
        {
            var r = new GeneralResult<GongChengTongJiModel>();
            switch (condition.KeyWord)
            {
                case "sy"://上月
                    condition.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.Day).AddMonths(-1);//上月1号0点
                    condition.EndTime = DateTime.Today.AddDays(1 - DateTime.Today.Day);//本月1号0点
                    break;
                case "by"://本月
                    condition.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.Day);//本月1号0点
                    condition.EndTime = DateTime.Today.AddDays(1);//明天0点
                    break;
                case "sn"://上年度
                    condition.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear).AddYears(-1);//去年1号0点
                    condition.EndTime = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);//今年1号0点
                    break;
                case "bn"://本年度
                    condition.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);//今年1号0点
                    condition.EndTime = DateTime.Today.AddDays(1);//明天0点
                    break;
            }
            if (!condition.BeginTime.HasValue || !condition.EndTime.HasValue)
            {
                r.SetFail("请选择时间区间");
            }
            else
            {
                r.SetSuccessT(new GongChengTongJiModel());
            }

            return r;
        }


        #endregion

        #region MyRegion

        public BootstrapTableResult<V_GONGCHENG_TONGJI> DoStat(SearchCondition search)
        {
            var condition = WhereClipBuilder(search);
            var count = Count(condition);
            //var pageList =PageList(condition,search, V_GONGCHENG_TONGJI._.TM.Desc).ToBootstrapTableList(count);
            var pageList = FromWhere(condition).Page(search.PageSize, search.PageNo)
                .OrderBy(V_GONGCHENG_TONGJI._.TM.Desc)
                .ToList().ToBootstrapTableList(count);

            return pageList;
        }

        public GeneralResult DoCount(SearchCondition search)
        {
            var r = new GeneralResult();
            var condition = WhereClipBuilder(search);
            var count = Count(condition);
            //招标人数量
            int zbrCount = GetDbSession().From<V_GONGCHENG_TONGJI>().Where(condition).Select(V_GONGCHENG_TONGJI._.ZBR)
                .GroupBy(V_GONGCHENG_TONGJI._.ZBR).Count();
            //招标代理数量
            int zbdlCount = GetDbSession().From<V_GONGCHENG_TONGJI>().Where(condition).Select(V_GONGCHENG_TONGJI._.ZBDLDW)
                .GroupBy(V_GONGCHENG_TONGJI._.ZBDLDW).Count();
            //控制价总额
            var kzj = (GetDbSession().Sum<V_GONGCHENG_TONGJI>(V_GONGCHENG_TONGJI._.ZBKZJ, condition));
            string sumKzj = Convert.ToDecimal(kzj.Equals(DBNull.Value) ? "0" : kzj).ToString("F2");
            //中标价总额
            var zbj = GetDbSession().Sum<V_GONGCHENG_TONGJI>(V_GONGCHENG_TONGJI._.ZBJ, condition);
            string sumZbj = Convert.ToDecimal(zbj.Equals(DBNull.Value) ? "0" : zbj).ToString("F2");
            //中标单位数
            int zbdwCount = GetDbSession().From<V_GONGCHENG_TONGJI>().Where(condition).Select(V_GONGCHENG_TONGJI._.ZBDW)
                .GroupBy(V_GONGCHENG_TONGJI._.ZBDW).Count();
            r.SetSuccess(new
            {
                zbxmCount = count,
                zbrCount,
                zbdlCount,
                sumKzj,
                sumZbj,
                zbdwCount
            });
            return r;
        }

        protected WhereClip WhereClipBuilder(SearchCondition search)
        {
            switch (search.KeyWord)
            {
                case "sy"://上月
                    search.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.Day).AddMonths(-1);//上月1号0点
                    search.EndTime = DateTime.Today.AddDays(1 - DateTime.Today.Day);//本月1号0点
                    break;
                case "by"://本月
                    search.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.Day);//本月1号0点
                    search.EndTime = DateTime.Today.AddDays(1);//明天0点
                    break;
                case "sn"://上年度
                    search.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear).AddYears(-1);//去年1号0点
                    search.EndTime = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);//今年1号0点
                    break;
                case "bn"://本年度
                    search.BeginTime = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);//今年1号0点
                    search.EndTime = DateTime.Today.AddDays(1);//明天0点
                    break;
            }
            var c = new WhereClipBuilder();
            if (search.BeginTime.HasValue)
            {
                c.And(V_GONGCHENG_TONGJI._.TM >= search.BeginTime);
            }

            if (search.EndTime.HasValue)
            {
                c.And(V_GONGCHENG_TONGJI._.TM < search.EndTime);
            }
            var classifyCodes = search.Type.Split('_');
            var c1 = new WhereClipBuilder();

            foreach (var classifyCode in classifyCodes)
            {
                c1.Or(V_GONGCHENG_TONGJI._.TENDER_PROJECT_CLASSIFY_CODE.BeginWith(classifyCode));
            }

            return c.ToWhereClip() & c1.ToWhereClip();
        }


        #endregion
    }
}


