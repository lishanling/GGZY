using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStPptnRController:BaseController
    {
        /// <summary>
        /// 读取ST_PPTN_R列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStPptnRs(ST_PPTN_R model, SearchCondition condition)
        {
            var result = Fw.StPptnRService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ST_PPTN_R明细
        /// </summary>
      /// <param name="STCD"></param>
      /// <param name="TM"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStPptnR(string STCD,DateTime? TM)
        
        {
            var result = Fw.StPptnRService.ViewByPk(STCD,TM);
            return JResult(result);
        }
        /// <summary>
        /// 创建ST_PPTN_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStPptnR(ST_PPTN_R model)
        {
            var result = Fw.StPptnRService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ST_PPTN_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStPptnR(ST_PPTN_R model)
        {
            var result = Fw.StPptnRService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ST_PPTN_R信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStPptnR(string ids)
        {
            var result = Fw.StPptnRService.Delete(ids);
            return JResult(result); 
        }
    }
}