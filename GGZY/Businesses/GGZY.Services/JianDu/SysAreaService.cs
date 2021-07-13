using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysAreaService
    {
        /// <summary>
        /// 全省九地市+平潭+省本级
        /// 35 3501~3509 350128 3520
        /// </summary>
        /// <returns></returns>
        public List<LabelValueModel> FuJianRegion()
        {
            var regions = FindList(SYS_AREA._.PCODE == "350000" || SYS_AREA._.AREACODE == "350000" ||
                                   SYS_AREA._.AREACODE == "350128");
            var r = regions.Select(c =>
            {
                var value = c.AREACODE.TrimEnd('0');
                if (value.Length % 2 > 0)//352000省本级
                {
                    value += "0";
                }
                var m = new LabelValueModel
                {
                    Id = c.AREACODE,
                    Label = c.AREANAME,
                    Value = value,
                };
                return m;
            }).ToList();
            return r;
        }
    }
}