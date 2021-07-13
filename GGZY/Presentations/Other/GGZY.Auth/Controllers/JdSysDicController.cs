using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYJD.DbEntity;

namespace GGZY.Auth.Controllers
{
    public class JdSysDicController:BaseController
    {
        #region 监督平台

        /// <summary>
        /// 读取SYS_DIC列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadSysDics(SYS_DIC model, SearchCondition condition)
        {
            var result = Jd.SysDicService.PageList(model, condition).ToPageTableResult(condition);
            return JResult(result);
        }
        /// <summary>
        /// 读取SYS_DIC明细
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        /// <returns></returns>
        public ActionResult ReadSysDic(decimal ID)

        {
            var result = Jd.SysDicService.ViewByPk(ID);
            return JResult(result);
        }
        /// <summary>
        /// 创建SYS_DIC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateSysDic(SYS_DIC model)
        {
            //model.ID = 0;
            var result = Jd.SysDicService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新SYS_DIC信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateSysDic(SYS_DIC model)
        {
            var result = Jd.SysDicService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除SYS_DIC信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteSysDic(string ids)
        {
            var result = Jd.SysDicService.Delete(ids);
            return JResult(result);
        }

        #endregion
    }
}