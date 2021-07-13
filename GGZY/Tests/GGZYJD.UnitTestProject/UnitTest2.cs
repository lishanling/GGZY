using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROJECT = GGZYJD.DbEntity.PROJECT;
using SYS_DIC = GGZYJD.DbEntity.SYS_DIC;
using TENDER_PROJECT = GGZYJD.DbEntity.TENDER_PROJECT;

namespace GGZYJD.UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetRecordReviewTypeListTest()
        {
            ServicesFactory.GGZYFW.UnifyUserService
                .FromWhere(UNIFY_USER._.MGUID == "ed6735a7-6b5b-4d40-9472-67c9b963e8d6")
                .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID &&
                                      (UNIFY_APP._.APPTYPE == ConfigHelper.APP_KEY_GGZYJD))
                .Select(UNIFY_AUTHS._.APPUID).ToFirst<string>();
            //var r = DbContext.Jd.From<TENDER_PROJECT>().Where(TENDER_PROJECT._.TENDER_PROJECT_CODE=="1")
            //    .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "1").ToList();

            //Console.WriteLine(r);
            //var m = ServicesFactory.GGZYJD.SysDicService.GetRecordReviewTypeList("123456");
            //Console.WriteLine(m.Serializer());
        }

        [TestMethod]
        public void TestMethod202005130853()
        {
            string sql = $"select M_DATA_SOURCE,M_TM from DEA_SEWAGE_PAID_TRANSFER_RES where M_KEY=''";
            var ds= new Dos.ORM.DbSession("ggzyjd").FromSql(sql).ToDataSet();

            var m = ServicesFactory.GGZYJD.TUserDepartmentService.FindSpDepartment(new T_USER_DEPARTMENT { JGBM="MZ"},
                new SearchCondition { });
            Console.WriteLine(m.Serializer());
        }
        [TestMethod]
        public void TestMethod202005121703()
        {
            //https://fj.tzxm.gov.cn/eap/credit.publicShow?projectcode=2020-350782-61-03-034516&biaoji=0
            //https://fj.tzxm.gov.cn/eap/credit.houseProjectPublicShow?projectCode=2020-350181-83-88-027869&biaoji=2
            //var m = ServicesFactory.GGZYJD.TAfcFixedService.BeforeList(new SearchCondition { KeyWord = "2020-350782-61-03-034516" });
            //Console.WriteLine(m.Serializer());

            //var m1 = ServicesFactory.GGZYJD.TAfcFixedService.BeforeDetail("a4ef87cd-bfc0-4531-a32e-8113c66a71d1", "FIXED");

            //Console.WriteLine(m1.Serializer());
            //var m1 = ServicesFactory.GGZYJD.TAfcFixedService.AfterList(new SearchCondition());

            //Console.WriteLine(m1.Serializer());
            var m2 = ServicesFactory.GGZYJD.TAfcFixedService.AfterDetail("S3501000000112101CTC","");

            Console.WriteLine(m2.Serializer());
        }

        [TestMethod]
        public void TestMethod202005121525()
        {
            Console.WriteLine(CommonUtils.TimeStampToDateTime("1579598459000"));
          //  var m=  ServicesFactory.GGZYJD.TAfcFixedService.FirstOrNull(WhereClip.All);
          //Console.WriteLine(m.Serializer());
        }
        [TestMethod]
        public void TestMethod202005121547()
        {
            var m = ServicesFactory.GGZYJD.TAfcSecondaryService.FirstOrNull(WhereClip.All);
            Console.WriteLine(m.Serializer());
        }

        private string UploadUrl = "http://114.115.162.77:8066/file/upload";
        private string Path = @"A:\Users\Administrator\Pictures\2019.jpg";
        private WebUtils WebUtil = new WebUtils();
        [TestMethod]
        public void TestMethod1()
        {
          
            
            using (var fs = new FileStream(Path, FileMode.Open))
            {
                var content = new byte[fs.Length];
                fs.Read(content, 0, content.Length);
                fs.Seek(0, SeekOrigin.Begin);
                var res = WebUtil.DoPost(UploadUrl, null, new Dictionary<string, FileItem>
                {
                    {"file",new FileItem("abc.gif",content) }
                });
                
                Console.WriteLine(res);
                var d = res.DeserializeObject<UploadRes>();
                Console.WriteLine(d.Serializer());
            }
            //var res = WebUtil.DoPost(UploadUrl, null, new Dictionary<string, FileItem>
            //{
            //    {"file",new FileItem(Path) }
            //});
            //Console.WriteLine(res);
            //var d = res.DeserializeObject<UploadRes>();
            //Console.WriteLine(d.Serializer());
        }


        [TestMethod]
        public void FileSuffixTest()
        {
            var dir = @"A:\Users\Administrator\Pictures";
            
            var dirInfo = new DirectoryInfo(dir);
            var files = dirInfo.GetFiles();
            foreach (var fileInfo in files)
            {
                
                using (var fs = fileInfo.OpenRead())
                {
                    //Console.WriteLine($" {fs.FileExtensions()} {fileInfo.Name}");
                    //var content = new byte[fs.Length];
                    //fs.Read(content, 0, content.Length);

                    //var info = $"{fileInfo.Name}:{string.Join("", content)}";
                    //Console.WriteLine(info);
                }
            }
        }
        [TestMethod]
        public void FileSuffixTest1()
        {
            var dir = @"A:\Users\Administrator\Pictures";

            var dirInfo = new DirectoryInfo(dir);
            var files = dirInfo.GetFiles();
            var list = new List<string>();
            foreach (var fileInfo in files)
            {

                using (var fs = fileInfo.OpenRead())
                {
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        string bx = " ";
                        byte buffer;
                        try
                        {
                            buffer = r.ReadByte();
                            bx = buffer.ToString();
                            buffer = r.ReadByte();
                            bx += buffer.ToString();
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                        }   
                        ////真实的文件类型
                        //Console.WriteLine(bx);
                        //文件格式
                        var ex = fileInfo.Name.Extension().Replace(".", "").ToUpper();
                        list.Add($"{ex}={bx};");

                    }

                }
            }

            var sortList = list.Distinct().OrderBy(c => c).ToList();

            foreach (var VARIABLE in sortList)
            {
                
                Console.WriteLine($"{VARIABLE}");
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine(CommonUtils.Md5Str(Path));

            Console.WriteLine(Path.Md5HashFromFile());
            Console.WriteLine(new { @params = 1 }.Serializer());
        }

        [TestMethod]
        public void TestMethod3()
        {

            //var f = TENDER_PROJECT._.M_ID.OracleConcat(TENDER_PROJECT._.M_ID);
            //Console.WriteLine(f.ToString());
            //var f1 = TENDER_PROJECT._.M_ID.OracleConcat("123");

            var r = ServicesFactory.GGZYJD.TenderProjectService.PageTable(new TENDER_PROJECT(), new SearchCondition());
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void JdUserMenuTest()
        {
            var r = ServicesFactory.GGZYJD.TUserMenuService.UserMenus(1);
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void InitialMenu()
        {
            ServicesFactory.GGZYJD.TUserMenuV2Service.InitialMenu();
        }
        [TestMethod]
        public void InitialPopedom()
        {
            ServicesFactory.GGZYJD.TUserPopedomV2Service.Initial();
        }

        [TestMethod]
        public void T()
        {
            var pattern = "jdsysdic";
            var replacement = "";
            Console.WriteLine(Regex.Replace("jdsysdic123_jdsysdic123", pattern, replacement, RegexOptions.IgnoreCase));
            Console.WriteLine(Regex.Replace("1jdsysdic123", pattern, replacement, RegexOptions.IgnoreCase));
            Console.WriteLine(Regex.Replace("JDSYSDIC123", pattern, replacement, RegexOptions.IgnoreCase));
        }

        [TestMethod]
        public void QueryableTest()
        {
            var query = ServicesFactory.GGZYFW.ProjectService.FromWhere(PROJECT._.PROJECT_NAME.Contain("工程"));
            Console.WriteLine();
            Console.WriteLine(query.GetWhereClip().Where);
            query.LeftJoin<SYS_DIC>(SYS_DIC._.ID == PROJECT._.M_ID);
            Console.WriteLine();
            Console.WriteLine(query.GetWhereClip().Where);
            Console.WriteLine();

            query.LeftJoin<SYS_DIC>(SYS_DIC._.VALUE == PROJECT._.INVEST_PROJECT_CODE);
            Console.WriteLine();
            query.ToFirst();
        }

        [TestMethod]
        public void UserListTest()
        {
            var query = ServicesFactory.GGZYFW.VUnifyUserService.PageTable(new V_UNIFY_USER
            {
                APPKEY = ConfigHelper.APP_KEY_PINGBIAO
            }, new SearchCondition());
            Console.WriteLine(query.Serializer());

        }

        [TestMethod]
        public void DynamicTest()
        {
            dynamic obj = EntityUtils.FastExpando.Attach(new Dictionary<string, object>());

            obj.a = 1;
            Console.WriteLine(((object)obj).Serializer());
            //var obj = new {a = 1, b = "2"};
            //var obj2 = new System.Dynamic.ExpandoObject();
            //IDictionary<string, object> obj2Dic = (IDictionary<string, object>) obj2;
            //obj2Dic.Add("t",1);
            //Console.WriteLine(obj2.Serializer());
            //Console.WriteLine(((dynamic)obj).a);
            //((dynamic) obj).a = "2";
            //Console.WriteLine(((dynamic)obj).a);
            //var r= ServicesFactory.GGZYJD.PtZxtsService.OnlineComplaint("201807025747", "",id=>$"/FileContent/Jd/Sys/{id}");
            //Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void EmailTest()
        {
            string body = "亲爱的用户：您好！<br />";
            body += "&nbsp;&nbsp;您现在“福建省公共资源交易电子行政监督平台”提交了一个投诉。<br />";
            body += "&nbsp;&nbsp;投诉编号为：123456,我们将尽快处理您的投诉，请耐心等待，不要重复提交。感谢您的支持！";
            EmailUtils.SendEmail("389005743@qq.com", body, "福建省公共资源交易电子行政监督平台");
        }
        [TestMethod]
        public void CreateUserTest()
        {
            ServicesFactory.GGZYFW.UnifyUserService.CreateUser("GGZYJD", "81", null);
        }

        [TestMethod]
        public void PadStringTest()
        {
            Console.WriteLine("L".PadLeft(3, '0'));
            Console.WriteLine("R".PadRight(3, '0'));
            Console.WriteLine("LEFT".PadLeft(3, '0'));
            Console.WriteLine("RIGHT".PadRight(3, '0'));
            Console.WriteLine(CommonUtils.ToUnixTimeStamp());
            Console.WriteLine(CommonUtils.ToUnixTimeStamp(isMilliseconds: true));
        }
        [TestMethod]
        public void GCJS_XMJC_ProjectInfoTest()
        {
            var r = ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.GCJS_XMJC_ProjectInfo("E3502110201116531031",
                    ids => ServicesFactory.GGZYFW.CommonService.Attachments(ids));
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void JdDynamicTest()
        {
           var entity = new GGZYJD.DbEntity.T_FRAUD();
           //Console.WriteLine(entity.Serializer());
           
           dynamic d = (dynamic) entity;
           d.A = 1;
           //d.Serializer = new Action(() => 
           //    this.Serializer()
           //    );
           Console.WriteLine(((object)d).Serializer());
        }
        [TestMethod]
        public void FwDynamicTest()
        {

           

            var entity = new GGZYFW.DbEntity.PROJECT(){PROJECT_NAME = "1"};
            Console.WriteLine(entity.Serializer());
            dynamic d = entity;
            d.A = 1;
            Console.WriteLine(((object)d).Serializer());


        }
    }
}
