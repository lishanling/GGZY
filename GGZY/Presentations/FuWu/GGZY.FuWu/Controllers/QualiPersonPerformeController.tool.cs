using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdQualiPersonPerformeController:BaseController
    {
        /// <summary>
        /// 读取QUALI_PERSON_PERFORME列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadQualiPersonPerformes(QUALI_PERSON_PERFORME model, SearchCondition condition)
        {
            var result = Fw.QualiPersonPerformeService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取QUALI_PERSON_PERFORME明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadQualiPersonPerforme(decimal M_ID)
        
        {
            var result = Fw.QualiPersonPerformeService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建QUALI_PERSON_PERFORME信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateQualiPersonPerforme(QUALI_PERSON_PERFORME model)
        {
            var result = Fw.QualiPersonPerformeService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新QUALI_PERSON_PERFORME信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateQualiPersonPerforme(QUALI_PERSON_PERFORME model)
        {
            var result = Fw.QualiPersonPerformeService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除QUALI_PERSON_PERFORME信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteQualiPersonPerforme(string ids)
        {
            var result = Fw.QualiPersonPerformeService.Delete(ids);
            return JResult(result); 
        }
    }
}