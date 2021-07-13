using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Extensions;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Helper;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGZYJD.UnitTestProject
{
    [TestClass]
    public class UnifyUnitTest
    {

        [TestMethod]
        public void SignTest()
        {
            Console.WriteLine(CommonUtils.Md5Str("E9498112A6CD42E0A4B2939CEBBC94CBACCEPT_DEPID388ACCEPT_DEPID_TEXT石狮市交建局COMPLAINT_ADRESS福建省福州市鼓楼区COMPLAINT_CODE352225199006060575COMPLAINT_CONTENTzcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题zcx测试投诉标题COMPLAINT_DNAME四创科技COMPLAINT_EMAIL389005743@qq.comCOMPLAINT_ISAGENCY0COMPLAINT_LEGAL_ISWT0COMPLAINT_NAME张传稀COMPLAINT_PC100010COMPLAINT_PHONE18610293812COMPLAINT_ROLE项目测试COMPLAINT_SX1COMPLAINT_TITLEZCX测试投诉标题0708001COMPLAINT_TYPE2COMPLAINT_ZW测试工程师FR_SFZ_AIDS[{\"new_id\":\"5ea93b37faae152db4658fb2\",\"id\":\"5f057ee6faae1526384001d3\",\"name\":\"法人身份证扫描件.pdf\",\"url\":\"/file/getcontent/5ea93b37faae152db4658fb2.pdf\",\"md5\":\"4EF93BDA83A99B9411D65C0089B80F84\",\"uid\":1594195690206,\"status\":\"success\",\"type\":\"FR_SFZ_AIDS\",\"Guid\":\"cccfb44eae684a66b89c991d7953b1b4\",\"signUrl\":\"/JdPortal/FileContent/Jd/Sys/cccfb44eae684a66b89c991d7953b1b4\"}]OTHER_AIDS532ee8951a7148168c5e6dcbdd6694c8respondents[{\"NAME\":\"博思软件\",\"TYPE\":\"1\",\"CODE\":\"123456789012345678\",\"CONTACT\":\"张三\",\"CONTACT_PHONE\":\"17759121608\",\"ADRESS\":\"福建省福州市高新区\",\"title\":\"编辑\",\"id\":\"0.8fw3he890gd\"},{\"NAME\":\"星网锐捷\",\"TYPE\":\"2\",\"CODE\":\"123456789012345678\",\"CONTACT\":\"李四\",\"CONTACT_PHONE\":\"19959125221\",\"ADRESS\":\"福建省福州市马尾区\",\"title\":\"添加\",\"id\":\"0.6usvv2qe3zh\"}]SFZ_AIDScccfb44eae684a66b89c991d7953b1b4TENDER_CLASSA01TENDER_PROJECT_CODEE473501211712180002004TENDER_PROJECT_NAME测试普通住建项目（石狮住建）ts1594195865789TSS_AIDS{}YYZM_AIDS278038d889144f368c71382f558b4a85ZMCL_AIDSd1364c7dc18d44198c11fbb61fe3dee2"));
        }
        [TestMethod]
        public void TmpJoinTest()
        {
            var from = ServicesFactory.GGZYJD.TenderProjectService.FromWhere()
                .InnerJoin<RECORD_REVIEW>(
                    RECORD_REVIEW._.TENDER_PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDERER_CODE
                    && RECORD_REVIEW._.REVIEW_STATUS.IsNotNull() && RECORD_REVIEW._.REVIEW_STATUS != '0'
                    && GGZYJD.DbEntity.TENDER_PROJECT._.M_ID_GGFW.IsNotNull())
                .GroupBy(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .Select(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1);
            ServicesFactory.GGZYJD.TProjectDataService.FromWhere()
                .LeftJoinTmp<DbEntity.TENDER_PROJECT>(from, T_PROJECT_DATA._.PROJECT_CODE == GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1)
                .First();
        }
        [TestMethod]
        public void LeftJoinTest()
        {
            //ServicesFactory.GGZYFW.TenderProjectService.FromWhere()
            //    .LeftJoin<PROJECT>(PROJECT._.PROJECT_CODE == TENDER_PROJECT._.PROJECT_CODE&&
            //                       (PROJECT._.IS_DELETE.IsNotNull()&&PROJECT._.IS_DELETE!=0)).ToFirst<object>();
        }
        [TestMethod]
        public void InitUnifyApplication()
        {
            ServicesFactory.GGZYFW.UnifyAppService.Add(new UNIFY_APP
            {
                MGUID=Guid.NewGuid().ToString(),
                APPKEY= ConfigHelper.APP_KEY_GGZYJD,
                APPNAME="公共资源监督",
                APPICON = String.Empty,
                SORT=10,
                APPTYPE = String.Empty,
                HOSTURL = string.Empty,
                SSOURL = string.Empty,
                OAUTHURL = string.Empty,
                CREATEDBY ="SYSTEM",
                CREATEDTIME=DateTime.Now,
                UPDATEDBY="SYSTEM",
                UPDATEDTIME=DateTime.Now
            });
            ServicesFactory.GGZYFW.UnifyAppService.Add(new UNIFY_APP
            {
                MGUID = Guid.NewGuid().ToString(),
                APPKEY = ConfigHelper.APP_KEY_GGZYFW,
                APPNAME = "公共资源服务",
                APPICON = String.Empty,
                SORT = 20,
                APPTYPE = String.Empty,
                HOSTURL = string.Empty,
                SSOURL = string.Empty,
                OAUTHURL = string.Empty,
                CREATEDBY = "SYSTEM",
                CREATEDTIME = DateTime.Now,
                UPDATEDBY = "SYSTEM",
                UPDATEDTIME = DateTime.Now
            });
        }
        [TestMethod]
        public void InitUnifyUser()
        {
            var jdUsers = ServicesFactory.GGZYJD.TUserService.FindAll();
            var users=new List<UNIFY_USER>();
            var auths = new List<UNIFY_AUTHS>();
            foreach (var c in jdUsers)
            {
                var user = new UNIFY_USER
                {
                    MGUID = Guid.NewGuid().ToString(),
                    NAME = c.USERNAME,
                    PWD = c.PASSWORD,
                    TYPE = 0,
                    STATE = 0,
                    CREATEDBY = "SYSTEM",
                    CREATEDTIME = DateTime.Now,
                    UPDATEDBY = "SYSTEM",
                    UPDATEDTIME = DateTime.Now,
                };
                users.Add(user);
                var auth=new UNIFY_AUTHS
                {
                    MGUID = Guid.NewGuid().ToString(),
                    USERGUID = user.MGUID,
                    APPGUID = "GGZYJD",
                    APPUID =c.ID.ToString(),
                    CREATEDBY = "SYSTEM",
                    CREATEDTIME = DateTime.Now,
                    UPDATEDBY = "SYSTEM",
                    UPDATEDTIME = DateTime.Now,
                };
                auths.Add(auth);
            }

            ServicesFactory.GGZYFW.UnifyUserService.Insert(users);
            ServicesFactory.GGZYFW.UnifyAuthsService.Insert(auths);

        }

        [TestMethod]
        public void AuthTest()
        {
            var id = "840e06e3-08e2-4c8e-aba2-a53d4032ad3f";
            var uid = ServicesFactory.GGZYFW.UnifyUserService.FromWhere(UNIFY_USER._.MGUID == id)
                .InnerJoin<UNIFY_AUTHS>(UNIFY_AUTHS._.USERGUID == UNIFY_USER._.MGUID)
                .InnerJoin<UNIFY_APP>(UNIFY_APP._.MGUID == UNIFY_AUTHS._.APPGUID && UNIFY_APP._.APPKEY == ConfigHelper.APP_KEY_GGZYJD)
                .Select(UNIFY_AUTHS._.APPUID,UNIFY_APP._.APPNAME).ToFirst<object>();
            Console.WriteLine(uid.Serializer());
        }

        [TestMethod]
        public void SignIn()
        {

        }

    }
}
