using System;
using System.Data;
using Dos.ORM;

namespace GGZYJD.DbEntity
{

    public partial class T_USER_EXTEND 
    {
        public override string GetSequence()
        {
            return "SEQ_T_USER_EXTEND";
        }

        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}