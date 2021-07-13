using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnExpressionService
    {
        /// <summary>
        /// 监督点名称
        /// </summary>
        /// <returns></returns>
        public object SpName()
        {
            var r = FromWhere().Select(WARN_EXPRESSION._.SP_NAME).ToList();
            var values = r.Select(c => c.SP_NAME).Distinct().ToList();
            return values.Select(c => new LabelValueModel
            {
                Label = c,
                Value = c
            });
        }
        /// <summary>
        /// 监督方式
        /// </summary>
        /// <returns></returns>
        public object SpWay()
        {
            var r = FromWhere().Select(WARN_EXPRESSION._.SP_WAY).ToList();
            var values = r.Select(c => c.SP_WAY).Distinct().ToList();
            return values.Select(c => new LabelValueModel
            {
                Label = c,
                Value = c
            });
        }
        /// <summary>
        /// 监督点所属流程
        /// </summary>
        /// <returns></returns>
        public object SpFlow()
        {
            var r = FromWhere().Select(WARN_EXPRESSION._.SP_FLOW_NAME).ToList();
            var values = r.Select(c => c.SP_FLOW_NAME).Distinct().ToList();
            return values.Select(c => new LabelValueModel
            {
                Label = c,
                Value = c
            });
        }
        /// <summary>
        /// 监督类型
        /// </summary>
        /// <returns></returns>
        public object SpType()
        {
            var r = FromWhere().Select(WARN_EXPRESSION._.SP_TYPE).ToList();
            var values = r.Select(c => c.SP_TYPE).Distinct().ToList();
            return values.Select(c => new LabelValueModel
            {
                Label = c,
                Value = c
            });
        }
        /// <summary>
        /// 获取tab页面树状结构数据,根据监督项目ID【包含监督点信息】
        /// </summary>
        /// <returns></returns>
        public List<SelectModel> GetPSTabList()
        {
            var dbSource = FindList(WARN_EXPRESSION._.ISDELETE != 1);
            var result = dbSource.GroupBy(c => c.SP_TYPE).Select(group => new SelectModel
            {
                Label = group.Key,
                Value = group.Key,
                Children = group.GroupBy(c => c.SP_FLOW_NAME)
                      .Select(c => new SelectModel
                      {
                          Label = c.Key,
                          Value = c.Key,
                          Children = c.Select(o => new SelectModel
                          {
                              Value = o.M_ID?.ToString(),
                              Label = o.SP_NAME,
                              Children = null
                          }).ToList()
                      }).ToList()
            }).ToList();
            return result;
        }
    }
}