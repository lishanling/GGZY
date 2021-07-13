using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Extensions;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LEGAL_PERSON_BASE = GGZYJD.DbEntity.LEGAL_PERSON_BASE;
using SYS_ATTACHMENT = GGZYJD.DbEntity.SYS_ATTACHMENT;

namespace GGZY.Services.JianDu
{
    public partial class JcTransRecordService
    {
        public PageTableResult PageList(SearchCondition search, WhereClip condition)
        {
            var query = FromWhere(condition);
            var count = query.Count();
            var pageList = query
                .OrderBy(JC_TRANS_RECORD._.IS_NEW.Desc)
                .OrderBy(JC_TRANS_RECORD._.TRANS_TIME.Desc)
                .Page(search.PageSize, search.PageNo)
                .Select(
                    JC_TRANS_RECORD._.ID,
                    JC_TRANS_RECORD._.TRANS_CODE,
                    JC_TRANS_RECORD._.TITLE,
                    JC_TRANS_RECORD._.RECEIVER,
                    JC_TRANS_RECORD._.RECEIVER_PHONE,
                    JC_TRANS_RECORD._.TRANS_TYPE,
                    JC_TRANS_RECORD._.TRANS_UNIT,
                    JC_TRANS_RECORD._.TRANS_TIME,
                    JC_TRANS_RECORD._.HAS_RESULT,
                    JC_TRANS_RECORD._.IS_NEW
                ).ToList<dynamic>().ToPageTableResult(search,count);
            return pageList;
        }

        public JC_TRANS_RECORD Detail(string id)
        {
            var record = Jd.JcTransRecordService.FirstOrNull(JC_TRANS_RECORD._.ID == id);
            if (null == record || record.IS_DELETE ==1)
            {
                return null;
            }
            record.Attach();
            record.IS_NEW = 0;
            Update<JC_TRANS_RECORD>(record);
            return record;
        }

