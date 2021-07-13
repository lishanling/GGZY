using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Extensions;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GGZY.Services.Infrastructure.Extensions;

namespace GGZY.Services
{
    /// <summary>
    /// 评标席位分配管理
    /// </summary>
    public partial class YdpbEvalExpertRecordService : BaseServiceT<YDPB_EVAL_EXPERT_RECORD>
    {
        /// <summary>
        /// 席位分配
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experts"></param>
        /// <returns></returns>
        public GeneralResult Add(int id, List<YDPB_EVAL_EXPERT_RECORD> experts)
        {
            var result = new GeneralResult();
            var applyResult = ServicesFactory.GGZYJD.YdpbEvalApplyService.ViewByPk(id);
            if (!(applyResult.Success && applyResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("申请单信息不存在");
                return result;
            }
            YDPB_EVAL_APPLY apply = (YDPB_EVAL_APPLY)applyResult.Data;
            if (apply.STATUS != 2 || apply.FLAG != 0)
            {
                result.SetFail("申请单审核未通过或已取消/变更");
                return result;
            }

            var conditionDetail = new WhereClipBuilder();
            conditionDetail.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            conditionDetail.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);
            conditionDetail.And(YDPB_EVAL_APPLY_DETAIL._.AREA_CODE == FwUser.AREACODE);
            var detail = ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(conditionDetail).FirstOrDefault();
            if (null == detail)
            {
                result.SetFail("会场申请信息不存在");
                return result;
            }
           
            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_EXPERT_RECORD._.IS_DELETE == 0);//审核通过
            condition.And(YDPB_EVAL_EXPERT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID);//审核通过
            var is_eval = ServicesFactory.GGZYJD.YdpbEvalExpertRecordService.Count(condition) >0;

            if (is_eval)
            {
                result.SetFail("重复分配");
                return result;
            }
            var conditionSeat = new WhereClipBuilder();
            conditionSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID);
            var seats = ServicesFactory.GGZYJD.YdpbEvalRoomSeatRecordService.FindList(conditionSeat);
            
            if(experts.Count !=seats.Count)
            {
                result.SetFail("评标专家与评标席位数量不一致");
                return result;
            }

            var db = GetDbSession();
            var tran = db.BeginTransaction();

