using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdZjpriConstructQualiInfoController:BaseController
    {
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_QUALI_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadZjpriConstructQualiInfos(ZJPRI_CONSTRUCT_QUALI_INFO model, SearchCondition condition)
        {
            var result = Fw.ZjpriConstructQualiInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ZJPRI_CONSTRUCT_QUALI_INFO明细
        /// </summary>
      /// <param name="QUALIFYID">资质信息主键</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadZjpriConstructQualiInfo(decimal QUALIFYID)
        
        {
            var result = Fw.ZjpriConstructQualiInfoService.ViewByPk(QUALIFYID);
            return JResult(result);
        }
        /// <summary>
        /// 创建ZJPRI_CONSTRUCT_QUALI_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateZjpriConstructQualiInfo(ZJPRI_CONSTRUCT_QUALI_INFO model)
        {
            var result = Fw.ZjpriConstructQualiInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ZJPRI_CONSTRUCT_QUALI_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateZjpriConstructQualiInfo(ZJPRI_CONSTRUCT_QUALI_INFO model)
        {
            var result = Fw.ZjpriConstructQualiInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ZJPRI_CONSTRUCT_QUALI_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteZjpriConstructQualiInfo(string ids)
        {
            var result = Fw.ZjpriConstructQualiInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}