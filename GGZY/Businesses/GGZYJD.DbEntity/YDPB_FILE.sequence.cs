using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
   public partial class YDPB_FILE
    {
        public YDPB_FILE()
        {
            FILE_ID = 0;
        }
        public override string GetSequence()
        {
            return "SEQ_YDPB_FILE";
        }

        public override Field GetIdentityField()
        {
            return _.FILE_ID;
        }
    }
}
