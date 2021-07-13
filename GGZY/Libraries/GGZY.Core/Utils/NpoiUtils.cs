using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.XWPF.UserModel;

namespace GGZY.Core.Utils
{
    public class NpoiUtils
    {
        //public static byte[] ExportDocx(AgreementConfirmViewModel model)
        //{
        //    var fullPath = HttpContext.Current.Server.MapPath("/Doc/手机游戏开放平台合作协议V1.0.docx");
        //    XWPFDocument doc;
        //    using (FileStream stream = File.OpenRead(fullPath))
        //    {

        //        doc = new XWPFDocument(stream);
        //        foreach (var para in doc.Paragraphs)
        //        {
        //            var runs = para.Runs;
        //            foreach (var run in runs)
        //            {
        //                var p = run.GetTextPosition() == -1 ? 0 : run.GetTextPosition();
        //                string text = run.GetText(p);
        //                text = text.Replace("AppName", model.AppName).Replace("{CompanyName}", model.CompanyName).Replace("{FullAddress}", model.FullAddress).Replace("{Contact}", model.Contact).Replace("{Email}", model.Email).Replace("{Phone}", model.Phone);
        //                run.SetText(text, 0);
        //            }
        //        }
        //        //doc1 = doc;
        //    }
        //    var tempPath = HttpContext.Current.Server.MapPath("/Doc/Temp/");
        //    if (!Directory.Exists(tempPath))
        //    {
        //        Directory.CreateDirectory(tempPath);
        //    }
        //    var tempFullPath = string.Format("{0}{1}_手机游戏开放平台合作协议.docx", tempPath, model.CompanyName);
        //    if (File.Exists(tempFullPath))
        //    {
        //        File.Delete(tempFullPath);
        //    }
        //    using (FileStream fs = File.Create(tempFullPath))
        //    {
        //        doc.Write(fs);
        //    }
        //    using (FileStream fs = File.OpenRead(tempFullPath))
        //    {
        //        byte[] bytes = new byte[fs.Length];
        //        fs.Read(bytes, 0, bytes.Length);
        //        // 设置当前流的位置为流的开始
        //        fs.Seek(0, SeekOrigin.Begin);
        //        return bytes;
        //    }
        //}
        //public static string ExportDocxWithPath(AgreementConfirmViewModel model)
        //{
        //    var fullPath = HttpContext.Current.Server.MapPath("/Doc/手机游戏开放平台合作协议V1.0.docx");
        //    XWPFDocument doc;
        //    using (FileStream stream = File.OpenRead(fullPath))
        //    {

        //        doc = new XWPFDocument(stream);
        //        foreach (var para in doc.Paragraphs)
        //        {
        //            var runs = para.Runs;
        //            foreach (var run in runs)
        //            {
        //                var p = run.GetTextPosition() == -1 ? 0 : run.GetTextPosition();
        //                string text = run.GetText(p);
        //                text = text.Replace("AppName", model.AppName).Replace("{CompanyName}", model.CompanyName).Replace("{FullAddress}", model.FullAddress).Replace("{Contact}", model.Contact).Replace("{Email}", model.Email).Replace("{Phone}", model.Phone);
        //                run.SetText(text, 0);
        //            }
        //        }
        //        //doc1 = doc;
        //    }
        //    var tempPath = HttpContext.Current.Server.MapPath("/Doc/Temp/");
        //    if (!Directory.Exists(tempPath))
        //    {
        //        Directory.CreateDirectory(tempPath);
        //    }
        //    var tempFullPath = string.Format("{0}{1}_手机游戏开放平台合作协议.docx", tempPath, model.CompanyName);
        //    if (File.Exists(tempFullPath))
        //    {
        //        File.Delete(tempFullPath);
        //    }
        //    using (FileStream fs = File.Create(tempFullPath))
        //    {
        //        doc.Write(fs);
        //    }
        //    return tempFullPath;
        //}
        public static Dictionary<PropertyInfo, DisplayAttribute> GetExportAttrDict<T>()
        {
            var dict = new Dictionary<PropertyInfo, DisplayAttribute>();
            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                var attr = propertyInfo.GetCustomAttributes(true).FirstOrDefault(c => c is DisplayAttribute);
                if (attr != null)
                {
                    var attr1 = attr;
                    if (attr is DisplayAttribute display)
                    {
                        attr1 = new DisplayAttribute() { Order = display.Order,Name= display.Name };
                    }
                    dict.Add(propertyInfo, attr1 as DisplayAttribute);

                }
            }
            return dict;
        }

