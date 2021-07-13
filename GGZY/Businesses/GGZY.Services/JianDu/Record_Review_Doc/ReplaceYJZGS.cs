using GGZY.Core.Helper;
using GGZY.Services.Infrastructure.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GGZY.Services.JianDu.Record_Review_Doc
{
    public class ReplaceYJZGS : BuildDoc
    {
        public ReplaceYJZGS(int RECORD_ID, string ReviewType) : base(RECORD_ID, ReviewType)
        {
        }
        public override Hashtable ReplaceWord(string guid = "")
        {
#pragma warning disable CS0219 // 变量“HaveCredit”已被赋值，但从未使用过它的值
            bool HaveCredit = false;
#pragma warning restore CS0219 // 变量“HaveCredit”已被赋值，但从未使用过它的值
            Hashtable Ht = new Hashtable();
            switch (ReviewType)
            {
                case "MS101":
                case "MC101":
                case "MJ101":
                case "MN101":
                case "MY101":
                case "MG101":
                case "MX101":
                    base.TempDocName = "招标文件整改意见书";
                    break;
                case "MZ101":
                case "MT101":
                    HaveCredit = true;
                    base.TempDocName = "招标文件整改意见书";
                    break;
                case "MC102":
                case "MS102":
                case "MN102":
                case "MY102":
                case "MG102":
                case "MX102":
                    base.TempDocName = "答疑澄清整改意见书";
                    break;
                case "MT102":
                case "MZ102":
                    HaveCredit = true;
                    base.TempDocName = "答疑澄清整改意见书";
                    break;
                case "MJ102":
                    base.TempDocName = "补遗书整改意见书";
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
            //基础数据替换
            word.ReplaceText("{REVIEW_COMMENT}", BasicDt.Rows[0]["AMENDMENT_OPINION"].ToString());
            RepBasic(word);

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
                    throw new Exception("生成"+base.TempDocName+"PDF失败:创建保存目录失败." + ex.Message, ex);
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
