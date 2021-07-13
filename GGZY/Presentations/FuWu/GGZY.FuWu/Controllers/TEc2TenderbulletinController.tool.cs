using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2TenderbulletinController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_TENDERBULLETIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Tenderbulletins(T_EC2_TENDERBULLETIN model, SearchCondition condition)
        {
            var result = Fw.TEc2TenderbulletinService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_TENDERBULLETIN明细
        /// </summary>
      /// <param name="TENDERBULLETINCODE">招标公告编号</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Tenderbulletin(string TENDERBULLETINCODE,string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2TenderbulletinService.ViewByPk(TENDERBULLETINCODE,TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_TENDERBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Tenderbulletin(T_EC2_TENDERBULLETIN model)
        {
            var result = Fw.TEc2TenderbulletinService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_TENDERBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Tenderbulletin(T_EC2_TENDERBULLETIN model)
        {
            var result = Fw.TEc2TenderbulletinService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_TENDERBULLETIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Tenderbulletin(string ids)
        {
            var result = Fw.TEc2TenderbulletinService.Delete(ids);
            return JResult(result); 
        }
    }
}