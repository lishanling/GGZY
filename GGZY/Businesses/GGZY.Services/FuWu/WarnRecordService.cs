using System.Collections.Generic;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnRecordService
    {
        #region 监察痕迹-监督预警
        /// <summary>
        /// 监察痕迹-监督预警
        /// </summary>
        /// <param name="fwTenderProjectCode"></param>
        /// <returns></returns>
        public List<object> GetMP_Logs(string fwTenderProjectCode)
        {
            var r = FromWhere(WARN_RESULT._.TENDER_PROJECT_CODE == fwTenderProjectCode && WARN_RECORD._.ISDELETE != 1 &&
                              WARN_RECORD._.OPERATE_TYPE == "1")
                .InnerJoin<WARN_RESULT>(WARN_RESULT._.M_ID == WARN_RECORD._.SP_RESULT_ID && WARN_RESULT._.ISDELETE != 1)
                .LeftJoin<WARN_EXPRESSION>(WARN_EXPRESSION._.ISDELETE!=1&&WARN_EXPRESSION._.M_ID==WARN_RESULT._.SP_ID)
                .OrderBy(WARN_RECORD._.CREATE_TIME.Desc)
                .Select(
                    WARN_EXPRESSION._.SP_NAME,
                    WARN_EXPRESSION._.SP_TYPE,
                    WARN_RESULT._.RESULT_STATUS,
                    WARN_EXPRESSION._.SP_POINT_RULE,
                    WARN_RECORD._.All)
                .ToList<object>();
            return r;
        }

        #endregion
    }
}