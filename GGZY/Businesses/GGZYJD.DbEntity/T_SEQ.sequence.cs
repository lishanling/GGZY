using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class T_SEQ : JdEntity
    {
        public override string GetSequence()
        {
            return "SEQ_T_SEQ";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
            //return base.GetIdentityField();
        }
    }
}
