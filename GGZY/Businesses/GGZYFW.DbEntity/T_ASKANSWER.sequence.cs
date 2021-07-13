using System;
using System.Data;
using Dos.ORM;

namespace GGZYFW.DbEntity
{
   
    public partial class T_ASKANSWER 
    {
        public override Field GetIdentityField()
        {
            return _.ID;
        }

        public override string GetSequence()
        {
            return "SEQ_T_ASKANSWER";
        }
    }
}