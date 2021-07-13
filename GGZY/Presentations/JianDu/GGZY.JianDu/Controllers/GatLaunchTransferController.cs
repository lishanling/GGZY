using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Framework.Controllers;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GGZY.JianDu.Controllers
{
    public class GatLaunchTransferController : BaseController
    {
        /// <summary>
        /// 公安厅外网系统-移送来源-移送对象
        /// 根据角色名称读取部门列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="RoleName"></param>
        /// <param name="DeptName"></param>
        /// <param name="AreaCode"></param>
        /// <returns></returns>
        public ActionResult ReadDepartByRole(SearchCondition search, string RoleName = "公安厅",
          string DeptName = "", string AreaCode = "")
        {
            var result = Jd.TUserService.PageTableClueByRoleName(search, DeptName, AreaCode, RoleName);
            return JResult(result);
        }

        /// <summary>
        /// 公安厅外网系统-移送功能
        /// </summary>
        /// <param name="record"></param>
        /// <param name="project"></param>
        /// <param name="entity"></param>
        /// <param name="person">移送人员</param>
        /// <param name="VIOLATION_RECORD"></param>
        /// <param name="ATTACHMENTS">附件信息</param>
        /// <returns></returns>
        public ActionResult Trans(JC_TRANS_RECORD record, JC_TRANS_PROJECT project,
            JC_TRANS_ENTITY entity,
            JC_TRANS_PERSON person,
            List<JC_TRANS_DETAIL> VIOLATION_RECORD,
            List<UploadResData> ATTACHMENTS)
        {

            var result = Jd.JcTransRecordService.Trans(record, project, VIOLATION_RECORD, entity, person, ATTACHMENTS);
            return JResult(result);

        }
    }
}