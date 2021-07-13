using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Cache;
using GGZY.Core.Models;
using GGZY.Core.Utils;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class ZjBidDocCharactCodeService
    {
        /// <summary>
        /// 软硬件雷同查询功能
        /// </summary>
        /// <param name="model"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public BootstrapTableResult<ZjSoftwareAndHardwareSimilarModel> SoftwareAndHardwareSimilar(ZJ_BID_DOC_CHARACT_CODE model, SearchCondition search)
        {
            var condition = ConditionBuilder(model);
            if (search.BeginTime.HasValue)
            {
                condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_TM>=search.BeginTime);
            }
            if (search.EndTime.HasValue)
            {
                condition.And(ZJ_BID_DOC_CHARACT_CODE._.M_TM <= search.EndTime);
            }
            var count = Count(condition);
            var pageList = FromWhere(condition.ToWhereClip())
                .LeftJoin<TENDER_PROJECT>(TENDER_PROJECT._.TENDER_PROJECT_CODE_OLD1 == ZJ_BID_DOC_CHARACT_CODE._.TENDER_PROJECT_CODE)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "2002" && SYS_DIC._.VALUE == TENDER_PROJECT._.TENDER_PROJECT_TYPE)
                .Page(search.PageSize,search.PageNo)
                .Select(
                    ZJ_BID_DOC_CHARACT_CODE._.BIDDER_NAME,
                    ZJ_BID_DOC_CHARACT_CODE._.BIDDER_ORG_CODE,
                    ZJ_BID_DOC_CHARACT_CODE._.TENDER_PROJECT_CODE,
                    TENDER_PROJECT._.TENDER_PROJECT_NAME,
                    SYS_DIC._.TEXT.As("TENDER_PROJECT_TYPE"),
                    ZJ_BID_DOC_CHARACT_CODE._.MAC_ADDRESS,
                    ZJ_BID_DOC_CHARACT_CODE._.CPU_ID,
                    ZJ_BID_DOC_CHARACT_CODE._.HARD_DISK_SERIAL_NUMBER,
                    ZJ_BID_DOC_CHARACT_CODE._.MEMORY_SERIAL_NUMBER,
                    ZJ_BID_DOC_CHARACT_CODE._.M_TM
                    ).ToList<ZjSoftwareAndHardwareSimilarModel>()
                .Select(c =>
                {
                    Similar(c);
                    return c;
                }).ToBootstrapTableList(count);
            return pageList;
        }
        /// <summary>
        /// 软硬件信息（Mac地址、CPU序列号、硬盘序列号，预算软件信息锁序列号） 是否与本投标项目的其他投标人雷同
        /// </summary>
        /// <param name="model"></param>
        public void Similar(ZjSoftwareAndHardwareSimilarModel model)
        {
            var condition = ZJ_BID_DOC_CHARACT_CODE._.TENDER_PROJECT_CODE == model.TENDER_PROJECT_CODE
                            && ZJ_BID_DOC_CHARACT_CODE._.MAC_ADDRESS == model.MAC_ADDRESS
                            && ZJ_BID_DOC_CHARACT_CODE._.CPU_ID == model.CPU_ID
                            && ZJ_BID_DOC_CHARACT_CODE._.HARD_DISK_SERIAL_NUMBER == model.HARD_DISK_SERIAL_NUMBER
                            && ZJ_BID_DOC_CHARACT_CODE._.MEMORY_SERIAL_NUMBER == model.MEMORY_SERIAL_NUMBER
                            && ZJ_BID_DOC_CHARACT_CODE._.BIDDER_ORG_CODE != model.BIDDER_ORG_CODE;

            model.Similar = Cache.Get($"TENDER_PROJECT_CODE:{model.TENDER_PROJECT_CODE}:ORG:{model.BIDDER_ORG_CODE}", () => FromWhere(condition)
                .Select(
                    ZJ_BID_DOC_CHARACT_CODE._.BIDDER_NAME,
                    ZJ_BID_DOC_CHARACT_CODE._.BIDDER_ORG_CODE,
                    ZJ_BID_DOC_CHARACT_CODE._.TENDER_PROJECT_CODE,
                    ZJ_BID_DOC_CHARACT_CODE._.MAC_ADDRESS,
                    ZJ_BID_DOC_CHARACT_CODE._.CPU_ID,
                    ZJ_BID_DOC_CHARACT_CODE._.HARD_DISK_SERIAL_NUMBER,
                    ZJ_BID_DOC_CHARACT_CODE._.MEMORY_SERIAL_NUMBER,
                    ZJ_BID_DOC_CHARACT_CODE._.M_TM).ToList<ZjSoftwareAndHardwareSimilarModel>());
        }
    }
}