            try
            {
                foreach (var expert in experts)
                {
                    var seat = seats.Where(w => expert.F_RECORD_ID == w.ID).FirstOrDefault();
                    if (null == seat)
                    {
                        result.SetFail("评标席位不存在");
                        return result;
                    }
                    expert.EVAL_ROOM_NAME = seat.EVAL_ROOM_NAME;
                    expert.SEAT_NUMBER = seat.SEAT_NUMBER;
                    expert.AREA_CODE = seat.AREA_CODE;
                    expert.CREATOR = Identity.LoginName;
                    expert.CREATOR_ID = FwUser.ID;
                    expert.END_TIME = seat.END_TIME;
                    expert.START_TIME = seat.START_TIME;
                    expert.EVAL_APPLY_DETAIL_ID = detail.ID;
                    db.Insert<YDPB_EVAL_EXPERT_RECORD>(tran, expert);
                }

                detail.Attach();
                detail.IS_EVAL_EXPERT = 1;
                
                db.Update<YDPB_EVAL_APPLY_DETAIL>(tran, detail);

                var sql = "select count(1) from YDPB_EVAL_APPLY_DETAIL where IS_EVAL_EXPERT =0 AND APPLY_ID=" + apply.ID + " AND ID !=" + detail.ID;
                var IS_EVAL_EXPERT = db.FromSql(sql).ToScalar<int>() ==0;
                if(IS_EVAL_EXPERT)
                {
                    apply.Attach();
                    apply.IS_EVAL_EXPERT = 1;
                    apply.DATA_TIMESTAMP = DateTime.Now;
                    db.Update<YDPB_EVAL_APPLY>(tran, apply);
                }
                tran.Commit();
                result.SetSuccess();
                return result;
            }
            catch(Exception ex)
            {
                tran.Rollback();
                result.SetFail(ex.Message,ex);
                return result;
            }
        }

        public GeneralResult Detail(int? id)
        {
            var result = new GeneralResult();
            var applyResult = ServicesFactory.GGZYJD.YdpbEvalApplyService.ViewByPk(id);
            if(!(applyResult.Success && applyResult.Data is YDPB_EVAL_APPLY))
            {
                result.SetFail("申请单信息不存在");
                return result;
            }
            YDPB_EVAL_APPLY apply = (YDPB_EVAL_APPLY)applyResult.Data;
            if(apply.STATUS !=2 || apply.FLAG !=0)
            {
                result.SetFail("申请单审核未通过或已取消/变更");
                return result;
            }

            var conditionDetail = new WhereClipBuilder();
            conditionDetail.And(YDPB_EVAL_APPLY_DETAIL._.IS_DELETE == 0);
            conditionDetail.And(YDPB_EVAL_APPLY_DETAIL._.APPLY_ID == apply.ID);
            conditionDetail.And(YDPB_EVAL_APPLY_DETAIL._.AREA_CODE ==FwUser.AREACODE);
            var detail =ServicesFactory.GGZYJD.YdpbEvalApplyDetailService.FindList(conditionDetail).FirstOrDefault();
            if(null == detail)
            {
                result.SetFail("会场申请信息不存在");
                return result;
            }

            var dic = apply.ToDictionary();
            dic["EXPERT_COUNT"] = detail.EXPERT_COUNT;
            dic["IS_EVAL_EXPERT"] = detail.IS_EVAL_EXPERT;
            dic.Remove("TENDER_PROJECT");
            dic.Remove("TENDER_PROJECT_CODE");
            dic.Remove("TENDER_PROJECT_ID");
            

            var condition = new WhereClipBuilder();
            condition.And(YDPB_EVAL_EXPERT_RECORD._.IS_DELETE == 0);//审核通过
            condition.And(YDPB_EVAL_EXPERT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID);//审核通过
            var experts = ServicesFactory.GGZYJD.YdpbEvalExpertRecordService.FindList(condition);

            if (experts.Any())
            {
                dic.Add("EVAL_ROOM_NAME", experts.FirstOrDefault().EVAL_ROOM_NAME);
                dic.Add("EXPERT", experts.Select(t => new{ 
                    t.F_RECORD_ID,
                    t.SEAT_NUMBER,
                    t.EXPERT_NAME,
                    t.ID_CARD_TYPE,
                    t.ID_CARD
                }));
                result.SetSuccess(dic);
                return result;
            }
            var conditionSeat = new WhereClipBuilder();
            conditionSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.IS_DELETE == 0);//审核通过
            conditionSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID);
            var seats = ServicesFactory.GGZYJD.YdpbEvalRoomSeatRecordService.FindList(conditionSeat);
            if(true)
            {
                dic.Add("EVAL_ROOM_NAME", seats.FirstOrDefault().EVAL_ROOM_NAME);
                dic.Add("EXPERT", seats.Select(t => new {
                    F_RECORD_ID = t.ID,
                    SEAT_NUMBER =t.SEAT_NUMBER,
                    EXPERT_NAME ="",
                    ID_CARD_TYPE ="",
                    ID_CARD =""
                }));
                result.SetSuccess(dic);
                return result;
            }
        }

        /// <summary>
        /// 评标席位分配管理列表
        /// </summary>
        /// <param name="search"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public GeneralResult List(SearchCondition search,int? state)
        {
            GeneralResult result = new GeneralResult();

            var condition = new WhereClipBuilder();
            condition.And(V_YDPB_APPLY_TRADE._.FLAG ==0);
            condition.And(V_YDPB_APPLY_TRADE._.AREA_CODE == FwUser.AREACODE);
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_TYPE.In(new List<int> { 0,1 }));
            condition.And(V_YDPB_APPLY_TRADE._.APPLY_STATUS ==2);
            if(state.HasValue)
            {
                condition.And(V_YDPB_APPLY_TRADE._.IS_EVAL_EXPERT == state);
            }

            var count = ServicesFactory.GGZYJD.VYdpbApplyTradeService.Count(condition);
            var record = ServicesFactory.GGZYJD.VYdpbApplyTradeService.PageList(condition, search, V_YDPB_APPLY_TRADE._.ID.Desc).ToBootstrapTableList<dynamic>(count); ;
            result.SetSuccess(record);
            return result;
        }
    }
}
