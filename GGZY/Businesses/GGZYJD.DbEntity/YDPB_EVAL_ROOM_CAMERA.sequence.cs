using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial  class YDPB_EVAL_ROOM_CAMERA
    {
        public YDPB_EVAL_ROOM_CAMERA()
        {
            IS_DELETE = 0;
            ID = 0;
        }
        public override string GetSequence()
        {
            return "SEQ_YDPB_EVAL_ROOM_CAMERA";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
            //return base.GetIdentityField();
        }
    }
}
