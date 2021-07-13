using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class TENDER_PROJECT : JdEntity
    {
        /// <summary>
        /// 构造函数，客户端提交参数时保护非开放数据
        /// </summary>
        /// <param name="tender_project"></param>
        public  TENDER_PROJECT(TENDER_PROJECT tender_project)
        {
            M_ID = 0;
            PROJECT_CODE = tender_project.PROJECT_CODE;
            TENDER_PROJECT_NAME = tender_project.TENDER_PROJECT_NAME;
            TENDER_PROJECT_TYPE = tender_project.TENDER_PROJECT_TYPE;
            REGION_CODE = tender_project.REGION_CODE;
            TENDER_CONTENT = tender_project.TENDER_CONTENT;
            TENDERER_NAME = tender_project.TENDERER_NAME;
            TENDERER_CODE_TYPE = tender_project.TENDERER_CODE_TYPE;
            TENDERER_CODE = tender_project.TENDERER_CODE;
            TENDERER_ROLE = tender_project.TENDERER_ROLE;
            TENDER_AGENCY_NAME = tender_project.TENDER_AGENCY_NAME;
            TENDER_AGENCY_CODE_TYPE = tender_project.TENDER_AGENCY_CODE_TYPE;
            TENDER_AGENCY_CODE = tender_project.TENDER_AGENCY_CODE;
            TENDER_AGENCY_ROLE = tender_project.TENDER_AGENCY_ROLE;
            TENDER_MODE = tender_project.TENDER_MODE;
            TENDER_ORGANIZE_FORM = tender_project.TENDER_ORGANIZE_FORM;
            SUPERVISE_DEPT_NAME = tender_project.SUPERVISE_DEPT_NAME;
            SUPERVISE_DEPT_CODE = tender_project.SUPERVISE_DEPT_CODE;
            APPROVE_DEPT_NAME = tender_project.APPROVE_DEPT_NAME;
            APPROVE_DEPT_CODE = tender_project.APPROVE_DEPT_CODE;
            PLATFORM_CODE = tender_project.PLATFORM_CODE;
            //PUB_SERVICE_PLAT_CODE = tender_project.PUB_SERVICE_PLAT_CODE;
            RECORD_DEPID = tender_project.RECORD_DEPID;
            CREATE_TIME = tender_project.CREATE_TIME;
            TENDERER_CONTRACT = tender_project.TENDERER_CONTRACT;
            TENDERER_PHONE = tender_project.TENDERER_PHONE;
            TENDER_AGENT_CONTRACT = tender_project.TENDER_AGENT_CONTRACT;
            TENDER_AGENT_PHONE = tender_project.TENDER_AGENT_PHONE;
            TENDER_DOCNAME = tender_project.TENDER_DOCNAME;
            RTYPE = tender_project.RTYPE;
        }
        public TENDER_PROJECT()
        {
            if(! M_ID.HasValue)
            {
                M_ID = 0;
            }
        }
        public override string GetSequence()
        {
            return "SEQ_tender_project";
        }

        public override Field GetIdentityField()
        {
            return _.M_ID;
        }
    }
}
