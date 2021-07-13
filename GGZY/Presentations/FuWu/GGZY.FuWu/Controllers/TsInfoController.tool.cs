using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTsInfoController:BaseController
    {
        /// <summary>
        /// 读取TS_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTsInfos(TS_INFO model, SearchCondition condition)
        {
            var result = Fw.TsInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取TS_INFO明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTsInfo(decimal ID)
        
        {
            var result = Fw.TsInfoService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建TS_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTsInfo(TS_INFO model)
        {
            var result = Fw.TsInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新TS_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTsInfo(TS_INFO model)
        {
            var result = Fw.TsInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除TS_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTsInfo(string ids)
        {
            var result = Fw.TsInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}