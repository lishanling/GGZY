using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdPtComplainController:BaseController
    {
        /// <summary>
        /// 读取PT_COMPLAIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtComplains(PT_COMPLAIN model, SearchCondition condition)
        {
            var result = Jd.PtComplainService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_COMPLAIN明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtComplain(decimal ID)
        
        {
            var result = Jd.PtComplainService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_COMPLAIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtComplain(PT_COMPLAIN model)
        {
            var result = Jd.PtComplainService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_COMPLAIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtComplain(PT_COMPLAIN model)
        {
            var result = Jd.PtComplainService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_COMPLAIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtComplain(string ids)
        {
            var result = Jd.PtComplainService.Delete(ids);
            return JResult(result); 
        }
    }
}