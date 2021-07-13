using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAhwhXzfwController:BaseController
    {
        /// <summary>
        /// 读取AHWH_XZFW列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAhwhXzfws(AHWH_XZFW model, SearchCondition condition)
        {
            var result = Fw.AhwhXzfwService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AHWH_XZFW明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAhwhXzfw(decimal ID)
        
        {
            var result = Fw.AhwhXzfwService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AHWH_XZFW信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAhwhXzfw(AHWH_XZFW model)
        {
            var result = Fw.AhwhXzfwService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AHWH_XZFW信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAhwhXzfw(AHWH_XZFW model)
        {
            var result = Fw.AhwhXzfwService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AHWH_XZFW信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAhwhXzfw(string ids)
        {
            var result = Fw.AhwhXzfwService.Delete(ids);
            return JResult(result); 
        }
    }
}