using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZY.Services.YDPB;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Services.Infrastructure.Extensions;
using GGZY.Core.Log;

namespace GGZY.Services.JianDu
{
    public partial class YdpbEvalApplyService : BaseServiceT<YDPB_EVAL_APPLY>
    {

        /// <summary>
        /// 评标状态变更 1:开始评标 2：结束评标 3：归档 4、中止评标
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult Eval(int id,int flag)
        {
            GeneralResult result = new GeneralResult();
            var applyResult = ViewByPk(id);
            if (!(applyResult.Success && applyResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("申请单信息不存在");
                return result;
            }
            YDPB_EVAL_APPLY apply = (YDPB_EVAL_APPLY)applyResult.Data;

            var condition = new WhereClipBuilder();
            condition.And(V_YDPB_APPLY_TRADE._.AREA_CODE == FwUser.AREACODE);//审核通过
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_STATUS == 2);//审核通过
            condition.And(V_YDPB_APPLY_TRADE._.FLAG == 0);
            condition.And(V_YDPB_APPLY_TRADE._.IS_MAIN == 1);
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_TYPE != 2);
           
            var detail = ServicesFactory.GGZYJD.VYdpbApplyTradeService.FindList(condition).FirstOrDefault();
            if(null == detail)
            {
                result.SetFail("项目信息不存在");
                return result;
            }

            switch (flag)
            {
                case 1://启动评标
                    if (detail.EVAL_STATUS != 0 && detail.EVAL_STATUS != 4)
                    {
                        result.SetFail("项目评标中/评标结束");
                        return result;
                    }
                    break;
                case 2://结束评标
                    if (detail.EVAL_STATUS != 1)
                    {
                        result.SetFail("项目未启动评标/评标结束");
                        return result;
                    }
                    break;
                case 4://中止评标
                    if (detail.EVAL_STATUS != 1)
                    {
                        result.SetFail("项目未启动评标/评标结束");
                        return result;
                    }
                    break;

            }

            //if( flag <= apply.EVAL_STATUS && flag !=3)
            //{
            //    result.SetFail("项目状态异常");
            //    return result;
            //}
            apply.Attach();
            apply.EVAL_STATUS = flag;
            Update(apply);
            result.SetSuccess();
            return result;
        }
        /// <summary>
        /// 查询远程异地分会场审批结果
        /// </summary>
        /// <param name="SERIES_NUMBER"></param>
        /// <returns></returns>
        public GeneralResult Query(string SERIES_NUMBER)
        {
            var result = new GeneralResult();
            var applyConditon = new WhereClipBuilder();
            applyConditon.And(YDPB_EVAL_APPLY._.IS_DELETE == 0);
            applyConditon.And(YDPB_EVAL_APPLY._.SERIES_NUMBER == SERIES_NUMBER);
            var apply = ServicesFactory.GGZYJD.YdpbEvalApplyService.FirstOrNull(applyConditon);
            if (null == apply)
            {
                result.SetFail("申请单信息不存在或已被删除");
                return result;
            }
            if (apply.FLAG != 0)
            {
                result.SetFail("申请单已变更/取消");
                return result;
            }
            var detailCondition = new WhereClipBuilder();
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);

            var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(detailCondition.ToWhereClip());
            details.ForEach(d => {
                ServicesFactory.GGZYJD.YdpbBranchService.query(apply, d);
            });

