using Dos.ORM;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SltScoreLogService : BaseServiceT<SLT_SCORE_LOG>
    {
        #region Utils
        protected WhereClipBuilder ConditionBuilder(SLT_SCORE_LOG model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(SLT_SCORE_LOG._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.CODE))
            {
                condition.And(SLT_SCORE_LOG._.CODE.Contain(model.CODE));
            }
            if (model.SCORE != null)
            {
                condition.And(SLT_SCORE_LOG._.SCORE == (model.SCORE));
            }
            if (!string.IsNullOrWhiteSpace(model.DATATIMESTAMP))
            {
                condition.And(SLT_SCORE_LOG._.DATATIMESTAMP.Contain(model.DATATIMESTAMP));
            }
            if (!string.IsNullOrWhiteSpace(model.SYNCDATA))
            {
                condition.And(SLT_SCORE_LOG._.SYNCDATA.Contain(model.SYNCDATA));
            }
            if (!string.IsNullOrWhiteSpace(model.SYNCTIME))
            {
                condition.And(SLT_SCORE_LOG._.SYNCTIME.Contain(model.SYNCTIME));
            }
            return condition;
        }
        #endregion
    }
}