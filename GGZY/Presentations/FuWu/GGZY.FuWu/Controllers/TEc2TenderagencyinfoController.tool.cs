using System.Web.Mvc;using GGZY.Framework.Controllers;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.FuWu.Controllers
{
    public partial class JdTEc2TenderagencyinfoController:BaseController
    {
        /// <summary>
        /// 读取T_EC2_TENDERAGENCYINFO列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public ActionResult ReadTEc2Tenderagencyinfos(T_EC2_TENDERAGENCYINFO model, SearchCondition condition)
        {
            var result = Fw.TEc2TenderagencyinfoService.PageList(model, condition);           
            return JResult(result);
        }
        /// <summary>
        /// 读取T_EC2_TENDERAGENCYINFO明细
        /// </summary>
      /// <param name="TENDERAGENCYCODE">招标代理机构代码</param>
      /// <param name="TENDERPROJECTCODE">招标项目编号</param>
        /// <returns></returns>
        /// <returns></returns>
       public ActionResult ReadTEc2Tenderagencyinfo(string TENDERAGENCYCODE,string TENDERPROJECTCODE)
        
        {
            var result = Fw.TEc2TenderagencyinfoService.ViewByPk(TENDERAGENCYCODE,TENDERPROJECTCODE);
            return JResult(result);
        }
        /// <summary>
        /// 创建T_EC2_TENDERAGENCYINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult CreateTEc2Tenderagencyinfo(T_EC2_TENDERAGENCYINFO model)
        {
            var result = Fw.TEc2TenderagencyinfoService.Add(model);
            return JResult(result);
        }
        /// <summary>
        /// 更新T_EC2_TENDERAGENCYINFO信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult UpdateTEc2Tenderagencyinfo(T_EC2_TENDERAGENCYINFO model)
        {
            var result = Fw.TEc2TenderagencyinfoService.Edit(model);
            return JResult(result);
        }
        /// <summary>
        /// 删除T_EC2_TENDERAGENCYINFO信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult DeleteTEc2Tenderagencyinfo(string ids)
        {
            var result = Fw.TEc2TenderagencyinfoService.Delete(ids);
            return JResult(result); 
        }
    }
}