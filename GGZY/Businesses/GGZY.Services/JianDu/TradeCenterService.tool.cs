using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.JianDu
{
    public partial  class TradeCenterService : BaseServiceT<TRADE_CENTER>
    {
        /// <summary>
        /// 查看
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public TRADE_CENTER ViewByAreaCode(string areaCode)
        {
            var condition = new WhereClipBuilder();
            condition.And(TRADE_CENTER._.AREA_CODE == areaCode && TRADE_CENTER._.IS_DELETE ==0);

            var dbModel = FirstOrNull(condition);
            return dbModel;
        }

        public GeneralResult I_Set_Notify_Url(string areacode,string url)
        {
            var result = new GeneralResult();

            var entity = ViewByAreaCode(areacode);
            if(null == entity)
            {
                result.SetFail("交易中心信息不存在或已被删除");
                return result;
            }
            entity.Attach();
            entity.NOTIFY_URL = url;
            Update(entity);
            result.SetSuccess();
            return result;
        }

        /// <summary>
        /// 县市交易中心对接服务接口-返回所有交易中心及其评标室列表
        /// </summary>
        /// <returns></returns>
        public GeneralResult I_ListAll()
        {
            var result = new GeneralResult();

            var dt = FromWhere<TRADE_CENTER>(TRADE_CENTER._.IS_DELETE == 0)
                  .LeftJoin<YDPB_EVAL_ROOM>(TRADE_CENTER._.AREA_CODE == YDPB_EVAL_ROOM._.AREA_CODE && YDPB_EVAL_ROOM._.IS_DELETE == 0 && YDPB_EVAL_ROOM._.ENABLED == 1 && YDPB_EVAL_ROOM._.STATE == 1)
                  .Select(TRADE_CENTER._.AREA_CODE, TRADE_CENTER._.UNIT_NAME, YDPB_EVAL_ROOM._.EVAL_ROOM_NAME)
                  .ToDataTable();

            var dics = dt.Rows.Cast<DataRow>().Select(dr => {
                var dict = new Dictionary<string, object>();
                dict.Add("AREA_CODE", dr["AREA_CODE"]);
                dict.Add("CENTER_NAME", dr["UNIT_NAME"]);
                dict.Add("EVAL_ROOM_NAME", dr["EVAL_ROOM_NAME"]);
                return dict;
            });
            var data = dics.GroupBy(g => new { CENTER_NAME = g["CENTER_NAME"].ToString(), AREA_CODE = g["AREA_CODE"] }).OrderBy(od=>od.Key.AREA_CODE).Select(t => new {
                AREA_CODE = t.Key.AREA_CODE,
                CENTER_NAME = t.Key.CENTER_NAME,
                EVAL_ROOM_LIST = t.Select(x => x["EVAL_ROOM_NAME"])
            });
            result.SetSuccess(data);
            return result;
        }

        /// <summary>
        /// 返回所有交易中心列表以及评标室名称
        /// </summary>
        /// <returns></returns>
        public GeneralResult ListAll()
        {
            var result = new GeneralResult();
            var condition = new WhereClipBuilder();
            condition.And(TRADE_CENTER._.IS_DELETE == 0);

            var data = FromWhere(condition.ToWhereClip())
                .Select(TRADE_CENTER._.AREA_CODE, TRADE_CENTER._.UNIT_NAME,TRADE_CENTER._.NOTIFY_URL).OrderBy(TRADE_CENTER._.AREA_CODE).ToList()
                .Select(t => new { AREA_CODE = t.AREA_CODE, CENTER_NAME = t.UNIT_NAME, NOTIFY_URL = t.NOTIFY_URL });
            result.SetSuccess(data);
            return result;
        }
    }
}
