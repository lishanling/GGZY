using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using GGZY.Core.Extensions;

namespace GGZY.Core.Helper
{
    public static class ExcelHelper
    {

        public static string ListToExcel<T>(List<T> list, List<Tuple<string, string>> headList, string saveUrl)
        {
            Workbook wb = new Workbook();
            Cells cells = wb.Worksheets[0].Cells;
            int i = 1, j = 0;
            //生成首行
            foreach (var head in headList)
            {
                cells[0, j].PutValue(head.Item2);
                j++;
            }
            //填充数据
            Type objType = typeof(T);
            foreach (T obj in list)
            {
                j = 0;
                for (j = 0; j < headList.Count; j++)
                {
                    PropertyInfo proInfo = objType.GetProperty(headList[j].Item1);
                    if (proInfo != null)
                    {
                        string value = "";
                        if (proInfo.PropertyType.FullName.ToLower().Contains("DateTime"))
                        {
                            value = DateTime.Parse(proInfo.GetValue(obj).ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            value = proInfo.GetValue(obj)?.ToString();
                        }
                        cells[i, j].PutValue(value);
                    }
                }
                i++;

            }
            //保存表格
            string saveDoMminurl = AppDomain.CurrentDomain.BaseDirectory + saveUrl.Replace("/", "\\");
            wb.Save(AppDomain.CurrentDomain.BaseDirectory + saveUrl);
            return saveDoMminurl;
        }
    }
}
