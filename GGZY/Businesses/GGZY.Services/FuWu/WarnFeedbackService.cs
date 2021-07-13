using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class WarnFeedbackService
    {
        public object WarnFeedback(string mId)
        {
            var warnResult = FromWhere<WARN_RESULT>(WARN_RESULT._.M_ID == mId)
                .LeftJoin<WARN_EXPRESSION>(WARN_RESULT._.SP_ID == WARN_EXPRESSION._.M_ID && WARN_EXPRESSION._.ISDELETE != 1)
                .Select(
                    WARN_EXPRESSION._.SP_NAME,
                    WARN_EXPRESSION._.SP_TYPE,
                    WARN_EXPRESSION._.SP_FLOW_NAME,
                    WARN_EXPRESSION._.SP_NODE_NAME,
                    WARN_EXPRESSION._.SP_POINT_TYPE,
                    WARN_EXPRESSION._.SP_WAY,
                    WARN_EXPRESSION._.SP_STATUS,
                    WARN_RESULT._.CONTENT
                    )
                .ToFirst<FwWarnResultExpressionModel>();
            var warnRecords =
                Fw.WarnRecordService.FindList(WARN_RECORD._.SP_RESULT_ID == mId && WARN_RECORD._.ISDELETE != 1);

            //var dynamic = FromWhere<WARN_RESULT>(WARN_RESULT._.M_ID == mId)
            //    .LeftJoin<WARN_RECORD>(WARN_RECORD._.SP_RESULT_ID==WARN_RESULT._.M_ID  )
            //    .Select(
            //    WARN_RECORD._.CREATE_TIME.As("CREATE_TIME"),
            //    WARN_RESULT._.RESULT_STATUS.As("T_RESULT_STATUS"),
            //    WARN_RECORD._.CONTENT.As("T_CONTENT")
            //    ).ToList<dynamic>();


            return new
            {
                JDDXXNR = warnResult,
                JDDDT = warnRecords,
                //  JDDD= dynamic
            };
        }
    }
}
