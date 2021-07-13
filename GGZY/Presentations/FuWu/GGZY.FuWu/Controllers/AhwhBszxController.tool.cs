using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAhwhBszxController:BaseController
    {
        /// <summary>
        /// 读取AHWH_BSZX列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAhwhBszxs(AHWH_BSZX model, SearchCondition condition)
        {
            var result = Fw.AhwhBszxService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AHWH_BSZX明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAhwhBszx(decimal ID)
        
        {
            var result = Fw.AhwhBszxService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AHWH_BSZX信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAhwhBszx(AHWH_BSZX model)
        {
            var result = Fw.AhwhBszxService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AHWH_BSZX信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAhwhBszx(AHWH_BSZX model)
        {
            var result = Fw.AhwhBszxService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AHWH_BSZX信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAhwhBszx(string ids)
        {
            var result = Fw.AhwhBszxService.Delete(ids);
            return JResult(result); 
        }
    }
}