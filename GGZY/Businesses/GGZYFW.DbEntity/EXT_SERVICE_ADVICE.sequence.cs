using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
   
    public partial class EXT_SERVICE_ADVICE : FwEntity
    {
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_EXT_SERVICE_ADVICE";
        }
    }
}