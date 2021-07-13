using System;
using System.Collections.Generic;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model.FuWu;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class TAskanswerService
    {
        #region 服务门户-咨询|质疑

        /// <summary>
        /// 服务门户-咨询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Ask(T_ASKANSWER model)
        {
            var r = new GeneralResult();
            if (string.IsNullOrWhiteSpace(model.TITLE)
                || string.IsNullOrWhiteSpace(model.ASK)
                || !model.ANN_ID.HasValue
                || !model.TM.HasValue
            )
            {
                r.SetFail("参数错误");
            }
            else
            {
                model.ID = 0;
                model.M_TM = DateTime.Now;
                model.ASK_USERID = FwUser.ID;
                model.RETURN = 0;
                model.TYPE = 0;//咨询
                Insert(model);
                r.SetSuccess();
            }
            return r;
        }
        /// <summary>
        /// 服务门户-质疑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Question(T_ASKANSWER model)
        {
            var r = new GeneralResult();
            if (string.IsNullOrWhiteSpace(model.TITLE)
                || string.IsNullOrWhiteSpace(model.ASK)
                ||string.IsNullOrWhiteSpace(model.ASK_ZY_REASON)
                || !model.ANN_ID.HasValue
                || !model.TM.HasValue
            )
            {
                r.SetFail("参数错误");
            }
            else
            {
                model.ID = 0;
                model.M_TM = DateTime.Now;
                model.ASK_USERID = FwUser.ID;
                model.RETURN = 0;
                model.TYPE = 1;//质疑
                Insert(model);
                r.SetSuccess();
            }
            return r;
        }

        #endregion

        /// <summary>
        /// 服务平台门户-交易信息-交易详情页-咨询质疑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TAskAnswerModel> EngineerTradeInfoQas(string id)
        {
            var qa = FromWhere(T_ASKANSWER._.ANN_ID == id && T_ASKANSWER._.IS_GS == 1)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "9001" && SYS_DIC._.VALUE == T_ASKANSWER._.TYPE)
                .LeftJoin<T_USER>(T_USER._.ID == T_ASKANSWER._.ANSWER_USERID)
                .OrderBy(T_ASKANSWER._.TM)
                .Select(
                    T_ASKANSWER._.ID,
                    T_ASKANSWER._.TM,
                    T_ASKANSWER._.ASK,
                    T_ASKANSWER._.TITLE,
                    T_ASKANSWER._.ANSWER,
                    T_ASKANSWER._.ANSWER_TM,
                    T_ASKANSWER._.ASK_ZY_REASON,
                    SYS_DIC._.TEXT.As("TYPE_TEXT"),
                    T_USER._.ZP_UNIT,
                    T_USER._.MANAGE_NAME
                ).ToList<TAskAnswerModel>();
            return qa;
        }

        public T_ASKANSWER EngineerTradeInfoQa(string id)
        {
            var qa = FromWhere(T_ASKANSWER._.ID == id && T_ASKANSWER._.IS_GS == 1)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "9001" && SYS_DIC._.VALUE == T_ASKANSWER._.TYPE)
                .LeftJoin<T_USER>(T_USER._.ID == T_ASKANSWER._.ANSWER_USERID)
                .OrderBy(T_ASKANSWER._.TM)
                .Select(
                    T_ASKANSWER._.ID,
                    T_ASKANSWER._.TM,
                    T_ASKANSWER._.ASK,
                    T_ASKANSWER._.TITLE,
                    T_ASKANSWER._.ANSWER,
                    T_ASKANSWER._.ANSWER_TM,
                    T_ASKANSWER._.ASK_ZY_REASON,
                    SYS_DIC._.TEXT.As("TYPE_TEXT"),
                    T_USER._.ZP_UNIT,
                    T_USER._.MANAGE_NAME
                ).ToFirst<TAskAnswerModel>();
            if (qa != null)
            {
                qa.ASK = qa.ASK.Replace("&lt;", "<").Replace("&gt;", ">");
                qa.ANSWER = qa.ANSWER.Replace("&lt;", "<").Replace("&gt;", ">");
                qa.ASK_ZY_REASON = qa.ASK_ZY_REASON.Replace("&lt;", "<").Replace("&gt;", ">");
            }
          
            return qa;
        }
    }
}