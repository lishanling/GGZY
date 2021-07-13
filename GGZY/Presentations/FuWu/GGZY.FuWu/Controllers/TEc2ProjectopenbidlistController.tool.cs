using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2ProjectopenbidlistController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_PROJECTOPENBIDLIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Projectopenbidlists(T_EC2_PROJECTOPENBIDLIST model, SearchCondition condition)
        {
            var result = Fw.TEc2ProjectopenbidlistService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_PROJECTOPENBIDLIST明细
        /// </summary>
      /// <param name="PROJECTOPENBIDLISTCODE">开标明细（工程）编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Projectopenbidlist(string PROJECTOPENBIDLISTCODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2ProjectopenbidlistService.ViewByPk(PROJECTOPENBIDLISTCODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_PROJECTOPENBIDLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Projectopenbidlist(T_EC2_PROJECTOPENBIDLIST model)
        {
            var result = Fw.TEc2ProjectopenbidlistService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_PROJECTOPENBIDLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Projectopenbidlist(T_EC2_PROJECTOPENBIDLIST model)
        {
            var result = Fw.TEc2ProjectopenbidlistService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_PROJECTOPENBIDLIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Projectopenbidlist(string ids)
        {
            var result = Fw.TEc2ProjectopenbidlistService.Delete(ids);
            return JResult(result); 
        }
    }
}