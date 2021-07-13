using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2BidinviteController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_BIDINVITE列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Bidinvites(T_EC2_BIDINVITE model, SearchCondition condition)
        {
            var result = Fw.TEc2BidinviteService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_BIDINVITE明细
        /// </summary>
      /// <param name="BIDINVITECODE">投标邀请书编号</param>
      /// <param name="BIDSECTIONCODE">标段（包）编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Bidinvite(string BIDINVITECODE,string BIDSECTIONCODE)
        
        {
            var result = Fw.TEc2BidinviteService.ViewByPk(BIDINVITECODE,BIDSECTIONCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_BIDINVITE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Bidinvite(T_EC2_BIDINVITE model)
        {
            var result = Fw.TEc2BidinviteService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_BIDINVITE信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Bidinvite(T_EC2_BIDINVITE model)
        {
            var result = Fw.TEc2BidinviteService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_BIDINVITE信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Bidinvite(string ids)
        {
            var result = Fw.TEc2BidinviteService.Delete(ids);
            return JResult(result); 
        }
    }
}