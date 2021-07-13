using System;
using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTProjectDataController:BaseController
    {
        /// <summary>
        /// 读取T_PROJECT_DATA列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTProjectDatas(T_PROJECT_DATA model, SearchCondition condition)
        {
            var result = Jd.TProjectDataService.PageList(model, condition).ToPageTableResult(condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_PROJECT_DATA明细
        /// </summary>
      /// <param name="ID">ID</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTProjectData(decimal ID)
        
        {
            var result = Jd.TProjectDataService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_PROJECT_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTProjectData(T_PROJECT_DATA model)
        {
            var result = Jd.TProjectDataService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_PROJECT_DATA信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTProjectData(T_PROJECT_DATA model)
        {
            var result = Jd.TProjectDataService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_PROJECT_DATA信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTProjectData(string ids)
        {
            var result = Jd.TProjectDataService.Delete(ids);
            return JResult(result); 
        }
    }
}