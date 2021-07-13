using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdStRiverRController:BaseController
    {
        /// <summary>
        /// 读取ST_RIVER_R列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadStRiverRs(ST_RIVER_R model, SearchCondition condition)
        {
            var result = Fw.StRiverRService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ST_RIVER_R明细
        /// </summary>
      /// <param name="STCD"></param>
      /// <param name="TM"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadStRiverR(string STCD,DateTime? TM)
        
        {
            var result = Fw.StRiverRService.ViewByPk(STCD,TM);
            return JResult(result);
        }
        /// <summary>
        /// 创建ST_RIVER_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateStRiverR(ST_RIVER_R model)
        {
            var result = Fw.StRiverRService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ST_RIVER_R信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateStRiverR(ST_RIVER_R model)
        {
            var result = Fw.StRiverRService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ST_RIVER_R信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteStRiverR(string ids)
        {
            var result = Fw.StRiverRService.Delete(ids);
            return JResult(result); 
        }
    }
}