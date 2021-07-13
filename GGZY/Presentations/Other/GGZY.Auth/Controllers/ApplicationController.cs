using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Framework.Controllers;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Auth.Controllers
{

    public class ApplicationController : BaseController
    {
        #region CURD

        [AllowAnonymous]
        public ActionResult List(UNIFY_APP model,SearchCondition search)
        {
            var r=  Fw.UnifyAppService.PageList(model, search).ToPageTableResult(search);
            return JResult(r);
        }
        [AllowAnonymous]
        public ActionResult Save(UNIFY_APP model)
        {
            var r = string.IsNullOrWhiteSpace(model.MGUID)
                ? Fw.UnifyAppService.CreateApplication(model)
                : Fw.UnifyAppService.UpdateApplication(model);
            return JResult(r);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Delete(string ids)
        {
            var r = Fw.UnifyAppService.Delete(ids);
            return JResult(r);
        }

        #endregion
        /// <summary>
        /// 已授权app列表
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public ActionResult AuthApp(string uid)
        {
            var r = Fw.UnifyAuthsService.AuthApp(uid);
            return JResult(r);
        }
        /// <summary>
        /// 未授权app列表
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public ActionResult UnAuthApp(string uid)
        {
            var r = Fw.UnifyAppService.UnAuthApp(uid);
            return JResult(r);
        }

        #region 运维人员 后台管理用户应用 绑定 解除绑定

        /// <summary>
        /// 用户授权应用情况
        /// </summary>
        /// <param name="appUid"></param>
        /// <param name="appIdKey"></param>
        /// <returns></returns>
        public ActionResult UserAuthApp(string appUid, string appIdKey)
        {
            var r = Fw.UnifyAppService.FindAppByAppUid(appUid, appIdKey);
            return JResult(r);
        }
        /// <summary>
        /// 绑定应用
        /// </summary>
        /// <param name="appIdKey"></param>
        /// <param name="appUid"></param>
        /// <param name="userGuid"></param>
        /// <returns></returns>
        public ActionResult BindApp(string appIdKey,string appUid,string userGuid)
        {
            if (string.IsNullOrWhiteSpace(userGuid))
            {
                userGuid = Fw.UnifyUserService.CreateUser(appIdKey, appUid, userGuid);
            }
            var r = Fw.UnifyAuthsService.SetOAuth(appIdKey, appUid, userGuid);
            //if (!r.Success)
            //{
            //    Fw.UnifyUserService.Delete(userGuid);
            //}
            return JResult(r);
        }
        /// <summary>
        /// 删除绑定
        /// </summary>
        /// <param name="appIdKey"></param>
        /// <param name="appUid"></param>
        /// <param name="userGuid"></param>
        /// <returns></returns>
        public ActionResult UnBindApp(string appIdKey, string appUid, string userGuid)
        {
            Fw.UnifyAuthsService.RemoveOAuth(appIdKey, appUid, userGuid);
            return JResult("");
        }

        #endregion

    }
}