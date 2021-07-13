using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2QualifybulletinController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_QUALIFYBULLETIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Qualifybulletins(T_EC2_QUALIFYBULLETIN model, SearchCondition condition)
        {
            var result = Fw.TEc2QualifybulletinService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_QUALIFYBULLETIN明细
        /// </summary>
      /// <param name="QUALIFYBULLETINCODE">资格预审公告编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Qualifybulletin(string QUALIFYBULLETINCODE,string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2QualifybulletinService.ViewByPk(QUALIFYBULLETINCODE,TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_QUALIFYBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Qualifybulletin(T_EC2_QUALIFYBULLETIN model)
        {
            var result = Fw.TEc2QualifybulletinService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_QUALIFYBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Qualifybulletin(T_EC2_QUALIFYBULLETIN model)
        {
            var result = Fw.TEc2QualifybulletinService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_QUALIFYBULLETIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Qualifybulletin(string ids)
        {
            var result = Fw.TEc2QualifybulletinService.Delete(ids);
            return JResult(result); 
        }
    }
}