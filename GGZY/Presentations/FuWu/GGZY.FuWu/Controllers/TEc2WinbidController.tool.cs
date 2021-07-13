using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2WinbidController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_WINBID列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Winbids(T_EC2_WINBID model, SearchCondition condition)
        {
            var result = Fw.TEc2WinbidService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_WINBID明细
        /// </summary>
      /// <param name="WINBIDDERCODE">中标人编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Winbid(string WINBIDDERCODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2WinbidService.ViewByPk(WINBIDDERCODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_WINBID信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Winbid(T_EC2_WINBID model)
        {
            var result = Fw.TEc2WinbidService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_WINBID信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Winbid(T_EC2_WINBID model)
        {
            var result = Fw.TEc2WinbidService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_WINBID信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Winbid(string ids)
        {
            var result = Fw.TEc2WinbidService.Delete(ids);
            return JResult(result); 
        }
    }
}