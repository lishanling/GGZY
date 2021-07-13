using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdCompareSelectAnnController:BaseController
    {
        /// <summary>
        /// 读取COMPARE_SELECT_ANN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadCompareSelectAnns(COMPARE_SELECT_ANN model, SearchCondition condition)
        {
            var result = Fw.CompareSelectAnnService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取COMPARE_SELECT_ANN明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadCompareSelectAnn(decimal M_ID)
        
        {
            var result = Fw.CompareSelectAnnService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建COMPARE_SELECT_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateCompareSelectAnn(COMPARE_SELECT_ANN model)
        {
            var result = Fw.CompareSelectAnnService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新COMPARE_SELECT_ANN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateCompareSelectAnn(COMPARE_SELECT_ANN model)
        {
            var result = Fw.CompareSelectAnnService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除COMPARE_SELECT_ANN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteCompareSelectAnn(string ids)
        {
            var result = Fw.CompareSelectAnnService.Delete(ids);
            return JResult(result); 
        }
    }
}