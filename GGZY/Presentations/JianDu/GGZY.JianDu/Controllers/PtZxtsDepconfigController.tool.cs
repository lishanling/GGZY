using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdPtZxtsDepconfigController:BaseController
    {
        /// <summary>
        /// 读取PT_ZXTS_DEPCONFIG列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtZxtsDepconfigs(PT_ZXTS_DEPCONFIG model, SearchCondition condition)
        {
            var result = Jd.PtZxtsDepconfigService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_ZXTS_DEPCONFIG明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtZxtsDepconfig(decimal ID)
        
        {
            var result = Jd.PtZxtsDepconfigService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_ZXTS_DEPCONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtZxtsDepconfig(PT_ZXTS_DEPCONFIG model)
        {
            var result = Jd.PtZxtsDepconfigService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_ZXTS_DEPCONFIG信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtZxtsDepconfig(PT_ZXTS_DEPCONFIG model)
        {
            var result = Jd.PtZxtsDepconfigService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_ZXTS_DEPCONFIG信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtZxtsDepconfig(string ids)
        {
            var result = Jd.PtZxtsDepconfigService.Delete(ids);
            return JResult(result); 
        }
    }
}