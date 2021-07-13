using GGZY.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZYJD.DbEntity;
using Dos.ORM;
using Newtonsoft.Json;
using System.Configuration;
using System.Security.Cryptography;

namespace GGZY.Services
{
    /// <summary>
    /// 远程异地评标调度系统县市接口服务-分会场相关功能接口服务
    /// </summary>
    public partial class YdpbBranchService: BaseServiceT<Dos.ORM.Entity>
    {
        private string SYSTEM_NO = ConfigurationManager.AppSettings["SYSTEM_NO"];
        /// <summary>
        /// 推送申请信息到分会场交易系统/场地管理系统
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="detail"></param>
        /// <param name="requestid"></param>
        public void Apply(YDPB_EVAL_APPLY apply,YDPB_EVAL_APPLY_DETAIL detail,string requestid="")
        {
            var action = "分会场申请通知";
            if (String.IsNullOrEmpty(SYSTEM_NO))
            {
                GGZY.Core.Log.Logger.Info(action + "失败：web.confg=>appsetting 未配置 SYSTEM_NO");
                return;
            }
            if(null == apply)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：申请单为空");
            }
            if (null == detail)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：申请会场信息为空");
            }
            requestid = (requestid == "") ? apply.SERIES_NUMBER + "-" + detail.AREA_CODE + "-" + detail.ID : requestid;
            var area_code = detail.AREA_CODE;

