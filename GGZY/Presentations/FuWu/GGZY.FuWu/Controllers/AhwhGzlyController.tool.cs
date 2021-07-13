using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAhwhGzlyController:BaseController
    {
        /// <summary>
        /// 读取AHWH_GZLY列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAhwhGzlys(AHWH_GZLY model, SearchCondition condition)
        {
            var result = Fw.AhwhGzlyService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AHWH_GZLY明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAhwhGzly(decimal ID)
        
        {
            var result = Fw.AhwhGzlyService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AHWH_GZLY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAhwhGzly(AHWH_GZLY model)
        {
            var result = Fw.AhwhGzlyService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AHWH_GZLY信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAhwhGzly(AHWH_GZLY model)
        {
            var result = Fw.AhwhGzlyService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AHWH_GZLY信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAhwhGzly(string ids)
        {
            var result = Fw.AhwhGzlyService.Delete(ids);
            return JResult(result); 
        }
    }
}