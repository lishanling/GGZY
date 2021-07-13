using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;

namespace GGZY.JianDu.Portal.Controllers
{
    /// <summary>
    /// 联动监管
    /// </summary>
    [AllowAnonymous]
    public class LinkageSupervisionController: BaseController
    {
        #region 标前

        [NonAction]
        public ActionResult BeforeList(SearchCondition search)
        {
            var r = Jd.TAfcFixedService.BeforeList(search);
            return JResult(r);
        }

        [NonAction]
        public ActionResult BeforeDetail(string guid, string type)
        {
            var r = Jd.TAfcFixedService.BeforeDetail(guid,type);
            return JResult(r);
        }

        /// <summary>
        /// 标前详情
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult BeforeDetail(string tenderProjectCode)
        {
            var r = Jd.TAfcFixedService.BeforeDetail(tenderProjectCode);
            return JResult(r);
        }
        #endregion

        #region 标后
        [NonAction]
        public ActionResult AfterList(SearchCondition search)
        {
            var r = Jd.TAfcFixedService.AfterList(search);
            return JResult(r);
        }
        [NonAction]
        public ActionResult AfterDetail(string guid, string type)
        {
            var r = Jd.TAfcFixedService.AfterDetail(guid, type);
            return JResult(r);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult AfterDetail(string tenderProjectCode)
        {
            var r = Jd.TAfcFixedService.AfterDetail(tenderProjectCode);
            return JResult(r);
        }
        #endregion


        public ActionResult LinkageInfo()
        {
            return JResult(new
            {

                Suspicious = 0,
                ColumnInfo = new
                {
                    FUJIAN = 0,
                    FUZHOU = 0,
                    PINGTAN = 0,
                    XIAMEN = 0,
                    PUTIAN = 0,
                    SANMING = 0,
                    QUANZHOU = 0,
                    ZHANGZHOU = 0,
                    NANPING = 0,
                    LONGYAN = 0,
                    NINGDE = 0,
                    SHENGBENJI = 0,
                },
                FanInfo = new
                {
                    ZHUJIAN = 0,
                    SHUILI = 0,
                    JIAOTONG = 0,
                }
            });
        }
    }
}