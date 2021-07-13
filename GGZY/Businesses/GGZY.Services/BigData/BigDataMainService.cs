using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Models;
using GGZY.Services.Base;

namespace GGZY.Services.BigData
{
    public partial class BigDataMainService : BaseService
    {
        public override DbSession GetDbSession()
        {
            return DbContext.Fw;
        }

        public GeneralResult GetData(BigDataSearchModel search)
        {
            var r = new GeneralResult();
            //行业类型参数
            if (!string.IsNullOrEmpty(search.TENDER_PROJECT_TYPE))
            {
                var tenderType = search.TENDER_PROJECT_TYPE;
                switch (tenderType)
                {
                    case "1":
                        search.TENDER_PROJECT_TYPE = "'A01','G01','A02','G02'";
                        break;
                    case "2":
                        search.TENDER_PROJECT_TYPE = "'A03','G03','A04','G04','A05','G05','A06','G06'";
                        break;
                    case "3":
                        search.TENDER_PROJECT_TYPE = "'A07','G07'";
                        break;
                    case "0":
                        search.TENDER_PROJECT_TYPE = "";
                        break;
                }
            }
            //处理专家信息混淆和脱敏
            List<string> tuomingCols = new List<string>() { "EXPERT_NAME", "ID_CARD", "LEGAL_NAME", "LEGAL_CODE" };
            string tuomingMethod = "USER_EXPERT_LIST,EXPERT_INFO,JG_EXPERT_LIST_COUNT,TENDERER_EXPERT,PROXY_EXPERT,TENDER_EXPERT,TENDER_EXPERT_WIN";
            //处理专家身份证的混淆号码
            if ("EXPERT_INFO,EXPERT_AGENCY,EXPERT_TENDERER,EXPERT_BIDDER,EXPERT_WIN_BIDDER,EXPERT_CHART_INFO,EXPERT_AREA".Contains(search.method) && !string.IsNullOrEmpty(search.mixcode))
            {
                char[] c = search.mixcode.ToArray();
                search.code =
                    $"{c[6]}{c[0]}{c[7]}{c[12]}{c[16]}{c[1]}{c[13]}{c[8]}{c[17]}{c[2]}{c[4]}{c[14]}{c[5]}{c[10]}{c[9]}{c[15]}{c[11]}{c[3]}";
            }

            string sql = GetSql(search, out string orderby, out List<OracleParameter> dbParams);
            if (string.IsNullOrEmpty(sql))
            {
                r.SetFail("查询不到对应方法");
                return r;
            }
            if (search.pageindex != 0 && search.pagesize != 0)
            {
                var dt = FromSqlByPage(sql, search.pageindex, search.pagesize, orderby, dbParams, out int count).ToDataTable();
                if (tuomingMethod.Contains(search.method))
                {
                    dt = AddMixCode(dt);//生成混淆列
                    dt = dt.DtDesensitization(tuomingCols.ToArray());
                }

                var result = new
                {
                    pageIndex = search.pageindex,
                    pageSize = search.pagesize,
                    count,
                    list = dt
                };
                r.SetSuccess(result);
            }
            else
            {
                var dt = FromSql(sql).AddParameter(dbParams.ToArray()).ToDataTable();
                if (tuomingMethod.Contains(search.method))
                {
                    dt = AddMixCode(dt);//生成混淆列
                    dt = dt.DtDesensitization(tuomingCols.ToArray());
                }
                r.SetSuccess(dt);
            }

            return r;
        }

