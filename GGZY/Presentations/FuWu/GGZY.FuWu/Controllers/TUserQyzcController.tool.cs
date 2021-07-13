using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTUserQyzcController:BaseController
    {
        /// <summary>
        /// 读取T_USER_QYZC列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTUserQyzcs(T_USER_QYZC model, SearchCondition condition)
        {
            var result = Fw.TUserQyzcService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_USER_QYZC明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTUserQyzc(decimal ID)
        
        {
            var result = Fw.TUserQyzcService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_USER_QYZC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTUserQyzc(T_USER_QYZC model)
        {
            var result = Fw.TUserQyzcService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_USER_QYZC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTUserQyzc(T_USER_QYZC model)
        {
            var result = Fw.TUserQyzcService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_USER_QYZC信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTUserQyzc(string ids)
        {
            var result = Fw.TUserQyzcService.Delete(ids);
            return JResult(result); 
        }
    }
}