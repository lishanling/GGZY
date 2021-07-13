using System;
using System.Collections.Generic;
using System.Data;
using Dos.ORM;
using GGZY.Core.Models;
using GGZYJD.DbEntity;
using Newtonsoft.Json;


namespace GGZY.Services.Infrastructure.Model.JianDu
{

    public partial class PtZxtsLookIntoModel
    {
        /// <summary>
        /// 附件集合
        /// </summary>
        public List<UploadResData> LOOK_AIDS_ATTACHMENTS { get; set; }

        public int? STATUS { get; set; }

        public string STATUS_TEXT
        {
            get
            {
                var txt = string.Empty;
                if (FEEDBACK_COUNT == 0)
                {
                    txt = "未反馈";
                }
                else if (FEEDBACK_COUNT > 0 && FEEDBACK_COUNT < LOOK_COUNT)
                {
                    txt = $"部分反馈({FEEDBACK_COUNT}/{LOOK_COUNT})";
                }
                else
                {
                    txt = "已反馈";
                }

                return txt;
            }
        }
        public int LOOK_COUNT { get; set; }

        public int FEEDBACK_COUNT { get; set; }

        public string COMPLAINT_TITLE { get; set; }
        public string TENDER_PROJECT_NAME { get; set; }

        public string CREATOR { get; set; }

        #region Utils
        public WhereClipBuilder ConditionBuilder()
        {
            WhereClipBuilder condition = new WhereClipBuilder();

            #region MyRegion

            if (!string.IsNullOrWhiteSpace(ID))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.ID.Contain(ID));
            }
            if (!string.IsNullOrWhiteSpace(TS_CODE))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.TS_CODE.Contain(TS_CODE));
            }
            if (!string.IsNullOrWhiteSpace(LOOK_CONTENT))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.LOOK_CONTENT.Contain(LOOK_CONTENT));
            }
            if (!string.IsNullOrWhiteSpace(LOOK_AIDS))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.LOOK_AIDS.Contain(LOOK_AIDS));
            }
            if (LOOK_TIME != null)
            {
                condition.And(PT_ZXTS_LOOK_INTO._.LOOK_TIME == (LOOK_TIME));
            }
            if (!string.IsNullOrWhiteSpace(CREATEDBY))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.CREATEDBY.Contain(CREATEDBY));
            }
            if (CREATEDTIME != null)
            {
                condition.And(PT_ZXTS_LOOK_INTO._.CREATEDTIME == (CREATEDTIME));
            }
            if (!string.IsNullOrWhiteSpace(UPDATEDBY))
            {
                condition.And(PT_ZXTS_LOOK_INTO._.UPDATEDBY.Contain(UPDATEDBY));
            }
            if (UPDATEDTIME != null)
            {
                condition.And(PT_ZXTS_LOOK_INTO._.UPDATEDTIME == (UPDATEDTIME));
            }


            #endregion



            return condition;
        }
        #endregion

        /// <summary>
        /// 投诉状态（1待签收，2待受理，3不予受理，4待处理，5已处理，6申请撤诉，7不予撤诉，8同意撤诉，9撤销 type=72）
        /// </summary>
        public decimal? PT_ZXTS_STATE { get; set; }

        /// <summary>
        /// 投诉处理人员
        /// </summary>
        public decimal? PT_ZXTS_HANDLE_UID { get; set; }
        /// <summary>
        /// 投诉处理状态(1待处理2已处理type=74)
        /// </summary>
        public decimal? PT_ZXTS_HANDLE_STATE { get; set; }

        public List<string> Button { get; set; }
    }
}