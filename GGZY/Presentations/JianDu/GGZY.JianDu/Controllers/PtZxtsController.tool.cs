using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdPtZxtsController:BaseController
    {
        /// <summary>
        /// 读取PT_ZXTS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtZxtss(PT_ZXTS model, SearchCondition condition)
        {
            var result = Jd.PtZxtsService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_ZXTS明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtZxts(decimal ID)
        
        {
            var result = Jd.PtZxtsService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_ZXTS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtZxts(PT_ZXTS model)
        {
            var result = Jd.PtZxtsService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_ZXTS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtZxts(PT_ZXTS model)
        {
            var result = Jd.PtZxtsService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_ZXTS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtZxts(string ids)
        {
            var result = Jd.PtZxtsService.Delete(ids);
            return JResult(result); 
        }
    }
}