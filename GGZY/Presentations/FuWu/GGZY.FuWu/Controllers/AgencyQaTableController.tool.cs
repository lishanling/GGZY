using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdAgencyQaTableController:BaseController
    {
        /// <summary>
        /// 读取AGENCY_QA_TABLE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadAgencyQaTables(AGENCY_QA_TABLE model, SearchCondition condition)
        {
            var result = Fw.AgencyQaTableService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取AGENCY_QA_TABLE明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadAgencyQaTable(decimal ID)
        
        {
            var result = Fw.AgencyQaTableService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建AGENCY_QA_TABLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateAgencyQaTable(AGENCY_QA_TABLE model)
        {
            var result = Fw.AgencyQaTableService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新AGENCY_QA_TABLE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateAgencyQaTable(AGENCY_QA_TABLE model)
        {
            var result = Fw.AgencyQaTableService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除AGENCY_QA_TABLE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteAgencyQaTable(string ids)
        {
            var result = Fw.AgencyQaTableService.Delete(ids);
            return JResult(result); 
        }
    }
}