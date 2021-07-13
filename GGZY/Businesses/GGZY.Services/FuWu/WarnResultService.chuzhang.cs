using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZY.Services.JianDu;
using GGZYFW.DbEntity;
using GGZYJD.DbEntity;



namespace GGZY.Services.FuWu
{
    /// <summary>
    /// 处长门户
    /// </summary>
    public partial class WarnResultService
    {
        #region 纪委监委
        /// <summary>
        /// 处长门户 纪委监委 发起督查 招标备案 细项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult RecordReviewSuperviseItem(TSuperviseModel model)
        {
            var r = new GeneralResult();
            var dbModel = FromWhere(WARN_RESULT._.M_ID == model.ENTITY_ID)
            .LeftJoin<GGZYFW.DbEntity.SYS_AREA_QUANGUO>(GGZYFW.DbEntity.SYS_AREA_QUANGUO._.AREACODE == WARN_RESULT._.REGION_CODE)
                .LeftJoin<GGZYFW.DbEntity.TENDER_PROJECT>(GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE == WARN_RESULT._.TENDER_PROJECT_CODE)
                //.LeftJoin<T_USER_DEPARTMENT>(T_USER_DEPARTMENT._.DEPID == TENDER_PROJECT._.RECORD_DEPID)
                //.LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE) //工程类别
                .Select(
                WARN_RESULT._.TENDER_PROJECT_CODE.As("CODE"),
                GGZYFW.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_NAME.As("PROJECT_NAME"),
                   GGZYFW.DbEntity. SYS_AREA_QUANGUO._.AREANAME.As("REGION_NAME")
                ).ToFirst<TSuperviseResultModel>();
            if (dbModel != null)
            {
                var tenderProject =
                    Jd.TenderProjectService.FirstOrNull(GGZYJD.DbEntity.TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 ==
                                                        dbModel.CODE);
                if (!string.IsNullOrWhiteSpace(tenderProject?.RECORD_DEPID))
                {
                    dbModel.APPROVAL_DEPNAME = Jd.TUserDepartmentService
                        .FirstOrNull(GGZYJD.DbEntity.T_USER_DEPARTMENT._.DEPID == tenderProject.RECORD_DEPID)?.DNAME;
                }
                r.SetSuccess(new
                {
                    DEPID=tenderProject?.RECORD_DEPID,
                    DQ=dbModel.REGION_NAME,
                    SCDW=dbModel.APPROVAL_DEPNAME,
                    BH=dbModel.CODE,
                    MC=dbModel.PROJECT_NAME,
                    SXLX="监督点处理"
                });
            }
            else
            {
                r.SetFail("未找到对应的招标备案信息");
            }
            return r;
        }


        #endregion
       
    }
}