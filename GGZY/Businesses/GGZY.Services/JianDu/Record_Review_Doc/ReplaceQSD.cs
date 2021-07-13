using GGZY.Core.Helper;
using GGZY.Services.Infrastructure.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GGZY.Services.JianDu.Record_Review_Doc
{
    /// <summary>
    /// 生成签收单
    /// </summary>
    public class ReplaceQSD : BuildDoc
    {
        public ReplaceQSD(int RECORD_ID, string ReviewType) : base(RECORD_ID, ReviewType)
        {
        }
        public override Hashtable ReplaceWord(string guid = "")
        {
            Hashtable Ht = new Hashtable();
            switch (ReviewType)
            {
                case "MS104":
                case "MN104":
                case "MY104":
                case "MG104":
                case "MX104":
                    base.TempDocName = "招标投标过程材料报备签收单";
                    break;
                case "MS101":
                case "MC101":
                case "MT101":
                case "MJ101":
                case "MZ101":
                case "MN101":
                case "MY101":
                case "MG101":
                case "MX101":
                    base.TempDocName = "招标文件备案材料签收单";
                    break;
                case "MT104":
                case "MJ104":
                case "MZ104":
                case "MC104":
                    base.TempDocName = "招标投标情况书面报告备案材料签收单";
                    break;
            }
            var directory = Path.Combine("~\\App_Data" + "\\BascAudit\\" );

            string fullPath = HttpContext.Current.Server.MapPath(Path.Combine(directory, ReviewType + "_" + base.TempDocName + ".docx"));
            if(! File.Exists(fullPath))
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
                    word.ReplaceText(@"\{3_CHECK}", "□");
                    word.ReplaceText(@"\{1_IS_SIGN}", "□");
                    word.ReplaceText(@"\{COMMENT}", "");
                    break;
                case "3":
                    word.ReplaceText(@"\{" + valueStr + @"_CHECK\}", "√");
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
            }
            #endregion

            #region 生成word
            string url = GetUrl(guid);
            string SaveUrl = Path.Combine(ConfigHelper.AppSettings.UploadDirectory, url.TrimStart('/').TrimStart('\\'));
            var dir = SaveUrl.Replace(Path.GetFileName(SaveUrl), "");
            var directorySave = HttpContext.Current?.Server.MapPath("~"+dir);
            if(! Directory.Exists(directorySave))
            {
                try
                {
                    Directory.CreateDirectory(directorySave);
                }
                catch (Exception ex)
                {
                    throw new Exception("生成"+base.TempDocName+"PDF失败:创建保存目录失败." + ex.Message, ex);
                }
            }
            string SaveName = GetDocName();
            word.SaveAs(HttpContext.Current?.Server.MapPath("~"+SaveUrl), "pdf");
            #endregion

            Ht.Add("URL", SaveUrl.Replace("//","/"));
            Ht.Add("SAVENAME", SaveName);
            return Ht;
            #endregion
        }
    }
}
