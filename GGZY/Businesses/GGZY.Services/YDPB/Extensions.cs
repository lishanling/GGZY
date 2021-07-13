using Dos.ORM;
using GGZY.Services.Base;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.YDPB
{
    public static class Extensions
    {
        public static dynamic GetDetail(this YDPB_EVAL_APPLY_DETAIL detail)
        {
            var conSeat = new WhereClipBuilder();
            conSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.EVAL_APPLY_DETAIL_ID == detail.ID && YDPB_EVAL_ROOM_SEAT_RECORD._.STATE == 1 && YDPB_EVAL_ROOM_SEAT_RECORD._.IS_DELETE == 0);
            conSeat.And(YDPB_EVAL_ROOM_SEAT_RECORD._.AREA_CODE == detail.AREA_CODE);
            var record = ServicesFactory.GGZYJD.YdpbEvalApplyRecordService.FirstOrNull(YDPB_EVAL_APPLY_RECORD._.APPLY_DETAIL_ID == detail.ID);
            
            if (detail.STATUS != 1)
            {
                return new
                {
                    detail.AREA_CODE,
                    detail.CENTER_NAME,
                    detail.STATUS,
                    REMARK = record?.REMARK,
                    EVAL_ROOM_NAME = "",
                    EVAL_ROOM_ADDR = "",
                    SEAT_NUMBER = new List<dynamic>()
                };
            }

            var seats = ServicesFactory.GGZYJD.YdpbEvalRoomSeatRecordService.FindList(conSeat);
            if(null != seats && seats.Any())
            {
                var gSeat = seats.GroupBy(g => new { g.EVAL_ROOM_NAME, g.EVAL_ROOM_ID }).FirstOrDefault();

                
                return new
                {
                    detail.AREA_CODE,
                    detail.CENTER_NAME,
                    detail.STATUS,
                    REMARK =record?.REMARK,
                    EVAL_ROOM_NAME = seats.FirstOrDefault()?.EVAL_ROOM_NAME,
                    EVAL_ROOM_ADDR = "",
                    SEAT_NUMBER = seats?.Select(t => t.SEAT_NUMBER),
                };
            }
            return new
            {
                detail.AREA_CODE,
                detail.CENTER_NAME,
                detail.STATUS,
                REMARK = record?.REMARK,
                EVAL_ROOM_NAME = "",
                EVAL_ROOM_ADDR = "",
                SEAT_NUMBER = new List<dynamic>()
            };
        }
    }
}
