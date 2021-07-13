using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial  class RECORD_ATTACHMENT
    {
        public RECORD_ATTACHMENT()
        {
            ID = 0;
        }
        public override string GetSequence()
        {
            return "SEQ_RECORD_ATTACHMENT";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}
