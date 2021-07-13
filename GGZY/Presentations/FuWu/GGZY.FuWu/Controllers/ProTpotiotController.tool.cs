using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdProTpotiotController:BaseController
    {
        /// <summary>
        /// 读取PRO_TPOTIOT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadProTpotiots(PRO_TPOTIOT model, SearchCondition condition)
        {
            var result = Fw.ProTpotiotService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PRO_TPOTIOT明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadProTpotiot(decimal ID)
        
        {
            var result = Fw.ProTpotiotService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PRO_TPOTIOT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateProTpotiot(PRO_TPOTIOT model)
        {
            var result = Fw.ProTpotiotService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PRO_TPOTIOT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateProTpotiot(PRO_TPOTIOT model)
        {
            var result = Fw.ProTpotiotService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PRO_TPOTIOT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteProTpotiot(string ids)
        {
            var result = Fw.ProTpotiotService.Delete(ids);
            return JResult(result); 
        }
    }
}