        /// <summary>
        /// 生存Excel.
        /// </summary>
        /// <typeparam name="TModel">数据源类型【泛型】.</typeparam>
        /// <param name="data">数据源.</param>
        /// <returns></returns>
        public static byte[] GenerateExcel<TModel>(IEnumerable<TModel> data)
        {
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet();
            var attrDict = GetExportAttrDict<TModel>();
            var attrArray = attrDict.OrderBy(c => c.Value.Order).ToArray();
            for (int i = 0; i < attrArray.Length; i++)
            {
                sheet.SetColumnWidth(i, 50 * 256);
            }
            var headerRow = sheet.CreateRow(0);

            for (int i = 0; i < attrArray.Length; i++)
            {
                headerRow.CreateCell(i).SetCellValue(attrArray[i].Value.Name);
            }
            int rowNumber = 1;
            foreach (var item in data)
            {
                var row = sheet.CreateRow(rowNumber++);
                for (int i = 0; i < attrArray.Length; i++)
                {
                    row.CreateCell(i).SetCellValue((attrArray[i].Key.GetValue(item, null) ?? "").ToString());
                }
            }
            using (var output = new MemoryStream())
            {
                workbook.Write(output);
                var bytes = output.ToArray();
                return bytes;
            }
        }

        /// <summary>
        /// 生存Excel.
        /// </summary>
        /// <typeparam name="TModel">数据源类型【泛型】.</typeparam>
        /// <param name="data">数据源.</param>
        /// <param name="path">文件保存路径.</param>
        /// <returns></returns>
        public static void GenerateExcelPath<TModel>(IEnumerable<TModel> data,string path)
        {
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet();
            var attrDict = GetExportAttrDict<TModel>();
            var attrArray = attrDict.OrderBy(c => c.Value.Order).ToArray();
            for (int i = 0; i < attrArray.Length; i++)
            {
                sheet.SetColumnWidth(i, 50 * 256);
            }
            var headerRow = sheet.CreateRow(0);

            for (int i = 0; i < attrArray.Length; i++)
            {
                headerRow.CreateCell(i).SetCellValue(attrArray[i].Value.Name);
            }
            int rowNumber = 1;
            foreach (var item in data)
            {
                var row = sheet.CreateRow(rowNumber++);
                for (int i = 0; i < attrArray.Length; i++)
                {
                    row.CreateCell(i).SetCellValue((attrArray[i].Key.GetValue(item, null) ?? "").ToString());
                }
            }

            path.CreateDirectoryIfNotExist();
            
            using (var output = new FileStream(path,FileMode.Create))
            {
                workbook.Write(output);
            }

          
        }


        ///// <summary>
        ///// 公安外网-导出使用
        ///// </summary>
        ///// <typeparam name="TModel"></typeparam>
        ///// <param name="data"></param>
        ///// <param name="titles"></param>
        ///// <returns></returns>
        //public static byte[] GenerateExcel<TModel>(this IEnumerable<TModel> data, params string[] titles)
        //{
        //    var workbook = new HSSFWorkbook();
        //    var sheet = workbook.CreateSheet();

        //    int rowNumber = 0;

        //    var properties = typeof(TModel).GetProperties();
        //    if (titles.Length == properties.Length)
        //    {
        //        foreach (TModel m in data)
        //        {
        //            if (rowNumber == 0)
        //            {
        //                for (int i = 0; i < titles.Length; i++)
        //                {
        //                    sheet.SetColumnWidth(i, 50 * 256);
        //                }
        //                var headerRow = sheet.CreateRow(rowNumber);

        //                for (int i = 0; i < titles.Length; i++)
        //                {
        //                    var value = titles[i];
        //                    headerRow.CreateCell(i).SetCellValue(value);
        //                }
        //            }
        //            var row = sheet.CreateRow(++rowNumber);
        //            for (int i = 0; i < properties.Length; i++)
        //            {
        //                System.Reflection.PropertyInfo p = properties[i];
        //                var v = p.GetValue(m)?.ToString();
        //                row.CreateCell(i).SetCellValue(v);
        //            }

        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("表头长度不匹配");
        //    }
        //    using (var output = new MemoryStream())
        //    {
        //        workbook.Write(output);
        //        var bytes = output.ToArray();
        //        return bytes;
        //    }
        //}

        /// <summary>
        /// 根据模版生存Word.
        /// </summary>
        /// <typeparam name="TModel">数据源类型【泛型】.</typeparam>
        /// <param name="data">数据源.</param>
        /// <param name="path">模板路径.</param>
        /// <returns></returns>
        public static byte[] GenerateWord<TModel>(TModel data, string path)
        {
            var fullPath = HttpContext.Current.Server.MapPath(path);
            var dic = GetExportAttrDict<TModel>();
            XWPFDocument doc;
            using (FileStream stream = File.OpenRead(fullPath))
            {
                doc = new XWPFDocument(stream);
                foreach (var para in doc.Paragraphs)
                {
                    var runs = para.Runs;
                    foreach (var run in runs)
                    {
                        var p = run.GetTextPosition() == -1 ? 0 : run.GetTextPosition();
                        string text = run.GetText(p);
                        foreach (var item in dic)
                        {
                            var key = item.Value.Name;
                            var value = item.Key.GetValue(data, null).ToString();
                            text = text.Replace(key, value);
                        }
                        run.SetText(text, 0);
                    }
                }
            }
            using (MemoryStream ms = new MemoryStream())
            {
                doc.Write(ms);
                return ms.ToArray();
            }
        }

