using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTransferorExInfoController:BaseController
    {
        /// <summary>
        /// 读取TRANSFEROR_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTransferorExInfos(TRANSFEROR_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.TransferorExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TRANSFEROR_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTransferorExInfo(decimal M_ID)
        
        {
            var result = Fw.TransferorExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TRANSFEROR_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTransferorExInfo(TRANSFEROR_EX_INFO model)
        {
            var result = Fw.TransferorExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TRANSFEROR_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTransferorExInfo(TRANSFEROR_EX_INFO model)
        {
            var result = Fw.TransferorExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TRANSFEROR_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTransferorExInfo(string ids)
        {
            var result = Fw.TransferorExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}