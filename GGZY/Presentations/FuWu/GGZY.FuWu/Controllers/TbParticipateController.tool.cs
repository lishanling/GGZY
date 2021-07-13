using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTbParticipateController:BaseController
    {
        /// <summary>
        /// 读取TB_PARTICIPATE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTbParticipates(TB_PARTICIPATE model, SearchCondition condition)
        {
            var result = Fw.TbParticipateService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TB_PARTICIPATE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTbParticipate(decimal ID)
        
        {
            var result = Fw.TbParticipateService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TB_PARTICIPATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTbParticipate(TB_PARTICIPATE model)
        {
            var result = Fw.TbParticipateService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TB_PARTICIPATE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTbParticipate(TB_PARTICIPATE model)
        {
            var result = Fw.TbParticipateService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TB_PARTICIPATE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTbParticipate(string ids)
        {
            var result = Fw.TbParticipateService.Delete(ids);
            return JResult(result); 
        }
    }
}