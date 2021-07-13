using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZYJD.DbEntity
{
    public partial class YDPB_EVAL_ROOM
    {
        public YDPB_EVAL_ROOM()
        {
            ID = 0;
            IS_DELETE = 0;
        }
        /// <summary>
        /// 自增长Sequence名称
        /// </summary>
        /// <returns></returns>
        public override string GetSequence()
        {
            return "SEQ_YDPB_EVAL_ROOM";
        }
        /// <summary>
        /// 自增长字段
        /// </summary>
        /// <returns></returns>
        public override Field GetIdentityField()
        {
            return _.ID;
        }
    }
}
