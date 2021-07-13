using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using GGZY.DataV4Service.Db;
using NLog;
using GGZY.DataV4Service.Exceptions;
using GGZY.DataV4Service.Extend;
using GGZY.DataV4Service.Logger;
using GGZY.DataV4Service.Validators;
using GGZY.DataV4Service.Validators.Title;
using Newtonsoft.Json;

namespace GGZY.DataV4Service
{
    public class DataManager
    {
        /// <summary>
        /// 上报数据主入口
        /// </summary>
        /// <param name="validation"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string UploadData(string validation, string data, string version)
        {
            var uploadId = Guid.NewGuid().ToString();
            var systemNo = "";
            var dataKey = "";
            var dataOpt = new DataOperator(version);
            try
            {
                StrongLogger.Debug(systemNo, dataKey,
                    $"上报数据({uploadId})，validation：{validation}，data：{data}，version:{version}");
                systemNo = dataOpt.GetSystemNo(validation);
                StrongLogger.Debug(systemNo, dataKey, $"身份验证({uploadId})");
                systemNo = dataOpt.ValidateToken(validation);
                StrongLogger.Debug(systemNo, dataKey, $"身份验证通过({uploadId})");

                StrongLogger.Debug(systemNo, dataKey, $"解析数据({uploadId})");
                var dataTableList = dataOpt.GetXmlContent(data);
                var dtTile = dataTableList[0];
                var dtContext = dataTableList[1];
                var dtFile = dataTableList[2];
                dataKey = dtTile.GetStringValue(Constant.DATA_KEY);


                StrongLogger.Debug(systemNo, dataKey, $"解析数据完成({uploadId})，DATA_KEY值:{dataKey}");

                StrongLogger.Debug(systemNo, dataKey, $"验证TITLE节点数据({uploadId})");
                dataOpt.ValidateTitle(dtTile, dtContext, systemNo);
                StrongLogger.Debug(systemNo, dataKey, $"验证TITLE节点数据通过({uploadId})");

                StrongLogger.Debug(systemNo, dataKey, $"验证CONTEXT节点数据({uploadId})");
                dataOpt.ValidateContext(dtTile, dtContext);
                StrongLogger.Debug(systemNo, dataKey, $"验证CONTEXT节点数据通过({uploadId})");

                StrongLogger.Debug(systemNo, dataKey, $"验证附件节点数据({uploadId})");
                dataOpt.ValidateFile(dtFile, systemNo);
                StrongLogger.Debug(systemNo, dataKey, $"验证附件节点数据通过({uploadId})");

                StrongLogger.Debug(systemNo, dataKey, $"保存数据({uploadId})");
                dataOpt.SaveData(dtTile, dtContext, dtFile, systemNo);
                StrongLogger.Debug(systemNo, dataKey, $"保存数据完成({uploadId})");

                UploadData2WeiXin(dtTile, dataKey, data, dtContext.GetStringValue("TENDER_PROJECT_CODE"));

                return JsonConvert.SerializeObject(new
                {
                    STATUS = "1"
                });
            }
            catch (Exception ex)
            {
                if (ex is StrongException)
                {
                    StrongLogger.Debug(systemNo, dataKey, ex.Message);
                }
                else
                {
                    StrongLogger.Error(systemNo, dataKey, "系统异常错误", ex);
                }
                return JsonConvert.SerializeObject(new
                {
                    STATUS = "-1",
                    MSG = ex.Message
                });
            }


        }
        /// <summary>
        /// 推送数据到微信订阅号系统
        /// </summary>
        /// <param name="dtTitle">客户端提交XML Title反序列化表</param>
        /// <param name="datakey"></param>
        /// <param name="data">XML报文</param>
        public static void UploadData2WeiXin(DataTable dtTitle, string datakey, string data, string tenderProjectCode)
        {
            string dataNo = dtTitle.GetStringValue("DATA_NO");
            string dataType = dtTitle.GetStringValue("DATA_TYPE");
            //如果是招标公告的验证备案状态通过才发送
            if ("803,833,863,9403,9503,9603".Contains(dataNo) && CheckRecordReviewStatus(dtTitle, tenderProjectCode))
            {
                //创建临时数据，等备案提交由值守程序发布
                if (dataType == "1")
                {
                    string sql =
                        "insert into Tender_ann_temp_data values(:datakey,:tender_project_code,:xmldata,:tender_type)";
                    string dataEn = dtTitle.GetStringValue("DATA_EN").Substring(0, 3);
                    string TenderType = "";
                    switch (dataEn)
                    {
                        case "ZJ_":
                        case "SL_":
                        case "JT_":
                        case "YG_":
                        case "GY_":
                        case "XX_":
                            TenderType = dataEn;
                            break;
                    }

                    List<OracleParameter> param = new List<OracleParameter>()
                    {
                        new OracleParameter("datakey", datakey),
                        new OracleParameter("tender_project_code", tenderProjectCode),
                        new OracleParameter("tender_type", TenderType)
                    };
                    OracleParameter p = new OracleParameter("xmldata", OracleType.Clob) { Value = data };
                    param.Add(p);
                    DAO.GGFW.ExecuteSql(sql, param.ToArray());
                    return;
                }
                else if (dataType == "2")
                {
                    string sql =
                        "update Tender_ann_temp_data set xmldata = :xmldata where datakey = :datakey";
                    string dataEn = dtTitle.GetStringValue("DATA_EN").Substring(0, 3);
                    string TenderType = "";
                    switch (dataEn)
                    {
                        case "ZJ_":
                        case "SL_":
                        case "JT_":
                        case "YG_":
                        case "GY_":
                        case "XX_":
                            TenderType = dataEn;
                            break;
                    }

                    List<OracleParameter> param = new List<OracleParameter>()
                    {
                        new OracleParameter("datakey", datakey)
                    };
                    OracleParameter p = new OracleParameter("xmldata", OracleType.Clob) { Value = data };
                    param.Add(p);
                    DAO.GGFW.ExecuteSql(sql, param.ToArray());
                    return;
                }
                else
                {
                    return;
                }
            }
            if (null == dtTitle || dtTitle.TableName != "TITLE")
            {
                return;
            }
            if (dtTitle.Rows.Count == 0)
            {
                return;
            }
            if (dtTitle.Columns.Count == 0 || !dtTitle.Columns.Contains("DATA_EN"))
            {
                return;
            }
            string data_en = dtTitle.GetStringValue(Constant.DATA_EN);

            if (!data.Contains("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"))
            {
                data = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + data;
            }
            Common.QueueRequest.Instance.Enqueue(datakey, data_en, data);
        }
        private static bool CheckRecordReviewStatus(DataTable dtTitle, string tenderProjectCode)
        {
            string dataEn = dtTitle.GetStringValue("DATA_EN").Substring(0, 3);
            string TenderType = "";
            switch (dataEn)
            {
                case "ZJ_":
                case "SL_":
                case "JT_":
                case "YG_":
                case "GY_":
                case "XX_":
                    TenderType = dataEn;
                    break;
            }

            if (!string.IsNullOrEmpty(TenderType))
            {
                string sqlCode = $"select tender_record_code from {TenderType}tender_project where tender_project_code = '{tenderProjectCode}'";
                var dt = DAO.XZJD.GetDataSet(sqlCode).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string code = dt.Rows[0][0].ToString();
                    //获取备案状态
                    if (code != "A999999999999999")
                    {
                        sqlCode = $"select REVIEW_STATUS from record_review where review_code = '{code}'";
                        dt = DAO.XZJD.GetDataSet(sqlCode).Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            //获取状态的中文描述
                            string status = dt.Rows[0][0].ToString();
                            if ("ZJ_,XX_,GY_,YG_".Contains(TenderType))
                            {
                                if (!"4,5,6".Contains(status))
                                {
                                    return true;
                                }

                            }
                            if ("SL_,JT_".Contains(TenderType))
                            {
                                if (!"5".Contains(status))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }














    }
}