            var configCondition = new WhereClipBuilder();
            configCondition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE ==0);
            configCondition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE == detail.AREA_CODE);
            configCondition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE == "apply");
            var config = ServicesFactory.GGZYJD.YdpbNotifyConfigService.FirstOrNull(configCondition);
            if(null == config)
            {
                GGZY.Core.Log.LoggerR.Info(requestid, action + "失败,"+detail.CENTER_NAME + " 未配置分会场申请接口，通知失败。请在远程异地评标调度系统进行审批。");
                return;
            }

            var center = GGZY.Services.GlobalDataService.Instance.CenterList.Where(w => w.AREA_CODE == detail.AREA_CODE).FirstOrDefault();
            if(center == null)
            {
                GGZY.Core.Log.Logger.Error(action + "失败："+detail.CENTER_NAME + "【"+detail.AREA_CODE+"】 未接入分会场场地管理接口API");
                return;
            }

            var data = new
            {
                SERIES_NUMBER = apply.SERIES_NUMBER,
                TENDER_AGENT_CONTRACT = apply.TENDER_AGENT_CONTRACT,
                TENDER_AGENT_PHONE = apply.TENDER_AGENT_PHONE,
                BID_EVAL_START_TIME = apply.BID_EVAL_START_TIME.Value.ToString("yyyyMMddHHmmss"),
                BID_EVAL_END_TIME = apply.BID_EVAL_END_TIME.Value.ToString("yyyyMMddHHmmss"),
                SEAT_COUNT = (int)detail.EXPERT_COUNT
            };
            var dataTiemstamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            var requestData = new {
                action = "apply",
                requestid = requestid,
                url = config.URL,
                data = new { 
                    validation = new{
                        DATAUUID = requestid,
                        SYSTEM_NO =SYSTEM_NO,
                        TIME = dataTiemstamp,
                        TOKEN = GenerateToken(requestid,dataTiemstamp,SYSTEM_NO,data, center.PRIVATE_KEY)
                    },
                    data = data,
                }
            };
            GGZY.Core.Utils.QueueHttpRequest.Instance.Enqueue(requestData);
        }

        /// <summary>
        /// 推送申请信息到分会场交易系统/场地管理系统
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="detail"></param>
        /// <param name="requestid"></param>
        public void Change(YDPB_EVAL_APPLY apply, YDPB_EVAL_APPLY_DETAIL detail, string requestid = "")
        {
            var action = "分会场变更申请通知";
            if (String.IsNullOrEmpty(SYSTEM_NO))
            {
                GGZY.Core.Log.Logger.Info(action + "失败：web.confg=>appsetting 未配置 SYSTEM_NO");
                return;
            }
            if (null == apply)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：申请单为空");
            }
            if (null == detail)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：申请会场信息为空");
            }
            requestid = (requestid == "") ? apply.SERIES_NUMBER + "-" + detail.AREA_CODE + "-" + detail.ID : requestid;
            var area_code = detail.AREA_CODE;

            var configCondition = new WhereClipBuilder();
            configCondition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE == 0);
            configCondition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE == detail.AREA_CODE);
            configCondition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE == "change");
            var config = ServicesFactory.GGZYJD.YdpbNotifyConfigService.FirstOrNull(configCondition);
            if (null == config)
            {
                GGZY.Core.Log.LoggerR.Info(requestid, action + "失败," + detail.CENTER_NAME + " 未配置分会场变更接口，通知失败。请在远程异地评标调度系统进行审批。");
                return;
            }

            var center = GGZY.Services.GlobalDataService.Instance.CenterList.Where(w => w.AREA_CODE == detail.AREA_CODE).FirstOrDefault();
            if (center == null)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：" + detail.CENTER_NAME + "【" + detail.AREA_CODE + "】 未接入分会场场地管理接口API");
                return;
            }

            var data = new
            {
                SERIES_NUMBER = apply.SERIES_NUMBER,
                ORIGINAL_SERIES_NUMBER = apply.F_SERIES_NUMBER,
                TENDER_AGENT_CONTRACT = apply.TENDER_AGENT_CONTRACT,
                TENDER_AGENT_PHONE = apply.TENDER_AGENT_PHONE,
                BID_EVAL_START_TIME = apply.BID_EVAL_START_TIME.Value.ToString("yyyyMMddHHmmss"),
                BID_EVAL_END_TIME = apply.BID_EVAL_END_TIME.Value.ToString("yyyyMMddHHmmss"),
                SEAT_COUNT = (int)detail.EXPERT_COUNT,
                REMARK = apply.REMARK
            };
            var dataTiemstamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            var requestData = new
            {
                action = "change",
                requestid = requestid,
                url = config.URL,
                data = new
                {
                    validation = new
                    {
                        DATAUUID = requestid,
                        SYSTEM_NO = SYSTEM_NO,
                        TIME = dataTiemstamp,
                        TOKEN = GenerateToken(requestid, dataTiemstamp, SYSTEM_NO, data, center.PRIVATE_KEY)
                    },
                    data = data,
                }
            };
            GGZY.Core.Utils.QueueHttpRequest.Instance.Enqueue(requestData);
        }


        /// <summary>
        /// 取消已审核通过申请单
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="detail"></param>
        /// <param name="requestid"></param>
        public void Cancel(YDPB_EVAL_APPLY apply, YDPB_EVAL_APPLY_DETAIL detail, string requestid = "")
        {
            var action = "分会场取消申请通知";
            if (String.IsNullOrEmpty(SYSTEM_NO))
            {
                GGZY.Core.Log.Logger.Info(action + "失败：web.confg=>appsetting 未配置 SYSTEM_NO");
                return;
            }
            if (null == apply)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：申请单为空");
            }
            if (null == detail)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：申请会场信息为空");
            }
            requestid = (requestid == "") ? apply.SERIES_NUMBER + "-" + detail.AREA_CODE + "-" + detail.ID : requestid;
            var area_code = detail.AREA_CODE;

            var configCondition = new WhereClipBuilder();
            configCondition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE == 0);
            configCondition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE == detail.AREA_CODE);
            configCondition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE == "cancel");
            var config = ServicesFactory.GGZYJD.YdpbNotifyConfigService.FirstOrNull(configCondition);
            if (null == config)
            {
                GGZY.Core.Log.LoggerR.Info(requestid, action + "失败," + detail.CENTER_NAME + " 未配置分会场取消接口，通知失败。请在远程异地评标调度系统进行审批。");
                return;
            }

            var center = GGZY.Services.GlobalDataService.Instance.CenterList.Where(w => w.AREA_CODE == detail.AREA_CODE).FirstOrDefault();
            if (center == null)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：" + detail.CENTER_NAME + "【" + detail.AREA_CODE + "】 未接入分会场场地管理接口API");
                return;
            }

            var data = new
            {
                SERIES_NUMBER =apply.SERIES_NUMBER,
                ORIGINAL_SERIES_NUMBER = apply.F_SERIES_NUMBER,
                TENDER_AGENT_CONTRACT = apply.TENDER_AGENT_CONTRACT,
                TENDER_AGENT_PHONE = apply.TENDER_AGENT_PHONE,
                REMARK = apply.REMARK
            };
            var dataTiemstamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            var requestData = new
            {
                action = "cancel",
                requestid = requestid,
                url = config.URL,
                data = new
                {
                    validation = new
                    {
                        DATAUUID = requestid,
                        SYSTEM_NO = SYSTEM_NO,
                        TIME = dataTiemstamp,
                        TOKEN = GenerateToken(requestid, dataTiemstamp, SYSTEM_NO, data, center.PRIVATE_KEY)
                    },
                    data = data,
                }
            };
            GGZY.Core.Utils.QueueHttpRequest.Instance.Enqueue(requestData);
        }

        /// <summary>
        /// 审批结果查询
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="detail"></param>
        /// <param name="requestid"></param>
        public void query(YDPB_EVAL_APPLY apply, YDPB_EVAL_APPLY_DETAIL detail, string requestid = "")
        {
            var action = "分会场审批结果查询";
            if (String.IsNullOrEmpty(SYSTEM_NO))
            {
                GGZY.Core.Log.Logger.Info(action + "失败：web.confg=>appsetting 未配置 SYSTEM_NO");
                return;
            }
           
            requestid = (requestid == "") ? Guid.NewGuid().ToString("N"): requestid;
            var area_code = detail.AREA_CODE;

            var configCondition = new WhereClipBuilder();
            configCondition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE == 0);
            configCondition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE == detail.AREA_CODE);
            configCondition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE == "query");
            var config = ServicesFactory.GGZYJD.YdpbNotifyConfigService.FirstOrNull(configCondition);
            if (null == config)
            {
                GGZY.Core.Log.LoggerR.Info(requestid, action + "失败," + detail.CENTER_NAME + " 未配置分会场申请结果查询接口，查询失败。。");
                return;
            }

            var center = GGZY.Services.GlobalDataService.Instance.CenterList.Where(w => w.AREA_CODE == detail.AREA_CODE).FirstOrDefault();
            if (center == null)
            {
                GGZY.Core.Log.Logger.Error(action + "失败：" + detail.CENTER_NAME + "【" + detail.AREA_CODE + "】 未接入分会场场地管理接口API");
                return;
            }

            var data = new
            {
                SERIES_NUMBER = apply.SERIES_NUMBER
            };
            var dataTiemstamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            var requestData = new
            {
                action ="query",
                detail = detail,
                requestid = requestid,
                url = config.URL,
                data = new
                {
                    validation = new
                    {
                        DATAUUID = requestid,
                        SYSTEM_NO = SYSTEM_NO,
                        TIME = dataTiemstamp,
                        TOKEN = GenerateToken(requestid, dataTiemstamp, SYSTEM_NO, data, center.PRIVATE_KEY)
                    },
                    data = data,
                }
            };
            GGZY.Core.Utils.QueueHttpRequest.Instance.Enqueue(requestData);
        }

        /// <summary>
        /// 异常通知
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="detail"></param>
        /// <param name="requestid"></param>
        public void exceptionNotify(string area_code, string msg,string requestid = "")
        {
            var action = "分会场通知审批结果到主会场";
            try
            {

                if (String.IsNullOrEmpty(SYSTEM_NO))
                {
                    GGZY.Core.Log.Logger.Info(action + "失败：web.confg=>appsetting 未配置 SYSTEM_NO");
                    return;
                }

                requestid = (requestid == "") ? Guid.NewGuid().ToString("N") : requestid;
              
                var configCondition = new WhereClipBuilder();
                configCondition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE == 0);
                configCondition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE == area_code);
                configCondition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE == "exception");
                var config = ServicesFactory.GGZYJD.YdpbNotifyConfigService.FirstOrNull(configCondition);
                if (null == config)
                {
                    GGZY.Core.Log.LoggerR.Info(requestid, action + "失败," + area_code + " 未配置异常通知接口，通知失败。");
                    return;
                }

                var center = GGZY.Services.GlobalDataService.Instance.CenterList.Where(w => w.AREA_CODE == area_code).FirstOrDefault();
                if (center == null)
                {
                    GGZY.Core.Log.Logger.Error(action + "失败：" + area_code + " 未接入分会场场地管理接口API");
                    return;
                }
                
             
                var dataTiemstamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                var data = new {
                    exception = msg
                };
                var requestData = new
                {
                    action = "exception",
                    requestid = requestid,
                    url = config.URL,
                    data = new
                    {
                        validation = new
                        {
                            DATAUUID = requestid,
                            SYSTEM_NO = SYSTEM_NO,
                            TIME = dataTiemstamp,
                            TOKEN = GenerateToken(requestid, dataTiemstamp, SYSTEM_NO, data, center.PRIVATE_KEY)
                        },
                        data = data,
                    }
                };
                GGZY.Core.Utils.QueueHttpRequest.Instance.Enqueue(requestData);
            }
            catch (Exception ex)
            {
                GGZY.Core.Log.LoggerR.Error(action + " 操作失败:" + ex.Message, ex);
            }
        }

        public void notify(YDPB_EVAL_APPLY apply, YDPB_EVAL_APPLY_DETAIL detail, string requestid = "")
        {
            var action = "分会场通知审批结果到主会场";
            try
            {
                if(null == apply)
                {
                    GGZY.Core.Log.Logger.Info(action + "失败：申请单信息为空");
                    return;
                }
                if (String.IsNullOrEmpty(SYSTEM_NO))
                {
                    GGZY.Core.Log.Logger.Info(action + "失败：web.confg=>appsetting 未配置 SYSTEM_NO");
                    return;
                }
                var mainCondition = new WhereClipBuilder();
                mainCondition.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply?.ID);
                mainCondition.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                mainCondition.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 1);
                var mainDetail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FirstOrNull(mainCondition);
                if (null == mainDetail)
                {
                    GGZY.Core.Log.Logger.Info(action + "失败：未找到主会场信息");
                    return;
                }

                requestid = (requestid == "") ? Guid.NewGuid().ToString("N") : requestid;
                var area_code = mainDetail.AREA_CODE;

                var configCondition = new WhereClipBuilder();
                configCondition.And(YDPB_NOTIFY_CONFIG._.IS_DELETE == 0);
                configCondition.And(YDPB_NOTIFY_CONFIG._.AREA_CODE == mainDetail.AREA_CODE);
                configCondition.And(YDPB_NOTIFY_CONFIG._.INTERFACE_CODE == "notify");
                var config = ServicesFactory.GGZYJD.YdpbNotifyConfigService.FirstOrNull(configCondition);
                if (null == config)
                {
                    GGZY.Core.Log.LoggerR.Info(requestid, action + "失败," + mainDetail.CENTER_NAME + " 未配置审批结果通知接口，通知失败。请在远程异地评标调度系统进行审批。");
                    return;
                }

                var center = GGZY.Services.GlobalDataService.Instance.CenterList.Where(w => w.AREA_CODE == area_code).FirstOrDefault();
                if (center == null)
                {
                    GGZY.Core.Log.Logger.Error(action + "失败：" + detail.CENTER_NAME + "【" + detail.AREA_CODE + "】 未接入分会场场地管理接口API");
                    return;
                }
                var seatCondition = new WhereClipBuilder();
                seatCondition.And(YDPB_EVAL_ROOM_SEAT_RECORD._.APPLY_ID == apply.ID);
                seatCondition.And(YDPB_EVAL_ROOM_SEAT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID);
                seatCondition.And(YDPB_EVAL_ROOM_SEAT_RECORD._.IS_DELETE == 0);
                seatCondition.And(YDPB_EVAL_ROOM_SEAT_RECORD._.STATE == 1);
                var seatRecord = ServicesFactory.GGZYJD.YdpbEvalRoomSeatRecordService.FindList(seatCondition);
                if (!seatRecord.Any() && detail.STATUS !=2 && apply.APPLY_TYPE !=2 && apply.FLAG !=2)
                {
                    GGZY.Core.Log.Logger.Error(action + "失败：" + detail.CENTER_NAME + "未找到分配的评标席位记录");
                    return;
                }

                var record = Jd.YdpbEvalApplyRecordService.FirstOrNull(YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == detail.ID);

                var data = new
                {
                    SERIES_NUMBER = apply.SERIES_NUMBER,
                    TENDER_PROJECT_NAME = apply.TENDER_PROJECT,
                    TENDER_PROJECT_CODE = apply.TENDER_PROJECT_CODE,
                    BID_EVAL_START_TIME = ! apply.BID_EVAL_START_TIME.HasValue?"": apply.BID_EVAL_START_TIME.Value.ToString("yyyyMMddHHmmss"),
                    BID_EVAL_END_TIME = ! apply.BID_EVAL_END_TIME.HasValue?"": apply.BID_EVAL_END_TIME.Value.ToString("yyyyMMddHHmmss"),
                    AREA_CODE = detail.AREA_CODE,
                    CENTER_NAME = detail.CENTER_NAME,
                    STATUS = (int)detail.STATUS,
                    REMARK = null == record?"":record.REMARK,
                    EVAL_ROOM_NAME = seatRecord.Any() ?seatRecord.FirstOrDefault().EVAL_ROOM_NAME:"",
                    EVAL_ROOM_ADDR = "",
                    SEAT_NUMBER = seatRecord.Any() ?seatRecord.Select(t => t.SEAT_NUMBER):new List<string>()

                };
                var dataTiemstamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                var requestData = new
                {
                    action = "notify",
                    detail = detail,
                    requestid = requestid,
                    url = config.URL,
                    data = new
                    {
                        validation = new
                        {
                            DATAUUID = requestid,
                            SYSTEM_NO = SYSTEM_NO,
                            TIME = dataTiemstamp,
                            TOKEN = GenerateToken(requestid, dataTiemstamp, SYSTEM_NO, data, center.PRIVATE_KEY)
                        },
                        data = data,
                    }
                };
                GGZY.Core.Utils.QueueHttpRequest.Instance.Enqueue(requestData);
            }
            catch(Exception ex)
            {
                GGZY.Core.Log.LoggerR.Error(action + " 操作失败:" + ex.Message, ex);
            }
        }


        public void notify(string SERIES_NUMBER,string areacode="", string requestid = "")
        {
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_APPLY._.IS_DELETE ==0);
            condition.And(YDPB_EVAL_APPLY._.SERIES_NUMBER == SERIES_NUMBER);
            var apply = ServicesFactory.GGZYJD.YdpbEvalApplyService.FirstOrNull(condition);

            if(null ==apply)
            {
                GGZY.Core.Log.LoggerR.Warn(Guid.NewGuid().ToString(),"通知失败，未找到申请单信息。申请单编号：" + SERIES_NUMBER);
                return;
            }

            var detailCondition = new WhereClipBuilder();
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0);
            if(! String.IsNullOrWhiteSpace(areacode))
            {
                detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.AREA_CODE == areacode);
            }
            var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(detailCondition);
            if(! details.Any())
            {
                GGZY.Core.Log.LoggerR.Warn(Guid.NewGuid().ToString(), "通知失败，未找到会场信息。申请单编号：" + SERIES_NUMBER);
                return;
            }
            
            details.ForEach(e => {
                notify(apply, e);
            });
        }

        /// <summary>
        /// 生成请求token
        /// </summary>
        /// <param name="requestid"></param>
        /// <param name="time"></param>
        /// <param name="system_no"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private string GenerateToken(string requestid,string time,string system_no,dynamic data, string secret="12345678")
        {
            var md5 = GGZY.Core.Utils.CommonUtils.Md5Str(JsonConvert.SerializeObject(data));
            return CreateToken(system_no + requestid + time + md5, secret);
        }
        public  string CreateToken(string message, string secret = "12345678")
        {
            secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage).Replace("+", "_").Replace("/", "_").Replace("=", "_");
            }
        }
    }
}