        public GeneralResult Trans(JC_TRANS_RECORD record,JC_TRANS_PROJECT project,List<JC_TRANS_DETAIL> details = null,
            JC_TRANS_ENTITY entity = null,
            JC_TRANS_PERSON person = null,
            List<GGZY.Core.Models.UploadResData> attachments = null)
        {
            var r = new GeneralResult();

            record.ID = Guid.NewGuid().ToString().ToLower();
            record.TRANS_TIME = DateTime.Now;
            record.IS_NEW = 1;
            record.HAS_RESULT = 0;
            record.DATA_TIMESTAMP = DateTime.Now;
            record.TRANS_CODE = "";
            record.TRANS_USER_PHONE = JdUser?.TELPHONE;
            record.TRANS_USER = JdUser?.MANAGE_NAME;
            record.TRANS_USER_ID = JdUser?.ID;
            record.TRANS_UNIT = JdUser?.UserDepartment.DNAME;
            record.TRANS_UNITID = JdUser?.UserDepartment.DEPID;

            GGZYFW.DbEntity.TENDER_PROJECT tp = null;
            GGZYFW.DbEntity.LEGAL_PERSON_BASE legal = null;
            switch (record.TRANS_TYPE)
            {
                case 1://项目
                    if (null == project)
                    {
                        r.SetFail("招标项目信息不存在");
                        return r;
                    }
                    tp = Fw.TenderProjectService.FirstOrNull(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == project.TENDER_PROJECT_CODE);
                    if (null == tp)
                    {
                        r.SetFail("招标项目信息不存在");
                        return r;
                    }
                    project.ID = Guid.NewGuid().ToString().ToLower();
                    project.RECORD_ID = record.ID;
                    project.TENDER_PROJECT_CODE = tp.TENDER_PROJECT_CODE;
                    project.TENDER_PROJECT_NAME = tp.TENDER_PROJECT_NAME;
                    project.TENDER_NAME = tp.TENDERER_NAME;
                    project.TENDER_CONTRACT = tp.TENDER_CONTENT;
                    project.TENDER_AGENCY_NAME = tp.TENDER_AGENCY_NAME;
                    project.TENDER_ANENCY_CODE = tp.TENDER_AGENCY_CODE;

                    if (null != details && details.Any())
                    {
                        details.ForEach(detail =>
                        {
                            detail.ID = Guid.NewGuid().ToString().ToLower();
                            detail.F_RECORD_ID = project.ID;
                            detail.RECORD_ID = record.ID;
                            detail.STATUS = 0;
                        });
                    }
                    break;
                case 2:
                    if(null == entity)
                    {
                        r.SetFail("主体信息不存在");
                        return r;
                    }
                    legal = Fw.LegalPersonBaseService.FirstOrNull(GGZYFW.DbEntity.LEGAL_PERSON_BASE._.LEGAL_CODE == entity.ENTITY_CODE);
                    if (null != legal)
                    {
                        entity.ENTITY_NAME = legal?.LEGAL_NAME;
                        entity.ENTITY_TYPE = Convert.ToInt32(legal?.LEGAL_ROLE?.TrimStart('0'));
                        entity.REGION_CODE = legal?.REGION_CODE;
                        var area = Fw.SysAreaQuanguoService.FirstOrNull(GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == legal?.REGION_CODE);
                        if (null != area)
                        {
                            entity.REGION_NAME = area.AREANAME;
                        }
                        
                    }
                    entity.ID = Guid.NewGuid().ToString().ToLower();
                    entity.RECORD_ID = record.ID;
                    if (null !=details && details.Any())
                    {
                        var entity_id = details.Where(w => w.VIOLATION_TYPE == 1).First();
                        if (null != entity_id)
                        {
                            var bdEntity = Fw.BdViolationEntityService.FirstOrNull(BD_VIOLATION_ENTITY._.ENTITY_CODE == entity.ENTITY_CODE);
                            if(null !=bdEntity)
                            {
                                entity.ENTITY_NAME = bdEntity.ENTITY_NAME;
                                entity.ENTITY_TYPE = bdEntity.ENTITY_TYPE;
                                entity.REGION_CODE = bdEntity.AREA_CODE;
                                var area = Fw.SysAreaQuanguoService.FirstOrNull(GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == bdEntity?.AREA_CODE);
                                if (null != area)
                                {
                                    entity.REGION_NAME = area.AREANAME;
                                }
                            }
                        }
                        details.ForEach(detail =>
                        {
                            detail.ID = Guid.NewGuid().ToString().ToLower();
                            detail.F_RECORD_ID = entity.ID;
                            detail.RECORD_ID = record.ID;
                            detail.STATUS = 0;
                            detail.DATA_TIMESTAMP = DateTime.Now;
                        });
                    }
                    break;
                case 3:
                    if (null == person)
                    {
                        r.SetFail("公职人员信息不存在");
                        return r;
                    }
                    if(String.IsNullOrWhiteSpace(person.PERSON_NAME))
                    {
                        if (null == person)
                        {
                            r.SetFail("公职人员姓名不能为空");
                            return r;
                        }
                    }
                    if (String.IsNullOrWhiteSpace(person.ENTITY_NAME))
                    {
                        if (null == person)
                        {
                            r.SetFail("公职人员所属单位名称不能为空");
                            return r;
                        }
                    }
                    if (String.IsNullOrWhiteSpace(person.ENTITY_CODE))
                    {
                        if (null == person)
                        {
                            r.SetFail("公职人员所属单位编码不能为空");
                            return r;
                        }
                    }
                    person.ID = Guid.NewGuid().ToString();
                    person.RECORD_ID = record.ID;
                    break;
                case 9: break;
                default:
                    r.SetFail("移送类型错误");
                    return r;
            }

            List<SYS_ATTACHMENT> files = new List<SYS_ATTACHMENT>();
            List<string> attachment_ids = new List<string>();

            if (attachments != null)
            {
                attachments.ForEach(e =>
                {
                    attachment_ids.Add(e.Id);
                    files.Add(e.JdSysAttachment(record.TRANS_USER_ID));
                });
            }

            var db = GetDbSession();
            using (var tran = db.BeginTransaction())
            {
                try
                {
                   
                    string sqlSEQ = "SELECT SEQ_TRANS_CODE.NEXTVAL FROM DUAL";
                    var code = tran.FromSql(sqlSEQ).ToScalar<string>();
                    record.TRANS_CODE = String.Concat("A",DateTime.Now.ToString("yyMMdd")+code.ToString().PadLeft(6,'0'));

                    UploadResData fileData = new UploadResData()
                    {
                        Id = GGZY.Core.Helper.Encrypt.MD5(Guid.NewGuid().ToString().ToLower(), 32),
                        new_id = "",
                        Md5 = "",
                        Url = "/TransData/" + record.TRANS_CODE + ".zip",
                        FullUrl = "/TransData/" + record.TRANS_CODE + ".zip",
                        Name = "移送记录数据包"
                    };
                    //生成数据包处理
                    var attData = fileData.JdSysAttachment(record.TRANS_USER_ID);
                    attData.AOBJTYPE = "";
                    files.Insert(0, attData);
                    attachment_ids.Add(attData.GUID);
                    record.ATTACHMENT_IDS = String.Join(",", attachment_ids.Distinct());
                   
                    tran.Insert<JC_TRANS_RECORD>(record);

                 

                    if (null != project && !String.IsNullOrWhiteSpace(project.ID))
                    {
                        tran.Insert<JC_TRANS_PROJECT>(project);
                    }
                    if (null != entity && !String.IsNullOrWhiteSpace(entity.ID))
                    {
                        tran.Insert<JC_TRANS_ENTITY>(entity);
                    }
                    if (null != person && !String.IsNullOrWhiteSpace(person.ID))
                    {
                        tran.Insert<JC_TRANS_PERSON>(person);
                    }
                    if (null !=details && details.Any())
                    {
                        details.ForEach(detail => {
                            tran.Insert<JC_TRANS_DETAIL>(detail);
                        });
                        
                    }
                    
                    if(files.Any())
                    {
                        files.ForEach(e => {
                            tran.Insert<SYS_ATTACHMENT>(e);
                        });
                    }
                    tran.Commit();
                    r.SetSuccess(attData, "移送成功");

                    try
                    {
                        bool isZip = CreateZipFile(record, project, details, entity, files);
                        if (!isZip)
                        {
                            r.SetFail("移送成功，生成移送数据包失败");
                        }
                    }
                    catch(Exception exx)
                    {
                        Logger.Error("移送失败:生成移送数据包失败." + exx.Message, exx);
                        r.SetFail("移送失败:生成移送数据包失败." + exx.Message);
                    }
                    return r;
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    Logger.Error("移送失败:" + ex.Message);
                    r.SetFail("移送失败:" + ex.Message);
                    return r;
                }
            }
        }
        public GeneralResult Export(List<string> record_ids,WhereClip condition = null)
        {
            var r = ExportToDisk(record_ids,condition);
            if(! r.Success)
            {
                return r;
            }
            var guid = r.Data.ToString();
            var folder = HttpContext.Current.Server.MapPath("~\\TransData\\" + guid + "\\");
            GGZY.Core.Helper.SharpZipHelper helper = new Core.Helper.SharpZipHelper();
            bool isZip = helper.ZipDirectory(
                folder, HttpContext.Current.Server.MapPath("~\\TransData\\" + guid + ".zip"));
            if (isZip)
            {
                Directory.Delete(folder, true);
            }

            UploadResData fileData = new UploadResData()
            {
                Id = GGZY.Core.Helper.Encrypt.MD5(guid, 32),
                new_id = "",
                Md5 = "",
                Url = "/TransData/" + guid + ".zip",
                FullUrl = "/TransData/" + guid + ".zip",
                Name = "移送记录数据包"
            };
            r.SetSuccess(fileData);
            return r;
        }