        private string GetSql(BigDataSearchModel search, out string orderby, out List<OracleParameter> dbParams)
        {
            string sql = "";
            orderby = "";
            dbParams = new List<OracleParameter>();
            Tuple<string, string, string> sqlObj = sqlTuple.FirstOrDefault(e => e.Item1 == search.method);
            if (sqlObj != null)
            {
                orderby = sqlObj.Item2;
                sql = sqlObj.Item3;
                //部分sql语句判断地区是350000，替换掉整个sql
                switch (sqlObj.Item1)
                {
                    case "CQ_List_AmountCount":
                    case "GCJS_LeftAmountCount":
                    case "GCJS_LeftJieYue":
                        if (search.pareacode == "350000")
                        {
                            search.method += "_sheng";
                        }
                        break;
                }
                //处理sql_where_tm
                if (sql.Contains("###sql_where_tm###"))
                {
                    sql = sql.Replace("###sql_where_tm###", GetTimeWhere(search));
                }
                if (sql.Contains("###sql_where_tm_bb###"))
                {
                    sql = sql.Replace("###sql_where_tm_bb###", GetTimeWhere_bb(search));
                }
                if (sql.Contains("###sql_where_publish###"))
                {
                    sql = sql.Replace("###sql_where_publish###", GetTimeWhere_publish(search));
                }
                if (sql.Contains("###sql_where_Winbid_tm###"))
                {
                    sql = sql.Replace("###sql_where_Winbid_tm###", GetTimeWhere_winbid(search));
                }
                if (sql.Contains("###sql_where_winsendtm###"))
                {
                    sql = sql.Replace("###sql_where_winsendtm###", GetTimeWhere_winSend(search));
                }
                if (sql.Contains("###sql_where_checktm###"))
                {
                    sql = sql.Replace("###sql_where_checktm###", GetTimeWhere_check(search));
                }
                if (sql.Contains("###sql_where_year###"))
                {
                    sql = sql.Replace("###sql_where_year###", GetTimeWhere_year(search));
                }
                if (sql.Contains("###sql_where_expertcheck###"))
                {
                    sql = sql.Replace("###sql_where_expertcheck###", GetTimeWhere_common(search, "EXPERT_CHECK_IN_TIME"));
                }
                if (sql.Contains("###sql_where_tm_aa###"))
                {
                    sql = sql.Replace("###sql_where_tm_aa###", GetTimeWhere_common(search, "aa.M_TM"));
                }
                if (sql.Contains("###sql_where_tm_pro###"))
                {
                    sql = sql.Replace("###sql_where_tm_pro###", GetTimeWhere_common(search, "pro.CREATE_TIME"));
                }
                //处理pareacode
                if (sql.Contains("###pareacodeS###"))
                {
                    //如果是空去掉整个语句,如果存在这个参数去掉对应标记
                    if (!string.IsNullOrEmpty(search.pareacode) && search.pareacode != "350000")
                    {
                        sql = sql.Replace("###pareacodeS###", "").Replace("###pareacodeE###", "");
                    }
                    else
                    {
                        //递归删除特定标记间的值
                        sql = RemoveSpecialStr(sql, "###pareacodeS###", "###pareacodeE###");
                    }
                }
                //处理tenderprojecttype
                if (sql.Contains("###tendertypeS###"))
                {
                    if (!string.IsNullOrEmpty(search.TENDER_PROJECT_TYPE))
                    {
                        sql = sql.Replace("###tendertypeS###", "").Replace("###tendertypeE###", "").Replace("$TENDER_PROJECT_TYPE$", search.TENDER_PROJECT_TYPE);
                    }
                    else
                    {
                        sql = RemoveSpecialStr(sql, "###tendertypeS###", "###tendertypeE###");
                    }
                }
                //处理areacode
                if (sql.Contains("###areacodeS###"))
                {
                    if (!string.IsNullOrEmpty(search.AREACODE))
                    {
                        sql = sql.Replace("###areacodeS###", "").Replace("###areacodeE###", "");
                    }
                    else
                    {
                        sql = RemoveSpecialStr(sql, "###areacodeS###", "###areacodeE###");
                    }
                }
                //处理code
                if (sql.Contains("###codeS###"))
                {
                    if (!string.IsNullOrEmpty(search.code))
                    {
                        sql = sql.Replace("###codeS###", "").Replace("###codeE###", "");
                    }
                    else
                    {
                        sql = RemoveSpecialStr(sql, "###codeS###", "###codeE###");
                    }
                }
                //处理name
                if (sql.Contains("###nameS###"))
                {
                    if (!string.IsNullOrEmpty(search.name))
                    {
                        sql = sql.Replace("###nameS###", "").Replace("###nameE###", "");
                    }
                    else
                    {
                        sql = RemoveSpecialStr(sql, "###nameS###", "###nameE###");
                    }
                }

                //构建数据库参数
                foreach (PropertyInfo pro in search.GetPropertyInfos())
                {
                    List<string> filterStr = new List<string>()
                        {"pageindex", "pagesize", "mixcode", "method", "TENDER_PROJECT_TYPE"};
                    //去除不需要的参数和分页参数
                    if (!filterStr.Contains(pro.Name) && pro.GetValue(search) != null)
                    {
                        //如果是省级的行政区划代码也不处理
                        if (pro.Name == "pareacode" && pro.GetValue(search).ToString() == "350000")
                        {
                            continue;
                        }
                        switch (pro.PropertyType.FullName)
                        {
                            case "System.String":
                                string strValue = pro.GetValue(search).ToString();
                                if (!string.IsNullOrEmpty(strValue))
                                {
                                    dbParams.Add(new OracleParameter(":" + pro.Name, strValue));
                                }

                                break;
                            case "System.Decimal":
                                decimal decimalValue = decimal.Parse(pro.GetValue(search).ToString(), null);
                                if (decimalValue != 0)
                                {
                                    dbParams.Add(new OracleParameter(":" + pro.Name, decimalValue));
                                }

                                break;
                            case "System.Int32":
                                int intValue = int.Parse(pro.GetValue(search).ToString(), null);
                                if (intValue != 0)
                                {
                                    dbParams.Add(new OracleParameter(":" + pro.Name, intValue));
                                }

                                break;
                            case "System.Double":
                                double doubleValue = double.Parse(pro.GetValue(search).ToString(), null);
                                if (Math.Abs(doubleValue) > 0)
                                {
                                    dbParams.Add(new OracleParameter(":" + pro.Name, doubleValue));
                                }

                                break;
                            case "System.DateTime":
                                DateTime dateValue = DateTime.Parse(pro.GetValue(search).ToString());
                                if (!DateTime.MinValue.Equals(dateValue))
                                {
                                    dbParams.Add(new OracleParameter(":" + pro.Name, DbType.DateTime)
                                    { Value = dateValue });
                                }

                                break;
                        }
                    }
                }
            }
            return sql;
        }

