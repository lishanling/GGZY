using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdBiderExInfoController:BaseController
    {
        /// <summary>
        /// 读取BIDER_EX_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadBiderExInfos(BIDER_EX_INFO model, SearchCondition condition)
        {
            var result = Fw.BiderExInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取BIDER_EX_INFO明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadBiderExInfo(decimal M_ID)
        
        {
            var result = Fw.BiderExInfoService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建BIDER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateBiderExInfo(BIDER_EX_INFO model)
        {
            var result = Fw.BiderExInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新BIDER_EX_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateBiderExInfo(BIDER_EX_INFO model)
        {
            var result = Fw.BiderExInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除BIDER_EX_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteBiderExInfo(string ids)
        {
            var result = Fw.BiderExInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}