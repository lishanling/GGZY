using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStRsvrRController:BaseController
    {
        /// <summary>
        /// 读取ST_RSVR_R列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStRsvrRs(ST_RSVR_R model, SearchCondition condition)
        {
            var result = Fw.StRsvrRService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ST_RSVR_R明细
        /// </summary>
      /// <param name="STCD"></param>
      /// <param name="TM"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStRsvrR(string STCD,DateTime? TM)
        
        {
            var result = Fw.StRsvrRService.ViewByPk(STCD,TM);
            return JResult(result);
        }
        /// <summary>
        /// 创建ST_RSVR_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStRsvrR(ST_RSVR_R model)
        {
            var result = Fw.StRsvrRService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ST_RSVR_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStRsvrR(ST_RSVR_R model)
        {
            var result = Fw.StRsvrRService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ST_RSVR_R信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStRsvrR(string ids)
        {
            var result = Fw.StRsvrRService.Delete(ids);
            return JResult(result); 
        }
    }
}