        private string RemoveSpecialStr(string str, string startFlag, string endFlag)
        {
            //找出起始标记位置和结束
            int startIndex = str.IndexOf(startFlag);
            int endIndex = str.IndexOf(endFlag);
            if (startIndex == -1 || endIndex == -1)
            {
                return str;
            }
            else
            {
                //截取出两位置之间的字符串
                string tempStr = str.Substring(startIndex, endIndex + endFlag.Length - startIndex);
                //从原字符串中删除掉截取处理的字符串
                str = str.Replace(tempStr, "");
                //递归继续处理
                return RemoveSpecialStr(str, startFlag, endFlag);
            }
        }


        /// <summary>
        /// 添加混淆的专家身份证号码
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private DataTable AddMixCode(DataTable dt)
        {
            //如果不包含这下列字段不做处理
            if (!dt.Columns.Contains("ID_CARD") && !dt.Columns.Contains("LEGAL_CODE"))
            {
                return dt;
            }
            var col = new DataColumn("MIXCODE");
            dt.Columns.Add(col);
            foreach (DataRow row in dt.Rows)
            {
                //获取身份证号
                string code = row["ID_CARD"] != null ? row["ID_CARD"].ToString() : row["LEGAL_CODE"].ToString();
                if (!string.IsNullOrEmpty(code) && code.Length == 18)
                {
                    char[] c = code.ToArray();
                    string mixCode = $"{c[1]}{c[5]}{c[9]}{c[17]}{c[10]}{c[12]}{c[0]}{c[2]}{c[7]}{c[14]}{c[13]}{c[16]}{c[3]}{c[6]}{c[11]}{c[15]}{c[4]}{c[8]}";
                    row["MIXCODE"] = mixCode;
                }

            }

            return dt;
        }
        private string GetTimeWhere(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and M_TM is not null and  M_TM >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and M_TM <= :EndTime";
            }

            return result;
        }
        private string GetTimeWhere_bb(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and bb.M_TM is not null and  bb.M_TM >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and bb.M_TM <= :EndTime";
            }

            return result;
        }
        private string GetTimeWhere_winbid(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and b.M_TM >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and b.M_TM <= :EndTime";
            }

            if (!string.IsNullOrEmpty(search.TENDER_PROJECT_TYPE))
            {
                result += " and pro.tender_project_type in (" + search.TENDER_PROJECT_TYPE + ")";
            }

            return result;
        }
        private string GetTimeWhere_winSend(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and NOTICE_SEND_TIME >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and NOTICE_SEND_TIME <= :EndTime";
            }

            return result;
        }
        private string GetTimeWhere_check(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and CHECK_TM >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and CHECK_TM <= :EndTime";
            }

            return result;
        }
        private string GetTimeWhere_year(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and cc.NOTICE_SEND_TIME >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and cc.NOTICE_SEND_TIME <= :EndTime";
            }

            return result;
        }
        private string GetTimeWhere_publish(BigDataSearchModel search)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += " and PUBLISH_DATE >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += " and PUBLISH_DATE <= :EndTime";
            }

            return result;
        }
        private string GetTimeWhere_common(BigDataSearchModel search, string col)
        {
            string result = "";
            if (!DateTime.MinValue.Equals(search.BeginTime))
            {
                result += $" and {col} >= :BeginTime";
            }
            if (!DateTime.MinValue.Equals(search.EndTime))
            {
                result += $" and {col} <= :EndTime";
            }

            return result;
        }

    }
}
