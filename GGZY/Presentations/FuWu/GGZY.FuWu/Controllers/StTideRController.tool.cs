using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStTideRController:BaseController
    {
        /// <summary>
        /// 读取ST_TIDE_R列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStTideRs(ST_TIDE_R model, SearchCondition condition)
        {
            var result = Fw.StTideRService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ST_TIDE_R明细
        /// </summary>
      /// <param name="STCD"></param>
      /// <param name="TM"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStTideR(string STCD,DateTime? TM)
        
        {
            var result = Fw.StTideRService.ViewByPk(STCD,TM);
            return JResult(result);
        }
        /// <summary>
        /// 创建ST_TIDE_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStTideR(ST_TIDE_R model)
        {
            var result = Fw.StTideRService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ST_TIDE_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStTideR(ST_TIDE_R model)
        {
            var result = Fw.StTideRService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ST_TIDE_R信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStTideR(string ids)
        {
            var result = Fw.StTideRService.Delete(ids);
            return JResult(result); 
        }
    }
}