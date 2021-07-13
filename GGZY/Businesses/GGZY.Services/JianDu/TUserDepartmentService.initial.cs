using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TUserDepartmentService
    {
        /// <summary>
        /// 按照二期项目初始化用户组织机构 父级id 归属地 可查看其他组织机构
        /// </summary>
        /// <returns></returns>
        public GeneralResult InitialDepartmentParentIdsAndRegionsAndOtherIds()
        {
            var r = new GeneralResult();
            var entities = FindAll();
            var areas = Jd.SysAreaQuanguoService.FindAll();
            foreach (var entity in entities)
            {
                var entityId = entity.DEPID?.ToString();
                if (!string.IsNullOrWhiteSpace(entity.AREACODE))
                {
                    var regionArr = new List<string> {entity.AREACODE};
                    FindParentAreaCode(regionArr,areas);
                    regionArr.Reverse();
                    var REGIONS = string.Join(",", regionArr);
                    Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "REGIONS",REGIONS, entityId, $"监督平台组织机构归属地");
                }

                if (entity.PARENTID != null)
                {
                    var departArr = new List<string> { entity.PARENTID.ToString() };
                    FindParentDepId(departArr, entities);
                    departArr.Reverse();
                    var PARENTIDS = string.Join(",", departArr);

                    Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "PARENTIDS", PARENTIDS, entityId, $"监督平台组织机构父级机构");
                }

                if (!string.IsNullOrWhiteSpace(entity.OTHERIDS))
                {

                    var depids = entity.OTHERIDS.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var otherArr = new List<string>();
                    foreach (var depid in depids)
                    {
                        var departArr = new List<string> { depid };
                        FindParentDepId(departArr, entities);
                        departArr.Reverse();
                        var PARENTIDS = string.Join(",", departArr);
                        otherArr.Add(PARENTIDS);
                    }

                    if (otherArr.Any())
                    {
                        var otherDepids = string.Join(";", otherArr);
                        Jd.TGeneralAttributeV2Service.SaveAttribute(entity, "OTHERDEPIDS", otherDepids, entityId, $"监督平台组织机构可查看其他机构");
                    }
                   
                }
               
            }
          
            return r;
        }

        protected void FindParentAreaCode(List<string> array, List<SYS_AREA_QUANGUO> datas)
        {
            var id = array.LastOrDefault();
            if (!string.IsNullOrWhiteSpace(id))
            {
                var data = datas.FirstOrDefault(c => c.AREACODE.ToString() == id);
                if (!string.IsNullOrWhiteSpace(data?.PCODE) && data?.PCODE != data?.AREACODE)
                {

                    array.Add(data.PCODE);
                    FindParentAreaCode(array, datas);
                }
            }
        }

        public void FindParentDepId(List<string> departArr, List<T_USER_DEPARTMENT> departs)
        {
            var depid = departArr.LastOrDefault();
            if (!string.IsNullOrWhiteSpace(depid))
            {
                var dep = departs.FirstOrDefault(c => c.DEPID.ToString() == depid);
                if (dep?.PARENTID != null && dep.PARENTID != -1 && dep.DEPID != dep.PARENTID)
                {

                    departArr.Add(dep.PARENTID.ToString());
                    FindParentDepId(departArr, departs);
                }
            }
        }
    }
}