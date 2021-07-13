using GGZY.Core.Models;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GGZY.Framework.Controllers
{
    /// <summary>
    /// 执纪系统、大数据相关功能接口
    /// </summary>
    public partial class CommonInfoController:BaseController
    {
        /// <summary>
        /// 站点选择插件（招标项目）
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult TenderProjects(GGZYFW.DbEntity.TENDER_PROJECT model, SearchCondition search)
        {
            var r = Fw.TenderProjectService.PageTable(model, search);
            return JResult(r);
        }

        /// <summary>
        /// 疑似违规点代码
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult ViolationRecords(BD_VIOLATION_RECORD_REQUEST model,SearchCondition search)
        {
            if (!String.IsNullOrWhiteSpace(model.TENDER_PROJECT_CODE))
            {
                var data = Fw.BdViolationRecordService.List(search, model.AREA_CODE, model.POINT_CODE,
                  model.DATETIME_START, model.DATETIME_END, model.STATE,
                  model.TENDER_PROJECT_CODE, model.TENDER_PROJECT_NAME,model.TENDER_PROJECT_TYPE);
                return JResult(data);
            }
            if (!String.IsNullOrWhiteSpace(model.ENTITY_CODE))
            {
                var dataEntity = Fw.BdViolationEntityService.List(search, model.AREA_CODE, model.POINT_CODE,
                  model.DATETIME_START, model.DATETIME_END, model.STATE,
                  model.ENTITY_CODE, model.ENTITY_NAME, null);
                return JResult(dataEntity);
            }
            GeneralResult r = new GeneralResult();
            r.SetFail("招标项目编号/实体统一社会信用代码 不能都为空");
            return JResult(r);
        }               

        /// <summary>
        /// 根据招标项目信息查询监督点列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="TENDER_PROJECT_CODE"></param>
        /// <param name="TENDER_PROJECT_NAME"></param>
        /// <returns></returns>
        public ActionResult SupervisionPoints(SearchCondition search,string TENDER_PROJECT_CODE="",string TENDER_PROJECT_NAME="")
        {
            if(String.IsNullOrEmpty(TENDER_PROJECT_NAME) && String.IsNullOrWhiteSpace(TENDER_PROJECT_CODE))
            {
                var r = new GeneralResult();
                r.SetFail("招标项目编号/招标项目名称不能都为空");
                return JResult(r);
            }
            var data = Fw.WarnResultService.PageTable(search,TENDER_PROJECT_CODE,TENDER_PROJECT_NAME);
            return JResult(data);
        }
        /// <summary>
        /// 公共服务平台主体信息列表-适用于弹框选择
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public ActionResult Entities(GGZYFW.DbEntity.LEGAL_PERSON_BASE model,SearchCondition search)
        {
            var data = Fw.LegalPersonBaseService.PageTable(model, search);
            return JResult(data);
        }
        /// <summary>
        /// 移送功能
        /// </summary>
        /// <param name="record"></param>
        /// <param name="project"></param>
        /// <param name="entity"></param>
        /// <param name="person">移送人员</param>
        /// <param name="VIOLATION_RECORD"></param>
        /// <param name="ATTACHMENTS">附件信息</param>
        /// <returns></returns>
        public ActionResult Trans(JC_TRANS_RECORD record,JC_TRANS_PROJECT project,
            JC_TRANS_ENTITY entity,
            JC_TRANS_PERSON person,
            List<JC_TRANS_DETAIL> VIOLATION_RECORD,
            List<UploadResData> ATTACHMENTS)
        {

            var result = Jd.JcTransRecordService.Trans(record, project, VIOLATION_RECORD,entity,person, ATTACHMENTS);
            return JResult(result);

        }
        /// <summary>
        /// 添加移送处理结果
        /// </summary>
        /// <param name="result"></param>
        /// <param name="ATTACHMENTS">attachments</param>
        /// <returns></returns>
        public ActionResult SubmitResult(JC_TRANS_RESULT result, List<UploadResData> ATTACHMENTS)
        {
            var r = new GeneralResult();
            if(String.IsNullOrWhiteSpace(result.RECORD_ID))
            {
                r.SetFail("移送记录ID不能为空");
                return JResult(r);
            }
            var record = Jd.JcTransRecordService.FirstOrNull(JC_TRANS_RECORD._.ID == result.RECORD_ID);
            if(null == record)
            {
                r.SetFail("移送记录不存在或已删除");
                return JResult(r);
            }
            switch(record.TRANS_TYPE)
            {
                case 1:
                    result.F_RECORD_ID = Jd.JcTransProjectService.FirstOrNull(JC_TRANS_PROJECT._.RECORD_ID ==
                        record.ID)?.ID;
                    break;
                case 2:
                    result.F_RECORD_ID = Jd.JcTransEntityService.FirstOrNull(JC_TRANS_ENTITY._.RECORD_ID ==
                        record.ID)?.ID;
                    break;
                default:
                    break;
            }
            r= Jd.JcTransResultService.Submit(record, result, ATTACHMENTS);
            return JResult(r);
        }

    }

    public class BD_VIOLATION_RECORD_REQUEST
    {
        public string ENTITY_CODE { get; set; }
        public string ENTITY_NAME { get; set; }
        /// <summary>
        /// 招标项目代码
        /// </summary>
        public string TENDER_PROJECT_CODE { get; set; }
        /// <summary>
        /// 招标项目名称
        /// </summary>
        public string TENDER_PROJECT_NAME { get; set; }
        /// <summary>
        /// 行业类型
        /// </summary>
        public string TENDER_PROJECT_TYPE { get; set; }
        /// <summary>
        /// 地区编码
        /// </summary>
        public string AREA_CODE { get; set; }

        public DateTime? DATETIME_START { get; set; }

        public DateTime? DATETIME_END { get; set; }
        /// <summary>
        /// 疑似违规点代码
        /// </summary>
        public string POINT_CODE { get; set; }

        public decimal? STATE { get; set; }

    }
}