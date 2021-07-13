using System;
using System.Collections.Generic;
using GGZY.Core.Models;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class ProjectService 
    {
        /// <summary>
        /// 监督平台门户 项目监督信息 工程建设 项目进场 项目信息
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="attachmentFunc">门户网站不显示附件</param>
        /// <returns></returns>
        public dynamic JD_GCJS_XMJC_ProjectInfo(string projectCode,Func<string,List<UploadResData>>attachmentFunc=null)
        {
            var entity = Fw.TenderProjectService.FromWhere(TENDER_PROJECT._.TENDER_PROJECT_CODE == projectCode)
                .InnerJoin<PROJECT>(TENDER_PROJECT._.PROJECT_CODE == PROJECT._.PROJECT_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == PROJECT._.INDUSTRIES_TYPE)
                .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == PROJECT._.REGION_CODE)
                .Select(
                    PROJECT._.PROJECT_CODE,
                    PROJECT._.PROJECT_NAME,
                    PROJECT._.REGION_CODE,
                    SYS_AREA_QUANGUO._.AREANAME,
                    PROJECT._.INDUSTRIES_TYPE,
                    SYS_DIC._.TEXT.As("INDUSTRIES_TYPE_TEXT"),
                    PROJECT._.PROJECT_SCALE,
                    PROJECT._.CONTACT_INFORMATION,
                    PROJECT._.CONTACTOR,
                    PROJECT._.FUND_SOURCE,
                    PROJECT._.CONTRIBUTION_SCALE,
                    PROJECT._.CREATE_TIME,
                    PROJECT._.M_ATT_PROJECT_APPROVAL_FILE
                ).ToFirst<dynamic>();
            if (entity != null)
            {

                #region 监督平台后台 sType == "HT" && MemberUserInfo.UserID != -1

                if (attachmentFunc != null)
                {

                    entity.M_ATT_PROJECT_APPROVAL_FILE_ATTACHMENT = attachmentFunc.Invoke(entity.M_ATT_PROJECT_APPROVAL_FILE);
                }

                #endregion

                string shiBenJi = entity.AREANAME?.ToString();//市本级
                string shiBenJiCode = entity.REGION_CODE?.ToString();//市本级编码
                if (!string.IsNullOrWhiteSpace(shiBenJiCode) && !string.IsNullOrWhiteSpace(shiBenJi))
                {
                    //var areacode = shiBenJiCode.PadRight(6, '0').Substring(0, 4).PadRight(6,'0');
                    var parentRegion = Fw.SysAreaQuanguoService.FirstOrNull(SYS_AREA_QUANGUO._.AREACODE.SubQueryIn(
                        Fw.SysAreaQuanguoService.FromWhere(SYS_AREA_QUANGUO._.AREACODE == shiBenJiCode).Select(SYS_AREA_QUANGUO._.PCODE)));
                    if (parentRegion != null)
                    {
                        entity.P_AREANAME = string.IsNullOrWhiteSpace(parentRegion.AREANAME) || parentRegion.AREANAME == "福建省" ? "" : parentRegion.AREANAME;
                        entity.P_REGION_CODE = parentRegion.AREACODE;
                    }
                    else
                    {
                        entity.P_AREANAME = "";
                        entity.P_REGION_CODE = "";
                    }
                }
                else
                {
                    entity.P_AREANAME = "";
                    entity.P_REGION_CODE = "";
                }
            }
            return entity;
        }
	}
}