using Dos.ORM;
using GGZY.Services.Base;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SltStaffLogService:BaseServiceT<SLT_STAFF_LOG>
    {
        #region Utils
        protected WhereClipBuilder ConditionBuilder(SLT_STAFF_LOG model)
        {
            WhereClipBuilder condition = new WhereClipBuilder();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                condition.And(SLT_STAFF_LOG._.ID.Contain(model.ID));
            }
            if (!string.IsNullOrWhiteSpace(model.NAME))
            {
                condition.And(SLT_STAFF_LOG._.NAME.Contain(model.NAME));
            }
            if (!string.IsNullOrWhiteSpace(model.ORGCODE))
            {
                condition.And(SLT_STAFF_LOG._.ORGCODE.Contain(model.ORGCODE));
            }
            if (!string.IsNullOrWhiteSpace(model.IDCARD))
            {
                condition.And(SLT_STAFF_LOG._.IDCARD.Contain(model.IDCARD));
            }
            if (!string.IsNullOrWhiteSpace(model.BIRTHDATE))
            {
                condition.And(SLT_STAFF_LOG._.BIRTHDATE.Contain(model.BIRTHDATE));
            }
            if (!string.IsNullOrWhiteSpace(model.PROTITLE))
            {
                condition.And(SLT_STAFF_LOG._.PROTITLE.Contain(model.PROTITLE));
            }
            if (model.WORKYEAR != null)
            {
                condition.And(SLT_STAFF_LOG._.WORKYEAR == (model.WORKYEAR));
            }
            if (!string.IsNullOrWhiteSpace(model.QUALIFYNAME))
            {
                condition.And(SLT_STAFF_LOG._.QUALIFYNAME.Contain(model.QUALIFYNAME));
            }
            if (!string.IsNullOrWhiteSpace(model.QUALIFYLEVEL))
            {
                condition.And(SLT_STAFF_LOG._.QUALIFYLEVEL.Contain(model.QUALIFYLEVEL));
            }
            if (!string.IsNullOrWhiteSpace(model.QUALIFYNO))
            {
                condition.And(SLT_STAFF_LOG._.QUALIFYNO.Contain(model.QUALIFYNO));
            }
            if (!string.IsNullOrWhiteSpace(model.SCHOOL))
            {
                condition.And(SLT_STAFF_LOG._.SCHOOL.Contain(model.SCHOOL));
            }
            if (!string.IsNullOrWhiteSpace(model.MAJOR))
            {
                condition.And(SLT_STAFF_LOG._.MAJOR.Contain(model.MAJOR));
            }
            if (!string.IsNullOrWhiteSpace(model.EDUCATE))
            {
                condition.And(SLT_STAFF_LOG._.EDUCATE.Contain(model.EDUCATE));
            }
            if (!string.IsNullOrWhiteSpace(model.SYNCDATA))
            {
                condition.And(SLT_STAFF_LOG._.SYNCDATA.Contain(model.SYNCDATA));
            }
            if (!string.IsNullOrWhiteSpace(model.SYNCTIME))
            {
                condition.And(SLT_STAFF_LOG._.SYNCTIME.Contain(model.SYNCTIME));
            }
            return condition;
        }
        #endregion

    }
}