using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model.JianDu;
using GGZYJD.DbEntity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GGZY.Services.JianDu
{
    public partial class TTpDataService
    {
        #region 监督服务 监督点统计 详情（监督点内容）
        /// <summary>
        /// 监督点内容
        /// /Member/XMCX/ProcessHtml/FJ00111001/MPContent/MP_2_3.aspx
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public GeneralResult GetTpDataInfo(TTpDataModel model)
        {
            var r = new GeneralResult();
            var list = new List<TTpDataModel>();
            if (!string.IsNullOrWhiteSpace(model.CODE) && !string.IsNullOrWhiteSpace(model.BUSINESSID))
            {
                list = FromWhere(T_TP_DATA._.CODE == model.CODE && T_TP_DATA._.BUSINESSID == model.BUSINESSID)
                    .ToList<TTpDataModel>();
            }
            if (model.ID == 147 || model.ID == 153)//投诉处理时限  //投诉受理时限
            {
                var idlist = new List<string>();
                foreach (var item in list)
                {
                    if (!string.IsNullOrWhiteSpace(item.BFIELD_5))
                    {
                        IList<Hashtable> childList = JsonConvert.DeserializeObject<List<Hashtable>>(item.BFIELD_5);
                        idlist = childList.Select(c => c["ID"]?.ToString()).Where(c => !string.IsNullOrWhiteSpace(c)).Distinct().ToList();
                    }
                }
                var ts = Jd.PtZxtsService.FindZxtsByTsIds(idlist);
                r.SetSuccess(new { Type = model.ID, DataInfo = ts });
            }
            else
            {
               
                r.SetSuccess(new { Type = model.ID, DataInfo = list });
            }
            return r;
        }

        #endregion
    }
}