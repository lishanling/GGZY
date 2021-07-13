using System;
using System.Collections.Generic;
using System.Threading;
using Aspose.Cells;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GGZY.Core;
using GGZY.Core.Extensions;
using GGZY.Core.Sms;

namespace BigData.Test
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var msg =
                "【福建省行政监督平台】福建省海洋渔业局将定于8月21日上午10点在福建省公共资源交易中心（福州市鼓楼区华林路128号屏东写字楼2层），召开“渔港工程项目电子招投标培训会”，请各单位派出1名分管领导和1名工作人员参加培训会。";
            var path = @"D:\手机号码1.xlsx";

            List<string> phones = new List<string>();
            var book = new Workbook(path);
            var cells = book.Worksheets[0].Cells;
            for (int i = 0; i <= cells.MaxRow; i++)
            {
                var phone = cells[i, 0].Value.ToString();
                if (!phones.Contains(phone))
                {
                    phones.Add(phone);
                }
            }

            foreach (string tel in phones)
            {
                SmsCommon sms = new SmsCommon();
                sms.Mobile = tel;
                sms.Content = msg;
                var r = sms.SendSms();
                Console.Write(r.Serializer());
                Thread.Sleep(10 * 1000);
            }

        }
    }
}
