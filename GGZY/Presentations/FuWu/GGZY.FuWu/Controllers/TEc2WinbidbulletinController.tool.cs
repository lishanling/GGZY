using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2WinbidbulletinController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_WINBIDBULLETIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Winbidbulletins(T_EC2_WINBIDBULLETIN model, SearchCondition condition)
        {
            var result = Fw.TEc2WinbidbulletinService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_WINBIDBULLETIN明细
        /// </summary>
      /// <param name="WINBIDBULLETINCODE">中标公告编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Winbidbulletin(string WINBIDBULLETINCODE,string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2WinbidbulletinService.ViewByPk(WINBIDBULLETINCODE,TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_WINBIDBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Winbidbulletin(T_EC2_WINBIDBULLETIN model)
        {
            var result = Fw.TEc2WinbidbulletinService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_WINBIDBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Winbidbulletin(T_EC2_WINBIDBULLETIN model)
        {
            var result = Fw.TEc2WinbidbulletinService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_WINBIDBULLETIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Winbidbulletin(string ids)
        {
            var result = Fw.TEc2WinbidbulletinService.Delete(ids);
            return JResult(result); 
        }
    }
}