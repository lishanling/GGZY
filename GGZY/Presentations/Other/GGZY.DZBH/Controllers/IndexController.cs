using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZY.Services.DZBH.ParamModel;
using GGZYFW.DbEntity;

namespace GGZY.DZBH.Controllers
{
    [AllowAnonymous]
    public class IndexController : BaseController
    {
        /// <summary>
        /// 添加申请单信息
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="status"></param>
        /// <param name="QUALFICATION_FILE"></param>
        /// <param name="BUSINESS_LICENSE"></param>
        /// <param name="TENDER_FILE"></param>
        /// <returns></returns>
        public ActionResult Add(BH_SEND_APPLICATION_FORM obj, string status, List<BH_ATTACHMENT> QUALFICATION_FILE, List<BH_ATTACHMENT> BUSINESS_LICENSE, List<BH_ATTACHMENT> TENDER_FILE, string orderPdfGuid)
        {
            return JResult(Fw.DZBHService.Add(obj, status, QUALFICATION_FILE, BUSINESS_LICENSE, TENDER_FILE, orderPdfGuid));
        }
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult View(int ID)
        {
            return JResult(Fw.DZBHService.ViewByPk(ID));
        }
        /// <summary>
        /// 首页的列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public ActionResult IndexList(SearchCondition search, string status)
        {
            return JResult(Fw.DZBHService.IndexList(search, status));
        }
        public ActionResult List(ListSearchModel search)
        {
            return JResult(Fw.DZBHService.List(search));
        }
        /// <summary>
        /// 获取承保机构信息
        /// </summary>
        /// <param name="systemNo"></param>
        /// <returns></returns>
        public ActionResult GetSystemInfo(string systemNo)
        {
            return JResult(Fw.DZBHService.GetSystemInfo(systemNo));
        }
        /// <summary>
        /// 获取招标项目信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult GetTenderProjectInfo(string code)
        {
            return JResult(Fw.DZBHService.GetTenderProjectInfo(code));
        }
        /// <summary>
        /// 根据招标项目名称获取招标项目列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public ActionResult GetAutoTenderProjectName(string key)
        {
            return JResult(Fw.DZBHService.GetAutoTenderProjectName(key));
        }
        /// <summary>
        /// 获取承保机构树结构
        /// </summary>
        /// <returns></returns>
        public ActionResult GetChengBaoTree(string regionCode)
        {
            return JResult(Fw.DZBHService.GetChengBaoTree(regionCode));
        }
        /// <summary>
        /// 获取地区树结构
        /// </summary>
        /// <returns></returns>
        public ActionResult GetBhRegionTree()
        {
            return JResult(Fw.SysAreaQuanguoService.GetRegionTree());
        }
        /// <summary>
        /// 获取项目类型字典
        /// </summary>
        /// <returns></returns>
        public ActionResult GetProjectType()
        {
            return JResult(Fw.DZBHService.GetProjectType());
        }
        /// <summary>
        /// 验证订单号
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult CheckOrder(string OrderId, string CheckType)
        {
            return JResult(Fw.DZBHService.CheckOrder(OrderId, CheckType));
        }
        /// <summary>
        /// 获取首页的统计数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetIndexCount()
        {
            return JResult(Fw.DZBHService.GetIndexCount());
        }
        [AllowAnonymous]
        public ActionResult RedirectToChengbao(int id)
        {
            string sendResult = "";
            string url = Fw.DZBHService.JumpToChengBao(id, out sendResult);
            if (!string.IsNullOrEmpty(url))
            {
                return Redirect(url);
            }

            return Content(string.IsNullOrEmpty(sendResult) ? "无法正确获取地址" : sendResult);
        }
        [AllowAnonymous]
        public ActionResult Reset(string orderId)
        {
            return Content(Fw.DZBHService.Reset(orderId));
        }
        [AllowAnonymous]
        public ActionResult SendToChengbao(int id)
        {
            string sendResult = Fw.DZBHService.SendToChengBao(id);

            return Content(string.IsNullOrEmpty(sendResult) ? "发送失败" : sendResult);
        }
    }
}