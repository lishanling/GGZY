using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdPtTjDataController:BaseController
    {
        /// <summary>
        /// 读取PT_TJ_DATA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadPtTjDatas(PT_TJ_DATA model, SearchCondition condition)
        {
            var result = Fw.PtTjDataService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取PT_TJ_DATA明细
        /// </summary>
      /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadPtTjData(decimal ID)
        
        {
            var result = Fw.PtTjDataService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建PT_TJ_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreatePtTjData(PT_TJ_DATA model)
        {
            var result = Fw.PtTjDataService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新PT_TJ_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdatePtTjData(PT_TJ_DATA model)
        {
            var result = Fw.PtTjDataService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除PT_TJ_DATA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeletePtTjData(string ids)
        {
            var result = Fw.PtTjDataService.Delete(ids);
            return JResult(result); 
        }
    }
}