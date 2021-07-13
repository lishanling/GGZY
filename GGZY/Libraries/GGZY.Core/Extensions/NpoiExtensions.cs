using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Core.Extensions
{
    public static class NpoiExtensions
    {
        

        public static byte[] GenerateExcel<TModel>(this IEnumerable<TModel> data, params string[] titles)
        {
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet();

            int rowNumber = 0;

            var properties = typeof(TModel).GetProperties();
            if (titles.Length == properties.Length)
            {
                foreach (TModel m in data)
                {
                    if (rowNumber == 0)
                    {
                        for (int i = 0; i < titles.Length; i++)
                        {
                            sheet.SetColumnWidth(i, 50 * 256);
                        }
                        var headerRow = sheet.CreateRow(rowNumber);

                        for (int i = 0; i < titles.Length; i++)
                        {
                            var value = titles[i];
                            headerRow.CreateCell(i).SetCellValue(value);
                        }
                    }
                    var row = sheet.CreateRow(++rowNumber);
                    for (int i = 0; i < properties.Length; i++)
                    {
                        System.Reflection.PropertyInfo p = properties[i];
                        var v = p.GetValue(m)?.ToString();
                        row.CreateCell(i).SetCellValue(v);
                    }

                }
            }
            else
            {
                throw new Exception("表头长度不匹配");
            }
            using (var output = new MemoryStream())
            {
                workbook.Write(output);
                var bytes = output.ToArray();
                return bytes;
            }
        }
    }
}
