using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class PROJECT: JdEntity
    {
        public PROJECT() {
            
        }

        public override string GetSequence()
        {
            return "SEQ_PROJECT";
        }

        public override Field GetIdentityField()
        {
            return _.M_ID;
        }

        /// <summary>
        /// 根据报建信息自动生成项目信息
        /// </summary>
        /// <param name="bjModel">报建信息</param>
        /// <param name="industries_type">行业类型</param>
        /// <param name="now">当前时间</param>
        public PROJECT(T_AFC_LOG bjModel,string industries_type, DateTime? now)
        {
            M_ID = 0;
            CONSTRUCTION_ID = bjModel.CODE;
            PROJECT_NAME = bjModel.PROJECT_NAME;
            REGION_CODE = bjModel.REGION_COUNTY ?? bjModel.REGION_CITY;
            INVEST_PROJECT_CODE = bjModel.TZ_CODE;
            ADDRESS = bjModel.PROJECT_ADDRESS;
            LEGAL_PERSON = bjModel.JS_DEP;
            INDUSTRIES_TYPE = industries_type;
            FUND_SOURCE = bjModel.FUND_SOURCE;
            CONTRIBUTION_SCALE = string.Format(@"财政资金投资比例：{0}(%)，自筹资金投资比例：{1}(%)，其他资金投资比例：{2}(%)", bjModel.CONTRIBUTION_SCALE_CZ, bjModel.CONTRIBUTION_SCALE_ZC, bjModel.CONTRIBUTION_SCALE_QT);
            PROJECT_SCALE = bjModel.GCGMJNR;
            CONTACTOR = bjModel.MANAGER;
            CONTACT_INFORMATION = bjModel.MANAGER_PHONE;

            APPROVAL_NAME = bjModel.APPROVAL_NAME;
            APPROVAL_NUMBER = bjModel.APPROVAL_NUMBER;
            APPROVAL_AUTHORITY = bjModel.APPROVAL_AUTHORITY;
            CREATE_TIME = (DateTime)bjModel.TM;
            DATA_TIMESTAMP = now.HasValue?now:null;
            M_ATT_PROJECT_APPROVAL_FILE = bjModel.APPROVAL_AIDS;
            M_ATT_LICENSE_FILE = bjModel.JS_CODE_AIDS;      
            M_CREATE_TM = now.HasValue ? now : null;
        }
    }
}
