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
    public partial class PtZxtsBtsrService 
    {
        /// <summary>
        /// 通过投诉编号查找被投诉人信息
        /// </summary>
        /// <param name="tsCode"></param>
        /// <returns></returns>
        public List<PtZxtsBtsrModel> GetBtsrByTsCode(string tsCode)
        {
            var list = FromWhere()
                .InnerJoin<PT_ZXTS>(PT_ZXTS._.ID == PT_ZXTS_BTSR._.TS_ID && PT_ZXTS._.CODE == tsCode)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "84" && SYS_DIC._.VALUE == PT_ZXTS_BTSR._.TYPE)
                .ToList<PtZxtsBtsrModel>();
            return list;
        }


        /// <summary>
        /// 通过投诉ID查找被投诉人信息
        /// </summary>
        /// <param name="tsId"></param>
        /// <returns></returns>
        public List<PtZxtsBtsrModel> GetBtsrByTsId(decimal? tsId)
        {
            var list = FromWhere(PT_ZXTS_BTSR._.TS_ID==tsId)
                .LeftJoin<SYS_DIC>(SYS_DIC._.TYPE == "84" && SYS_DIC._.VALUE == PT_ZXTS_BTSR._.TYPE)
                .Select(PT_ZXTS_BTSR._.All,SYS_DIC._.TEXT.As("TYPE_TEXT"))
                .ToList<PtZxtsBtsrModel>();
            return list;
        }
    }
}