            result.SetSuccess();
            return result;
        }

        /// <summary>
        /// 分会场审批通知
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult I_Audit(string SERIES_NUMBER,int? STATUS,string AREA_CODE,string CENTER_NAME,string EVAL_ROOM_NAME,string EVAL_ROOM_ADDR,List<string> SEAT_NUMBER,string REMARK)
        {
            var result = new GeneralResult();

            if (STATUS != 1 && STATUS != 2)
            {
                result.SetFail("审批状态status值异常");
                return result;
            }

            var applyConditon = new WhereClipBuilder();
            applyConditon.And(YDPB_EVAL_APPLY._.IS_DELETE ==0);
            applyConditon.And(YDPB_EVAL_APPLY._.SERIES_NUMBER == SERIES_NUMBER);
            var apply = ServicesFactory.GGZYJD.YdpbEvalApplyService.FirstOrNull(applyConditon);
            if(null == apply)
            {
                result.SetFail("申请单信息不存在或已被删除");
                return result;
            }
            if(apply.FLAG !=0)
            {
                result.SetFail("申请单已变更/取消");
                return result;
            }
            if(apply.STATUS !=1)
            {
                result.SetFail("申请单审批状态异常");
                GGZY.Core.Log.Logger.Debug("YDPB_EVAL_APPLY.STATUS值为:" + apply.STATUS + ",期望值:1");
                return result;
            }

            var detailCondition = new WhereClipBuilder();
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.AREA_CODE == AREA_CODE && YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            detailCondition.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);

            YDPB_EVAL_APPLY_DETAIL detail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FirstOrNull(detailCondition);
            if (null == detail || detail.IS_DELETE == 1)
            {
                result.SetFail("会场申请信息不存在或已被删除");
                return result;
            }

            var conRecord = new WhereClipBuilder();
            conRecord.And(YDPB_EVAL_APPLY_RECORD._.IS_DELETE == 0 && YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == detail.ID && YDPB_EVAL_APPLY_RECORD._.AREA_CODE == detail.AREA_CODE);
            var record = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FirstOrNull(conRecord);
            if (null == record)
            {
                result.SetFail("审批流程记录异常");
                return result;
            }
            if (record.STATUS != 0)
            {
                result.SetFail("重复审批");
                return result;
            }

            YDPB_EVAL_ROOM_SEAT_RECORD seatRecord = new YDPB_EVAL_ROOM_SEAT_RECORD();
            seatRecord.APPLY_ID = apply.ID;
            seatRecord.AREA_CODE =  detail.AREA_CODE;
            seatRecord.CREATOR_ID = 0;
            seatRecord.START_TIME = apply.BID_EVAL_START_TIME;
            seatRecord.END_TIME = apply.BID_EVAL_END_TIME;
            seatRecord.EVAL_APPLY_DETAIL_ID = detail.ID;

            //申请类型
            if(apply.APPLY_TYPE ==0)
            {

                var db = GetDbSession();
                var tran = db.BeginTransaction();
                try
                {
                    #region 审核通过
                    if (STATUS == 1)
                    {
                        var roomCondition = new WhereClipBuilder();
                        roomCondition.And(YDPB_EVAL_ROOM._.AREA_CODE == AREA_CODE);
                        roomCondition.And(YDPB_EVAL_ROOM._.EVAL_ROOM_NAME == EVAL_ROOM_NAME);
                        var room = ServicesFactory.GGZYJD.YdpbEvalRoomService.FirstOrNull(roomCondition);

                        if (null == room)
                        {
                            result.SetFail("评标室信息不存在");
                            return result;
                        }
                       
                        if (!SEAT_NUMBER.Any())
                        {
                            result.SetFail("评标席位不能为空");
                            return result;
                        }
                        if (SEAT_NUMBER.Distinct().ToList().Count != detail.EXPERT_COUNT)
                        {
                            result.SetFail("评标席位数量与申请信息不一致");
                            return result;
                        }


                        detail.Attach();
                        detail.STATUS = STATUS;
                        detail.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                       

                        SEAT_NUMBER.Distinct().ToList().ForEach(seat =>
                        {
                            seatRecord.EVAL_ROOM_ID = room.ID;
                            seatRecord.EVAL_ROOM_NAME = room.EVAL_ROOM_NAME;
                            seatRecord.SEAT_NUMBER = seat;
                            seatRecord.STATE = 1;
                            seatRecord.APPLY_ID = apply.ID;
                            db.Insert<YDPB_EVAL_ROOM_SEAT_RECORD>(tran, seatRecord);
                        });
                        record.Attach();
                        record.STATUS = STATUS;
                        record.REMARK = REMARK;
                        record.AUDIT_TIME = DateTime.Now;
                        record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(AREA_CODE) ? GlobalDataService.Instance.Centers[AREA_CODE] : CENTER_NAME;
                        record.AUDIT_USER_ID = 0;
                        record.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                        apply.Attach();
                        apply.DATA_TIMESTAMP = DateTime.Now;
                        //主会场审核通过
                        if (detail.IS_MAIN == 1)
                        {
                            apply.STATUS = 1;
                            var updateRecordSql = "UPDATE YDPB_EVAL_APPLY_RECORD SET IS_MAIN_AUDIT =1 where APPLY_ID=" + apply.ID + " AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detail.ID + " AND id !=" + record.ID;
                            db.FromSql(updateRecordSql).SetDbTransaction(tran).ExecuteNonQuery();
                        }
                        else
                        {
                            var isFinish = db.FromSql("SELECT COUNT(1) FROM YDPB_EVAL_APPLY_RECORD WHERE APPLY_DETAIL_ID !=" + detail.ID + " AND APPLY_ID=" + apply.ID + "  AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detail.ID + " AND STATUS=0").ToScalar();
                            if (Convert.ToInt32(isFinish) == 0)
                            {
                                apply.STATUS = 2;
                            }
                        }
                        db.Update<YDPB_EVAL_APPLY>(tran, apply);
                        tran.Commit();

                        //通知主会场审批结果
                        ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);
                        result.SetSuccess();
                        return result;
                    }
                    #endregion

                    #region 审核不通过
                    if (STATUS ==2)
                    {
                        detail.Attach();
                        detail.STATUS = STATUS;
                        detail.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                        record.Attach();
                        record.STATUS = STATUS;
                        record.REMARK = REMARK;
                        record.AUDIT_TIME = DateTime.Now;
                        record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(AREA_CODE) ?
                            GlobalDataService.Instance.Centers[AREA_CODE] : CENTER_NAME;
                        record.AUDIT_USER_ID = null == Identity?0:Identity?.FwUser()?.ID;
                        record.DATA_TIMESTAMP = DateTime.Now;
                        record.CREATOR = null == Identity?"": Identity.LoginName;
                        db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                        apply.Attach();
                        apply.DATA_TIMESTAMP = DateTime.Now;
                        apply.STATUS = 3;//审核不通过
                        db.Update<YDPB_EVAL_APPLY>(tran, apply);

                        string sql = "UPDATE YDPB_EVAL_ROOM_SEAT_RECORD SET  STATE =0,DATA_TIMESTAMP=SYSDATE WHERE APPLY_ID=" + apply.ID;
                        db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();

                        tran.Commit();
                        result.SetSuccess();

                        //通知主会场审批结果
                        ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);

                        Audit_Notify(apply, detail.ID);

                        return result;
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    result.SetFail(ex.Message, ex);
                    return result;
                }
                finally
                {
                    tran.Close();                    
                }
            }

            #region 变更申请审批
            if(apply.APPLY_TYPE ==1)
            {
                var db = GetDbSession();
                var tran = db.BeginTransaction();
                try
                {

                    #region 审核通过
                    if (STATUS == 1)
                    {
                        var roomCondition = new WhereClipBuilder();
                        roomCondition.And(YDPB_EVAL_ROOM._.AREA_CODE == AREA_CODE);
                        roomCondition.And(YDPB_EVAL_ROOM._.EVAL_ROOM_NAME == EVAL_ROOM_NAME);
                        var room = ServicesFactory.GGZYJD.YdpbEvalRoomService.FirstOrNull(roomCondition);

                        if (null == room)
                        {
                            result.SetFail("评标室信息不存在");
                            return result;
                        }

                        if (!SEAT_NUMBER.Any())
                        {
                            result.SetFail("评标席位不能为空");
                            return result;
                        }
                        if (SEAT_NUMBER.Distinct().ToList().Count != detail.EXPERT_COUNT)
                        {
                            result.SetFail("评标席位数量与申请信息不一致");
                            return result;
                        }

                        detail.Attach();
                        detail.STATUS = STATUS;
                        detail.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                        SEAT_NUMBER.Distinct().ToList().ForEach(seat =>
                        {
                            seatRecord.EVAL_ROOM_ID = room.ID;
                            seatRecord.EVAL_ROOM_NAME = room.EVAL_ROOM_NAME;
                            seatRecord.SEAT_NUMBER = seat;
                            seatRecord.STATE = 1;
                            seatRecord.APPLY_ID = apply.ID;
                            db.Insert<YDPB_EVAL_ROOM_SEAT_RECORD>(tran, seatRecord);
                        });
                        record.Attach();
                        record.STATUS = STATUS;
                        record.REMARK = REMARK;
                        record.AUDIT_TIME = DateTime.Now;
                        record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(AREA_CODE) ?
                            GlobalDataService.Instance.Centers[AREA_CODE] : CENTER_NAME;
                        record.AUDIT_USER_ID = 0;
                        record.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                        apply.Attach();
                        apply.DATA_TIMESTAMP = DateTime.Now;
                        //主会场审核通过
                        if (detail.IS_MAIN == 1)
                        {
                            apply.STATUS = 1;
                            var updateRecordSql = "UPDATE YDPB_EVAL_APPLY_RECORD SET IS_MAIN_AUDIT =1 where APPLY_ID=" + apply.ID + " AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detail.ID + " AND id !=" + record.ID;
                            db.FromSql(updateRecordSql).SetDbTransaction(tran).ExecuteNonQuery();
                        }
                        else
                        {
                            var isFinish = db.FromSql("SELECT COUNT(1) FROM YDPB_EVAL_APPLY_RECORD WHERE APPLY_ID=" + apply.ID + "  AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detail.ID + " AND STATUS=0").ToScalar();
                            if (Convert.ToInt32(isFinish) == 0)
                            {
                                apply.STATUS = 2;//审核通过

                                var FResult = ViewByPk(apply.FID);
                                if (FResult.Success && FResult.Data is YDPB_EVAL_APPLY)
                                {
                                    var sourceEntity = (YDPB_EVAL_APPLY)FResult.Data;
                                    sourceEntity.Attach();
                                    sourceEntity.FLAG = 1;
                                    db.Update<YDPB_EVAL_APPLY>(tran, sourceEntity);
                                }

                                string sql = "UPDATE YDPB_EVAL_ROOM_SEAT_RECORD SET  STATE =0,DATA_TIMESTAMP=SYSDATE WHERE APPLY_ID=" + apply.FID;
                                db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();
                            }
                        }
                        db.Update<YDPB_EVAL_APPLY>(tran, apply);
                        tran.Commit();
                        //通知主会场审批结果
                        ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);
                        result.SetSuccess();
                        return result;
                    }
                    #endregion

                    #region 审核不通过
                    if (true)
                    {
                        detail.Attach();
                        detail.STATUS = STATUS;
                        detail.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                        record.Attach();
                        record.STATUS = STATUS;
                        record.REMARK = REMARK;
                        record.AUDIT_TIME = DateTime.Now;
                        record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(AREA_CODE) ?
                           GlobalDataService.Instance.Centers[AREA_CODE] : CENTER_NAME;
                        record.AUDIT_USER_ID = 0;
                        record.DATA_TIMESTAMP = DateTime.Now;
                        db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                        apply.Attach();
                        apply.DATA_TIMESTAMP = DateTime.Now;
                        apply.STATUS = 3;
                        db.Update<YDPB_EVAL_APPLY>(tran, apply);


                        tran.Commit();
                        result.SetSuccess();

                        //通知主会场审批结果
                        ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);

                        Audit_Notify(apply, detail.ID);
                        
                        return result;
                    }
                    #endregion

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    result.SetFail(ex.Message, ex);
                    return result;
                }
                finally
                {
                    tran.Close();
                }
            }
            #endregion 变更申请审批

            #region 取消申请审批
            if (apply.APPLY_TYPE ==2)
            {
                var db = GetDbSession();
                var tran = db.BeginTransaction();

                try
                {
                    detail.Attach();
                    detail.STATUS = STATUS;
                    detail.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    record.Attach();
                    record.STATUS = STATUS;
                    record.REMARK = REMARK;
                    record.AUDIT_TIME = DateTime.Now;
                    record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(AREA_CODE) ?
                            GlobalDataService.Instance.Centers[AREA_CODE] : CENTER_NAME;
                    record.AUDIT_USER_ID = 0;
                    //record.CREATOR = Identity.LoginName;
                    record.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                    if (STATUS == (int)Audit_Status.审核通过)
                    {
                        apply.Attach();
                        apply.DATA_TIMESTAMP = DateTime.Now;
                        if (detail.IS_MAIN == 1)
                        {
                            apply.STATUS = 1;//审核通过
                        }

                        string sql = "UPDATE YDPB_EVAL_ROOM_SEAT_RECORD SET  STATE =0,DATA_TIMESTAMP=SYSDATE WHERE EVAL_APPLY_DETAIL_ID=" + detail.FID;
                        db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();

                        var isFinish = db.FromSql("SELECT COUNT(1) FROM YDPB_EVAL_APPLY_RECORD WHERE APPLY_ID=" + apply.ID + "  AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detail.ID + " AND STATUS=0").ToScalar<int>();
                        if (isFinish == 0)
                        {
                            apply.STATUS = 2;//审核通过

                            var FResult = ViewByPk(apply.FID);
                            if (FResult.Success && FResult.Data is YDPB_EVAL_APPLY)
                            {
                                var sourceEntity = (YDPB_EVAL_APPLY)FResult.Data;
                                sourceEntity.Attach();
                                sourceEntity.FLAG = 2;
                                db.Update<YDPB_EVAL_APPLY>(tran, sourceEntity);
                            }
                            apply.STATUS = 2;//审核通过

                        }
                        db.Update<YDPB_EVAL_APPLY>(tran, apply);
                    }
                    tran.Commit();
                    //通知主会场审批结果
                    ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);
                    result.SetSuccess();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    result.SetException(ex.Message, ex);
                }
                finally
                {
                    tran.Close();
                }

            }
            #endregion 取消申请审批
            return result;
        }
        /// <summary>
        /// 评标状态变更 1:开始评标 2：结束评标 3：归档 4、中止评标
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult I_Eval(string tender_project_code,string areacode, int flag)
        {
            GeneralResult result = new GeneralResult();

            WhereClipBuilder condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_APPLY._.TENDER_PROJECT_CODE == tender_project_code);
            condition.And(YDPB_EVAL_APPLY._.IS_DELETE == 0);
            condition.And(YDPB_EVAL_APPLY._.STATUS ==2);
 

            var apply = FindList(condition).OrderByDescending(od=>od.ID).FirstOrDefault();
            if(null == apply)
            {
                result.SetFail("招标项目信息不存在或申请单未审核通过");
                return result;
            }

            WhereClipBuilder condTrade = new WhereClipBuilder();
            condTrade.And(V_YDPB_APPLY_TRADE._.IS_MAIN ==1);
            condTrade.And(V_YDPB_APPLY_TRADE._.ID == apply.ID);

            var detail = ServicesFactory.GGZYJD.VYdpbApplyTradeService.FindList(condTrade).FirstOrDefault();
            if (null == detail)
            {
                result.SetFail("招标项目信息不存在或申请单未审核通过");
                return result;
            }
            if(detail.AREA_CODE !=areacode)
            {
                result.SetFail("非本中心主场项目，处理失败");
                return result;
            }
            if(detail.APPLY_STATUS !=2)
            {
                result.SetFail("会场申请信息未通过，处理失败");
                return result;
            }
            if(apply.FLAG !=0)
            {
                result.SetFail("会场申请信息已变更或取消，处理失败");
                return result;
            }
            switch(flag)
            {
                case 1://启动评标
                    if(detail.EVAL_STATUS !=0 && detail.EVAL_STATUS !=4)
                    {
                        result.SetFail("项目评标中/评标结束");
                        return result;
                    }
                    break;
                case 2://结束评标
                    if(detail.EVAL_STATUS !=1)
                    {
                        result.SetFail("项目未启动评标/评标结束");
                        return result;
                    }
                    break;
                case 4://中止评标
                    if (detail.EVAL_STATUS != 1)
                    {
                        result.SetFail("项目未启动评标/评标结束");
                        return result;
                    }
                    break;

            }

            apply.Attach();
            apply.EVAL_STATUS = flag;
            Update(apply);
            result.SetSuccess();
            return result;
        }


        /// <summary>
        /// 场地变更
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Change(int id, YDPB_EVAL_APPLY model, List<YDPB_EVAL_APPLY_DETAIL> details)
        {
            var result = new GeneralResult();
            var main_count = details.Where(w => w.IS_MAIN == 1).Count();
            if (main_count == 0)
            {
                result.SetFail("主会场申请信息不能为空");
                return result;
            }
            if (main_count > 1)
            {
                result.SetFail("只能有一条主会场申请信息");
                return result;
            }

            var oldResult = ViewByPk(id);
            if (!(oldResult.Success && oldResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("原申请单不存在或已被删除");
                return result;
            }
            YDPB_EVAL_APPLY applyOld = (YDPB_EVAL_APPLY)oldResult.Data;

            if (applyOld.FLAG == 0)
            {
                var conditionCheck = (YDPB_EVAL_APPLY._.FID == applyOld.ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);
                var dbModelCheck = FirstOrNull(conditionCheck);
                if (null != dbModelCheck)
                {
                    result.SetFail("原申请单已申请取消/变更");
                    return result;
                }
            }

            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                var seqSql = "SELECT SEQ_YDPB_EVAL_APPLY.NEXTVAL FROM DUAL";
                model.ID = db.FromSql(seqSql).SetDbTransaction(tran).ToScalar<int>();
                model.FID = id;
                model.APPLY_TYPE = (int)Apply_Type.场地变更;
                model.STATUS = 0;
                model.EXPERT_COUNT = details.Sum(s => s.EXPERT_COUNT);
                model.SERIES_NUMBER = General_SERIES_NUMBER(model);
                model.CREATOR = Identity.LoginName;
                model.CREATOR_ID = FwUser.ID;
                model.F_SERIES_NUMBER = applyOld.SERIES_NUMBER;
                db.Insert<YDPB_EVAL_APPLY>(tran, model);

                if (true)
                {
                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = 0;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = "";
                    record.APPLY_STEP = "提交申请";
                    record.CENTER_NAME = FwUser.ZP_UNIT;
                    record.AUDIT_TIME = DateTime.Now;
                    record.STATUS = (int)Audit_Status.已办理;
                    record.AUDIT_USER = Identity?.LoginName;
                    record.IS_MAIN_AUDIT = 1;
                    record.CREATOR = Identity.LoginName;
                    record.CREATOR_ID = FwUser.ID;
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                }

                details.OrderByDescending(od => od.IS_MAIN).ToList().ForEach(detail => {
                    detail.APPLY_ID = model.ID;
                    detail.STATUS = 0;
                    detail.CREATOR = Identity?.Name;
                    detail.CREATOR_ID = FwUser.ID;
                    detail.ID = db.Insert<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = detail.ID;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = detail.AREA_CODE;
                    record.APPLY_STEP = detail.IS_MAIN == 1 ? "主会场审批" : "分会场审批";
                    record.CENTER_NAME = detail.CENTER_NAME;
                    record.STATUS = (int)Audit_Status.待审批;
                    record.IS_MAIN_AUDIT = detail.IS_MAIN;
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                });
                tran.Commit();

                Change_Notify(model);

                 var dic = new { model.ID, model.SERIES_NUMBER };

                result.SetSuccess(dic);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }
        /// <summary>
        /// 场地变更时 原申请单会场业务通知
        /// </summary>
        /// <param name="model"></param>
        private void Change_Notify(YDPB_EVAL_APPLY model)
        {
            try
            {
                //通知已被取消的分会场

                var sourceApply = ServicesFactory.GGZYJD.YdpbEvalApplyService.FirstOrNull(YDPB_EVAL_APPLY._.SERIES_NUMBER == model.F_SERIES_NUMBER);
                if (null != sourceApply)
                {
                    //推送审批信息到分会场处理
                    var branchCondtion = new WhereClipBuilder();
                    branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                    branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == model.ID);
                    branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0);
                    //新的分会场
                    var branchDetails = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(branchCondtion.ToWhereClip());
                  
                    //通知其他分会场该申请单已经取消

                    //原来的分会场
                    var subDetails = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService
                        .FindList(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == sourceApply.ID
                        && YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0).ToList();

                    branchDetails.ForEach(e => {
                        if (subDetails.Where(w => w.AREA_CODE == e.AREA_CODE).Any())
                        {
                            ServicesFactory.GGZYJD.YdpbBranchService.Change(model, e);
                            return;
                        }
                        ServicesFactory.GGZYJD.YdpbBranchService.Apply(model, e);
                    });

                    if (subDetails.Where(w=> ! branchDetails.Select(t=>t.AREA_CODE).ToList().Contains(w.AREA_CODE)).Any())
                    {
                        subDetails.Where(w => ! branchDetails.Select(t => t.AREA_CODE).ToList().Contains(w.AREA_CODE)).ToList().ForEach(e =>
                        {
                            sourceApply.REMARK = "主会场发起变更单，系统自动取消";
                            ServicesFactory.GGZYJD.YdpbBranchService.Cancel(sourceApply, e);
                        });
                    }
                }

            }
            catch (Exception ex)
            {

                Logger.Error("通知已被取消的分会场 失败:" + ex.Message, ex);
            }
        }

        public GeneralResult I_Query(string series_number, string tender_project_code, string area_code)
        {
            var result = new GeneralResult();

            if (String.IsNullOrEmpty(series_number))
            {
                result.SetFail("申请单编号不能为空");
                return result;
            }
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_APPLY._.SERIES_NUMBER == series_number && YDPB_EVAL_APPLY._.IS_DELETE == 0);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail("申请单信息不存在或已被删除");
                return result;
            }
            var con = new WhereClipBuilder();
            con.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == dbModel.ID && YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            con.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0);

            var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(con).ToList();
            if (!details.Any())
            {
                result.SetFail("会场申请信息不存在或已被删除");
                return result;
            }
            List<dynamic> subs = new List<dynamic>();
            details.ForEach(e =>
            {
                if(e.STATUS ==0)
                {
                    ServicesFactory.GGZYJD.YdpbBranchService.query(dbModel, e);
                }
                subs.Add(e.GetDetail());
            });

            var data = new
            {
                dbModel.SERIES_NUMBER,
                dbModel.TENDER_PROJECT_CODE,
                TENDER_PROJECT_NAME = dbModel.TENDER_PROJECT,
                BID_EVAL_START_TIME = dbModel.BID_EVAL_START_TIME,
                BID_EVAL_END_TIME = dbModel.BID_EVAL_END_TIME,
                SUB_DETAIL = subs,
            };
            result.SetSuccess(data);
            return result;
        }

        /// <summary>
        /// 变更
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult I_Change(YDPB_EVAL_APPLY model, List<YDPB_EVAL_APPLY_DETAIL> details, YDPB_EVAL_ROOM_SEAT_RECORD seatRecord, List<string> seats)
        {
            var result = new GeneralResult();

            if (String.IsNullOrEmpty(model.F_SERIES_NUMBER))
            {
                result.SetFail("原申请单编号不能为空");
                return result;
            }
            if (null == model.REMARK)
            {
                result.SetFail("取消原因不能为空");
                return result;
            }
            if (model.F_SERIES_NUMBER.Length != 22)
            {
                result.SetFail("原申请单编号格式错误");
                return result;
            }
            var id = Convert.ToInt32(model.F_SERIES_NUMBER.Substring(model.F_SERIES_NUMBER.Length - 6, 6));
            var remark = model.REMARK;
            var viewResult = ViewByPk(id);
            if (!(viewResult.Success && viewResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("原申请单信息不存在或已删除");
                return result;
            }
            YDPB_EVAL_APPLY entity = (YDPB_EVAL_APPLY)viewResult.Data;
            if (entity.STATUS != 2)
            {
                result.SetFail("原申请单信息未审核通过");
                return result;
            }
            if (entity.FLAG != 0)
            {
                result.SetFail("原申请单已变更/取消");
                return result;
            }
            if (entity.FLAG == 0)
            {
                var conditionCheck = (YDPB_EVAL_APPLY._.FID == entity.ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);
                var dbModelCheck = FirstOrNull(conditionCheck);
                if (null != dbModelCheck)
                {
                    result.SetFail("原申请单已申请取消/变更");
                    return result;
                }
            }
            var mainDetail = details.Where(w => w.IS_MAIN == 1).FirstOrDefault();
            var room = ServicesFactory.GGZYJD.YdpbEvalRoomService.ViewByNameModel(mainDetail.AREA_CODE, seatRecord.EVAL_ROOM_NAME);
            if (null == room)
            {
                result.SetFail("主会场评标室信息不存在，请检查评标室名称是否一致");
                return result;
            }
           
            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                var seqSql = "SELECT SEQ_YDPB_EVAL_APPLY.NEXTVAL FROM DUAL";
                model.ID = db.FromSql(seqSql).SetDbTransaction(tran).ToScalar<int>();
                model.F_SERIES_NUMBER = model.F_SERIES_NUMBER;
                model.FID = entity.ID;
                model.APPLY_TYPE = (int)Apply_Type.场地变更;
                model.STATUS = 1;
                model.EXPERT_COUNT = details.Sum(s => s.EXPERT_COUNT);
                model.SERIES_NUMBER = General_SERIES_NUMBER(model);
                model.CREATOR = "";
                db.Insert<YDPB_EVAL_APPLY>(tran, model);

                if (true)
                {
                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = 0;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = "";
                    record.APPLY_STEP = "提交申请";
                    record.CENTER_NAME = "";
                    record.AUDIT_TIME = DateTime.Now;
                    record.STATUS = (int)Audit_Status.已办理;
                    record.AUDIT_USER = "";
                    record.IS_MAIN_AUDIT = 1;
                    record.CREATOR = "";
                    record.CREATOR_ID = 0;
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                }

                details.OrderByDescending(od => od.IS_MAIN).ToList().ForEach(detail => {
                    detail.APPLY_ID = model.ID;
                    detail.FID = detail.IS_MAIN == 1 ? mainDetail.ID:0;
                    detail.STATUS = detail.IS_MAIN == 1 ? (int)Audit_Status.审核通过 : (int)Audit_Status.待审批;
                    detail.CREATOR = "";
                    detail.CREATOR_ID = 0;
                    detail.ID = db.Insert<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = detail.ID;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = detail.AREA_CODE;
                    record.APPLY_STEP = detail.IS_MAIN == 1 ? "主会场审批" : "分会场审批";
                    record.CENTER_NAME = detail.CENTER_NAME;
                    record.STATUS = detail.IS_MAIN == 1 ? (int)Audit_Status.审核通过 : (int)Audit_Status.待审批;
                    record.IS_MAIN_AUDIT = 1;
                    record.REMARK = detail.IS_MAIN == 1 ? "交易系统审核通过" : "";
                    if (detail.IS_MAIN == 1)
                    {
                        record.AUDIT_TIME = DateTime.Now;
                    }
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);

                    if (detail.IS_MAIN == 1)
                    {
                        seatRecord.EVAL_ROOM_ID = room.ID;
                        seatRecord.EVAL_ROOM_NAME = room.EVAL_ROOM_NAME;
                        seatRecord.AREA_CODE = detail.AREA_CODE;
                        seatRecord.CREATOR_ID = 0;
                        seatRecord.EVAL_APPLY_DETAIL_ID = detail.ID;
                        seatRecord.APPLY_ID = model.ID;

                        seats.Distinct().ToList().ForEach(seat =>
                        {
                            seatRecord.SEAT_NUMBER = seat;
                            seatRecord.STATE = 1;
                            db.Insert<YDPB_EVAL_ROOM_SEAT_RECORD>(tran, seatRecord);
                        });
                    }
                });
                tran.Commit();

                Change_Notify(model);

                var dic = new { model.SERIES_NUMBER };

                result.SetSuccess(dic);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult I_Add(YDPB_EVAL_APPLY model, List<YDPB_EVAL_APPLY_DETAIL> details, YDPB_EVAL_ROOM_SEAT_RECORD seatRecord,List<string> seats)
        {
            var result = new GeneralResult();
            var mainDetail = details.Where(w => w.IS_MAIN == 1).FirstOrDefault(); 
            var room = ServicesFactory.GGZYJD.YdpbEvalRoomService.ViewByNameModel(mainDetail.AREA_CODE, seatRecord.EVAL_ROOM_NAME);
            if (null == room)
            {
                result.SetFail("主会场评标室信息不存在，请检查评标室名称是否一致");
                return result;
            }

            //var applyCondition = new WhereClipBuilder();
            //applyCondition.And(YDPB_EVAL_APPLY._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE);
            //applyCondition.And(YDPB_EVAL_APPLY._.IS_DELETE == 0);
            //applyCondition.And(YDPB_EVAL_APPLY._.FLAG.In(new[] { 0,2}));
            //var count = ServicesFactory.GGZYJD.YdpbEvalApplyService.Count(applyCondition);
            //if(count % 2 !=0)
            //{
            //    result.SetFail("重复申请:该招标项目已提交申请");
            //    return result;
            //}

            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                var seqSql = "SELECT SEQ_YDPB_EVAL_APPLY.NEXTVAL FROM DUAL";
                model.ID = db.FromSql(seqSql).SetDbTransaction(tran).ToScalar<int>();

                model.APPLY_TYPE = (int)Apply_Type.场地申请;
                model.STATUS =1;
                model.EXPERT_COUNT = details.Sum(s => s.EXPERT_COUNT);
                model.SERIES_NUMBER = General_SERIES_NUMBER(model);
                model.CREATOR = "";
                db.Insert<YDPB_EVAL_APPLY>(tran, model);

                if (true)
                {
                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = 0;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = "";
                    record.APPLY_STEP = "提交申请";
                    record.CENTER_NAME = "";
                    record.AUDIT_TIME = DateTime.Now;
                    record.STATUS = (int)Audit_Status.已办理;
                    record.AUDIT_USER = "";
                    record.IS_MAIN_AUDIT = 1;
                    record.CREATOR = "";
                    record.CREATOR_ID = 0;
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                }

                details.OrderByDescending(od => od.IS_MAIN).ToList().ForEach(detail => {
                    detail.APPLY_ID = model.ID;
                    detail.STATUS = detail.IS_MAIN == 1 ? (int)Audit_Status.审核通过 : (int)Audit_Status.待审批;
                    detail.CREATOR = "";
                    detail.CREATOR_ID = 0;
                    detail.ID = db.Insert<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = detail.ID;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = detail.AREA_CODE;
                    record.APPLY_STEP = detail.IS_MAIN == 1 ? "主会场审批" : "分会场审批";
                    record.CENTER_NAME = detail.CENTER_NAME;
                    record.STATUS = detail.IS_MAIN == 1 ? (int)Audit_Status.审核通过: (int)Audit_Status.待审批;
                    record.IS_MAIN_AUDIT = 1;
                    record.REMARK = detail.IS_MAIN == 1 ? "交易系统审核通过" : "";
                    if (detail.IS_MAIN == 1)
                    {
                        record.AUDIT_TIME = DateTime.Now;
                    }
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);


                    seatRecord.APPLY_ID = model.ID;
                    seatRecord.AREA_CODE = detail.AREA_CODE;
                    seatRecord.EVAL_APPLY_DETAIL_ID = detail.ID;
                    seatRecord.EVAL_ROOM_ID = room.ID;
                    if(detail.IS_MAIN ==1)
                    {
                        seatRecord.EVAL_ROOM_ID = room.ID;
                        seatRecord.EVAL_ROOM_NAME = room.EVAL_ROOM_NAME;
                        seatRecord.AREA_CODE = detail.AREA_CODE;
                        seatRecord.CREATOR_ID = 0;
                        seatRecord.EVAL_APPLY_DETAIL_ID = detail.ID;

                        seats.Distinct().ToList().ForEach(seat =>
                        {
                            seatRecord.SEAT_NUMBER = seat;
                            seatRecord.STATE = 1;
                            db.Insert<YDPB_EVAL_ROOM_SEAT_RECORD>(tran, seatRecord);
                        });
                    }
                });
                tran.Commit();

                //推送审批信息到分会场处理
                var branchCondtion = new WhereClipBuilder();
                branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == model.ID);
                branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0);
                var branchDetails = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(branchCondtion.ToWhereClip());
                branchDetails.ForEach(e => {
                    ServicesFactory.GGZYJD.YdpbBranchService.Apply(model, e);
                });

                var dic = new {model.SERIES_NUMBER };
                result.SetSuccess(dic);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult Add(YDPB_EVAL_APPLY model, List<YDPB_EVAL_APPLY_DETAIL> details)
        {
            var result = new GeneralResult();
            var main_count = details.Where(w => w.IS_MAIN == 1).Count();
            if (main_count == 0)
            {
                result.SetFail("主会场申请信息不能为空");
                return result;
            }
            if (main_count > 1)
            {
                result.SetFail("只能有一条主会场申请信息");
                return result;
            }
            var applyCondition = new WhereClipBuilder();
            applyCondition.And(YDPB_EVAL_APPLY._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE);
            applyCondition.And(YDPB_EVAL_APPLY._.IS_DELETE == 0);
            applyCondition.And(YDPB_EVAL_APPLY._.FLAG.In(new[] { 0, 2 }));
            var count = ServicesFactory.GGZYJD.YdpbEvalApplyService.Count(applyCondition);
            if (count != 2 && count != 0)
            {
                result.SetFail("重复申请:该招标项目已提交申请");
                return result;
            }

            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                var seqSql = "SELECT SEQ_YDPB_EVAL_APPLY.NEXTVAL FROM DUAL";
                model.ID = db.FromSql(seqSql).SetDbTransaction(tran).ToScalar<int>();

                model.APPLY_TYPE = (int) Apply_Type.场地申请;
                model.STATUS = 0;
                model.EXPERT_COUNT = details.Sum(s => s.EXPERT_COUNT);
                model.SERIES_NUMBER = General_SERIES_NUMBER(model);
                model.CREATOR = FwUser.ZP_UNIT;
                model.CREATOR_ID = FwUser.ID;
                model.TENDER_AGENCY_NAME = FwUser.ZP_UNIT;
                model.TENDER_AGENCY_CODE = FwUser.LICENSE_NO;
                db.Insert<YDPB_EVAL_APPLY>(tran, model);

                if (true)
                {
                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = 0;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = "";
                    record.APPLY_STEP = "提交申请";
                    record.CENTER_NAME = FwUser.ZP_UNIT;
                    record.AUDIT_TIME = DateTime.Now;
                    record.STATUS = (int)Audit_Status.已办理;
                    record.AUDIT_USER = Identity?.LoginName;
                    record.IS_MAIN_AUDIT = 1;
                    record.CREATOR = Identity.LoginName;
                    record.CREATOR_ID = FwUser.ID;
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                }

                details.OrderByDescending(od => od.IS_MAIN).ToList().ForEach(detail => {
                    detail.APPLY_ID = model.ID;
                    detail.STATUS = 0;
                    detail.CREATOR = Identity?.Name;
                    detail.CREATOR_ID = FwUser.ID;
                    detail.ID = db.Insert<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                    record.APPLY_DETAIL_ID = detail.ID;
                    record.APPLY_ID = model.ID;
                    record.AREA_CODE = detail.AREA_CODE;
                    record.APPLY_STEP = detail.IS_MAIN == 1 ? "主会场审批" : "分会场审批";
                    record.CENTER_NAME = detail.CENTER_NAME;
                    record.STATUS = (int)Audit_Status.待审批;
                    record.IS_MAIN_AUDIT = detail.IS_MAIN;
                    db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                });
                tran.Commit();

                var dic = new { model.ID, model.SERIES_NUMBER };

                details.Where(w => w.IS_MAIN == 0).ToList().ForEach(e=> {
                    ServicesFactory.GGZYJD.YdpbBranchService.Apply(model, e);
                });
                result.SetSuccess(dic);
            }
            catch (Exception e)
            {
                tran.Rollback();
                result.SetFail(e.Message, e);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }

        /// <summary>
        /// 招标代理公司查看详情页面
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public GeneralResult ViewByTrade(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_APPLY._.ID == ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail("申请单信息不存在或已被删除");
                return result;
            }

            var con = new WhereClipBuilder();
            con.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == ID && YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            con.And(YDPB_EVAL_APPLY_DETAIL._.AREA_CODE == FwUser.AREACODE);

            var detail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(con).FirstOrDefault();
            if (null == detail)
            {
                result.SetFail("会场申请信息不存在或已被删除");
                return result;
            }


            dbModel.STATUS = detail.STATUS;

            var dic = dbModel.ToDictionary();
            dic.Remove("TENDER_PROJECT");
            dic.Remove("TENDER_PROJECT_CODE");
            dic.Remove("TENDER_PROJECT_ID");
            dic.Add("DETAIL", detail);

            var conSeat = new WhereClipBuilder();
            conSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID && YDPB_EVAL_ROOM_SEAT_RECORD._.STATE == 1 && YDPB_EVAL_ROOM_SEAT_RECORD._.IS_DELETE == 0);
            conSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.AREA_CODE == FwUser.AREACODE);

            var seats = ServicesFactory.GGZYJD.YdpbEvalRoomSeatRecordService.FindList(conSeat);
            var gSeat = seats.GroupBy(g => new { g.EVAL_ROOM_NAME, g.EVAL_ROOM_ID }).FirstOrDefault();
            if (seats.Count > 0)
            {
                dic.Add("EVAL_ROOM_NAME", gSeat.Key);
                dic.Add("SEAT", gSeat.Select(t => t.SEAT_NUMBER));
            }
            else
            {
                dic.Add("EVAL_ROOM_NAME", "");
                dic.Add("SEAT", new List<string>());
            }

            var conRecord = new WhereClipBuilder();
            conRecord.And(YDPB_EVAL_APPLY_RECORD._.AREA_CODE == FwUser.AREACODE);
            conRecord.And(YDPB_EVAL_APPLY_RECORD._.APPLY_ID == ID && YDPB_EVAL_APPLY_RECORD._.IS_DELETE == 0 && YDPB_EVAL_APPLY_RECORD._.IS_MAIN_AUDIT == 1);
            var records = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FindList(conRecord);
            dic.Add("RECORD", records.Select(t => new {
                t.ID,
                t.APPLY_STEP,
                t.CENTER_NAME,
                t.AUDIT_TIME,
                t.STATUS,
                t.REMARK
            }).FirstOrDefault());

            result.SetSuccess(dic);
            return result;
        }

        /// <summary>
        /// 申请单审批
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult Audit(dynamic dic)
        {
            var result = new GeneralResult();
            var status = Convert.ToInt32(dic["STATUS"]);
            var remark = dic["REMARK"];
            var detailid = Convert.ToInt32(dic["APPLY_DETAIL_ID"]);
            var roomid = Convert.ToInt32(dic["EVAL_ROOM_ID"]);
            List<string> seats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(dic["SEAT"].ToString());

            if (status != 1 && status != 2)
            {
                result.SetFail("审批状态status值异常");
                return result;
            }

            YDPB_EVAL_APPLY_DETAIL detail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.ViewByPkModel(detailid);
            if (null == detail || detail.IS_DELETE ==1 || detail.AREA_CODE != FwUser.AREACODE)
            {
                result.SetFail("会场申请信息不存在或已被删除");
                return result;
            }

            var applyResult = ViewByPk(detail.APPLY_ID);

            if (!applyResult.Success || !(applyResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("申请单信息不存在或已被删除");
                return result;
            }

            var conRecord = new WhereClipBuilder();
            conRecord.And(YDPB_EVAL_APPLY_RECORD._.IS_DELETE ==0 && YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == detailid && YDPB_EVAL_APPLY_RECORD._.AREA_CODE == FwUser.AREACODE);
            var record = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FindList(conRecord).FirstOrDefault();
            if (null == record)
            {
                result.SetFail("审批流程记录异常");
                return result;
            }
            if (record.STATUS != 0)
            {
                result.SetFail("重复审批");
                return result;
            }

            YDPB_EVAL_APPLY apply = (YDPB_EVAL_APPLY)applyResult.Data;

            YDPB_EVAL_ROOM_SEAT_RECORD seatRecord = new YDPB_EVAL_ROOM_SEAT_RECORD();
            seatRecord.AREA_CODE = FwUser.AREACODE;
            seatRecord.CREATOR_ID = FwUser.ID;
            seatRecord.START_TIME = apply.BID_EVAL_START_TIME;
            seatRecord.END_TIME = apply.BID_EVAL_END_TIME;
            seatRecord.EVAL_APPLY_DETAIL_ID = detail.ID;
            seatRecord.APPLY_ID = apply.ID;
            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {
                #region 审核通过
                if (status == 1)
                {
                    YDPB_EVAL_ROOM room = ServicesFactory.GGZYJD.YdpbEvalRoomService.ViewByPkModel(roomid);
                    if (null == room)
                    {
                        result.SetFail("评标室信息不存在");
                        return result;
                    }
                    if (room.AREA_CODE != FwUser.AREACODE)
                    {
                        result.SetFail("非本中心评标室,分配失败");
                        return result;
                    }
                    if (!seats.Any())
                    {
                        result.SetFail("评标席位不能为空");
                        return result;
                    }
                    if (seats.Distinct().ToList().Count != detail.EXPERT_COUNT)
                    {
                        result.SetFail("评标席位数量与申请信息不一致");
                        return result;
                    }


                    detail.Attach();
                    detail.STATUS = status;
                    detail.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    seats.Distinct().ToList().ForEach(seat =>
                    {
                        seatRecord.EVAL_ROOM_ID = roomid;
                        seatRecord.EVAL_ROOM_NAME = room.EVAL_ROOM_NAME;
                        seatRecord.SEAT_NUMBER = seat;
                        seatRecord.STATE = 1;
                        seatRecord.APPLY_ID = apply.ID;
                        db.Insert<YDPB_EVAL_ROOM_SEAT_RECORD>(tran, seatRecord);
                    });
                    record.Attach();
                    record.STATUS = status;
                    record.REMARK = remark;
                    record.AUDIT_TIME = DateTime.Now;
                    record.AUDIT_USER =GlobalDataService.Instance.Centers.ContainsKey(FwUser.AREACODE)?GlobalDataService.Instance.Centers[FwUser.AREACODE]: FwUser.ZP_UNIT;
                    record.AUDIT_USER_ID = FwUser.ID;
                    record.CREATOR = Identity.LoginName;
                    record.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                    apply.Attach();
                    apply.DATA_TIMESTAMP = DateTime.Now;
                    //主会场审核通过
                    if (detail.IS_MAIN == 1)
                    {
                        apply.STATUS = 1;
                        var updateRecordSql = "UPDATE YDPB_EVAL_APPLY_RECORD SET IS_MAIN_AUDIT =1 where APPLY_ID=" + apply.ID + " AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detailid + " AND id !=" + record.ID;
                        db.FromSql(updateRecordSql).SetDbTransaction(tran).ExecuteNonQuery();

                        //推送申请信息给分会场
                        var subConditions = new WhereClipBuilder();
                        subConditions.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                        subConditions.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);
                        subConditions.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0);
                        var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(subConditions.ToWhereClip());
                        details.ForEach(subDetail => {
                            ServicesFactory.GGZYJD.YdpbBranchService.Apply(apply, subDetail);
                        });
                        
                    }
                    else
                    {
                        var isFinish = db.FromSql("SELECT COUNT(1) FROM YDPB_EVAL_APPLY_RECORD WHERE APPLY_DETAIL_ID !=" + detailid + " AND APPLY_ID=" + apply.ID + "  AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detailid + " AND STATUS=0").ToScalar();
                        if (Convert.ToInt32(isFinish) == 0)
                        {
                            apply.STATUS = 2;
                        }
                    }
                    db.Update<YDPB_EVAL_APPLY>(tran, apply);
                    tran.Commit();
                    result.SetSuccess();

                    //推送审核信息反馈给主会场
                    ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);

                    return result;
                }
                #endregion

                #region 审核不通过
                if (true)
                {
                    detail.Attach();
                    detail.STATUS = status;
                    detail.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    record.Attach();
                    record.STATUS = status;
                    record.REMARK = remark;
                    record.AUDIT_TIME = DateTime.Now;
                    record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(FwUser.AREACODE) ? 
                        GlobalDataService.Instance.Centers[FwUser.AREACODE] : FwUser.ZP_UNIT;
                    record.AUDIT_USER_ID = FwUser.ID;
                    record.DATA_TIMESTAMP = DateTime.Now;
                    record.CREATOR = Identity.LoginName;
                    db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                    apply.Attach();
                    apply.DATA_TIMESTAMP = DateTime.Now;
                    apply.STATUS = 3;
                    db.Update<YDPB_EVAL_APPLY>(tran, apply);

                    string sql = "UPDATE YDPB_EVAL_ROOM_SEAT_RECORD SET  STATE =0,DATA_TIMESTAMP=SYSDATE WHERE APPLY_ID=" + apply.ID;
                    db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();

                    tran.Commit();
                    result.SetSuccess();

                    //推送审核信息反馈给主会场
                    ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);

                    Audit_Notify(apply, detail.ID);


                    return result;
                }
                #endregion
            }
            catch (Exception ex)
            {
                result.SetFail(ex.Message,ex);
                tran.Rollback();
                return result;
            }
            finally
            {
                tran.Close();
            }
        }

        /// <summary>
        /// 分会场审核不通过时 业务通知处理
        /// </summary>
        /// <param name="apply"></param>
        /// <param name="apply_detail_id"></param>
        private void Audit_Notify(YDPB_EVAL_APPLY apply,decimal? apply_detail_id)
        {
            var db = GetDbSession();

            using (var tran = db.BeginTransaction())
            {
                try
                {
                    //通知其他分会场该申请单已经取消
                    var subDetails = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService
                        .FindList(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID
                        && YDPB_EVAL_APPLY_DETAIL._.ID != apply_detail_id
                        && YDPB_EVAL_APPLY_DETAIL._.STATUS != 2
                        && YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0).ToList();
                    if (subDetails.Any())
                    {
                        subDetails.ForEach(e =>
                        {
                            apply.REMARK = "其他分会场审批未通过，系统自动取消";
                            apply.F_SERIES_NUMBER = apply.SERIES_NUMBER;
                            apply.SERIES_NUMBER = "QX_" + apply.SERIES_NUMBER;
                            ServicesFactory.GGZYJD.YdpbBranchService.Cancel(apply, e);

                            if (e.STATUS == 0)
                            {
                                //分会场未审核的话，系统自动更新为 审核不通过
                                e.Attach();
                                e.STATUS = 2;
                                e.DATA_TIMESTAMP = DateTime.Now;
                                tran.Update<YDPB_EVAL_APPLY_DETAIL>(e);

                                var subRecord = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService
                                .FirstOrNull(YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == e.ID);

                                if (null != subRecord)
                                {
                                    subRecord.Attach();
                                    subRecord.REMARK = "其他分会场审批未通过，系统自动取消";
                                    subRecord.DATA_TIMESTAMP = DateTime.Now;
                                    tran.Update<YDPB_EVAL_APPLY_RECORD>(subRecord);
                                }
                            }
                        });
                    }
                    tran.Commit();
                }

                catch (Exception ex)
                {
                    tran.Rollback();
                    Logger.Error("分会场未审批通过,通知其他分会场 失败:" + ex.Message, ex);
                }
            }
        }

        /// <summary>
        /// 申请单审批
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult AuditChange(dynamic dic)
        {
            var result = new GeneralResult();
            var status = Convert.ToInt32(dic["STATUS"]);
            var remark = dic["REMARK"];
            var detailid = Convert.ToInt32(dic["APPLY_DETAIL_ID"]);
            var roomid = Convert.ToInt32(dic["EVAL_ROOM_ID"]);

            var db = GetDbSession();
            var tran = db.BeginTransaction();
            try
            {

                List<string> seats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(dic["SEAT"].ToString());

                if (status != 1 && status != 2)
                {
                    result.SetFail("审批状态status值异常");
                    return result;
                }

                YDPB_EVAL_APPLY_DETAIL detail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.ViewByPkModel(detailid);
                if (null == detail || detail.IS_DELETE ==1 || detail.AREA_CODE != FwUser.AREACODE)
                {
                    result.SetFail("会场申请信息不存在");
                    return result;
                }

                var applyResult = ViewByPk(detail.APPLY_ID);

                if (!applyResult.Success || !(applyResult.Data is YDPB_EVAL_APPLY))
                {
                    result.SetFail("申请单信息不存在");
                    return result;
                }

                var conRecord = new WhereClipBuilder();
                conRecord.And(YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == detailid && YDPB_EVAL_APPLY_RECORD._.AREA_CODE == FwUser.AREACODE);
                var record = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FindList(conRecord).FirstOrDefault();
                if (null == record)
                {
                    result.SetFail("审批流程记录异常");
                    return result;
                }
                if (record.STATUS != 0)
                {
                    result.SetFail("重复审批");
                    return result;
                }

                YDPB_EVAL_APPLY apply = (YDPB_EVAL_APPLY)applyResult.Data;

                YDPB_EVAL_ROOM_SEAT_RECORD seatRecord = new YDPB_EVAL_ROOM_SEAT_RECORD();
                seatRecord.AREA_CODE = FwUser.AREACODE;
                seatRecord.CREATOR_ID = FwUser.ID;
                seatRecord.START_TIME = apply.BID_EVAL_START_TIME;
                seatRecord.END_TIME = apply.BID_EVAL_END_TIME;
                seatRecord.EVAL_APPLY_DETAIL_ID = detail.ID;
                seatRecord.APPLY_ID = apply.ID;

                #region 审核通过
                if (status == 1)
                {
                    YDPB_EVAL_ROOM room = ServicesFactory.GGZYJD.YdpbEvalRoomService.ViewByPkModel(roomid);
                    if (null == room)
                    {
                        result.SetFail("评标室信息不存在");
                        return result;
                    }
                    if (!seats.Any())
                    {
                        result.SetFail("评标席位不能为空");
                        return result;
                    }
                    if (seats.Distinct().ToList().Count != detail.EXPERT_COUNT)
                    {
                        result.SetFail("评标席位数量与申请不一致");
                        return result;
                    }
                    detail.Attach();
                    detail.STATUS = status;
                    detail.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    seats.Distinct().ToList().ForEach(seat =>
                    {
                        seatRecord.EVAL_ROOM_ID = roomid;
                        seatRecord.EVAL_ROOM_NAME = room.EVAL_ROOM_NAME;
                        seatRecord.SEAT_NUMBER = seat;
                        seatRecord.STATE = 1;
                        seatRecord.APPLY_ID = apply.ID;
                        db.Insert<YDPB_EVAL_ROOM_SEAT_RECORD>(tran, seatRecord);
                    });
                    record.Attach();
                    record.STATUS = status;
                    record.REMARK = remark;
                    record.AUDIT_TIME = DateTime.Now;
                    record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(FwUser.AREACODE) ?
                        GlobalDataService.Instance.Centers[FwUser.AREACODE] : FwUser.ZP_UNIT;
                    record.AUDIT_USER_ID = FwUser.ID;
                    record.CREATOR = Identity.LoginName;
                    record.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                    apply.Attach();
                    apply.DATA_TIMESTAMP = DateTime.Now;
                    //主会场审核通过
                    if (detail.IS_MAIN == 1)
                    {
                        apply.STATUS = 1;
                        var updateRecordSql = "UPDATE YDPB_EVAL_APPLY_RECORD SET IS_MAIN_AUDIT =1 where APPLY_ID=" + apply.ID + " AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detailid + " AND id !=" + record.ID;
                        db.FromSql(updateRecordSql).SetDbTransaction(tran).ExecuteNonQuery();

                        //推送审批信息到分会场处理
                        var branchCondtion = new WhereClipBuilder();
                        branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                        branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);
                        branchCondtion.And(YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0);
                        var branchDetails = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(branchCondtion.ToWhereClip());
                        branchDetails.ForEach(e => {
                            ServicesFactory.GGZYJD.YdpbBranchService.Change(apply, e);
                        });
                    }
                    else
                    {
                        var isFinish = db.FromSql("SELECT COUNT(1) FROM YDPB_EVAL_APPLY_RECORD WHERE APPLY_ID=" + apply.ID + "  AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detailid + " AND STATUS=0").ToScalar();
                        if (Convert.ToInt32(isFinish) == 0)
                        {
                            apply.STATUS = 2;//审核通过

                            var FResult = ViewByPk(apply.FID);
                            if(FResult.Success && FResult.Data is YDPB_EVAL_APPLY)
                            {
                                var sourceEntity = (YDPB_EVAL_APPLY)FResult.Data;
                                sourceEntity.Attach();
                                sourceEntity.FLAG = 1;
                                db.Update<YDPB_EVAL_APPLY>(tran,sourceEntity);
                            }

                            string sql = "UPDATE YDPB_EVAL_ROOM_SEAT_RECORD SET  STATE =0,DATA_TIMESTAMP=SYSDATE WHERE APPLY_ID=" + apply.FID;
                            db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();
                        }
                    }
                    db.Update<YDPB_EVAL_APPLY>(tran, apply);
                    tran.Commit();
                    result.SetSuccess();

                    if(detail.IS_MAIN !=1)
                    {
                        //推送审核信息反馈给主会场
                        ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);
                    }
                    return result;
                }
                #endregion

                #region 审核不通过
                if (true)
                {
                    detail.Attach();
                    detail.STATUS = status;
                    detail.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                    record.Attach();
                    record.STATUS = status;
                    record.REMARK = remark;
                    record.AUDIT_TIME = DateTime.Now;
                    record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(FwUser.AREACODE) ?
                       GlobalDataService.Instance.Centers[FwUser.AREACODE] : FwUser.ZP_UNIT;
                    record.AUDIT_USER_ID = FwUser.ID;
                    record.DATA_TIMESTAMP = DateTime.Now;
                    record.CREATOR = Identity.LoginName;
                    db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);

                    apply.Attach();
                    apply.DATA_TIMESTAMP = DateTime.Now;
                    apply.STATUS = 3;
                    db.Update<YDPB_EVAL_APPLY>(tran, apply);


                    tran.Commit();
                    result.SetSuccess();

                    //推送审核信息反馈给主会场
                    ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);

                    try
                    {
                        //通知其他分会场该申请单已经取消
                        var subDetails = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService
                            .FindList(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID
                            && YDPB_EVAL_APPLY_DETAIL._.ID != detail.ID
                            && YDPB_EVAL_APPLY_DETAIL._.IS_MAIN == 0).ToList();
                        if (subDetails.Any())
                        {
                            subDetails.ForEach(e =>
                            {
                                apply.REMARK = "其他分会场未审批通过，系统自动取消";
                                ServicesFactory.GGZYJD.YdpbBranchService.Cancel(apply, e);
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("变更申请，分会场未审批通过,通知其他分会场 失败:" + ex.Message, ex);
                    }

                    return result;
                }
                #endregion

            }catch(Exception ex)
            {
                tran.Rollback();
                result.SetFail(ex.Message,ex);
                return result;
            }
            finally
            {
                tran.Close();
            }
        }


        public GeneralResult AuditCancel(dynamic dic)
        {
            var result = new GeneralResult();
            var status = Convert.ToInt32(dic["STATUS"]);
            var remark = dic["REMARK"];
            var detailid = Convert.ToInt32(dic["APPLY_DETAIL_ID"]);

            YDPB_EVAL_APPLY_DETAIL detail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.ViewByPkModel(detailid);
            if (null == detail)
            {
                result.SetFail("会场申请信息不存在");
                return result;
            }

            var applyResult = ViewByPk(detail.APPLY_ID);

            if (!applyResult.Success || !(applyResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("申请单信息不存在");
                return result;
            }

            var conRecord = new WhereClipBuilder();
            conRecord.And(YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == detailid && YDPB_EVAL_APPLY_RECORD._.AREA_CODE == FwUser.AREACODE);
            var record = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FindList(conRecord).FirstOrDefault();
            if (null == record)
            {
                result.SetFail("审批流程记录异常");
                return result;
            }
            if (record.STATUS != 0)
            {
                result.SetFail("重复审批");
                return result;
            }

          
            var db = GetDbSession();
            var tran = db.BeginTransaction();

            try
            {
                YDPB_EVAL_APPLY apply = (YDPB_EVAL_APPLY)applyResult.Data;

                detail.Attach();
                detail.STATUS = status;
                detail.DATA_TIMESTAMP = DateTime.Now;
                db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                record.Attach();
                record.STATUS = status;
                record.REMARK = remark;
                record.AUDIT_TIME = DateTime.Now;
                record.AUDIT_USER = GlobalDataService.Instance.Centers.ContainsKey(FwUser.AREACODE) ?
                        GlobalDataService.Instance.Centers[FwUser.AREACODE] : FwUser.ZP_UNIT;
                record.AUDIT_USER_ID = FwUser.ID;
                record.CREATOR = Identity.LoginName;
                record.DATA_TIMESTAMP = DateTime.Now;
                db.Update<YDPB_EVAL_APPLY_RECORD>(tran, record);



               

                if (status == (int)Audit_Status.审核通过)
                {
                    apply.Attach();
                    apply.DATA_TIMESTAMP = DateTime.Now;
                    if (detail.IS_MAIN == 1)
                    {
                        apply.STATUS = 1;//审核通过
                    }

                    string sql = "UPDATE YDPB_EVAL_ROOM_SEAT_RECORD SET  STATE =0,DATA_TIMESTAMP=SYSDATE WHERE EVAL_APPLY_DETAIL_ID=" + detail.FID;
                    db.FromSql(sql).SetDbTransaction(tran).ExecuteNonQuery();

                    var isFinish = db.FromSql("SELECT COUNT(1) FROM YDPB_EVAL_APPLY_RECORD WHERE APPLY_ID=" + apply.ID + "  AND APPLY_DETAIL_ID !=0  AND APPLY_DETAIL_ID !=" + detailid + " AND STATUS=0").ToScalar<int>();
                    if (isFinish == 0)
                    {
                        apply.STATUS = 2;//审核通过

                        var FResult = ViewByPk(apply.FID);
                        if (FResult.Success && FResult.Data is YDPB_EVAL_APPLY)
                        {
                            var sourceEntity = (YDPB_EVAL_APPLY)FResult.Data;
                            sourceEntity.Attach();
                            sourceEntity.FLAG = 2;
                            db.Update<YDPB_EVAL_APPLY>(tran, sourceEntity);
                        }
                        apply.STATUS = 2;//审核通过
                       
                    }
                    db.Update<YDPB_EVAL_APPLY>(tran, apply);
                }
                tran.Commit();

                //if (detail.IS_MAIN != 1)
                //{
                //    //ServicesFactory.GGZYJD.YdpbBranchService.notify(apply, detail);
                //}

                result.SetSuccess();
            }
            catch(Exception ex)
            {
                tran.Rollback();
                result.SetException(ex.Message, ex);
            }
            finally
            {
                tran.Close();
            }
            return result;
        }

        /// <summary>
        /// 招标代理公司查看详情页面
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public GeneralResult View(decimal? ID)


        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_APPLY._.ID == ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);

            var dbModel = FirstOrNull(condition);
            if (dbModel == null)
            {
                result.SetFail(OBJECT_NOT_EXIST);
            }
            else
            {
                var dic = dbModel.ToDictionary();
                if(dbModel.FLAG ==0)
                {
                    var conditionCheck = (YDPB_EVAL_APPLY._.FID == dbModel.ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);
                    var dbModelCheck = FirstOrNull(conditionCheck);
                    if(null != dbModelCheck)
                    {
                        dic["FLAG"] = 3;
                    }
                }

                var con = new WhereClipBuilder();
                con.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == ID && YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(con);
                dic.Add("DETAIL", details);

                var conRecord = new WhereClipBuilder();
                conRecord.And(YDPB_EVAL_APPLY_RECORD._.APPLY_ID == ID && YDPB_EVAL_APPLY_RECORD._.IS_DELETE == 0 && YDPB_EVAL_APPLY_RECORD._.IS_MAIN_AUDIT == 1);
                var records = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FindList(conRecord);
                dic.Add("RECORD", records.Select(t => new {
                    t.ID,
                    t.APPLY_STEP,
                    t.CENTER_NAME,
                    t.AUDIT_TIME,
                    t.STATUS,
                    t.REMARK
                }));
                result.SetSuccess(dic);
            }
            return result;
        }
        public GeneralResult PageList(int? state, SearchCondition search)
        {
            if (null == search)
            {
                search = new SearchCondition();
            }
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            if (state.HasValue)
            {
                condition.And(V_YDPB_APPLY_ALL._.STATE == state);
            }
            condition.And(V_YDPB_APPLY_ALL._.CREATOR_ID == FwUser.ID);
            var count = ServicesFactory.GGZYJD.VYdpbApplyAllService.Count(condition);
            var pageList = ServicesFactory.GGZYJD.VYdpbApplyAllService.PageList(condition, search, V_YDPB_APPLY_ALL._.ID.Desc).ToBootstrapTableList<dynamic>(count);
            result.SetSuccess(pageList);
            return result;
        }
        /// <summary>
        /// 评标项目列表(主会场)
        /// </summary>
        /// <param name="eval_state"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public GeneralResult PageListProject(int? EVAL_STATUS, SearchCondition search)
        {
            if (null == search)
            {
                search = new SearchCondition();
            }
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(V_YDPB_APPLY_TRADE._.FLAG == 0);
            condition.And(V_YDPB_APPLY_TRADE._.AREA_CODE == FwUser.AREACODE);//审核通过
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_STATUS == 2);//审核通过
            condition.And(V_YDPB_APPLY_TRADE._.IS_MAIN == 1);
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_TYPE.In(0,1));
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_IS_EVAL_EXPERT == 1);
            if (EVAL_STATUS.HasValue)
            {
                condition.And(V_YDPB_APPLY_TRADE._.EVAL_STATUS == EVAL_STATUS);
            }
            var count = ServicesFactory.GGZYJD.VYdpbApplyTradeService.Count(condition);
            var pageList = ServicesFactory.GGZYJD.VYdpbApplyTradeService.PageList(condition, search, V_YDPB_APPLY_TRADE._.ID.Desc).ToBootstrapTableList<dynamic>(count);
            result.SetSuccess(pageList);
            return result;
        }
        /// <summary>
        /// 申请单取消
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult Cancel(dynamic dic)
        {
            var result = new GeneralResult();
            if (null == dic["ID"])
            {
                result.SetFail("原申请单ID不能为空");
                return result;
            }
            if (null == dic["REMARK"])
            {
                result.SetFail("取消原因不能为空");
                return result;
            }
            var id = Convert.ToInt32(dic["ID"]);
            var remark = dic["REMARK"];
            var viewResult = ViewByPk(id);

            if (viewResult.Success && viewResult.Data is YDPB_EVAL_APPLY)
            {
                YDPB_EVAL_APPLY entity = (YDPB_EVAL_APPLY)viewResult.Data;

                if (entity.CREATOR_ID != FwUser.ID)
                {
                    result.SetFail("非法授权");
                    return result;
                }

                if (entity.STATUS != 2)
                {
                    result.SetFail("原申请单信息未审核通过");
                    return result;
                }

                if(entity.FLAG !=0)
                {
                    result.SetFail("申请单已变更/取消");
                    return result;
                }
                if (entity.FLAG == 0)
                {
                    var conditionCheck = (YDPB_EVAL_APPLY._.FID == entity.ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);
                    var dbModelCheck = FirstOrNull(conditionCheck);
                    if (null != dbModelCheck)
                    {
                        result.SetFail("原申请单已申请取消/变更");
                        return result;
                    }
                }
                var db = GetDbSession();
                var tran = db.BeginTransaction();

                try
                {
                    var con = new WhereClipBuilder();
                    con.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == entity.ID && YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                    var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(con);

                    var model = new YDPB_EVAL_APPLY();
                    model.FID = entity.ID;
                    model.F_SERIES_NUMBER = entity.SERIES_NUMBER;
                    model.APPLY_TYPE = (int)Apply_Type.场地取消;
                    model.CREATOR = FwUser.ZP_UNIT;
                    model.CREATOR_ID = FwUser.ID;
                    model.TENDER_PROJECT = entity.TENDER_PROJECT;
                    model.TENDER_PROJECT_CODE = entity.TENDER_PROJECT_CODE;
                    model.TENDER_PROJECT_ID = entity.TENDER_PROJECT_ID;
                    model.STATUS = (int)Audit_Status.待审批;
                    model.REMARK = remark;

                    if (true)
                    {
                        var seqSql = "SELECT SEQ_YDPB_EVAL_APPLY.NEXTVAL FROM DUAL";
                        model.ID = db.FromSql(seqSql).SetDbTransaction(tran).ToScalar<int>();
                        model.SERIES_NUMBER = General_SERIES_NUMBER(model);
                        db.Insert<YDPB_EVAL_APPLY>(tran, model);

                        YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                        record.APPLY_DETAIL_ID = 0;
                        record.APPLY_ID = model.ID;
                        record.AREA_CODE = "";
                        record.APPLY_STEP = "提交申请";
                        record.CENTER_NAME = FwUser.ZP_UNIT;
                        record.AUDIT_TIME = DateTime.Now;
                        record.STATUS = (int)Audit_Status.已办理;
                        record.AUDIT_USER = Identity?.LoginName;
                        record.IS_MAIN_AUDIT = 1;
                        record.CREATOR = Identity.LoginName;
                        record.CREATOR_ID = FwUser.ID;
                        db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                    }

                    details.OrderByDescending(od => od.IS_MAIN).ToList().ForEach(d =>
                    {

                        var detail = new YDPB_EVAL_APPLY_DETAIL();
                        detail.FID = d.ID;
                        detail.ID = 0;
                        detail.AREA_CODE = d.AREA_CODE;
                        detail.APPLY_ID = model.ID;
                        detail.CREATOR = Identity?.Name;
                        detail.CREATOR_ID = FwUser.ID;
                        detail.CENTER_NAME = d.CENTER_NAME;
                        detail.IS_MAIN = d.IS_MAIN;
                        detail.ID = db.Insert<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                        YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                        record.APPLY_DETAIL_ID = detail.ID;
                        record.APPLY_ID = model.ID;
                        record.AREA_CODE = detail.AREA_CODE;
                        record.APPLY_STEP = detail.IS_MAIN == 1 ? "主会场审批" : "分会场审批";
                        record.CENTER_NAME = detail.CENTER_NAME;
                        record.STATUS = (int)Audit_Status.待审批;
                        record.IS_MAIN_AUDIT = 1;//取消申请审批 不分先后
                        db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                    });

                    tran.Commit();


                    //推送申请信息到分会场处理
                    details.Where(w=>w.IS_MAIN ==0).ToList().ForEach(e => {
                        ServicesFactory.GGZYJD.YdpbBranchService.Cancel(model, e);
                    });

                    var data = new { model.ID, model.SERIES_NUMBER };
                    result.SetSuccess(data);
                    return result;
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    result.SetException(ex.Message,ex);
                    return result;
                }
                finally
                {
                    tran.Close();
                }

            }
            result.SetFail("原申请单信息不存在或已删除");
            return result;
        }

        /// <summary>
        /// 申请单取消
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public GeneralResult I_Cancel(YDPB_EVAL_APPLY entityApply)
        {
            var result = new GeneralResult();
            if (String.IsNullOrEmpty(entityApply.F_SERIES_NUMBER))
            {
                result.SetFail("原申请单编号不能为空");
                return result;
            }
            if (null == entityApply.REMARK)
            {
                result.SetFail("取消原因不能为空");
                return result;
            }
            if(entityApply.F_SERIES_NUMBER.Length !=22)
            {
                result.SetFail("原申请单编号格式错误");
                return result;
            }
            var id = Convert.ToInt32(entityApply.F_SERIES_NUMBER.Substring(entityApply.F_SERIES_NUMBER.Length -6,6));
            var remark = entityApply.REMARK;
            var viewResult = ViewByPk(id);

            if (viewResult.Success && viewResult.Data is YDPB_EVAL_APPLY)
            {
                YDPB_EVAL_APPLY entity = (YDPB_EVAL_APPLY)viewResult.Data;
                if (entity.STATUS != 2)
                {
                    result.SetFail("原申请单信息未审核通过");
                    return result;
                }
                if (entity.FLAG != 0)
                {
                    result.SetFail("申请单已变更/取消");
                    return result;
                }

                if (entity.FLAG == 0)
                {
                    var conditionCheck = (YDPB_EVAL_APPLY._.FID == entity.ID && YDPB_EVAL_APPLY._.IS_DELETE == 0);
                    var dbModelCheck = FirstOrNull(conditionCheck);
                    if (null != dbModelCheck)
                    {
                        result.SetFail("原申请单已申请取消/变更");
                        return result;
                    }
                }

                var db = GetDbSession();
                var tran = db.BeginTransaction();

                try
                {
                    var con = new WhereClipBuilder();
                    con.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == entity.ID && YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
                    var details = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(con);

                    var model = new YDPB_EVAL_APPLY();
                    model.FID = entity.ID;
                    model.F_SERIES_NUMBER = entity.SERIES_NUMBER;
                    model.APPLY_TYPE = (int)Apply_Type.场地取消;
                    model.CREATOR ="";
                    model.CREATOR_ID = 0;
                    model.TENDER_PROJECT = entity.TENDER_PROJECT;
                    model.TENDER_PROJECT_CODE = entity.TENDER_PROJECT_CODE;
                    model.TENDER_PROJECT_ID = entity.TENDER_PROJECT_ID;
                    model.TENDER_AGENCY_CODE = entity.TENDER_AGENCY_CODE;
                    model.TENDER_AGENCY_NAME = entity.TENDER_AGENCY_NAME;
                    model.TENDER_AGENT_CONTRACT = entity.TENDER_AGENT_CONTRACT;
                    model.TENDER_AGENT_PHONE = entity.TENDER_AGENT_PHONE;

                    model.STATUS = 1;//主会场审批通过
                    model.REMARK = remark;

                    if (true)
                    {
                        var seqSql = "SELECT SEQ_YDPB_EVAL_APPLY.NEXTVAL FROM DUAL";
                        model.ID = db.FromSql(seqSql).SetDbTransaction(tran).ToScalar<int>();
                        model.SERIES_NUMBER = General_SERIES_NUMBER(model);
                        db.Insert<YDPB_EVAL_APPLY>(tran, model);

                        YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                        record.APPLY_DETAIL_ID = 0;
                        record.APPLY_ID = model.ID;
                        record.AREA_CODE = "";
                        record.APPLY_STEP = "提交申请";
                        record.AUDIT_TIME = DateTime.Now;
                        record.STATUS = (int)Audit_Status.已办理;
                        record.IS_MAIN_AUDIT = 1;
                        record.REMARK = "交易系统推送";
                        db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                    }

                    details.OrderByDescending(od => od.IS_MAIN).ToList().ForEach(d =>
                    {

                        var detail = new YDPB_EVAL_APPLY_DETAIL();
                        detail.FID = d.ID;
                        detail.ID = 0;
                        detail.AREA_CODE = d.AREA_CODE;
                        detail.APPLY_ID = model.ID;
                        detail.CREATOR = "";
                        detail.CREATOR_ID = 0;
                        detail.CENTER_NAME = d.CENTER_NAME;
                        detail.IS_MAIN = d.IS_MAIN;
                        detail.STATUS = d.IS_MAIN;
                        detail.ID = db.Insert<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                        YDPB_EVAL_APPLY_RECORD record = new YDPB_EVAL_APPLY_RECORD();
                        record.APPLY_DETAIL_ID = detail.ID;
                        record.APPLY_ID = model.ID;
                        record.AREA_CODE = detail.AREA_CODE;
                        record.APPLY_STEP = detail.IS_MAIN == 1 ? "主会场审批" : "分会场审批";
                        record.CENTER_NAME = detail.CENTER_NAME;
                        record.STATUS = detail.IS_MAIN;
                        record.IS_MAIN_AUDIT = 1;//取消申请审批 不分先后
                        db.Insert<YDPB_EVAL_APPLY_RECORD>(tran, record);
                    });

                    tran.Commit();

                    //推送申请信息到分会场处理
                    details.Where(w=>w.IS_MAIN ==0).ToList().ForEach(e => {
                        ServicesFactory.GGZYJD.YdpbBranchService.Cancel(model, e);
                    });
                   
                    var data = new {model.SERIES_NUMBER };
                    result.SetSuccess(data);
                    return result;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    result.SetException(ex.Message, ex);
                    return result;
                }
                finally
                {
                    tran.Close();
                }

            }
            result.SetFail("原申请单信息不存在或已删除");
            return result;
        }
        /// <summary>
        /// 生成申请单编号
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string General_SERIES_NUMBER(YDPB_EVAL_APPLY entity)
        {
            string prefix = "";
            switch (Convert.ToInt32(entity.APPLY_TYPE))
            {
                case 0:
                    prefix = "SQ";
                    break;
                case 1:
                    prefix = "BG";
                    break;
                case 2:
                    prefix = "QX";
                    break;
                default:
                    break;
            }
            entity.SERIES_NUMBER = prefix + DateTime.Now.ToString("yyyyMMddHHmmsss") + entity.ID.ToString().PadLeft(6, '0');
            return entity.SERIES_NUMBER;
        }
    }
}
