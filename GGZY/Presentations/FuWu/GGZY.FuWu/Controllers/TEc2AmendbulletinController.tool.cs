using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2AmendbulletinController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_AMENDBULLETIN列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Amendbulletins(T_EC2_AMENDBULLETIN model, SearchCondition condition)
        {
            var result = Fw.TEc2AmendbulletinService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_AMENDBULLETIN明细
        /// </summary>
      /// <param name="AMENDBULLETINCODE">变更公告编号</param>
      /// <param name="ORIGINALBULLETINCODE">原公告编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Amendbulletin(string AMENDBULLETINCODE,string ORIGINALBULLETINCODE)
        
        {
            var result = Fw.TEc2AmendbulletinService.ViewByPk(AMENDBULLETINCODE,ORIGINALBULLETINCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_AMENDBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Amendbulletin(T_EC2_AMENDBULLETIN model)
        {
            var result = Fw.TEc2AmendbulletinService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_AMENDBULLETIN信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Amendbulletin(T_EC2_AMENDBULLETIN model)
        {
            var result = Fw.TEc2AmendbulletinService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_AMENDBULLETIN信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Amendbulletin(string ids)
        {
            var result = Fw.TEc2AmendbulletinService.Delete(ids);
            return JResult(result); 
        }
    }
}