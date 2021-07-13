using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class REVIEW_OPERS
    {
        public REVIEW_OPERS()
        {
            ID = 0;
        }
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_REVIEW_OPERS";
        }

    }
}
