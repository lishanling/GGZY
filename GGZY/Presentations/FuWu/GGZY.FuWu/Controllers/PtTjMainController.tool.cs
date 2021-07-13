using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtTjMainController:BaseController
    {
        /// <summary>
        /// 读取PT_TJ_MAIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtTjMains(PT_TJ_MAIN model, SearchCondition condition)
        {
            var result = Fw.PtTjMainService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_TJ_MAIN明细
        /// </summary>
      /// <param name="TM">年月</param>
      /// <param name="AREACODE">行政级别</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtTjMain(DateTime? TM,string AREACODE)
        
        {
            var result = Fw.PtTjMainService.ViewByPk(TM,AREACODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_TJ_MAIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtTjMain(PT_TJ_MAIN model)
        {
            var result = Fw.PtTjMainService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_TJ_MAIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtTjMain(PT_TJ_MAIN model)
        {
            var result = Fw.PtTjMainService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_TJ_MAIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtTjMain(string ids)
        {
            var result = Fw.PtTjMainService.Delete(ids);
            return JResult(result); 
        }
    }
}