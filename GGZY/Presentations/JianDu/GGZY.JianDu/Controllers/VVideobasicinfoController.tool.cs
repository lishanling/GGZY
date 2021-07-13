using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdVVideobasicinfoController:BaseController
    {
        /// <summary>
        /// 读取V_VIDEOBASICINFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadVVideobasicinfos(V_VIDEOBASICINFO model, SearchCondition condition)
        {
            var result = Jd.VVideobasicinfoService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取V_VIDEOBASICINFO明细
        /// </summary>
      /// <param name="VID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadVVideobasicinfo(decimal VID)
        
        {
            var result = Jd.VVideobasicinfoService.ViewByPk(VID);
            return JResult(result);
        }
        /// <summary>
        /// 创建V_VIDEOBASICINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateVVideobasicinfo(V_VIDEOBASICINFO model)
        {
            var result = Jd.VVideobasicinfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新V_VIDEOBASICINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateVVideobasicinfo(V_VIDEOBASICINFO model)
        {
            var result = Jd.VVideobasicinfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除V_VIDEOBASICINFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteVVideobasicinfo(string ids)
        {
            var result = Jd.VVideobasicinfoService.Delete(ids);
            return JResult(result); 
        }
    }
}