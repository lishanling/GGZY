using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZY.Services.Infrastructure.Model;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class SysAreaQuanguoService 
    {
        /// <summary>
        /// 监督-当前登录账号-组织机构-归属地树
        /// 工程领域大数据
        /// </summary>
        /// <returns></returns>
        public List<SelectModel> DepRegionTree()
        {
            var r = new List<SelectModel>();
            var allRegion = Cache.Get<List<SYS_AREA_QUANGUO>>("REGION:ALL", () =>
                {
                    var areas = FromWhere().Select(SYS_AREA_QUANGUO._.AREACODE, SYS_AREA_QUANGUO._.AREANAME,
                        SYS_AREA_QUANGUO._.PCODE).ToList();
                    var regions = areas.Select(c =>
                    {
                        if (c.PCODE == c.AREACODE)
                        {
                            c.PCODE = null;
                        }
                        return c;
                    }).OrderBy(c => c.AREACODE).ToList();
                    return regions;
                }
            );
            var areaCode = JdUser?.UserDepartment?.AREACODE;
            if (!string.IsNullOrWhiteSpace(areaCode))
            {
                var pRegions = allRegion.FindAll(c => c.PCODE == areaCode).OrderBy(c => c.AREACODE);
                foreach (var region in pRegions)
                {
                    var m = new SelectModel(region.AREACODE, region.AREANAME);
                    ChildrenRegion(m, allRegion);
                    r.Add(m);
                }
            }

            return r;
        }

        protected void ChildrenRegion(SelectModel model, List<SYS_AREA_QUANGUO> regions)
        {
            var children = regions.FindAll(c => c.PCODE == model.Value && c.AREACODE != model.Value);
            if (children.Any())
            {
                foreach (var child in children)
                {
                    var m = new SelectModel(child.AREACODE, child.AREANAME);
                    if (child.AREACODE != model.Value)
                    {
                        ChildrenRegion(m, regions);
                    }
                    model.Children.Add(m);
                }
            }
            else
            {
                model.Children = null;
            }
        }
    }
}