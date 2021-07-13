using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2WincandidatebulletinController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_WINCANDIDATEBULLETIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Wincandidatebulletins(T_EC2_WINCANDIDATEBULLETIN model, SearchCondition condition)
        {
            var result = Fw.TEc2WincandidatebulletinService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_WINCANDIDATEBULLETIN明细
        /// </summary>
      /// <param name="WINCANDIDATEBULLETINCODE">中标候选人公示编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Wincandidatebulletin(string WINCANDIDATEBULLETINCODE,string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2WincandidatebulletinService.ViewByPk(WINCANDIDATEBULLETINCODE,TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_WINCANDIDATEBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Wincandidatebulletin(T_EC2_WINCANDIDATEBULLETIN model)
        {
            var result = Fw.TEc2WincandidatebulletinService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_WINCANDIDATEBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Wincandidatebulletin(T_EC2_WINCANDIDATEBULLETIN model)
        {
            var result = Fw.TEc2WincandidatebulletinService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_WINCANDIDATEBULLETIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Wincandidatebulletin(string ids)
        {
            var result = Fw.TEc2WincandidatebulletinService.Delete(ids);
            return JResult(result); 
        }
    }
}