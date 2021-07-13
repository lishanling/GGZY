using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2BidsectionController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_BIDSECTION列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Bidsections(T_EC2_BIDSECTION model, SearchCondition condition)
        {
            var result = Fw.TEc2BidsectionService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_BIDSECTION明细
        /// </summary>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Bidsection(string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2BidsectionService.ViewByPk(BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_BIDSECTION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Bidsection(T_EC2_BIDSECTION model)
        {
            var result = Fw.TEc2BidsectionService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_BIDSECTION信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Bidsection(T_EC2_BIDSECTION model)
        {
            var result = Fw.TEc2BidsectionService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_BIDSECTION信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Bidsection(string ids)
        {
            var result = Fw.TEc2BidsectionService.Delete(ids);
            return JResult(result); 
        }
    }
}