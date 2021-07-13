using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class PtZxtsRevokeService 
    {
        public PT_ZXTS_REVOKE FindLastRevokeByTsId(decimal? tsId)
        {
          var revoke=  Jd.PtZxtsRevokeService.FromWhere(PT_ZXTS_REVOKE._.TS_ID == tsId)
                .OrderBy(PT_ZXTS_REVOKE._.ID.Desc).First();
          return revoke;
        }
	}
}