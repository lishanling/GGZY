using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.FuWu;
using GGZY.Services.Infrastructure.Helper;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using Newtonsoft.Json;

namespace GGZY.Services.JianDu
{
    public partial class OpertionRecordService
    {
        /// <summary>
        /// 某备案信息的操作记录列表
        /// </summary>
        /// <param name="record_id">备案id</param>
        /// <returns></returns>
		public GeneralResult List(int record_id, Func<string, string> urlBuilder)
        {
            #region sql
            /*
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT case when E.Staff is null then -1 else E.id end INSTANCE_ID,");
            sb.AppendLine("          C.MANAGE_NAME,");
            sb.AppendLine("          TO_CHAR(OPERATION_TIME,'yyyy-MM-dd HH24:mi:ss') OPERATION_TIME,");
            sb.AppendLine("          CASE OPERATION_BEHAVIOR ");
            sb.AppendLine("			  WHEN 1 THEN '提交' ");
            sb.AppendLine("			  WHEN 2 THEN '退回，不属于本部门监管的项目' ");
            sb.AppendLine("			  WHEN 3 THEN '退回，备案材料不完整' ");
            sb.AppendLine("			  WHEN 5 THEN '未发现问题' ");
            sb.AppendLine("			  WHEN 6 THEN '需整改' ");
            sb.AppendLine("			  WHEN 8 THEN '已签收' ");
            sb.AppendLine("			  WHEN 9 THEN '审查修改' ");
            sb.AppendLine("			  WHEN 10 THEN '撤回' ");
            sb.AppendLine("			  WHEN 11 THEN '重新提交' ");
            sb.AppendLine("		  END AS OPERATION_BEHAVIOR_TEXT,");
            sb.AppendLine("          OPERATION_BEHAVIOR ,");
            sb.AppendLine("          REVIEW_OPINION,");
            sb.AppendLine("          D.FILETILE,");
            sb.AppendLine("          D.GUID,");
            sb.AppendLine("          A.ID,");
            sb.AppendLine("          F.OPER_ID,");
            sb.AppendLine("          (case c.type when 3 then");
            sb.AppendLine("                                     (select");
            sb.AppendLine("                                              DEP_NAME");
            sb.AppendLine("                                     from");
            sb.AppendLine("                                              T_USER_EXTEND");
            sb.AppendLine("                                     where");
            sb.AppendLine("                                              U_ID =a.OPERATION_PERSON");
            sb.AppendLine("                                     ) else");
            sb.AppendLine("                                            (select");
            sb.AppendLine("                                                     DNAME");
            sb.AppendLine("                                            from");
            sb.AppendLine("                                                     T_USER_DEPARTMENT");
            sb.AppendLine("                                            where");
            sb.AppendLine("                                                     DEPID =a.DEPID");
            sb.AppendLine("                                     ) end ) DNAME");
            sb.AppendLine(" FROM");
            sb.AppendLine("          OPERTION_RECORD A");
            sb.AppendLine(" LEFT JOIN");
            sb.AppendLine("          T_USER C ON A.OPERATION_PERSON=C.ID");
            sb.AppendLine(" LEFT JOIN");
            sb.AppendLine("          SYS_ATTACHMENT D ON A.ATTACHMENT_ID=D.GUID");
            sb.AppendLine(" LEFT JOIN");
            sb.AppendLine("          REVIEW_INSTANCE E ON a.instance_id = E.ID");
            sb.AppendLine(" LEFT JOIN");
            sb.AppendLine("          RECORD_LOG F ON A.ID=F.OPER_ID");
            sb.AppendLine(" WHERE");
            sb.AppendLine("          RECORD_ID=" + record_id);
            sb.AppendLine(" ORDER BY");
            sb.AppendLine("          OPERATION_TIME DESC");
            */
            #endregion

            var data = FromWhere<OPERTION_RECORD>(OPERTION_RECORD._.RECORD_ID == record_id)
                .LeftJoin<T_USER>(T_USER._.ID == OPERTION_RECORD._.OPERATION_PERSON)
                .LeftJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID == OPERTION_RECORD._.DEPID)
             .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == OPERTION_RECORD._.DEPID)
             .LeftJoin<SYS_ATTACHMENT>(SYS_ATTACHMENT._.GUID == OPERTION_RECORD._.ATTACHMENT_ID)
            .LeftJoin<REVIEW_INSTANCE>(REVIEW_INSTANCE._.ID == OPERTION_RECORD._.INSTANCE_ID)
            .LeftJoin<RECORD_LOG>(RECORD_LOG._.OPER_ID == OPERTION_RECORD._.ID)
            .Select(
                 OPERTION_RECORD._.ID,
                 REVIEW_INSTANCE._.STAFF,
                T_USER._.MANAGE_NAME,
                T_USER._.TYPE,
                OPERTION_RECORD._.OPERATION_TIME,
                OPERTION_RECORD._.OPERATION_BEHAVIOR,
                 OPERTION_RECORD._.REVIEW_OPINION,
                 SYS_ATTACHMENT._.AOBJTYPE,
                 SYS_ATTACHMENT._.FILETILE,
                 SYS_ATTACHMENT._.FILEPATH,
                  SYS_ATTACHMENT._.GUID,
                 T_USER_EXTEND._.DEP_NAME,
                 T_USER_DEPARTMENT._.DNAME,
                 REVIEW_INSTANCE._.ID.As("REVIEW_INSTANCE_ID")
                )
            .OrderBy(OPERTION_RECORD._.OPERATION_TIME.Desc)
            .ToList<dynamic>();

