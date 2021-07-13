using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdPtZxtsDepconfigController
    {
        #region 投诉签收设置
        /// <summary>
        /// 添加签收人
        /// </summary>
        /// <param name="uIds"></param>
        /// <returns></returns>
        public ActionResult AddTsDepConfig(decimal[] uIds)
        {
            var r = Jd.PtZxtsDepconfigService.AddTsDepConfig(uIds);
            return JResult(r);
        }

        /// <summary>
        /// 移除签收人
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult RemoveTsDepConfig(decimal id)
        {
            var r = Jd.PtZxtsDepconfigService.RemoveTsDepConfig(id);
            return JResult(r);
        }
        /// <summary>
        /// 签收人列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult TsDepConfigList(SearchCondition search)
        {
            var r = Jd.PtZxtsDepconfigService.TsDepConfigList(search);
            return JResult(r);
        }
        #endregion
    }
}