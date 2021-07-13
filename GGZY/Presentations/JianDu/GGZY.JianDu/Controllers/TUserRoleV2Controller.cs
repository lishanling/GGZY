using System;
using System.Web.Mvc;
using GGZY.Core.Extensions;
using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYJD.DbEntity;

namespace GGZY.JianDu.Controllers
{
    public partial class JdTUserRoleV2Controller : BaseController
    {

        /// <summary>
        /// 监督平台用户角色组权限设置
        /// </summary>
        /// <param name="group"></param>
        /// <param name="auth"></param>
        /// <returns></returns>
        public ActionResult SaveAuthGroupItem(GeneralAuthGroup group, GeneralAuthRule auth)
        {
            var r = Jd.TUserRoleV2Service.SaveAuthGroupItem(group,auth);
            return JResult(r);
        }
        /// <summary>
        /// 添加一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        [Route("auth_group/method/add.auth.group.item")]
        [Route("TUserRoleV2/AddAuthGroupItem")]
        public ActionResult AddAuthGroupItem(GeneralAuthGroup group)
        {
            var r = Jd.TUserRoleV2Service.AddAuthGroupItem(group);
            return JResult(r);
        }
        /// <summary>
        /// 编辑一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        [Route("auth_group/method/set.auth.group.item")]
        [Route("TUserRoleV2/SetAuthGroupItem")]
        public ActionResult SetAuthGroupItem(GeneralAuthGroup group)
        {
            var r = Jd.TUserRoleV2Service.SetAuthGroupItem(group);
            return JResult(r);
        }
        /// <summary>
        /// 获取一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        [Route("auth_group/method/get.auth.group.item")]
        [Route("TUserRoleV2/GetAuthGroupItem")]
        public ActionResult GetAuthGroupItem(GeneralAuthGroup group)
        {
            var r = Jd.TUserRoleV2Service.GetAuthGroupItem(group);
            return JResult(r);
        }
        /// <summary>
        /// 获取用户组列表
        /// </summary>
        /// <param name="group"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        [Route("auth_group/method/get.auth.group.list")]
        [Route("TUserRoleV2/GetAuthGroupList")]
        public ActionResult GetAuthGroupList(GeneralAuthGroup group,SearchCondition search)
        {
            var r = Jd.TUserRoleV2Service.GetAuthGroupList(group,search);
            return JResult(r);
        }
        /// <summary>
        /// 删除一个用户组
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        [Route("auth_group/method/del.auth.group.item")]
        [Route("TUserRoleV2/DelAuthGroupItem")]
        public ActionResult DelAuthGroupItem(GeneralAuthGroup group)
        {
            var r = Jd.TUserRoleV2Service.DelAuthGroupItem(group);
            return JResult(r);
        }
        /// <summary>
        /// 设置用户组状态
        /// </summary>
        /// <param name="group"></param>
        [Route("auth_group/method/set.auth.group.status")]
        [Route("TUserRoleV2/SetAuthGroupStatus")]
        public ActionResult SetAuthGroupStatus(GeneralAuthGroup group)
        {
            Jd.TUserRoleV2Service.SetAuthGroupStatus(group);
            return JResult(true);
        }
        /// <summary>
        /// 设置用户组排序
        /// </summary>
        /// <param name="group"></param>
        [Route("auth_group/method/set.auth.group.sort")]
        [Route("TUserRoleV2/SetAuthGroupSort")]
        public ActionResult SetAuthGroupSort(GeneralAuthGroup group)
        {
            Jd.TUserRoleV2Service.SetAuthGroupSort(group);
            return JResult(true);
        }
    }
}