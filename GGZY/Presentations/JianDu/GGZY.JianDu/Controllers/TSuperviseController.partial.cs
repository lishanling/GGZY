using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class TSuperviseController
    {
        #region 通用

        public ActionResult SuperviseCount(TSuperviseResultSearchModel model)
        {
            var r = model.Validate();
            if (r.Success)
            {
                switch (model.ENTITY_TYPE_NAME)
                {
                    case nameof(T_AFC_PROJECT):
                        var afcProject = Jd.TSuperviseResultService.AfcProjectSuperviseCount(model);
                        r.SetSuccess(afcProject);
                        break;
                    case nameof(PT_ZXTS):
                        var zxts = Jd.TSuperviseResultService.ZxtsSuperviseCount(model);
                        r.SetSuccess(zxts);
                        break;
                    case nameof(RECORD_REVIEW):
                        var zbba = Jd.TSuperviseResultService.ReviewSuperviseCount(model);
                        r.SetSuccess(zbba);
                        break;
                }
            }

            return JResult(r);
        }
        public ActionResult SuperviseList(TSuperviseResultSearchModel model)
        {
            var r = model.Validate();
            if (r.Success)
            {
                PageTableResult page = model.ToPageTableResult();
                switch (model.ENTITY_TYPE_NAME)
                {
                    case nameof(T_AFC_PROJECT):
                        page = Jd.TSuperviseResultService.AfcProjectSuperviseList(model);
                        break;
                    case nameof(PT_ZXTS):
                        page = Jd.TSuperviseResultService.ZxtsSuperviseList(model);
                        break;
                    case nameof(RECORD_REVIEW):
                        page = Jd.TSuperviseResultService.ReviewSuperviseList(model);
                        break;
                }
                r.SetSuccess(page);
            }

            return JResult(r);
        }

        /// <summary>
        /// 招标计划-检查点-红灯变更为绿灯
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Change(TSuperviseResultLogModel model)
        {
            var r = Jd.TSuperviseResultService.SuperviseChange(model);
            return JResult(r);
        }

        #endregion
    }
}