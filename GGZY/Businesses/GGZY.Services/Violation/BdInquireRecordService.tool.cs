using Dos.ORM;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Services.Extensions;
using GGZY.Services.Infrastructure.Extensions;
using GGZYFW.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.FuWu
{
    public partial class BdInquireRecordService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="record"></param>
        /// <param name="attachments"></param>
        /// <returns></returns>
        public GeneralResult Add(BD_INQUIRE_RECORD record, List<SYS_ATTACHMENT> attachments)
        {
            var db = GetDbSession();
            var r = new GeneralResult();

            Entity bd_record = new Entity();

            switch (record.POINT_TYPE)
            {
                case 1:
                    bd_record = Fw.BdViolationEntityService.FirstOrNull(BD_VIOLATION_ENTITY._.ID == record.VIOLATION_RECORD_ID);
                    if (null == bd_record)
                    {
                        r.SetFail("疑似违规主体信息不存在");
                        return r;
                    }
                    bd_record.Attach();
                    ((BD_VIOLATION_ENTITY)bd_record).STATE = 1;
                    break;
                default:
                    bd_record = Fw.BdViolationRecordService.FirstOrNull(BD_VIOLATION_RECORD._.ID == record.VIOLATION_RECORD_ID);
                    if (null == bd_record)
                    {
                        r.SetFail("疑似违规项信息不存在");
                        return r;
                    }
                    bd_record.Attach();
                    ((BD_VIOLATION_RECORD)bd_record).STATE = 1;
                    break;
            }
           
            using (var tran = db.BeginTransaction())
            {
                try
                {
                    attachments.ForEach(e =>
                    {
                        e.REMARK = "大数据-调查结果记录";
                        tran.Insert<SYS_ATTACHMENT>(e);
                    });

                    if (null != attachments && attachments.Any())
                    {
                        record.GUIDS = String.Join(",", attachments.Select(t => t.FILEPATH));
                    }
                    tran.Insert<BD_INQUIRE_RECORD>(record);

                    switch (record.POINT_TYPE)
                    {
                        case 1:
                            tran.Update<BD_VIOLATION_ENTITY>((BD_VIOLATION_ENTITY)bd_record);
                            break;
                        default:
                            tran.Update<BD_VIOLATION_RECORD>((BD_VIOLATION_RECORD)bd_record);
                            break;
                    }

                    tran.Commit();
                    r.SetSuccess();
                    return r;
                }
                catch(Exception ex)
                {
                    Logger.Error("保存调查结果记录失败:"+ex.Message);
                    r.SetFail("保存调查结果记录失败");
                    return r;
                }
            }
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="urlBuilder"></param>
        /// <returns></returns>
        public GeneralResult Detail(string record_id,Func<string,string> urlBuilder)
        {
            var r = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(BD_INQUIRE_RECORD._.VIOLATION_RECORD_ID == record_id);

            var entity = FirstOrNull(condition);
            if(null == entity)
            {
                r.SetFail("记录不存在");
                return r;
            }
            var dic = entity.ToDictionary();

            dic.Add("ATTACHMENTS", Fw.SysAttachmentService.FindAttachment(entity.GUIDS, urlBuilder));
            r.SetSuccess(dic);
            return r;
        }
    }
}
