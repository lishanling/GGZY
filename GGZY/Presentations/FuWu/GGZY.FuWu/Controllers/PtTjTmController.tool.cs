using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtTjTmController:BaseController
    {
        /// <summary>
        /// 读取PT_TJ_TM列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtTjTms(PT_TJ_TM model, SearchCondition condition)
        {
            var result = Fw.PtTjTmService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_TJ_TM明细
        /// </summary>
      /// <param name="TM">年月</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtTjTm(DateTime? TM)
        
        {
            var result = Fw.PtTjTmService.ViewByPk(TM);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_TJ_TM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtTjTm(PT_TJ_TM model)
        {
            var result = Fw.PtTjTmService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_TJ_TM信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtTjTm(PT_TJ_TM model)
        {
            var result = Fw.PtTjTmService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_TJ_TM信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtTjTm(string ids)
        {
            var result = Fw.PtTjTmService.Delete(ids);
            return JResult(result); 
        }
    }
}