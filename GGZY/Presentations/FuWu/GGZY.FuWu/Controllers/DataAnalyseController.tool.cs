using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdDataAnalyseController:BaseController
    {
        /// <summary>
        /// 读取DATA_ANALYSE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadDataAnalyses(DATA_ANALYSE model, SearchCondition condition)
        {
            var result = Fw.DataAnalyseService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取DATA_ANALYSE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadDataAnalyse(decimal ID)
        
        {
            var result = Fw.DataAnalyseService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建DATA_ANALYSE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateDataAnalyse(DATA_ANALYSE model)
        {
            var result = Fw.DataAnalyseService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新DATA_ANALYSE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateDataAnalyse(DATA_ANALYSE model)
        {
            var result = Fw.DataAnalyseService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除DATA_ANALYSE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteDataAnalyse(string ids)
        {
            var result = Fw.DataAnalyseService.Delete(ids);
            return JResult(result); 
        }
    }
}