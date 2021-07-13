using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriConstructEnterInfoController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_ENTER_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriConstructEnterInfos(ZJPRI_CONSTRUCT_ENTER_INFO model, SearchCondition condition)
        {
            var result = Fw.ZjpriConstructEnterInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_ENTER_INFO明细
        /// </summary>
      /// <param name="ID">主键GUID默认生成</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriConstructEnterInfo(string ID)
        
        {
            var result = Fw.ZjpriConstructEnterInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_CONSTRUCT_ENTER_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriConstructEnterInfo(ZJPRI_CONSTRUCT_ENTER_INFO model)
        {
            var result = Fw.ZjpriConstructEnterInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_CONSTRUCT_ENTER_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriConstructEnterInfo(ZJPRI_CONSTRUCT_ENTER_INFO model)
        {
            var result = Fw.ZjpriConstructEnterInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_CONSTRUCT_ENTER_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriConstructEnterInfo(string ids)
        {
            var result = Fw.ZjpriConstructEnterInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}