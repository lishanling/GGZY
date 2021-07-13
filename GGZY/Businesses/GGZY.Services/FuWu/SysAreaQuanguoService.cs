using System;
using System.Collections.Generic;
using System.Linq;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Services.Infrastructure.Model;
using GGZYFW.DbEntity;

namespace GGZY.Services.FuWu
{
    public partial class SysAreaQuanguoService
    {
        /// <summary>
        /// 根据行政区划编码，获取行政区划名称
        /// </summary>
        /// <param name="areacode"></param>
        /// <returns></returns>
        public string GetRegionName(string areacode)
        {
            if (String.IsNullOrWhiteSpace(areacode))
            {
                return "";
            }
            var region = FirstOrNull(SYS_AREA_QUANGUO._.AREACODE == areacode)?.AREANAME;
            return region;
        }
        /// <summary>
        /// 根据行政区划编码，按省市县获取行政区划名称
        /// </summary>
        /// <param name="areacode"></param>
        /// <returns></returns>
        public IEnumerable<string> GetRegionNames(string areacode)
        {
            if (String.IsNullOrWhiteSpace(areacode))
            {
                return new List<string>();
            }
            if (areacode.Length != 6)
            {
                throw new Exception("行政区划代码错误");
            }
            List<string> codes = new List<string>();
            codes.Add(areacode);
            codes.Add(String.Concat(areacode.Substring(0, 4).PadRight(6, '0')));
            codes.Add(String.Concat(areacode.Substring(0, 2).PadRight(6, '0')));
            var regions = FindList(SYS_AREA_QUANGUO._.AREACODE.In(codes), SYS_AREA_QUANGUO._.AREACODE.Asc)
                .Select(t => t.AREANAME).Distinct();
            return regions;
        }
        public GeneralResult GetRegionTree()
        {
            GeneralResult res = new GeneralResult();
            var dbModel = FromWhere(SYS_AREA_QUANGUO._.AREACODE.Like("35%"))
                .Select(SYS_AREA_QUANGUO._.AREANAME, SYS_AREA_QUANGUO._.AREACODE, SYS_AREA_QUANGUO._.PCODE, SYS_AREA_QUANGUO._.ORDER_BY)
                .ToList();
            var shi = dbModel.Where(e => e.PCODE == "350000").OrderBy(e => e.ORDER_BY).ToList();
            List<Dictionary<string, object>> chiList = new List<Dictionary<string, object>>();
            foreach (var s in shi)
            {
                if (s.AREACODE == "350000") continue;
                chiList.Add(new Dictionary<string, object>()
                {
                    { "value",s.AREACODE},
                    {"label",s.AREANAME },
                    {"children",GetChildren(s.AREACODE,dbModel) }
                });
            }
            List<object> result = new List<object>();
            result.Add(new
            {
                value = "350000",
                label = "福建省",
                children = chiList
            });
            res.SetSuccess(result);
            return res;
        }
        public List<Dictionary<string, string>> GetChildren(string pCode, List<SYS_AREA_QUANGUO> list)
        {
            return list.Where(e => e.PCODE == pCode).Select(e => new Dictionary<string, string>()
            {
                { "value",e.AREACODE},
                {"label",e.AREANAME }
            }).ToList();
        }

        public List<object> Region(string pid)
        {
            if (string.IsNullOrWhiteSpace(pid))
            {

                var region = FindList(SYS_AREA_QUANGUO._.PCODE.IsNull() || SYS_AREA_QUANGUO._.AREACODE == SYS_AREA_QUANGUO._.PCODE,
                        SYS_AREA_QUANGUO._.AREACODE.Asc)
                    .Select(c => new { value = c.AREACODE, label = c.AREANAME })
                    //.ToDictionary(c => c.Label, c => c.Value)
                    //.ToDictionary(c => c.AREACODE, c => c.AREANAME)
                    .ToList<object>();
                return region;
            }
            else
            {
                var region = FindList(SYS_AREA_QUANGUO._.PCODE == pid,
                        SYS_AREA_QUANGUO._.AREACODE.Asc)
                    .Select(c => new { value = c.AREACODE, label = c.AREANAME })
                    //.ToDictionary(c => c.Label, c => c.Value)
                    //.ToDictionary(c => c.AREACODE, c => c.AREANAME)
                    .ToList<object>();
                return region;

            }
        }
        /// <summary>
        /// 获取指定行政区域的下一级
        /// </summary>
        /// <param name="pcode"></param>
        /// <returns></returns>
        public List<SelectModel> RegionTree(string pcode = "350000")
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

            var pRegions = allRegion.FindAll(c => c.PCODE == pcode).OrderBy(c => c.AREACODE);
            foreach (var region in pRegions)
            {
                var m = new SelectModel(region.AREACODE, region.AREANAME);
                ChildrenRegion(m, allRegion);
                r.Add(m);
            }
            return r;
        }

        /// <summary>
        /// 获取指定行政区域的省、市、县三级
        /// </summary>
        /// <param name="pcode"></param>
        /// <returns></returns>
        public SelectModel RegionTrees(string pcode = "350000")
        {
            var allRegion = Cache.Get<List<SYS_AREA_QUANGUO>>("REGION:ALL", () => FindAll().OrderBy(c => c.AREACODE).ToList());
            var province = pcode.Substring(0, 2).PadRight(6, '0');
            var city = pcode.Substring(0, 4).PadRight(6, '0');
            var district = pcode;

            var region = allRegion.Find(c => c.AREACODE == pcode);


            if (null == region)
            {
                return new SelectModel { };
            }
            var m = new SelectModel(region.AREACODE, region.AREANAME);
            ChildrenRegion(m, allRegion);
            //获取省级
            if (province == pcode)
            {

                return m;
            }
            //市级编码
            if (city == pcode)
            {
                var provinceEntity = allRegion.Find(c => c.AREACODE == province);
                if (null == provinceEntity)
                {
                    return new SelectModel { };
                }
                var provinceModel = new SelectModel(provinceEntity.AREACODE, provinceEntity.AREANAME);
                provinceModel.Children = new List<SelectModel> { m };
                return provinceModel;
            }
            if (true)
            {

                var cityEntity = allRegion.Find(c => c.AREACODE == city);
                if (null == cityEntity)
                {
                    return new SelectModel { };
                }
                var cityModel = new SelectModel(cityEntity.AREACODE, cityEntity.AREANAME);
                cityModel.Children = new List<SelectModel> { m };

                var provinceEntity = allRegion.Find(c => c.AREACODE == province);
                if (null == provinceEntity)
                {
                    return new SelectModel { };
                }
                var provinceModel = new SelectModel(provinceEntity.AREACODE, provinceEntity.AREANAME);
                provinceModel.Children = new List<SelectModel> { cityModel };

                return provinceModel;
            }
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