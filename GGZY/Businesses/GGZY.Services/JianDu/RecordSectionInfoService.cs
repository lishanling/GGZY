using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class RecordSectionInfoService 
    {

        public List<RECORD_SECTION_INFO> List(decimal record_id, string bid_section_code = "")
        {
            var conditon = new WhereClipBuilder();
            conditon.And(RECORD_SECTION_INFO._.RECORD_ID == record_id);
            if(!String.IsNullOrWhiteSpace(bid_section_code))
            {
                conditon.And(RECORD_SECTION_INFO._.BID_SECTION_CODE == bid_section_code);
            }

            var bids = FindList<RECORD_SECTION_INFO>(conditon.ToWhereClip());
            return bids;
        }
	}
}