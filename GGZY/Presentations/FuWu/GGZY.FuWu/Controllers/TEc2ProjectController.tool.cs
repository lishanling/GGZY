using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2ProjectController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_PROJECT列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Projects(T_EC2_PROJECT model, SearchCondition condition)
        {
            var result = Fw.TEc2ProjectService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_PROJECT明细
        /// </summary>
      /// <param name="PROJECTCODE">项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Project(string PROJECTCODE)
        
        {
            var result = Fw.TEc2ProjectService.ViewByPk(PROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Project(T_EC2_PROJECT model)
        {
            var result = Fw.TEc2ProjectService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_PROJECT信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Project(T_EC2_PROJECT model)
        {
            var result = Fw.TEc2ProjectService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_PROJECT信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Project(string ids)
        {
            var result = Fw.TEc2ProjectService.Delete(ids);
            return JResult(result); 
        }
    }
}