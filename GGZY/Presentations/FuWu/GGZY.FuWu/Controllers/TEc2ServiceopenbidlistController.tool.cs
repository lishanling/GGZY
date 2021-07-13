using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2ServiceopenbidlistController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_SERVICEOPENBIDLIST列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Serviceopenbidlists(T_EC2_SERVICEOPENBIDLIST model, SearchCondition condition)
        {
            var result = Fw.TEc2ServiceopenbidlistService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_SERVICEOPENBIDLIST明细
        /// </summary>
      /// <param name="SERVICEOPENBIDLISTCODE">开标明细（服务）编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Serviceopenbidlist(string SERVICEOPENBIDLISTCODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2ServiceopenbidlistService.ViewByPk(SERVICEOPENBIDLISTCODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_SERVICEOPENBIDLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Serviceopenbidlist(T_EC2_SERVICEOPENBIDLIST model)
        {
            var result = Fw.TEc2ServiceopenbidlistService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_SERVICEOPENBIDLIST信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Serviceopenbidlist(T_EC2_SERVICEOPENBIDLIST model)
        {
            var result = Fw.TEc2ServiceopenbidlistService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_SERVICEOPENBIDLIST信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Serviceopenbidlist(string ids)
        {
            var result = Fw.TEc2ServiceopenbidlistService.Delete(ids);
            return JResult(result); 
        }
    }
}