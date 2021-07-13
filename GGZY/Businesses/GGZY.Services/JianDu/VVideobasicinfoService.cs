using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class VVideobasicinfoService
    {
        /// <summary>
        /// 交易场所视频
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public PageTableResult GetPageVideoBasicInfo(V_VIDEOBASICINFO model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            var count = Count(condition.ToWhereClip());
            if (count > 0)
            {
                var list = FromWhere(condition.ToWhereClip())
                    .LeftJoin<SYS_AREA_QUANGUO>(SYS_AREA_QUANGUO._.AREACODE == V_VIDEOBASICINFO._.AREACODE)
                    .Page(search.PageSize, search.PageNo)
                    .OrderBy(V_VIDEOBASICINFO._.CREATE_TM.Desc)
                    .Select(
                        SYS_AREA_QUANGUO._.SHENG,
                        SYS_AREA_QUANGUO._.SHI,
                        SYS_AREA_QUANGUO._.XIAN,
                        V_VIDEOBASICINFO._.All
                        )
                    .ToList<JdVideoBasicInfoModel>();
                return list.ToPageTableTResult(search, count);
            }
            return search.ToPageTableResult();
        }
        /// <summary>
        /// 获取视频节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<JdVideoPointInfoModel> GetVideoTree(V_VIDEOBASICINFO model)
        {
            var basic = FromWhere(V_VIDEOBASICINFO._.VID == model.VID && V_VIDEOBASICINFO._.VISIBLE == 1).ToList<JdVideoPointInfoModel>();
            var info = FromWhere(V_VIDEOBASICINFO._.VID == model.VID && V_VIDEOBASICINFO._.VISIBLE == 1)
                .InnerJoin<V_VIDEOPOINTINFO>(V_VIDEOPOINTINFO._.ENNMCD == V_VIDEOBASICINFO._.VID)
                .Select(
                    V_VIDEOPOINTINFO._.ENNMCD,
                    V_VIDEOPOINTINFO._.CAMERAID,
                    V_VIDEOPOINTINFO._.ITEMNAME,
                    V_VIDEOPOINTINFO._.CHANNEL,
                    V_VIDEOPOINTINFO._.DEVICEID,
                    V_VIDEOPOINTINFO._.STATUS,
                    V_VIDEOBASICINFO._.All).ToList<JdVideoPointInfoModel>();
            basic.ForEach(c =>
            {
                c.ID = $"v_{c.VID}";
                c.NAME = c.VNAME?.Trim();
                c.PID = $"s_";
                c.CHANNEL = -1;
                c.STATUS = 1;
            });
            info.ForEach(c =>
            {
                c.ID = $"p_{c.ENNMCD?.Trim()}{c.CAMERAID}";
                c.NAME = c.ITEMNAME?.TrimEnd();
                c.PID = $"v_{c.VID}";
            });
            basic.AddRange(info);
            var r = basic.OrderBy(c => c.ORDER_BY).ToList();
            return r;
        }
    }
}