using GGZY.Core.Helper;
using GGZY.Services.Infrastructure.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GGZY.Services.JianDu.Record_Review_Doc
{
    /// <summary>
    /// 住建签收单
    /// </summary>
    public class ZJ_ReplaceQSD : ZJ_BuildDoc
    {

        public ZJ_ReplaceQSD(int RECORD_ID, string ReviewType, string Version) : base(RECORD_ID, ReviewType, Version)
        {
        }
        public override Hashtable ReplaceWord(string guid = "")
        {
            Hashtable Ht = new Hashtable();
            switch (ReviewType)
            {
                case "MS104":
                    base.TempDocName = "招标投标过程材料报备签收单";
                    break;
                case "MS101":
                case "MC101":
                case "MT101":
                case "MJ101":
                case "MZ101":
                    base.TempDocName = "招标文件备案材料签收单";
                    break;
                case "MT104":
                case "MJ104":
                case "MZ104":
                case "MC104":
                case "MT1041":
                case "MZ1041":
                    base.TempDocName = "招标投标情况书面报告备案材料签收单";
                    break;
            }
            var directory = Path.Combine("~\\App_Data" + "\\BascAudit\\");

            string fullPath = HttpContext.Current.Server.MapPath(Path.Combine(directory, ReviewType + "_" + base.TempDocName + ".docx"));
            if (!File.Exists(fullPath))
            {
                throw new Exception("生成签收单失败:模板文件 " + fullPath + " 不存在或无法读取，请检查.");
            }
            AsposeWord word = new AsposeWord(fullPath);

            #region 数据替换并生成文件

            #region 基础数据替换
            string valueStr = BasicDt.Rows[0]["REVIEW_STATUS"].ToString();
            switch (valueStr)
            {
                case "2":
                    word.ReplaceText(@"\{" + valueStr + @"_CHECK\}", "√");
                    word.ReplaceText(@"\{3_CHECK\}", "□");
                    word.ReplaceText(@"\{1_IS_SIGN\}", "□");
                    word.ReplaceText(@"\{COMMENT\}", "");
                    break;
                case "3":
                    word.ReplaceText(@"\{" + valueStr + "_CHECK}", "√");
                    word.ReplaceText(@"\{2_CHECK\}", "□");
                    word.ReplaceText(@"\{1_IS_SIGN\}", "□");
                    word.ReplaceText(@"\{COMMENT\}", BasicDt.Rows[0]["SIGN_COMMENT"].ToString());
                    break;
                default:
                    word.ReplaceText(@"\{2_CHECK\}", "□");
                    word.ReplaceText(@"\{3_CHECK\}", "□");
                    word.ReplaceText(@"\{1_IS_SIGN\}", "√");
                    word.ReplaceText(@"\{COMMENT\}", "");
                    break;
            };
            RepBasic(word);
            #endregion

            #region 获取附件信息并替换
            if (AttDt.Rows.Count > 0)
            {
                for (int i = 0; i < AttDt.Rows.Count; i++)
                {
                    DataRow Att = AttDt.Rows[i];
                    string key = Att["ATTFILE_TYPECODE"].ToString();
                    string value = Att["IS_INTACT"].ToString();
                    switch (value)
                    {
                        case "0": //不完整状态
                            word.ReplaceText(@"\{" + key + @"\}", "□");
                            break;
                        case "1": //完整状态
                            word.ReplaceText(@"\{" + key + @"\}", "√");
                            break;
                        default:
                            word.ReplaceText(@"\{" + key + @"\}", "□");
                            break;
                    }
                }
                if (ReviewType == "MZ1041" || ReviewType == "MT1041")
                {
                    StringBuilder sbSql = new StringBuilder();
                    sbSql.AppendLine("SELECT B.BID_SECTION_NAME,");
                    sbSql.AppendLine("       A.BID_SECTION_CODE,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MZ104_F11', IS_INTACT)) MZ104_F11,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MZ104_F09', IS_INTACT)) MZ104_F09,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MZ104_F08', IS_INTACT)) MZ104_F08,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MZ104_F07', IS_INTACT)) MZ104_F07,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MZ104_F05', IS_INTACT)) MZ104_F05,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MT104_F11', IS_INTACT)) MT104_F11,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MT104_F09', IS_INTACT)) MT104_F09,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MT104_F08', IS_INTACT)) MT104_F08,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MT104_F07', IS_INTACT)) MT104_F07,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MT104_F05', IS_INTACT)) MT104_F05,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MC104_F11', IS_INTACT)) MC104_F11,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MC104_F09', IS_INTACT)) MC104_F09,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MC104_F08', IS_INTACT)) MC104_F08,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MC104_F07', IS_INTACT)) MC104_F07,");
                    sbSql.AppendLine("       SUM(decode(A.ATTFILE_TYPECODE, 'MC104_F05', IS_INTACT)) MC104_F05");
                    sbSql.AppendLine("  FROM RECORD_ATTACHMENT A");
                    sbSql.AppendLine(" INNER JOIN SECTION B");
                    sbSql.AppendLine("    ON A.BID_SECTION_CODE = B.BID_SECTION_CODE");
                    sbSql.AppendLine(" WHERE RECORD_ID = "+base.RecordId);
                    sbSql.AppendLine(" group by BID_SECTION_NAME, A.BID_SECTION_CODE, b.data_timestamp");
                    sbSql.AppendLine(" order by b.data_timestamp");


                    DataTable dt = FromSql(sbSql.ToString()).ToDataTable();
                    dt.Columns.Add("RN", typeof(string));
                    //查询出的datatable数据，新建datatable的数据类型改为字符型，再把数据插入到新的datatable
                    DataTable dtNew = new DataTable();
                    dtNew = dt.Clone();
                    foreach (DataColumn col in dtNew.Columns)
                    {
                        if (col.DataType.FullName == "System.Decimal")
                        {
                            col.DataType = Type.GetType("System.String");
                        }
                    }
                    //把数据全部导入到dtNew的datatable中
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        DataRow drNew = dtNew.NewRow();
                        dr["RN"] = i + 1;
                        drNew["RN"] = i + 1;
                        foreach (DataColumn column in dt.Columns)
                        {
                            drNew[column.ColumnName] = dr[column.ColumnName];
                        }
                        dtNew.Rows.Add(drNew);
                    }

                    //将数据修改为附件应有的格式
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {
                        DataRow dr = dtNew.Rows[i];
                        for (int j = 0; j < dtNew.Columns.Count; j++)
                        {
                            if (dtNew.Columns[j].ColumnName != "BID_SECTION_CODE" && dtNew.Columns[j].ColumnName != "BID_SECTION_NAME" && dtNew.Columns[j].ColumnName != "RN")
                            {
                                if (dr[j].ToString() == "1")
                                {
                                    dr[j] = "√";
                                }
                                else
                                {
                                    dr[j] = "□";
                                }
                            }

                        }
                    }
                    dtNew.TableName = "ATTBID";
                    word.doc.MailMerge.ExecuteWithRegions(dtNew);
                }
            }
            #endregion

            #region 生成word
            string url = GetUrl(guid);
            string SaveUrl = Path.Combine(ConfigHelper.AppSettings.UploadDirectory, url.TrimStart('/').TrimStart('\\'));
            var dir = SaveUrl.Replace(Path.GetFileName(SaveUrl), "");
            var directorySave = HttpContext.Current?.Server.MapPath("~"+dir);
            if (!Directory.Exists(directorySave))
            {
                try
                {
                    Directory.CreateDirectory(directorySave);
                }
                catch (Exception ex)
                {
                    throw new Exception("生成" + base.TempDocName + "PDF失败:创建保存目录失败." + ex.Message, ex);
                }
            }
            string SaveName = GetDocName();
            word.SaveAs(HttpContext.Current?.Server.MapPath("~" + SaveUrl), "pdf");
            #endregion

            Ht.Add("URL", SaveUrl.Replace("//", "/"));
            Ht.Add("SAVENAME", SaveName);
            return Ht;
            #endregion
        }
    }
}
