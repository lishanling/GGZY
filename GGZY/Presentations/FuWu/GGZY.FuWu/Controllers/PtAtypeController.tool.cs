using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtAtypeController:BaseController
    {
        /// <summary>
        /// 读取PT_ATYPE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtAtypes(PT_ATYPE model, SearchCondition condition)
        {
            var result = Fw.PtAtypeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_ATYPE明细
        /// </summary>
      /// <param name="ID">编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtAtype(decimal ID)
        
        {
            var result = Fw.PtAtypeService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_ATYPE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtAtype(PT_ATYPE model)
        {
            var result = Fw.PtAtypeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_ATYPE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtAtype(PT_ATYPE model)
        {
            var result = Fw.PtAtypeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_ATYPE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtAtype(string ids)
        {
            var result = Fw.PtAtypeService.Delete(ids);
            return JResult(result); 
        }
    }
}