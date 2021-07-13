using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAhwhNewsController:BaseController
    {
        /// <summary>
        /// 读取AHWH_NEWS列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAhwhNewss(AHWH_NEWS model, SearchCondition condition)
        {
            var result = Fw.AhwhNewsService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AHWH_NEWS明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAhwhNews(decimal ID)
        
        {
            var result = Fw.AhwhNewsService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AHWH_NEWS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAhwhNews(AHWH_NEWS model)
        {
            var result = Fw.AhwhNewsService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AHWH_NEWS信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAhwhNews(AHWH_NEWS model)
        {
            var result = Fw.AhwhNewsService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AHWH_NEWS信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAhwhNews(string ids)
        {
            var result = Fw.AhwhNewsService.Delete(ids);
            return JResult(result); 
        }
    }
}