using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Extensions
{
    public class FwSysAttachmentComparer : IEqualityComparer<GGZYFW.DbEntity.SYS_ATTACHMENT>
    {
        public bool Equals(GGZYFW.DbEntity.SYS_ATTACHMENT x, GGZYFW.DbEntity.SYS_ATTACHMENT y)

        {

            if (x == null)

                return y == null;

            return x.FILEPATH == y.FILEPATH;

        }





        public int GetHashCode(GGZYFW.DbEntity.SYS_ATTACHMENT obj)

        {

            if (obj == null)

                return 0;

            return obj.FILEPATH.GetHashCode();

        }

    }
}
