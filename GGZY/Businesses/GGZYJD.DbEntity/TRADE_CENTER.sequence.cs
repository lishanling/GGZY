using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    /// <summary>
    /// 交易中心列表
    /// </summary>
    public partial class TRADE_CENTER
    {
        public override string GetSequence()
        {
            return "SEQ_TRADE_CENTER";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
            //return base.GetIdentityField();
        }
    }
}
