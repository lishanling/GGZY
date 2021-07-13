using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class OPERTION_RECORD
    {
        public   OPERTION_RECORD()
        {
            ID = 0;
        }
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_OPERTION_RECORD";
        }

    }
}
