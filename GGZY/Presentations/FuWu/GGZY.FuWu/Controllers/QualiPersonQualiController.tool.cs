using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdQualiPersonQualiController:BaseController
    {
        /// <summary>
        /// 读取QUALI_PERSON_QUALI列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadQualiPersonQualis(QUALI_PERSON_QUALI model, SearchCondition condition)
        {
            var result = Fw.QualiPersonQualiService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取QUALI_PERSON_QUALI明细
        /// </summary>
      /// <param name="M_ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadQualiPersonQuali(decimal M_ID)
        
        {
            var result = Fw.QualiPersonQualiService.ViewByPk(M_ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建QUALI_PERSON_QUALI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateQualiPersonQuali(QUALI_PERSON_QUALI model)
        {
            var result = Fw.QualiPersonQualiService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新QUALI_PERSON_QUALI信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateQualiPersonQuali(QUALI_PERSON_QUALI model)
        {
            var result = Fw.QualiPersonQualiService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除QUALI_PERSON_QUALI信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteQualiPersonQuali(string ids)
        {
            var result = Fw.QualiPersonQualiService.Delete(ids);
            return JResult(result); 
        }
    }
}