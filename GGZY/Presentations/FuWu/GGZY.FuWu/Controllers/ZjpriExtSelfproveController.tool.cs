using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriExtSelfproveController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_EXT_SELFPROVE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriExtSelfproves(ZJPRI_EXT_SELFPROVE model, SearchCondition condition)
        {
            var result = Fw.ZjpriExtSelfproveService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_EXT_SELFPROVE明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriExtSelfprove(string ID)
        
        {
            var result = Fw.ZjpriExtSelfproveService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_EXT_SELFPROVE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriExtSelfprove(ZJPRI_EXT_SELFPROVE model)
        {
            var result = Fw.ZjpriExtSelfproveService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_EXT_SELFPROVE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriExtSelfprove(ZJPRI_EXT_SELFPROVE model)
        {
            var result = Fw.ZjpriExtSelfproveService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_EXT_SELFPROVE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriExtSelfprove(string ids)
        {
            var result = Fw.ZjpriExtSelfproveService.Delete(ids);
            return JResult(result); 
        }
    }
}