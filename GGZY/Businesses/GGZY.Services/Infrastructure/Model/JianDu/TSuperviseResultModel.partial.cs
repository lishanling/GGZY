using System;
using System.Collections.Generic;
using System.Data;
using GGZY.Core.Extensions;
using GGZY.Core.Models;
using GGZYJD.DbEntity;


namespace GGZY.Services.Infrastructure.Model.JianDu
{
    /// <summary>
    /// 实体类T_AFC_PROJECT_SUPERVISE_RESULT。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public partial class TSuperviseResultModel
    {

        public List<string> Buttons
        {
            get
            {
                var btns=new List<string>(){"SUPERVISE","CHANGE","DETAIL"};
                if (STATUS != 1)
                {
                    btns = new List<string>() {  "DETAIL" };
                }

                return btns;
            }
        }


        #region T_AFC_PROJECT

        public string CODE { get; set; }
        public string PROJECT_NAME { get; set; }
        public string APPROVAL_DEPNAME { get; set; }

        public string REGION_NAME { get; set; }

        public string STATE_TEXT { get; set; }

        #endregion
        /// <summary>
        /// 监察点动态
        /// </summary>
        public List<T_SUPERVISE_RESULT_LOG> Logs { get; set; }
        /// <summary>
        /// 督查&反馈
        /// </summary>
        public List<TSuperviseAndFeedbackModel> SuperviseFeedback { get; set; }


      
        public string DEPID { get; set; }

       public string REVIEW_TYPE_TEXT { get; set; }

       public string MID => ENTITY_ID?.DesEncrypt();
    }
}