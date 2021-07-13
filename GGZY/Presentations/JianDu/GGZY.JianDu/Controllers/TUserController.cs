using System.Web.Mvc;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.JianDu;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTUserController
    {
        /// <summary>
        /// 当前登录用户相同部门人员信息（启用状态 工作台用户 IS_ENABLE == 1 TYPE == "0"）
        /// 投诉处理选择经办人
        /// </summary>
        /// <returns></returns>
        public ActionResult ComplaintAcceptUser()
        {

            var r = Jd.TUserService.FindUerByDepartId();
            return JResult(r);
        }

        #region 个人设置 邮箱 电话 密码修改


        public ActionResult ProfileInfo()
        {
            var profile = Jd.TUserService.JdUserInfo();
            return JResult(profile);
        }
        /// <summary>
        /// 个人设置-绑定邮箱
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult BindEmail(ProfileModel model)
        {
            var r = Jd.TUserService.BindEmail(model, CheckCode);
            return JResult(r);
        }
        /// <summary>
        /// 个人设置-绑定手机
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult BindMobile(ProfileModel model)
        {
            var r = Jd.TUserService.BindMobile(model);
            return JResult(r);
        }
        /// <summary>
        /// 个人设置-短信提醒
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SetMsgRemind(ProfileModel model)
        {
            var r = Jd.TUserService.SetMsgRemind(model);
            return JResult(r);
        }
        /// <summary>
        /// 个人设置-修改密码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult ChangePwd(ProfileModel model)
        {
            var r = Jd.TUserService.ChangePwd(model);
            return JResult(r);
        }
        /// <summary>
        /// 个人设置-基本信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult SaveUserExtend(TUserExtend model)
        {
            var r = Jd.TUserExtendService.SaveUserExtend(model);
            return JResult(r);
        }


        #endregion

        #region 监督首页统计


        #region 当前登录用户部门地区列表信息
        /// <summary>
        /// 当前登录用户部门地区列表信息
        /// </summary>
        /// <returns></returns>
        public ActionResult JdUserDepartRegions()
        {
            var r = Jd.TUserService.JdUserDepartRegions();
            return JResult(r);
        }

        #endregion 

     

        #region 获取登录用户部门行业类型

        /// <summary>
        /// GetUerHyType
        /// </summary>
        /// <returns></returns>
        public ActionResult JdUserDepartIndustries()
        {
            var r = Jd.TUserService.JdUserDepartIndustries();
            return JResult(r);
        }

        #endregion

        #endregion
    }
}