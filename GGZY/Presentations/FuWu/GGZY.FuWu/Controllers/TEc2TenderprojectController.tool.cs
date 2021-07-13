using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2TenderprojectController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_TENDERPROJECT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Tenderprojects(T_EC2_TENDERPROJECT model, SearchCondition condition)
        {
            var result = Fw.TEc2TenderprojectService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_TENDERPROJECT明细
        /// </summary>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Tenderproject(string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2TenderprojectService.ViewByPk(TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_TENDERPROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Tenderproject(T_EC2_TENDERPROJECT model)
        {
            var result = Fw.TEc2TenderprojectService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_TENDERPROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Tenderproject(T_EC2_TENDERPROJECT model)
        {
            var result = Fw.TEc2TenderprojectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_TENDERPROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Tenderproject(string ids)
        {
            var result = Fw.TEc2TenderprojectService.Delete(ids);
            return JResult(result); 
        }
    }
}