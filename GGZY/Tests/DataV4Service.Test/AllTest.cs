using System;
using System.Text;
using System.Collections.Generic;
using GGZY.DataV4Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataV4Service.Test
{
    /// <summary>
    /// AllTest 的摘要说明
    /// </summary>
    [TestClass]
    public class AllTest
    {
        private UploadDataMocker mocker = new UploadDataMocker();
        public AllTest()
        {
            try
            {
                mocker.Mock2();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"初始化模式数据异常:{ex}");
            }
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void 所有数据上报()
        {
            Console.WriteLine($"新增数据上报");
            上报数据并验证("insert");

            Console.WriteLine($"修改数据上报");
            上报数据并验证("update");

            Console.WriteLine($"删除数据上报");
            上报数据并验证("delete");
        }
        private void 上报数据并验证(string opt)
        {
            foreach (var dataType in DataConfigManager.GetDataTypeList())
            {
                //                var dataType = "主体数据类";
                foreach (var datano in DataConfigManager.GetDataNameList(dataType))
                {
                    if (Convert.ToInt32(datano) >= 500)
                    {
                        Console.WriteLine($"dataNo：{datano}");
                        var data = mocker.GetMockData(datano, opt);
                        if (data != null)
                        {
                            var result = mocker.GetUploadResult(data);
                            Assert.IsTrue("1".Equals(result.Item1), datano + ":" + result.Item2);
                            mocker.IsSuccess(datano, opt);
                        }
                    }
                }

            }
        }
    }
}
