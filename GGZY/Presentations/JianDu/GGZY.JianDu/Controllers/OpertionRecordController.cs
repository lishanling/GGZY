using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.JianDu.Controllers
{
    public class JdOpertionRecordController: BaseController
    {
        /// <summary>
        /// 操作记录列表
        /// </summary>
        /// <param name="record_id"></param>
        /// <returns></returns>
        public ActionResult List(int record_id)
        {
            var r = new GeneralResult();
            if (record_id == 0)
            {
                r.SetFail("参数错误");
                return JResult(r);
            }
            var data = Jd.OpertionRecordService.List(record_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
            return JResult(data);
        }
        /// <summary>
        /// 备案记录详情
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="oper_id"></param>
        /// <returns></returns>
        public ActionResult Detail(int record_id,int oper_id)
        {
            var r = new GeneralResult();
            if (record_id ==0 || oper_id ==0)
            {
                r.SetFail("参数错误");
                return JResult(r);
            }
            var data = Jd.OpertionRecordService.Detail(record_id,oper_id, id => CommonAttachmentBuilder(id, "Jd", "Sys"));
            return JResult(data);
        }
        /// <summary>
        /// 显示某招标项目的所有签章文件
        /// </summary>
        /// <param name="search"></param>
        /// <param name="tender_project_code">招标项目编号</param>
        /// <param name="is_signup">是否签章</param>
        /// <param name="review_type">备案类型</param>
        /// <returns></returns>
        public ActionResult ListSignup(SearchCondition search, string tender_project_code, int? is_signup, string review_type)
        {
            var r = new GeneralResult();
            if(String.IsNullOrEmpty(tender_project_code))
            {
                r.SetFail("招标项目编号不能为空");
                return JResult(r);
            }
            var data = Jd.OpertionRecordService.ListSignup(search, tender_project_code, is_signup, review_type,id=>CommonAttachmentBuilder(id,"Jd","Sys"));
            return JResult(data);
        }
        /// <summary>
        /// 监察痕迹-招标备案
        /// </summary>
        /// <param name="jdTenderProjectCode"></param>
        /// <returns></returns>
        public ActionResult GetBA_Logs(string jdTenderProjectCode)
        {
            var data = Jd.OpertionRecordService.GetBA_Logs(jdTenderProjectCode);
            return JResult(data);
        }
    }
}