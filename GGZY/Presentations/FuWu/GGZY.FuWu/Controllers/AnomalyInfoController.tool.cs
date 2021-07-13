using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAnomalyInfoController:BaseController
    {
        /// <summary>
        /// 读取ANOMALY_INFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAnomalyInfos(ANOMALY_INFO model, SearchCondition condition)
        {
            var result = Fw.AnomalyInfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取ANOMALY_INFO明细
        /// </summary>
      /// <param name="M_ID">数据主键id</param>
      /// <param name="M_KEY">数据M_KEY</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAnomalyInfo(decimal M_ID,string M_KEY)
        
        {
            var result = Fw.AnomalyInfoService.ViewByPk(M_ID,M_KEY);
            return JResult(result);
        }
        /// <summary>
        /// 创建ANOMALY_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAnomalyInfo(ANOMALY_INFO model)
        {
            var result = Fw.AnomalyInfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新ANOMALY_INFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAnomalyInfo(ANOMALY_INFO model)
        {
            var result = Fw.AnomalyInfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除ANOMALY_INFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAnomalyInfo(string ids)
        {
            var result = Fw.AnomalyInfoService.Delete(ids);
            return JResult(result); 
        }
    }
}