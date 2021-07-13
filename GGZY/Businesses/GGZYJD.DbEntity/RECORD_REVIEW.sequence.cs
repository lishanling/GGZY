using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial  class RECORD_REVIEW
    {
        public RECORD_REVIEW()
        {
            IS_SIGN = 0;
        }
        public override string GetSequence()
        {
            return "SEQ_RECORD_REVIEW";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}
