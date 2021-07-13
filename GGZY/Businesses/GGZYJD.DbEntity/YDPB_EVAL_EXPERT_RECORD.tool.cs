﻿using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class YDPB_EVAL_EXPERT_RECORD : JdEntity
    {
        public YDPB_EVAL_EXPERT_RECORD()
        {
            ID = 0;
            IS_DELETE = 0;
        }

        public override string GetSequence()
        {
            return "SEQ_YDPB_EVAL_EXPERT_RECORD";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}
