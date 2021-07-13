using System;
using System.Collections.Generic;
using System.Linq;
using Dos.ORM;
using GGZY.Core.Models;
using GGZY.Services.Base;
using GGZYJD.DbEntity;

namespace GGZY.Services.JianDu
{
    public partial class TRecordRegulatorService 
    {
        public List<LabelValueModel> FindJianDuDepartment()
        {
            var ls = FindAll().Select(c => new LabelValueModel {Label = c.RNAME, Value = c.RCODE}).ToList();
            return ls;
        }
	}
}