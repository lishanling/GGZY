using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class RECORD_WRITTEN
    {
        public RECORD_WRITTEN()
        {

        }
        public override string GetSequence()
        {
            return "SEQ_RECORD_WRITTEN";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }

}