            var result = data.Select(t => new
            {
                ID = t.ID,
                INSTANCE_ID = t.STAFF == null ? -1 :t.REVIEW_INSTANCE_ID,
                MANAGE_NAME = t.MANAGE_NAME,
                OPERATION_TIME = t.OPERATION_TIME,
                OPERATION_BEHAVIOR = t.OPERATION_BEHAVIOR,
                OPERATION_BEHAVIOR_TEXT = ((EnumOperation)Convert.ToInt32(t.OPERATION_BEHAVIOR)).DisplayEnumDescription(),
                REVIEW_OPINION = t.REVIEW_OPINION,
                FILE_PATH = urlBuilder?.Invoke(t.GUID),
                FILE_TILE = t.FILETILE,
                DEPT_NAME = t.TYPE == 3 ? t.DEP_NAME : t.DNAME
            }).ToList();
            GeneralResult r = new GeneralResult();
            r.SetSuccess(result);
            return r;
        }

        /// <summary>
        /// 操作记录详情
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="oper_id"></param>
        /// <returns></returns>
        public GeneralResult Detail(int record_id,int oper_id, Func<string, string> urlBuilder)
        {
            GeneralResult r = new GeneralResult();
            var op_log = Jd.RecordLogService.FirstOrNull(RECORD_LOG._.BA_ID == record_id &&
                RECORD_LOG._.OPER_ID == oper_id);
            if(null == op_log)
            {
                r.SetFail("操作记录不存在或已删除");
                return r;
            }
            
            if (op_log.ATTCHAMENT.Contains("ATTACHMENTS"))
            {
                var attrs = JsonConvert.DeserializeObject<List<UploadResData_ReviewRequest>>(op_log.ATTCHAMENT);
                foreach(var att in attrs)
                {
                    if(null != att.ATTACHMENTS && att.ATTACHMENTS.Any())
                    {
                        att.ATTACHMENTS.ForEach(attachment => {
                            attachment.FullUrl = urlBuilder?.Invoke(attachment.Id);
                        });
                    }
                   
                }
                r.SetSuccess(attrs);
                return r;
            }

            if(true)
            {
                var attachments = JsonConvert.DeserializeObject<List<Dictionary<string,string>>>(op_log.ATTCHAMENT);
                var guids = new List<string>();
                
                foreach(var att in attachments)
                {
                    var a_guids = att["GUIDS"]?.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);
                    if(a_guids != null && a_guids.Any())
                    {
                        guids.AddRange(a_guids);
                    }
                }
                var sys_attachments = Jd.SysAttachmentService.FindList(SYS_ATTACHMENT._.GUID.In(guids));

                List<UploadResData_ReviewRequest> datas = new List<UploadResData_ReviewRequest>();
                foreach (var att in attachments)
                {
                    var sys_atta = sys_attachments.Where(w => w.AID == Convert.ToInt32(att["ID"])).FirstOrDefault();
                    UploadResData_ReviewRequest data = new UploadResData_ReviewRequest
                    {
                        BID_SECTION_CODE = att.ContainsKey("BID_SECTION_CODE") ? att["BID_SECTION_CODE"] : "",
                        TYPE = att["ATTFILE_TYPECODE"],
                        TITLE = att["ATTFILE_TYPENAME"],
                        DESCRIPTION = att["DESCRIPTION"],
                        Url = sys_atta?.FILEPATH,
                        Name = sys_atta?.FILETILE,
                        FullUrl =urlBuilder?.Invoke(sys_atta.GUID)
                    };
                    datas.Add(data);    
                }
                var result = datas.GroupBy(g => new { g.BID_SECTION_CODE, g.TYPE, g.TITLE,g.DESCRIPTION })
                    .Select(t => new {
                        TYPE = t.Key.TYPE,
                        TITLE = t.Key.TITLE,
                        DESCRIPTION = t.Key.DESCRIPTION,
                        BID_SECTION_CODE = t.Key.BID_SECTION_CODE,
                        ATTACHMENTS = t.Where(w=>!(String.IsNullOrWhiteSpace(w.FullUrl)
                        || String.IsNullOrWhiteSpace(w.Name))).Select(t1 => new {
                            full_url = t1.FullUrl,
                            url = t1.Url,
                            name = t1.Name,
                            md5 =t1.Md5
                        })
                    });
                    r.SetSuccess(result);
                return r;
            }
            
           
        }

        /// <summary>
        /// 获取某招标项目的签章列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="tender_project_code"></param>
        /// <param name="is_signup"></param>
        /// <param name="review_type"></param>
        /// <returns></returns>
        public GeneralResult ListSignup(SearchCondition search,string tender_project_code,int? is_signup,string review_type,Func<string,string>urlBuilder)
        {
            var r = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(RECORD_REVIEW._.TENDER_PROJECT_CODE == tender_project_code);
            if(is_signup.HasValue)
            {
                switch(is_signup.Value)
                {
                    case 0:
                        condition.And(SYS_ATTACHMENT._.CONVERTREMARK.IsNull() || SYS_ATTACHMENT._.CONVERTREMARK !="已签章");
                        break;
                    case 1:
                        condition.And(SYS_ATTACHMENT._.CONVERTREMARK == "已签章");
                        break;
                }
            }
            if(! String.IsNullOrWhiteSpace(review_type))
            {
                condition.And(RECORD_REVIEW._.REVIEW_TYPE == review_type);
            }
            var count = FromWhere<OPERTION_RECORD>()
                .InnerJoin<RECORD_REVIEW>(OPERTION_RECORD._.RECORD_ID == RECORD_REVIEW._.ID
                && OPERTION_RECORD._.OPERATION_PERSON != RECORD_REVIEW._.CREATOR)
                .LeftJoin<T_USER>(OPERTION_RECORD._.OPERATION_PERSON == T_USER._.ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == OPERTION_RECORD._.DEPID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE && SYS_DIC._.TYPE == "3021")
                .LeftJoin<SYS_ATTACHMENT>(SYS_ATTACHMENT._.GUID == OPERTION_RECORD._.ATTACHMENT_ID)
                .Where(condition.ToWhereClip()).Count();

            var datas = FromWhere<OPERTION_RECORD>()
                .InnerJoin<RECORD_REVIEW>(OPERTION_RECORD._.RECORD_ID == RECORD_REVIEW._.ID
                 && OPERTION_RECORD._.OPERATION_PERSON != RECORD_REVIEW._.CREATOR)
                .LeftJoin<T_USER>(OPERTION_RECORD._.OPERATION_PERSON == T_USER._.ID)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == OPERTION_RECORD._.DEPID)
                .LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE && SYS_DIC._.TYPE == "3021")
                .LeftJoin<SYS_ATTACHMENT>(SYS_ATTACHMENT._.GUID == OPERTION_RECORD._.ATTACHMENT_ID)
                .Where(condition.ToWhereClip())
                .Page(search.PageSize, search.PageNo)
                .OrderBy(RECORD_REVIEW._.REVIEW_TYPE)
                .Select(
                    RECORD_REVIEW._.ID,
                    RECORD_REVIEW._.REVIEW_CODE,
                    SYS_DIC._.TEXT,
                    T_USER_DEPARTMENT._.DNAME,
                    T_USER._.MANAGE_NAME,
                    OPERTION_RECORD._.OPERATION_TIME,
                    SYS_ATTACHMENT._.FILETILE,
                    SYS_ATTACHMENT._.FILEPATH,
                    SYS_ATTACHMENT._.GUID,
                    SYS_ATTACHMENT._.AOBJTYPE,
                    SYS_ATTACHMENT._.CONVERTREMARK
                ).ToList<dynamic>();

            var pageList = datas.Select(t => new {
                RECORD_ID=t.ID,
                REVIEW_CODE = t.REVIEW_CODE,
                REVIEW_TYPE = t.TEXT,
                DEPARTMENT = t.DNAME,
                OPERATOR = t.MANAGE_NAME,
                OPERATION_TIME = t.OPERATION_TIME,
                FILETILE = t.FILETILE,
                FILE_GUID = t.GUID,
                IS_SIGNUP = "已签章"==t.CONVERTREMARK?1:0,
                //FILE_URL = "FC".Equals(t.AOBJTYPE)?String.Concat(ConfigHelper.AppSettings.UploadHost,t.FILEPATH) : t.FILEPATH
                FILE_URL=urlBuilder?.Invoke(t.GUID),
                full_url = urlBuilder?.Invoke(t.GUID)
            }).ToPageTableResult<dynamic>(search,count);
            r.SetSuccess(pageList);
            return r;
        }
        /// <summary>
        /// 监察痕迹-招标备案
        /// </summary>
        /// <param name="jdTenderProjectCode"></param>
        /// <returns></returns>
        public List<OperationRecordModel> GetBA_Logs(string jdTenderProjectCode)
        {
            var list = FromWhere(RECORD_REVIEW._.TENDER_PROJECT_CODE == jdTenderProjectCode)
                .InnerJoin<RECORD_REVIEW>(RECORD_REVIEW._.ID == OPERTION_RECORD._.RECORD_ID &&
                                          RECORD_REVIEW._.REVIEW_STATUS > 0)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "3021" && SYS_DIC._.VALUE == RECORD_REVIEW._.REVIEW_TYPE)
                .LeftJoin<T_USER>(T_USER._.ID == OPERTION_RECORD._.OPERATION_PERSON)
                .LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID==T_USER._.DEPARTID)
                .LeftJoin<T_USER_EXTEND>(T_USER_EXTEND._.U_ID==T_USER._.ID)
                .OrderByDescending(OPERTION_RECORD._.OPERATION_TIME)
                .Select(
                    T_USER._.TYPE.As("OPERATION_PERSON_TYPE"),
                    T_USER._.MANAGE_NAME,
                    SYS_DIC._.TEXT.As("REVIEW_TYPE_TEXT"),
                    RECORD_REVIEW._.REVIEW_CODE,
                    T_USER_DEPARTMENT._.DNAME.As("T_USER_DEPARTMENT_DNAME"),
                    T_USER_EXTEND._.DEP_NAME.As("T_USER_EXTEND_DEP_NAME"),
                    OPERTION_RECORD._.All)
                .ToList<OperationRecordModel>();
            list.ForEach(c=> { c.ATTACHMENT_ID_FILES = Jd.CommonService.Attachments(c.ATTACHMENT_ID, "Sys"); });
            return list;
        }
    }
}