        public static IEnumerable<TModel> GenerateIEnumerable<TModel>(string path,string sheetName="sheet1") where TModel : class, new()
        {
            //List<TModel> list = new List<TModel>();
            IEnumerator rows = GetDataRows(path,sheetName:sheetName);
            if (rows != null)
            {
                var dict = GetExportAttrDict<TModel>();
                var dictColumns = new Dictionary<int, KeyValuePair<PropertyInfo, DisplayAttribute>>();
                var titleRow = (IRow)rows.Current;
                foreach (var cell in titleRow.Cells)
                {
                    var prop = dict.FirstOrDefault(c => cell.StringCellValue == c.Value.Name);
                    if (prop.Key != null && !dictColumns.ContainsKey(cell.ColumnIndex))
                    {
                        dictColumns.Add(cell.ColumnIndex, prop);
                    }
                }
                while (rows.MoveNext())
                {
                    var row = (IRow)rows.Current;
                    var firstCell = row.GetCell(0);
                    if (firstCell == null || firstCell.CellType == CellType.Blank ||
                        string.IsNullOrWhiteSpace(firstCell.ToString()))
                        continue;

                    var model = new TModel();

                    foreach (var pair in dictColumns)
                    {
                        var propType = pair.Value.Key.PropertyType;
                        if (propType == typeof(DateTime?) ||
                            propType == typeof(DateTime))
                        {
                            pair.Value.Key.SetValue(model, GetCellDateTime(row, pair.Key), null);
                        }
                        else
                        {
                            var val = Convert.ChangeType(GetCellValue(row, pair.Key), propType);
                            pair.Value.Key.SetValue(model, val, null);
                        }
                    }
                    yield return model;
                }
            }
            //return list;
        }

        static DateTime? GetCellDateTime(IRow row, int index)
        {
            DateTime? result = null;
            try
            {
                switch (row.GetCell(index).CellType)
                {
                    case CellType.Numeric:
                        try
                        {
                            result = row.GetCell(index).DateCellValue;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case CellType.String:
                        var str = row.GetCell(index).StringCellValue;
                        if (str.EndsWith("年"))
                        {
                            DateTime dt;
                            if (DateTime.TryParse((str + "-01-01").Replace("年", ""), out dt))
                            {
                                result = dt;
                            }
                        }
                        else if (str.EndsWith("月"))
                        {
                            DateTime dt;
                            if (DateTime.TryParse((str + "-01").Replace("年", "").Replace("月", ""), out dt))
                            {
                                result = dt;
                            }
                        }
                        else if (!str.Contains("年") && !str.Contains("月") && !str.Contains("日"))
                        {

                            DateTime dt;
                            if (DateTime.TryParse(str, out dt))
                            {
                                result = dt;
                            }
                            else if (DateTime.TryParse((str + "-01-01").Replace("年", "").Replace("月", ""), out dt))
                            {
                                result = dt;
                            }
                            else
                            {
                                result = null;
                            }

                        }
                        else
                        {
                            DateTime dt;
                            if (DateTime.TryParse(str.Replace("年", "").Replace("月", ""), out dt))
                            {
                                result = dt;
                            }
                        }
                        break;
                    case CellType.Blank:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
        static IEnumerator GetDataRows(string path, bool withoutTitle = true, string sheetName = "sheet1")
        {
            if (string.IsNullOrWhiteSpace(path))
                return null;
            IWorkbook workbook;
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    if (path.IndexOf(".xlsx", StringComparison.Ordinal) > 0)
                    {
                        workbook = new XSSFWorkbook(fs);
                    }
                    else
                    {
                        workbook = new HSSFWorkbook(fs);
                    }
                }
            }
            catch
            {
                return null;
            }

            ISheet sheet = workbook.GetSheet(sheetName) ?? workbook.GetSheetAt(0);
            IEnumerator rows = sheet.GetRowEnumerator();
            if (withoutTitle) rows.MoveNext();
            return rows;
        }

        static string GetCellValue(IRow row, int index)
        {
            var result = string.Empty;
            try
            {
                switch (row.GetCell(index).CellType)
                {
                    case CellType.Numeric:
                        result = row.GetCell(index).NumericCellValue.ToString();
                        break;
                    case CellType.String:
                        result = row.GetCell(index).StringCellValue;
                        break;
                    case CellType.Blank:
                        result = string.Empty;
                        break;
                    #region

                    //case CellType.Formula:
                    //    result = row.GetCell(index).CellFormula;
                    //    break;
                    //case CellType.Boolean:
                    //    result = row.GetCell(index).NumericCellValue.ToString();
                    //    break;
                    //case CellType.Error:
                    //    result = row.GetCell(index).NumericCellValue.ToString();
                    //    break;
                    //case CellType.Unknown:
                    //    result = row.GetCell(index).NumericCellValue.ToString();
                    //    break;

                    #endregion
                    default:
                        result = row.GetCell(index).ToString();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return (result ?? "").Trim();
        }
    }
}