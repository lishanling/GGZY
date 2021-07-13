using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2TendererinfoController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_TENDERERINFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Tendererinfos(T_EC2_TENDERERINFO model, SearchCondition condition)
        {
            var result = Fw.TEc2TendererinfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_TENDERERINFO明细
        /// </summary>
      /// <param name="TENDERERCODE">招标人代码</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Tendererinfo(string TENDERERCODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2TendererinfoService.ViewByPk(TENDERERCODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_TENDERERINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Tendererinfo(T_EC2_TENDERERINFO model)
        {
            var result = Fw.TEc2TendererinfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_TENDERERINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Tendererinfo(T_EC2_TENDERERINFO model)
        {
            var result = Fw.TEc2TendererinfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_TENDERERINFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Tendererinfo(string ids)
        {
            var result = Fw.TEc2TendererinfoService.Delete(ids);
            return JResult(result); 
        }
    }
}