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
    /// <summary>
    /// 生成整改意见书
    /// </summary>
    public class ReplaceZGD: BuildDoc
    {
        /// <summary>
        /// 生成整改意见书
        /// </summary>
        /// <param name="RECORD_ID"></param>
        /// <param name="ReviewType"></param>
        public ReplaceZGD(int RECORD_ID, string ReviewType) : base(RECORD_ID, ReviewType)
        {
        }
        public override Hashtable ReplaceWord(string guid = "")
        {
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
                case "MC102":
                case "MS102":
                case "MN102":
                case "MY102":
                case "MG102":
                case "MX102":
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
                throw new Exception("生成整改单失败:模板文件 " + fullPath + " 不存在或无法读取，请检查.");
            }
            AsposeWord word = new AsposeWord(fullPath);
            #region 数据替换并生成文件

            string Date = Convert.ToDateTime(BasicDt.Rows[0]["REVIEW_TIME"]).ToString("yyyy年MM月dd日");
            word.ReplaceText("{ADJUST_TIME}", Date);
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