#region MyRegion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Security;
using Dos.ORM;
using GGZY.Core.Authentication;
using GGZY.Core.Authentication.Jwt;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Helper;
using GGZY.Core.Log;
using GGZY.Core.Models;
using GGZY.Core.Sms;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZY.Services.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LEGAL_PERSON_BASE = GGZYFW.DbEntity.LEGAL_PERSON_BASE;

#endregion


namespace GGZYJD.UnitTestProject
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DbLinkTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TMultimediaDataService.GetVideoList(new MvTjAllCreateXzjdModel(), new SearchCondition{PageSize = 1});
                Console.WriteLine(r.Serializer());

                //var r=ServicesFactory.GGZYJD.TenderProjectService.FromWhere<GGZYJD.DbEntity.TENDER_PROJECT>(where: DBLINK_DZJYPT_SECTION._.TENDER_PROJECT_CODE == "E3508220201122496870")
                //    .RightJoin<DBLINK_DZJYPT_SECTION>("1=0").Select(DBLINK_DZJYPT_SECTION._.TENDER_PROJECT_CODE).ToList();
                //Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void GetPSTabListTest()
        {
            try
            {
                var r = ServicesFactory.GGZYFW.WarnExpressionService.GetPSTabList();
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void GetAFC_LogsTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TAfcLogService.GetAFC_Logs("E473501022007160002002");
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void CFDetailedRecoredTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TPunishService.CFDetailedRecored(new TCopySendModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void CFSourceTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TPunishService.CFSource(new TTPunishModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void DownCFListTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TPunishService.DownCFList(new TCopySendModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void RedProjectTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.RedProject(new JDHomePageModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void TimeProjectCountTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.TimeProjectCount(new JDHomePageModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void JCCountTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.JCCount(new JDHomePageModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }

        [TestMethod]
        public void DuChaCountTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.DuChaCount(new JDHomePageModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void DuChaRegionTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.DuChaRegion(new JDHomePageModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }

        [TestMethod]
        public void TransRecordDetailTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.JcTransRecordService.TransRecordDetail("886677c4-bf52-4770-a99c-c78f4583463a");
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void WarnResultDetailTest()
        {
            try
            {
                var r = ServicesFactory.GGZYFW.WarnResultService.WarnResultDetail("0bb41ca1-a10b-4c6b-9e8a-63d816432c3e");
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }

        }

        [TestMethod]
        public void CFDetailedTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TPunishService.CFDetailed(new TPunisnDataModel(){ ID = "f1b36794-bace-4476-9a00-1119bb895a1e" }, new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void CFSearchListTest()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TPunishService.CFSearchList(new GGZYJD.DbEntity.T_PUNISH(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        [TestMethod]
        public void CFPeopleTest()
        {
            try
            {
                //  var model = new ;
                var r = ServicesFactory.GGZYJD.TPunishService.CFPeople(new TTPunishModel(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }

        [TestMethod]
        public void CFProjectTest()
        {
            try
            {
                   //  var model = new ;
                   var r = ServicesFactory.GGZYJD.TPunishService.CFProject(new GGZYJD.DbEntity.TENDER_PROJECT(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }
        //[TestMethod]
        //public void ProjectPointTest()
        //{
        //    try
        //    {
        //        //  var model = new ;
        //        var r = ServicesFactory.GGZYJD.TSuperviseResultService.ProjectPointJDCount(new WARN_RESULT(), new SearchCondition());
        //        Console.WriteLine(r.Serializer());
        //    }
        //    catch (Exception e)
        //    {
        //        Logger.Debug(e.Message, e);
        //    }
        //}


        //[TestMethod]
        //public void ProjectPointSearchListTest()
        //{
        //    try
        //    {
        //        //  var model = new ;
        //        var r = ServicesFactory.GGZYJD.TSuperviseResultService.ProjectPointSearchList(new WARN_RESULT { TENDER_PROJECT_CODE= "E3507210701100001"}, new SearchCondition());
        //        Console.WriteLine(r.Serializer());
        //    }
        //    catch (Exception e)
        //    {
        //        Logger.Debug(e.Message, e);
        //    }
        //}

        [TestMethod]
        public void PointSearchListTest()
        {
            try
            {
              //  var model = new ;
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.PointSearchList( new JDCount_Model() , new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }

        [TestMethod]
        public void ProjectPointSearchListTest()
        {
            try
            {
                //  var model = new ;
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.ProjectPointSearchList(new XinWarnResultModel{}, new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }

        [TestMethod]
        public void PointJDCountTest()
        {
            try
            {
            
                var r = ServicesFactory.GGZYJD.TSuperviseResultService.PointJDCount(new JDCount_Model(), new SearchCondition());
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Logger.Debug(e.Message, e);
            }
        }

        //[TestMethod]
        //public void ZxtsSuperviseSearchListTest()
        //{
        //   var model = new PtZxtsModel();
        //   var r = ServicesFactory.GGZYJD.TSuperviseResultService.ZxtsSuperviseSearchList(model, new SearchCondition());
        //   Console.WriteLine(r.Serializer());           
        //}

        [TestMethod]
        public void HyHandleItemsTest1()
        {
            var model = new ProjectSupervisionResponseHyModel
            {
                //TYPE = nameof(T_AFC_PROJECT),ID = "4572",
                //TYPE = nameof(RECORD_REVIEW),ID = "1278",
                //TYPE = nameof(PT_ZXTS),ID = "311",
                TYPE = nameof(GGZYFW.DbEntity.WARN_RESULT),ID = "882359c9-9246-4b4c-bd27-bafe39b2097a",
                //TYPE = nameof(T_AFC_PROJECT),ID = "4572",
                //TYPE = nameof(T_AFC_PROJECT),ID = "4572",
            };
            var r = ServicesFactory.GGZYJD.ProjectSupervisionService.HandleItems(model,new SearchCondition());
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void HyProjectSupervisionsTest()
        {
            var r = ServicesFactory.GGZYJD.ProjectSupervisionService.HyProjectSupervisions(new ProjectSupervisionRequestModel());
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void SearchDetailTest()
        {
            var r = ServicesFactory.GGZYFW.CommonService.SearchDetail("4580", "03");
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ReadJdUsersTest()
        {
            var r = ServicesFactory.GGZYJD.TUserService.PageTable(new GGZYJD.DbEntity.T_USER(), new SearchCondition());
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void JwProjectSupervisionCountTest()
        {
            var r = ServicesFactory.GGZYJD.ProjectSupervisionService.JwProjectSupervisionCount();
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void PageTableByTypeTxtTest()
        {
            var r = ServicesFactory.GGZYJD.PtArticleService.PageTableByTypeTxt(new GGZYJD.DbEntity.PT_ARTICLE() , new SearchCondition(),new GGZYJD.DbEntity.PT_ATYPE {TEXT = "国家政策法规,福建省政策法规,政策解读" });
            Console.WriteLine(r.Serializer());
        }
        //[TestMethod]
        //public void ReviewSuperviseSearchListTest()
        //{
        //   var model = new DbEntity.ReviewSuperviseProjectModel();
        //   var r = ServicesFactory.GGZYJD.TSuperviseResultService.ReviewSuperviseSearchList(model, new SearchCondition());
        //   Console.WriteLine(r.Serializer());
        //}

        [TestMethod]
        public void AfcSearchListTest()
        {
            var r = ServicesFactory.GGZYJD.TSuperviseResultService.AfcSearchList(new TAfcProjectModel() , new SearchCondition());
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void AfcSearchExportTest()
        {
            var r = ServicesFactory.GGZYJD.TSuperviseResultService.AfcSearchExport(new TAfcProjectModel(), new SearchCondition());
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void GetAuthGroupListTest()
        {
            var r = ServicesFactory.GGZYJD.TUserRoleV2Service.GetAuthGroupList(new GeneralAuthGroup(){GROUP_ID= "5213737133734416428" }, new SearchCondition());
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void Arr2()
        {
            var s = "A,A01,A02,B,B01,B02";
            var arr = s.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            var p = arr.Where(c => c.Length == 1).ToList();
            var r = new List<List<string>>();
          
            p.ForEach(c =>
            {
                var children = arr.Where(child => child.StartsWith(c) && child.Length > 1);
                r.AddRange(children.Select(child => new List<string> {c, child}));     
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void DepartmentTree()
        {
            var r = ServicesFactory.GGZYJD.TUserDepartmentService.DepartmentTree();
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void CzAfcProjects()
        {
            var r = ServicesFactory.GGZYJD.TAfcProjectService.AfcProjects(new TAfcProjectModel(), new SearchCondition());
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void LengthTest()
        {
            var s = "广西壮族自治区财政厅政府采购监督管理处，联系电话：；广西壮族自治区建设工程招标投标办公室，联系电话：";
            Console.WriteLine(s.Length);
            Console.WriteLine(Encoding.Default.GetBytes(s).Length);
        }

        [TestMethod]
        public void ProjectReportBuild4Approval_TEST()
        {
            var r = ServicesFactory.GGZYJD.TAfcProjectService.ProjectReportBuild4Approval(new TAfcProjectModel(), new SearchCondition
            {
                Type = "3"
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void PreviewAfcProject_TEST()
        {
            var r = ServicesFactory.GGZYJD.TAfcProjectService.PreviewAfcProject("3ZFhorOitxc%3d");
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void Guid16_TEST()
        {
            Console.WriteLine($"TS{Guid.NewGuid().To16String(true)}");
            Console.WriteLine($"QZ{Guid.NewGuid().To16String(true)}");
            Console.WriteLine($"QZ{DateTime.Now:yyMMddHHmmssffff}");
        }
        [TestMethod]
        public void GetProjectList_GGFW_TEST()
        {
            var r = ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.GetProjectList_GGFW(new MV_TJ_ALLCREATE_XZJD(), new SearchCondition
            {
                //BeginTime = DateTime.Today.AddDays(-92),
            });
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void TestJoin()
        {
            var r = ServicesFactory.GGZYFW.MvGgxxXzjdService.GetGGGSList_GGFW(new MvGgxxXzjdModel
            {
                GGTYPE = "1"
            }, new SearchCondition
            {
                BeginTime = DateTime.Today.AddDays(-92),
            });
            Console.WriteLine(r.Serializer());
            var stat = ServicesFactory.GGZYFW.MvGgxxXzjdService.GetGGGSList_GGFW_Stat(new MvGgxxXzjdModel
            {
                GGTYPE = "1"
            }, new SearchCondition
            {
                BeginTime = DateTime.Today.AddDays(-92)
            });
            Console.WriteLine(stat.Serializer());
            var chart = ServicesFactory.GGZYFW.MvGgxxXzjdService.GetGGGSList_GGFW_Chart(new MvGgxxXzjdModel
            {
                GGTYPE = "1"
            }, new SearchCondition
            {
                BeginTime = DateTime.Today.AddDays(-92),
                EndTime = DateTime.Now
            });
            Console.WriteLine(chart.Serializer());
        }
        [TestMethod]
        public void JdAttTest()
        {
            using (var trans = DbContext.Fw.BeginTransaction())
            {
                var data = new UploadResData
                {
                    Id = "123",
                    Url = "/file/getcontent/5ea4eadbfaae15407cd4c5f5.jpg",
                    Md5 = "F8935BC91ACDE8C28DF52D0C5572AAB9",
                    Name = "营业执照.jpg",
                    new_id = "456",
                };
                var sysAtt = data.FwSysAttachment();
                trans.Insert(sysAtt);
            }
            //var att = new GGZYJD.DbEntity.SYS_ATTACHMENT
            //{
            //    AID = 0,
            //    GUID = "3266",
            //    CREATEID = null,
            //    CREATETIME = DateTime.Now,
            //    UPDATETIME = DateTime.Now,
            //    UPDATEID = null,
            //    AOBJTYPE = SYS_ATTACHMENT.FILE_CENTER,
            //    FILEPATH = "/file/getcontent/5ea4eadbfaae15407cd4c5f5.jpg",
            //    MD5 = "F8935BC91ACDE8C28DF52D0C5572AAB9",
            //    FILETILE = "营业执照.jpg",
            //    FILETYPE = ".jpg",
            //    ORDERID = 0,
            //    CONVERTREMARK = string.Empty,
            //    CONVERTDATETIME = DateTime.Now,
            //};
            // ServicesFactory.GGZYJD.SysAttachmentService.Insert(att);
        }
        [TestMethod]
        public void WjSmsTest()
        {
            var sms = new SmsChinaWJ
            {
                Mobile = "15880022782",
                Content = $"当前时间{DateTime.Now:yyyyMMddHHmmss}"
            };
            var r = sms.SendSms();
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void DesUtils()
        {
            var s = "O(∩_∩)O,你很棒棒哦!";
            // s ="{'PageTotal':10,'PageNo':1,'Total':98,'PageSize':10,'Table':[{'ID':'FSuOwjJj%2f0s%3d','TITLE':'CA厂商常见问题','TYPE':'58','TM':'2019-06-24 08:49:50','CONTENTS':'<p>1、</p>'},{'ID':'gBKDG0QuvaE%3d','TITLE':'电子交易平台常见问题','TYPE':'58','TM':'2019-06-24 08:48:29','CONTENTS':'<p>1、<br /></p>'},{'ID':'3CBiZiKZ4Gk%3d','TITLE':'融合客户端常见问题','TYPE':'58','TM':'2019-06-18 11:25:16','CONTENTS':'<p>内容内容</p>'},{'ID':'V%2brWIoELdzI%3d','TITLE':'福州外国语学校俄国领事馆（文物）内部修复工程远程异地评标完成','TYPE':'81','TM':'2019-04-18 16:26:53','CONTENTS':'<p>2019年04月15日，福州市公共服务中心、省本级公共服务中心联合开展远程异地电子评标。在场专家通过登陆远程评标系统进行视音频互动，对福州外国语学校俄国领事馆（文物）内部修复工程进行评标。</p>'},{'ID':'QIECQQCe6Vc%3d','TITLE':'11111','TYPE':'926','TM':'2019-01-22 16:11:26','CONTENTS':'<p>11111111</p>'},{'ID':'8cRgdHINanI%3d','TITLE':'测试打发烦烦烦远程异地评标完成','TYPE':'81','TM':'2017-06-08 10:27:33','CONTENTS':'<p>2017年05月12日，福州市公共服务中心、省本级公共服务中心联合开展远程异地电子评标。在场专家通过登陆远程评标系统进行视音频互动，对测试打发烦烦烦进行评标。</p>'},{'ID':'qA%2fiiA%2fHcxA%3d','TITLE':'大数据挖掘的技术流程','TYPE':'67','TM':'2017-04-18 16:22:53','CONTENTS':'<p> ; 从数据本身来考虑，通常<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E6%95%B0%E6%8D%AE%E6%8C%96%E6%8E%98\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>数据挖掘</a>需要有数据清理、数据变换、数据挖掘实施过程、模式评估和知识表示等8个步骤。</p><p> ; （1） 信息收集：根据确定的数据分析对象抽象出在数据分析中所需要的特征信息，然后选择合适的信息收集方法，将收集到的信息存入数据库。对于海量数据，选择一个合适的数据存储和管理的<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E6%95%B0%E6%8D%AE%E4%BB%93%E5%BA%93\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>数据仓库</a>是至关重要的。</p><p> ; （2） 数据集成：把不同来源、格式、特点性质的数据在逻辑上或物理上有机地集中，从而为企业提供全面的数据共享。</p><p> ; （3） 数据规约：执行多数的数据挖掘算法即使在少量数据上也需要很长的时间，而做商业运营数据挖掘时往往数据量非常大。数据规约技术可以用来得到数据集的规约表示，它小得多，但仍然接近于保持原数据的完整性，并且规约后执行数据挖掘结果与规约前执行结果相同或几乎相同。</p><p> ; （4） 数据清理：在数据库中的数据有一些是不完整的（有些感兴趣的属性缺少属性值），含噪声的（包含错误的属性值），并且是不一致的（同样的信息不同的表示方式），因此需要进行数据清理，将完整、正确、一致的数据信息存入数据仓库中。</p><p> ; （5） 数据变换：通过平滑聚集，数据概化，规范化等方式将数据转换成适用于数据挖掘的形式。对于有些实数型数据,通过概念分层和数据的离散化来转换数据也是重要的一步。</p><p> ; （6） 数据挖掘过程：根据数据仓库中的数据信息，选择合适的分析工具，<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E5%BA%94%E7%94%A8%E7%BB%9F%E8%AE%A1%E6%96%B9%E6%B3%95\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>应用统计方法</a>、事例推理、<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E5%86%B3%E7%AD%96%E6%A0%91\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>决策树</a>、规则推理、模糊集、甚至<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E7%A5%9E%E7%BB%8F%E7%BD%91%E7%BB%9C\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>神经网络</a>、<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E9%81%97%E4%BC%A0%E7%AE%97%E6%B3%95\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>遗传算法</a>的方法处理信息，得出有用的分析信息。</p><p> ; （7） 模式评估：从商业角度，由行业专家来验证数据挖掘结果的正确性。</p><p> ; （8） 知识表示：将数据挖掘所得到的分析信息以可视化的方式呈现给用户，或作为新的知识存放在知识库中，供其他应用程序使用。</p><p> ; 数据挖掘过程是一个反复循环的过程，每一个步骤如果没有达到预期目标，都需要回到前面的步骤，重新调整并执行。不是每件数据挖掘的工作都需要这里列出的每一步，例如在某个工作中不存在多个数据源的时候，步骤（2）数据集成的步骤便可以省略。</p><p> ; 步骤（3）数据规约（4）数据清理（5）数据变换又合称数据预处理。在数据挖掘中，至少60%的费用可能要花在步骤（1）信息收集阶段，而至少60%以上的精力和时间是花在数据预处理</p><p><a style=\'color: rgb(19, 110, 194); position: absolute; top: -50px;\' name=\'2\'></a><a style=\'color: rgb(19, 110, 194); position: absolute; top: -50px;\' name=\'sub13714637_2\'></a><a style=\'color: rgb(19, 110, 194); position: absolute; top: -50px;\' name=\'操作方法\'></a></p><p><br/></p>'},{'ID':'4sa83u4LA4M%3d','TITLE':'大数据的IT分析工具','TYPE':'67','TM':'2017-04-18 16:19:34','CONTENTS':'<p> ; 大数据概念应用到<a target=\'_blank\' href=\'http://baike.baidu.com/item/IT/16684878\' data-lemmaid=\'16684878\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>IT</a>操作工具产生的数据中，大数据可以使<a target=\'_blank\' href=\'http://baike.baidu.com/item/IT/16684878\' data-lemmaid=\'16684878\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>IT</a>管理软件供应商解决大广泛的业务决策。<a target=\'_blank\' href=\'http://baike.baidu.com/item/IT/16684878\' data-lemmaid=\'16684878\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>IT</a>系统、应用和技术基础设施每天每秒都在产生数据。大数据非结构化或者结构数据都代表了‘所有用户的行为、服务级别、安全、风险、欺诈行为等更多操作’的绝对记录。</p><p> ; 大数据分析的产生旨在于IT管理，企业可以将实时数据流分析和历史相关数据相结合，然后大数据分析并发现它们所需的模型。反过来，帮助预测和预防未来运行中断和性能问题。进一步来讲，他们可以利用大数据了解使用模型以及地理趋势，进而加深大数据对重要用户的洞察力。 他们也可以追踪和记录网络行为，大数据轻松地识别业务影响；随着对服务利用的深刻理解加快利润增长；同时跨多系统收集数据发展IT服务目录。</p><p> ; 大数据分析的想法，尤其在<a target=\'_blank\' href=\'http://baike.baidu.com/item/IT/16684878\' data-lemmaid=\'16684878\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>IT</a>操作方面，大数据对于我们发明并没有什么作用，但是我们一直在其中。<a target=\'_blank\' href=\'http://baike.baidu.com/item/Gartner\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>Gartner</a>已经关注这个话题很多年了，基本上他们已经强调，如果<a target=\'_blank\' href=\'http://baike.baidu.com/item/IT/16684878\' data-lemmaid=\'16684878\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>IT</a>正在引进新鲜灵感，他们将会扔掉大数据老式方法开发一个新的<a target=\'_blank\' href=\'http://baike.baidu.com/item/IT/16684878\' data-lemmaid=\'16684878\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>IT</a>操作分析平台。<span style=\'font-size: 12px; line-height: 0; position: relative; vertical-align: baseline; top: -0.5em; margin-left: 2px; color: rgb(51, 102, 204); cursor: default; padding: 0px 2px;\'>[17]</span><a style=\'color: rgb(19, 110, 194); position: relative; top: -50px; font-size: 0px; line-height: 0;\' name=\'ref_[17]_13647476\'></a> ;</p><p><br/></p>'},{'ID':'d2ZHMBP7%2fkw%3d','TITLE':'大数据的趋势','TYPE':'67','TM':'2017-04-18 16:17:27','CONTENTS':'<p><span style=\'font-weight: 700;\'> ; 趋势一：数据的资源化</span></p><p> ; 何为资源化，是指大数据成为企业和社会关注的重要战略资源，并已成为大家争相抢夺的新焦点。因而，企业必须要提前制定大数据营销战略计划，抢占市场先机。</p><p><span style=\'font-weight: 700;\'> ; 趋势二：与云计算的深度结合</span></p><p> ; 大数据离不开云处理，云处理为大数据提供了弹性可拓展的基础设备，是产生大数据的平台之一。自2013年开始，大数据技术已开始和云计算技术紧密结合，预计未来两者关系将更为密切。除此之外，物联网、移动互联网等新兴计算形态，也将一齐助力大数据革命，让大数据营销发挥出更大的影响力。</p><p><span style=\'font-weight: 700;\'> ; 趋势三：科学理论的突破</span></p><p> ; 随着大数据的快速发展，就像计算机和互联网一样，大数据很有可能是新一轮的技术革命。随之兴起的数据挖掘、机器学习和人工智能等相关技术，可能会改变数据世界里的很多算法和基础理论，实现科学技术上的突破。</p><p><span style=\'font-weight: 700;\'> ; 趋势四：数据科学和数据联盟的成立</span></p><p> ; 未来，数据科学将成为一门专门的学科，被越来越多的人所认知。各大高校将设立专门的数据科学类专业，也会催生一批与之相关的新的就业岗位。与此同时，基于数据这个基础平台，也将建立起跨领域的数据共享平台，之后，数据共享将扩展到企业层面，并且成为未来产业的核心一环。</p><p><span style=\'font-weight: 700;\'> ; 趋势五：数据泄露泛滥</span></p><p> ; 未来几年数据泄露事件的增长率也许会达到100%，除非数据在其源头就能够得到安全保障。可以说，在未来，每个财富500强企业都会面临数据攻击，无论他们是否已经做好安全防范。而所有企业，无论规模大小，都需要重新审视今天的安全定义。在财富500强企业中，超过50%将会设置首席信息安全官这一职位。企业需要从新的角度来确保自身以及客户数据，所有数据在创建之初便需要获得安全保障，而并非在数据保存的最后一个环节，仅仅加强后者的安全措施已被证明于事无补。</p><p><span style=\'font-weight: 700;\'> ; 趋势六：数据管理成为核心竞争力</span></p><p> ; 数据管理成为核心竞争力，直接影响财务表现。当“数据资产是企业核心资产”的概念深入人心之后，企业对于数据管理便有了更清晰的界定，将数据管理作为企业核心竞争力，持续发展，战略性规划与运用数据资产，成为企业数据管理的核心。数据资产管理效率与主营业务收入增长率、销售收入增长率显著正相关;此外，对于具有互联网思维的企业而言，数据资产竞争力所占比重为36.8%，数据资产的管理效果将直接影响企业的财务表现。</p><p><span style=\'font-weight: 700;\'> ; 趋势七：数据质量是BI(商业智能)成功的关键</span></p><p> ; 采用自助式商业智能工具进行大数据处理的企业将会脱颖而出。其中要面临的一个挑战是，很多数据源会带来大量低质量数据。想要成功，企业需要理解原始数据与数据分析之间的差距，从而消除低质量数据并通过BI获得更佳决策。</p><p><span style=\'font-weight: 700;\'> ; 趋势八：数据生态系统复合化程度加强</span></p><p> ; 大数据的世界不只是一个单一的、巨大的计算机网络，而是一个由大量活动构件与多元参与者元素所构成的生态系统，终端设备提供商、基础设施提供商、网络服务提供商、网络接入服务提供商、数据服务使能者、数据服务提供商、触点服务、数据服务零售商等等一系列的参与者共同构建的生态系统。而今，这样一套数据生态系统的基本雏形已然形成，接下来的发展将趋向于系统内部角色的细分，也就是市场的细分;系统机制的调整，也就是商业模式的创新;系统结构的调整，也就是竞争环境的调整等等，从而使得数据生态系统复合化程度逐渐增强。<span style=\'font-size: 12px; line-height: 0; position: relative; vertical-align: baseline; top: -0.5em; margin-left: 2px; color: rgb(51, 102, 204); cursor: default; padding: 0px 2px;\'>[16]</span><a style=\'color: rgb(19, 110, 194); position: relative; top: -50px; font-size: 0px; line-height: 0;\' name=\'ref_[16]_13647476\'></a> ;</p><p><br/></p>'},{'ID':'SgdpFeF8iao%3d','TITLE':'大数据的结构','TYPE':'67','TM':'2017-04-18 16:12:12','CONTENTS':'<p> ; 大数据包括结构化、半结构化和非结构化数据，非结构化数据越来越成为数据的主要部分。据IDC的调查报告显示：企业中80%的数据都是非结构化数据，这些数据每年都按指数增长60%。<span style=\'font-size: 12px; line-height: 0; position: relative; vertical-align: baseline; top: -0.5em; margin-left: 2px; color: rgb(51, 102, 204); cursor: default; padding: 0px 2px;\'>[8]</span><a style=\'color: rgb(19, 110, 194); position: relative; top: -50px; font-size: 0px; line-height: 0;\' name=\'ref_[8]_13647476\'></a> ; ;大数据就是<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E4%BA%92%E8%81%94%E7%BD%91\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>互联网</a>发展到现今阶段的一种<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E8%A1%A8%E8%B1%A1\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>表象</a>或<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E7%89%B9%E5%BE%81\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>特征</a>而已，没有必要神话它或对它</p><p style=\'text-align:center\'><a class=\'image-link\' nslog-type=\'9317\' href=\'http://baike.baidu.com/pic/%E5%A4%A7%E6%95%B0%E6%8D%AE/1356941/0/09fa513d269759ee4e22ef3bb4fb43166c22dfd4?fr=lemma=single\' target=\'_blank\' title=\'\' style=\'color: rgb(19, 110, 194); text-decoration-line: none; display: block; width: 220px; height: 157px;\'><img class=\'\' src=\'/UploadFile/ueditor/image/20170418/6362812877171872368923811.jpg\' alt=\'\' style=\'border: 0px; display: block; margin: 0px auto; width: 220px; height: 157px;\'/></a></p><p>保持敬畏之心，在以<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E4%BA%91%E8%AE%A1%E7%AE%97\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>云计算</a>为代表的技术创新大幕的衬托下，这些原本看起来很难收集和使用的数据开始容易被利用起来了，通过各行各业的不断创新，大数据会逐步为人类创造更多的价值。<span style=\'font-size: 12px; line-height: 0; position: relative; vertical-align: baseline; top: -0.5em; margin-left: 2px; color: rgb(51, 102, 204); cursor: default; padding: 0px 2px;\'>[9]</span><a style=\'color: rgb(19, 110, 194); position: relative; top: -50px; font-size: 0px; line-height: 0;\' name=\'ref_[9]_13647476\'></a> ;</p><p> ; 其次，想要系统的<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E8%AE%A4%E7%9F%A5\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>认知</a>大数据，必须要全面而细致的分解它，着手从三个层面来展开：</p><p> ; 第一层面是<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E7%90%86%E8%AE%BA\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>理论</a>，理论是认知的必经途径，也是被广泛认同和传播的基线。在这里从大数据的特征定义理解行业对大数据的整体描绘和定性；从对大数据价值的探讨来深入解析大数据的珍贵所在；洞悉大数据的发展趋势；从大数据<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E9%9A%90%E7%A7%81\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>隐私</a>这个特别而重要的视角审视人和数据之间的长久博弈。</p><p> ; 第二层面是<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E6%8A%80%E6%9C%AF\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>技术</a>，技术是大数据价值体现的手段和前进的基石。在这里分别从云计算、分布式处理技术、存储技术和感知技术的发展来说明大数据从采集、处理、存储到形成结果的整个过程。</p><p> ; 第三层面是<a target=\'_blank\' href=\'http://baike.baidu.com/item/%E5%AE%9E%E8%B7%B5\' style=\'color: rgb(19, 110, 194); text-decoration-line: none;\'>实践</a>，实践是大数据的最终价值体现。在这里分别从互联网的大数据，政府的大数据，企业的大数据和个人的大数据四个方面来描绘大数据已经展现的美好景象及即将实现的蓝图。<span style=\'font-size: 12px; line-height: 0; position: relative; vertical-align: baseline; top: -0.5em; margin-left: 2px; color: rgb(51, 102, 204); cursor: default; padding: 0px 2px;\'>[9]</span><a style=\'color: rgb(19, 110, 194); position: relative; top: -50px; font-size: 0px; line-height: 0;\' name=\'ref_[9]_13647476\'></a> ;</p><p><br/></p>'}]}";
            var key = "lyynhbbo";
            var encode = DESEncryptUtils.Encode(s, key);
            Console.WriteLine(encode);
            var decode = DESEncryptUtils.Decode(encode, key);
            Console.WriteLine(decode);

            Console.WriteLine();
            key = "B98DB5CA435B479D819C6B255CBCD62C";
            var iv = "AB6882A633472F39";
            encode = AESEncryptUtils.EncryptByAES(s, key, iv);
            Console.WriteLine(encode);
            decode = AESEncryptUtils.DecryptByAES(encode, key, iv);
            Console.WriteLine(decode);



        }


        [TestMethod]
        public void AAWhereTest()
        {
            var r = "eQe2G3U70To%3d".DesDecrypt();
            Console.WriteLine(r.Serializer());
            var r1 = ServicesFactory.GGZYJD.TAfcProjectService.ProjectReportBuildApproval(new TAfcProjectModel { MID = "eQe2G3U70To%3d", APPROVAL_STATE = 3 });
            Console.WriteLine(r1);
        }
        [TestMethod]
        public void WhereTest()
        {
            var where = LEGAL_PERSON_BASE._.LEGAL_CODE == "";
            Console.WriteLine(where.Where);
            Console.WriteLine(where.WhereString);
            Console.WriteLine(where.expressionString);
            var r = ServicesFactory.GGZYFW.LegalPersonBaseService.FromWhere(where);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void GetTpDataInfoTest()
        {
            var r = ServicesFactory.GGZYJD.TTpDataService.GetTpDataInfo(new TTpDataModel() { CODE = "FJ00111001.3.6", BUSINESSID = "I3505000129999720001" });
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void LookIntoPageListTest()
        {
            var r = ServicesFactory.GGZYJD.PtZxtsLookIntoService.LookIntoPageList(new PtZxtsLookIntoModel() { STATUS = 0 }, new SearchCondition());
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void FeedbackDetailTest()
        {
            var r = ServicesFactory.GGZYJD.PtZxtsLookIntoService.FeedbackDetail("QZ202006230000");
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TAfcProjectBuilder()
        {
            ServicesFactory.GGZYJD.TAfcProjectService.ProjectReportBuild(new TAfcProjectModel
            { KIND = "1", TZ_CODE = "2020-350421-22-03-001861" });
        }

        [TestMethod]
        public void ComplaintDetailTest()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Logger.Debug("Debug");
            //    Logger.Info("Info");
            //    Logger.Warn("Warn");
            //    Logger.Error("Error");
            //    Logger.Fatal("Fatal");
            //    Thread.Sleep(1000*5);
            //}
            var r = ServicesFactory.GGZYJD.TUserDepartmentService.FindDepartmentByDepid(23);
            Console.WriteLine(r.Serializer());
            //var r = ServicesFactory.GGZYJD.PtZxtsService.ComplaintDetail("202006106903");
            //Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void ComplaintCountTest()
        {
            var r = ServicesFactory.GGZYJD.PtZxtsService.ComplaintCount();
            Console.WriteLine(r.Serializer());
            //var plist=ServicesFactory.GGZYJD.PtZxtsService.ComplaintPageList(new PtZxtsModel(), new SearchCondition());
            //Console.WriteLine(plist.Serializer());
        }
        [TestMethod]
        public void ComplaintPageListTest()
        {
            var plist = ServicesFactory.GGZYJD.PtZxtsService.ComplaintPageList(new PtZxtsModel
            {

            }, new SearchCondition()
            {
                BeginTime = new DateTime(2020, 7, 30),

                EndTime = new DateTime(2020, 7, 31)
            });
            Console.WriteLine(plist.Serializer());
        }
        [TestMethod]
        public void AfterDetailTest()
        {
            //var r= ServicesFactory.GGZYJD.TAfcFixedService.AfterDetail("E3505050602100001001");
            //Console.WriteLine(r.Serializer()); 
            var r1 = ServicesFactory.GGZYJD.TAfcFixedService.AfterDetailMock("E3505050602100001001");
            Console.WriteLine(r1.Serializer());
        }
        [TestMethod]
        public void GCJS_KB_TEST()
        {
            ServicesFactory.GGZYFW.MvTjAllcreateXzjdService.GCJS_KB("E3500000001001066001", "HT");
        }
        public void SetPValue(object obj, Type type)
        {
            foreach (var prop in type.GetProperties())
            {
                var pValue = prop.GetValue(obj);
                if (pValue != null)
                {
                    if (prop.CanRead && prop.CanWrite)
                    {
                        if (prop.PropertyType == typeof(string) || prop.PropertyType == typeof(String))
                        {
                            if (!pValue.ToString().CheckSqlStr())
                            {
                                var v = Convert.ChangeType(pValue.ToString().FilterSql(), prop.PropertyType);
                                prop.SetValue(obj, v);
                            }
                        }
                        else if (pValue is List<string> listStr)
                        {
                            var list1 = new List<string>();
                            foreach (var o in listStr)
                            {
                                list1.Add(!o.ToString().CheckSqlStr() ? o.ToString().FilterSql() : o);
                            }
                            prop.SetValue(obj, list1);
                        }

                        else if (pValue is IEnumerable<object> list)
                        {
                            foreach (var o in list)
                            {
                                SetPValue(o, o.GetType());
                            }
                            prop.SetValue(obj, list);
                        }

                        else if (!prop.PropertyType.IsPrimitive && !prop.PropertyType.IsValueType)
                        {
                            SetPValue(pValue, prop.PropertyType);
                            prop.SetValue(obj, pValue);

                        }
                    }
                }
            }

        }
        [TestMethod]
        public void SqlFilterTest()
        {
            var dic = new Dictionary<string, string>
            {
                {"1","1" },
                {"2","2" }
            };
            Console.WriteLine(dic.Serializer());
            return;
#pragma warning disable CS0162 // 检测到无法访问的代码
            var r = ServicesFactory.GGZYJD.ProjectService.FromWhere()
#pragma warning restore CS0162 // 检测到无法访问的代码
                 .Select(new Field("'FIXED'").As("AFC_TYPE"), new Field("'FIXED'").Count()).ToFirst<object>();
            Console.WriteLine(r.Serializer());
            var model = new GeneralAuthRule
            {
                RULE_ID = "73512e84-c4ec-4a1e-8141-d4ada0bc8c73",
                GROUP_ID = "13",
                REMARK = null,
                POWER = "Select,Censor,Add,Update,Del",
                MODULE = "GGZYJD_ADMIN",
                NAME = "交通审查人员",
                LOG_AUTH = null,
                MENU_AUTH = new List<string>
                {

                    "1",
                    "e8d1bf47-f302-447a-bb2a-a347bea91df5",
                    "9fb07c6a-b66c-4c1d-b511-c69276c90cae",
                    "87f4d24d-0aef-43c8-913d-83a2f5ffe100",
                    "3f4ef3b2-9456-4a47-8daa-d3009da58835",
                    "51",
                    "4cd4e21d-e5b0-4515-b4ce-ab68374438c1",
                    "4ce1ddd7-2607-42d2-8549-eb8dd73b07da",
                    "e6e7300e-0a81-479c-a25a-1c489b94b989",
                    "5b02139a-d6e1-4894-a344-8f6d6e01c2a5",
                    "6e5eb5b3-0a78-4781-ba46-6b7e0e6d2cb9",
                    "ed12e731-eb7c-4e69-ba31-86b170776e79",
                    "0716b2cd-8a73-46fe-863f-d4ee8ac6f004",
                    "19b16850-91cc-463b-8a45-7105b9549c18",
                    "9b13991d-1a41-488f-af25-5b42cb28d744",
                    "462bdf4f-e261-4bf1-8532-e9641361e8d2",
                    "2360baf3-3816-4311-978f-92da04498a8c",
                    "b62e34c8-d4f4-41f0-a3aa-f9a89540db53",
                    "7338e03a-f805-46aa-bc34-bfa2740e63fc",
                    "48960f84-4a69-4137-8f53-7a4c58ad8d6d",
                    "4987acf9-b859-4583-be0d-6c2b6ba5016b",
                    "da561dee-abdc-4fb6-a570-e1676b93b7f7",
                    "e966bb36-a4bf-4af0-b9ce-810d95a97dbd",
                    "bb03674e-87ee-48bb-a118-01594f004ff6",
                    "7ca660e0-ebe5-462a-b0d1-614c6d0c9a43",
                    "16a24764-9ee8-4f3a-9a52-3a5bd5be1319",
                    "f148e4a0-882c-4539-bfcc-cf62b9d7dace",
                    "04266cb2-916b-4c7a-aae2-be27ce358ff4",
                    "605fe43f-97fa-4884-9a75-a74eab9154f3",
                    "309f96fd-21be-4504-80dd-f94304ce235e",
                    "fb604314-b705-47a7-b345-92bbde45a71c",
                    "94678ef3-a26a-468a-a173-2d77527107d5",
                    "4d506bf8-27aa-4889-b7aa-cf5460f00b7d",
                    "813ef436-d2a6-42d9-af80-035ee6727eea",
                    "598ba020-b97a-46c9-8b6b-cfaa717cab4b",
                    "b6917b30-c88a-4806-aea7-c77aa1c1380d",
                    "2a77420d-ecc7-4429-8f7b-040b4b6b423b",
                    "716ef211-91ea-4d2a-8766-6898dcba6ad6",
                    "923696b7-4bb1-4a86-8b3f-6d9a5d8ded7b",
                    "4b184c2e-f434-4cb1-93c1-db0b6696822a"
                },

            };
            SetPValue(model, model.GetType());
            //Console.WriteLine(model.MENU_AUTH.GetType());
            //Console.WriteLine(typeof(List<string>));

        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("select * from".FilterSql());
            //var address ="http://110.89.45.4:7581/epoint-financeplatform-web/rest/file/download?fileguid=9f34764f-565e-4b15-b139-16b819b95038";
            //var saveDir = $"D:/test/download";
            //var savePath = WebUtils.Download(address, saveDir);
            //Console.WriteLine(savePath);
            // Console.WriteLine("xxsx.jpg".Extension());
            // Console.WriteLine("%2f2736%2bACxjQ%3d".DesDecrypt());
            //var r= ServicesFactory.GGZYJD.CommonService.GeneralTable(new SearchCondition(),out int _);
            //Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void FileCopy()
        {
            var dir = new DirectoryInfo(@"D:\Desktop\autocode\JdController");
            foreach (var file in dir.GetFiles())
            {
                var destFileName = file.Name.Replace(".cs", ".tool.cs");
                var destFullFileName = $@"D:\Desktop\autocode\JdControllerTool\{destFileName}";
                file.CopyTo(destFullFileName);
            }
        }

        [TestMethod]
        public void JoinTest()
        {
            long i = Guid.NewGuid().ToByteArray().Aggregate<byte, long>(1, (current, b) => current * (b + 1));
            Console.WriteLine(i);
            var s = $"{i - DateTime.Now.Ticks:x}";
            Console.WriteLine(s);
            var guid = Guid.NewGuid().ToString("N");
            Console.WriteLine(guid);
            Console.WriteLine(guid.Length);
            return;
#pragma warning disable CS0162 // 检测到无法访问的代码
            var r = ServicesFactory.GGZYFW.TenderProjectService.Join(113169);
#pragma warning restore CS0162 // 检测到无法访问的代码
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void JoinTest1()
        {
            var r = ServicesFactory.GGZYFW.TenderProjectService.Join1(113169);
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void JoinTest2()
        {
            var r = ServicesFactory.GGZYFW.TenderProjectService.Join2(113169);
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void ThreadTest()
        {
            bool wait = true;
            new Thread((s) =>
                {
                    dynamic d = s as dynamic;
                    var a = d.A;
                    Console.WriteLine(a);
                    wait = false;
                })
            { IsBackground = true }.Start(new
            {
                A = 1,
                B = 2
            });

            while (wait)
            {

            }
            //Console.ReadKey();
        }

        [TestMethod]
        public void GeneralResultTest()
        {
            var r = new GeneralResult<LoginModel>();
            r.SetSuccessT(new LoginModel
            {
                Name = "0",
            });
            //Console.WriteLine(r.TData.Name);
            Console.WriteLine(r.Serializer());
            if (r is GeneralResult result)
            {
                Console.WriteLine(result.Serializer());
            }
        }

        [TestMethod]
        public void RsaTest()
        {

            var rsa = new RSACryptoServiceProvider();
            var xml = rsa.ToXmlString(true);
            Console.WriteLine(xml);
            Console.WriteLine();
            var rspParm = rsa.ExportParameters(true);
            Console.WriteLine(CommonUtils.BytesToHexString(rspParm.Exponent));
            Console.WriteLine();
            Console.WriteLine(CommonUtils.BytesToHexString(rspParm.Modulus));
            Console.WriteLine();
            var s = "abc123";
            //var hash = FormsAuthentication.HashPasswordForStoringInConfigFile(s, "MD5");
            //Console.WriteLine(hash);
            //Console.WriteLine();

            MD5 md5 = MD5.Create();
            Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            Console.WriteLine(CommonUtils.BytesToHexString(bytes));
        }

        [TestMethod]
        public void WebClientTest()
        {
            var url = "http://114.115.162.77:8060/api/logs";
            var postString = "{a:1}";
            //log.Debug("提交数据开始,请求id:"+ requestid + ",url:" + url + ",data:" + postString);
            WebClient webClient = new WebClient { Encoding = Encoding.UTF8 };
            byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
            webClient.Headers.Add("Content-Type", "application/json");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
            byte[] responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流  
            var result = Encoding.UTF8.GetString(responseData);//解码  
            Console.WriteLine(result);
        }

        [TestMethod]
        public void WebClientAsyncTest()
        {
            var url = "http://114.115.162.77:8060/api/logs";
            var postString = "{a:1:1}";
            //log.Debug("提交数据开始,请求id:"+ requestid + ",url:" + url + ",data:" + postString);
            byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add("Content-Type", "application/json");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                webClient.UploadDataCompleted += WebClient_UploadDataCompleted;
                webClient.UploadDataAsync(new Uri(url), "POST", postData);//得到返回字符流 
            }

            Console.WriteLine(DateTime.Now);
            Thread.Sleep(500);
            Console.WriteLine(DateTime.Now);
        }

        private void WebClient_UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
            var result = Encoding.UTF8.GetString(e.Result);//解码 
            Console.WriteLine($"RSP:{result} {DateTime.Now}");


        }

        [TestMethod]
        public void RegisterPersonalUserTest()
        {
            var r = ServicesFactory.GGZYFW.TUserService.RegisterPersonalUser(new RegisterModel
            {
                UserName = DateTime.Now.ToString("yyyyMMddHHmmss"),
                Email = DateTime.Now.ToString("yyyyMMddHHmmss"),
                Mobile = "12345678902",
            });
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void RegisterUserMember()
        {
            try
            {
                var r = ServicesFactory.GGZYJD.TUserService.RegisterUserMember(new RegisterModel
                {
                    //AccountType = "0",
                    UserName = "0",
                    Email = "0",
                    Pwd = "0",
                    ConfirmPwd = "0",
                    OrgName = "0",
                    OrgCode = "0",
                    OrgType = "0",
                    OrgCodeImg = "0",
                    Province = "0",
                    City = "0",
                    County = "0",
                    Address = "0",
                    PostalCode = "0",
                    UnifiedCreditCode = "0",
                    //UnifiedCreditCodeImg = "0",
                    ContractPhone = "0",
                    Contract = "0",
                    Mobile = "0",
                    ManageName = "0",
                });
                Console.WriteLine(r.Serializer());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [TestMethod]
        public void AuthApp()
        {
            var rsp = new GeneralResult();

            //var r= ServicesFactory.GGZYFW.UnifyAuthsService.FindAll();
            //Console.WriteLine(r.Serializer());
            var authApp = ServicesFactory.GGZYFW.UnifyAuthsService.AuthApp();
            rsp.SetSuccess(authApp);
            Console.WriteLine();
            Console.WriteLine(rsp.Serializer());

            var unAuthApp = ServicesFactory.GGZYFW.UnifyAppService.UnAuthApp();
            rsp.SetSuccess(unAuthApp);
            Console.WriteLine();
            Console.WriteLine(rsp.Serializer());
        }

        [TestMethod]
        public void Redirect()
        {
            var r = ServicesFactory.GGZYFW.UnifyAppService.ViewByPk("f42df117-ef78-49c2-883c-1ff939aa44a1");
            if (r.Success)
            {
                var app = r.Data as UNIFY_APP;
                var ticket = Guid.NewGuid().ToString("N");


                var url = $"{app.SSOURL}?ticket={ticket}";
                r.SetSuccess(new { Url = url });
            }

            Console.WriteLine();
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void CreateToken()
        {
            var identity = new CustomAuthenticationIdentity
            {
                Ticket = "Ticket",
                TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss"),
                Id = "Id",
                Name = "Name",
                LoginName = "LoginName"
            };


            var tokenManager = new JwtTokenManager();
            Console.WriteLine(tokenManager.CreateToken(identity).Serializer());
            Console.WriteLine();
            Console.WriteLine(tokenManager.CheckToken(identity.Ticket).Serializer());
        }

        [TestMethod]
        public void RsaTest1()
        {
            var s = "strong9889";
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            var publicKey = rsa.ToXmlString(false);
            var privateKey = rsa.ToXmlString(true);
            rsa.FromXmlString(publicKey);
            var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(s), false);
            var secret = Convert.ToBase64String(bytes);
            Console.WriteLine(secret);

            var rsa1 = new RSACryptoServiceProvider();
            rsa1.FromXmlString(privateKey);
            bytes = rsa1.Decrypt(Convert.FromBase64String(secret), false);
            var s1 = Encoding.UTF8.GetString(bytes);
            Console.WriteLine(s1);
        }

        [TestMethod]
        public void EnumTesst()
        {
            var certs = Enum.GetValues(typeof(CertSign)).Cast<CertSign>().ToList();
            foreach (CertSign cert in certs)
            {
                var name = Enum.GetName(typeof(CertSign), cert);
                Console.WriteLine($"{(int)cert} {cert} {name}");
            }
        }

        [TestMethod]
        public void PropertiesTest()
        {
            var m = new CertificateAuthorityModel();
            var ls = m.Data.GetType().GetProperties();
            foreach (PropertyInfo info in ls)
            {
                Console.WriteLine(info.Name);
                try
                {
                    info.SetValue(m.Data, "1");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            Console.WriteLine(m.Data.Serializer());
        }

        [TestMethod]
        public void OtherTradeInfo_ZFCG()
        {
            var r = ServicesFactory.GGZYFW.MvJyxxService.OtherTradeInfo("A99-91359128593462349A-20170601-002267-T");//D01-12350100MB02709751-20190627-527731-5
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeDetail_ZFCG()
        {
            var r = ServicesFactory.GGZYFW.MvJyxxService.ZFCG_TradeInfo("D03-12350100MB02709751-20200319-102642-5");//D01-12350100MB02709751-20190627-527731-5
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void TradeInfoProTypes()
        {
            var r = ServicesFactory.GGZYFW.MvJyxxService.TradeInfoProTypes(new SearchCondition
            {
                BeginTime = DateTime.Now.AddMonths(-6),
                EndTime = DateTime.Now
            });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TradeInfoTest()
        {
            //var model=n
            var r = ServicesFactory.GGZYFW.MvJyxxService.TradeInfoPageList(
                  new MV_JYXX
                  {
                      KIND = "GCJS",

                  },
                  new SearchCondition
                  {
                      PageNo = 1,
                      PageSize = 10,
                      BeginTime = new DateTime(2019, 11, 25),
                      EndTime = new DateTime(2020, 3, 24, 23, 59, 59)
                  });
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void ReplaceTest()
        {
            var pattern = ":TM1";
            var s = "SELECT count(*) as r_cnt FROM ( SELECT   * FROM \"MV_JYXX\"  WHERE ((((((\"MV_JYXX\".\"TM\" >= :TM1) AND (\"MV_JYXX\".\"TM\" <= :TM2)) AND (\"MV_JYXX\".\"TM\" <= :TM3)) AND (\"MV_JYXX\".\"AREACODE\" LIKE '350%')) AND (\"MV_JYXX\".\"KIND\" = 'GCJS')) AND ((\"MV_JYXX\".\"M_DATA_SOURCE\" = '9999') OR (\"MV_JYXX\".\"TM\" >= :TM12))) UNION  SELECT   * FROM \"MV_JYXX_HISTORY\"  WHERE ((((((\"MV_JYXX_HISTORY\".\"TM\" >= :TM4) AND (\"MV_JYXX_HISTORY\".\"TM\" <= :TM5)) AND (\"MV_JYXX_HISTORY\".\"TM\" <= :TM6)) AND (\"MV_JYXX_HISTORY\".\"AREACODE\" LIKE '350%')) AND (\"MV_JYXX_HISTORY\".\"KIND\" = 'GCJS')) AND ((\"MV_JYXX_HISTORY\".\"M_DATA_SOURCE\" = '9999') OR (\"MV_JYXX_HISTORY\".\"TM\" >= :TM14)))) MV_JYXX";
            var s1 = s.Replace("TM", "1");
            Console.WriteLine(s1);
            for (var r = 1; r < 15; r++)
            {

                s = Regex.Replace(s, $"\\b{pattern}\\b", "2", RegexOptions.None);

                Console.WriteLine(s);
            }
            Console.WriteLine(Regex.Replace("TM,:TM1,:TM2", $":\\bTM1\\b", "2", RegexOptions.None));

        }

        [TestMethod]
        public void GCJS_TradeInfoTest()
        {
            Console.WriteLine(DateTime.MinValue);
            //var r = ServicesFactory.GGZYFW.MvJyxxService.GCJS_TradeInfo("65049");//63076
            var r = ServicesFactory.GGZYFW.MvJyxxService.GCJS_TradeInfoDetail("65049");//63076
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void TDSYQ_TradeInfoTest()
        {
            var r = ServicesFactory.GGZYFW.MvJyxxService.TDSYQ_TradeInfo("B01-12350100MB02709751-20161231-211018-2");
            Console.WriteLine(r.Serializer());
        }

        [TestMethod]
        public void WhereString()
        {
            var r = ServicesFactory.GGZYFW.CommonService.KeywordSearch(new SearchCondition { Type = "2" });
            Console.WriteLine(r.Serializer());
        }
        [TestMethod]
        public void NoticeCountTest()
        {
            var r = ServicesFactory.GGZYJD.PtArticleService.PageDataTable(new DbEntity.PT_ARTICLE(), new SearchCondition { PageSize = 1 });
            Console.WriteLine(r.Serializer());
        }
    }
}
