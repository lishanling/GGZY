using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdQualiInqueryClariController:BaseController
    {
        /// <summary>
        /// 读取QUALI_INQUERY_CLARI列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadQualiInqueryClaris(QUALI_INQUERY_CLARI model, SearchCondition condition)
        {
            var result = Fw.QualiInqueryClariService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取QUALI_INQUERY_CLARI明细
        /// </summary>
      /// <param name="M_ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadQualiInqueryClari(decimal M_ID)
        
        {
            var result = Fw.QualiInqueryClariService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建QUALI_INQUERY_CLARI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateQualiInqueryClari(QUALI_INQUERY_CLARI model)
        {
            var result = Fw.QualiInqueryClariService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新QUALI_INQUERY_CLARI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateQualiInqueryClari(QUALI_INQUERY_CLARI model)
        {
            var result = Fw.QualiInqueryClariService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除QUALI_INQUERY_CLARI信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteQualiInqueryClari(string ids)
        {
            var result = Fw.QualiInqueryClariService.Delete(ids);
            return JResult(result); 
        }
    }
}