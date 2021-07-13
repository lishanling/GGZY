using System;
using System.Collections.Generic;
using Aspose.Cells;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataV4Service.Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var excel = new Workbook("D:\\需要排除的数据(7).xlsx");
            var cells = excel.Worksheets[0].Cells;
            List<string> list = new List<string>();
            for (int i = 0; i <= cells.MaxRow; i++)
            {
                list.Add(cells[i, 1].Value.ToString());
            }
            List<string> list1 = new List<string>();
            list.ForEach(e => list1.Add($"'{e}'"));
            string s = string.Join(",", list1.ToArray());
            Console.Write(s);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var time2 = DateTime.UtcNow;
            var time = DateTime.Now;
            string t = DateTime.UtcNow.ToString("");
            string t1 = new DateTime(2060,10,10).ToUniversalTime().ToString();
        }

    }
}
