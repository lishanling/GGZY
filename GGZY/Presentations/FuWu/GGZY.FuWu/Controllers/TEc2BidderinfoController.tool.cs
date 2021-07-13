using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2BidderinfoController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_BIDDERINFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Bidderinfos(T_EC2_BIDDERINFO model, SearchCondition condition)
        {
            var result = Fw.TEc2BidderinfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_BIDDERINFO明细
        /// </summary>
      /// <param name="BIDDERCODE">投标人代码</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Bidderinfo(string BIDDERCODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2BidderinfoService.ViewByPk(BIDDERCODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_BIDDERINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Bidderinfo(T_EC2_BIDDERINFO model)
        {
            var result = Fw.TEc2BidderinfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_BIDDERINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Bidderinfo(T_EC2_BIDDERINFO model)
        {
            var result = Fw.TEc2BidderinfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_BIDDERINFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Bidderinfo(string ids)
        {
            var result = Fw.TEc2BidderinfoService.Delete(ids);
            return JResult(result); 
        }
    }
}