        public dynamic Collection(string record_id)
        {
            var project = Jd.JcTransProjectService.FirstOrNull(JC_TRANS_PROJECT._.RECORD_ID == record_id);
            var jdproject = Jd.TenderProjectService.FirstOrNull(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == project.TENDER_PROJECT_CODE);
            var info = Fw.TenderProjectService.FromWhere()
                         .InnerJoin<TENDER_ANN_QUA_INQUERY_ANN>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_ANN_QUA_INQUERY_ANN._.TENDER_PROJECT_CODE)
                         .LeftJoin<TENDER_CANDIDATE_ANNOUNCE>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == TENDER_CANDIDATE_ANNOUNCE._.TENDER_PROJECT_CODE)
                         .LeftJoin<WIN_RESULT_ANNO>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WIN_RESULT_ANNO._.TENDER_PROJECT_CODE)
                         .Where(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == jdproject?.TENDER_PROJECT_CODE_OLD1)
                         .Select(
                         //公告开始时间
                         TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
                         //公告截止时间
                         TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
                         //招标文件/资格预审文件获取时开始间
                         TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_START_TIME,
                          //招标文件/资格预审文件获取截至时间
                          TENDER_ANN_QUA_INQUERY_ANN._.DOC_GET_END_TIME,
                          //开标时间
                          TENDER_ANN_QUA_INQUERY_ANN._.BID_OPEN_TIME,
                          //投标截止时间
                          TENDER_ANN_QUA_INQUERY_ANN._.BID_DOC_REFER_END_TIME,
                           //保证金缴纳开始时间
                           TENDER_ANN_QUA_INQUERY_ANN._.NOTICE_SEND_TIME,
                           //候选人公示开始时间
                           TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_START_TIME,
                           //候选人公示结束时间
                           TENDER_CANDIDATE_ANNOUNCE._.PUBLICITY_END_TIME,
                           //结果公示开始时间
                           WIN_RESULT_ANNO._.NOTICE_SEND_TIME.As("WIN_NOTICE_SEND_TIME")
                         ).First<dynamic>();

            var projectData = new
            {
                ID = project.ID,
                TENDER_PROJECT_NAME = project.TENDER_PROJECT_NAME,
                TENDER_PROJECT_CODE = project.TENDER_PROJECT_CODE,
                TENDER_NAME = project.TENDER_NAME,
                TENDER_CONTRACT = project.TENDER_CONTRACT,
                TENDER_AGENCY_NAME = project.TENDER_AGENCY_NAME,
                TENDER_ANENCY_CODE = project.TENDER_ANENCY_CODE,
                RECORD_ID = project.RECORD_ID,
                //公告开始时间
                NOTICE_START_TIME = info?.NOTICE_SEND_TIME,
                //公告截止时间
                NOTICE_END_TIME = info?.BID_OPEN_TIME,
                //招标文件/资格预审文件获取时开始间
                DOC_GET_START_TIME = info?.DOC_GET_START_TIME,
                //招标文件/资格预审文件获取截至时间
                DOC_GET_END_TIME = info?.DOC_GET_END_TIME,
                //开标时间
                BID_OPEN_TIME = info?.BID_OPEN_TIME,
                //投标截止时间
                BID_DOC_REFER_END_TIME = info?.BID_DOC_REFER_END_TIME,
                //保证金缴纳截止时间
                MARGIN_RECEIVE_END_TIME = info?.DOC_GET_END_TIME,
                //候选人公示开始时间
                PUBLICITY_START_TIME = info?.PUBLICITY_START_TIME,
                //候选人公示结束时间
                PUBLICITY_END_TIME = info?.PUBLICITY_END_TIME,
                //结果公示开始时间
                WIN_NOTICE_SEND_TIME = info?.WIN_NOTICE_SEND_TIME
            };
            return projectData;
                 
        }




        protected GeneralResult ExportToDisk(List<string> record_ids,WhereClip condition = null)
        {
            GeneralResult r = new GeneralResult();
            try
            {
                List<JC_TRANS_RECORD> records = new List<JC_TRANS_RECORD>();
                List<JC_TRANS_PROJECT> projects = new List<JC_TRANS_PROJECT>();
                List<JC_TRANS_ENTITY> entities = new List<JC_TRANS_ENTITY>();
                List<JC_TRANS_RESULT> results = new List<JC_TRANS_RESULT>();
                List<JC_TRANS_DETAIL> details = new List<JC_TRANS_DETAIL>();

                if (condition != null)
                {
                    var fromsection = FromWhere<JC_TRANS_RECORD>(condition)
                    .Select(JC_TRANS_RECORD._.ID);
                   
                     records = Jd.JcTransRecordService.FindList(JC_TRANS_RECORD._.ID.SubQueryIn(fromsection));
                     projects = Jd.JcTransProjectService.FindList(JC_TRANS_PROJECT._.RECORD_ID.SubQueryIn(fromsection));
                     entities = Jd.JcTransEntityService.FindList(JC_TRANS_ENTITY._.RECORD_ID.SubQueryIn(fromsection));
                     results = Jd.JcTransResultService.FindList(JC_TRANS_RESULT._.RECORD_ID.SubQueryIn(fromsection));
                     details = Jd.JcTransDetailService.FindList(JC_TRANS_DETAIL._.RECORD_ID.SubQueryIn(fromsection));
                }
                else
                {
                    if(record_ids.Any())
                    {
                         records = Jd.JcTransRecordService.FindList(JC_TRANS_RECORD._.ID.In(record_ids));
                         projects = Jd.JcTransProjectService.FindList(JC_TRANS_PROJECT._.RECORD_ID.In(record_ids));
                         entities = Jd.JcTransEntityService.FindList(JC_TRANS_ENTITY._.RECORD_ID.In(record_ids));
                         results = Jd.JcTransResultService.FindList(JC_TRANS_RESULT._.RECORD_ID.In(record_ids));
                         details = Jd.JcTransDetailService.FindList(JC_TRANS_DETAIL._.RECORD_ID.In(record_ids));
                    }
                }
                var guid = Guid.NewGuid().ToString().ToLower();
                var folder = HttpContext.Current.Server.MapPath("~\\TransData\\" + guid + "\\");

                records.ForEach(e =>
                {
                    var childFolder = folder + e.TRANS_CODE;

                    GGZY.Core.Helper.WriteFileHelper.WriteFile(childFolder, "TRANS_RECORD.JSON", JsonConvert.SerializeObject(e));

                    if (projects.Where(w => w.RECORD_ID == e.ID && w.IS_DELETE != 1).Any())
                    {
                        var projectData = Jd.JcTransRecordService.Collection(e.ID);
                        GGZY.Core.Helper.WriteFileHelper.WriteFile(childFolder, "TRANS_PROJECT.JSON", JsonConvert.SerializeObject(projectData));
                    }

                    if (entities.Where(w => w.RECORD_ID == e.ID && w.IS_DELETE != 1).Any())
                    {
                        var entity = entities.Where(w => w.RECORD_ID == e.ID).First();
                        GGZY.Core.Helper.WriteFileHelper.WriteFile(childFolder, "TRANS_ENTITY.JSON", JsonConvert.SerializeObject(entity));
                    }

                    if (details.Where(w => w.RECORD_ID == e.ID && w.IS_DELETE != 1).Any())
                    {
                        var dtls = details.Where(w => w.RECORD_ID == e.ID).ToList();

                        GGZY.Core.Helper.WriteFileHelper.WriteFile(childFolder, "TRANS_DETAIL.JSON", JsonConvert.SerializeObject(dtls));
                    }
                });
                r.SetSuccess(guid);
                return r;
            }
            catch(Exception ex)
            {
                r.SetFail("导出移送数据到硬盘失败:服务器异常");
                Logger.Error(ex.Message, ex);
                return r;
            }
        }
        protected bool CreateZipFile(JC_TRANS_RECORD record, JC_TRANS_PROJECT project, List<JC_TRANS_DETAIL> details = null,
           JC_TRANS_ENTITY entity = null,
           List<GGZYJD.DbEntity.SYS_ATTACHMENT> attachments = null)
        {
            var folder = HttpContext.Current.Server.MapPath("~\\TransData\\"+record.TRANS_CODE + "\\");
            GGZY.Core.Helper.WriteFileHelper.WriteFile(folder, "TRANS_RECORD.JSON",JsonConvert.SerializeObject(record));

            if (null != project && !String.IsNullOrEmpty(project.RECORD_ID))
            {
                var projectData = Jd.JcTransRecordService.Collection(project.RECORD_ID);
                GGZY.Core.Helper.WriteFileHelper.WriteFile(folder, "TRANS_PROJECT.JSON", JsonConvert.SerializeObject(projectData));
            }
            if (null != details && details.Any())
            {

                GGZY.Core.Helper.WriteFileHelper.WriteFile(folder, "TRANS_DETAIL.JSON", JsonConvert.SerializeObject(details));
            }
            if (null != entity && !String.IsNullOrEmpty(entity.ID))
            {
                GGZY.Core.Helper.WriteFileHelper.WriteFile(folder, "TRANS_ENTITY.JSON", JsonConvert.SerializeObject(entity));
            }
            if (null != attachments && attachments.Any())
            {
                GGZY.Core.Helper.WriteFileHelper.WriteFile(folder, "SYS_ATTACHMENT.JSON", JsonConvert.SerializeObject(attachments));
            }

            GGZY.Core.Helper.SharpZipHelper helper = new Core.Helper.SharpZipHelper();
            bool isZip = helper.ZipDirectory(folder, HttpContext.Current.Server.MapPath("~\\TransData\\" + record.TRANS_CODE + ".zip"));
            if (isZip)
            {
                Directory.Delete(folder, true);
            }
            return isZip;
        }
    }
}
