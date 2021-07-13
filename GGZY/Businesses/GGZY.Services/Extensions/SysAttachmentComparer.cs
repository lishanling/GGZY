using GGZYJD.DbEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.Extensions
{
    public class SysAttachmentComparer: IEqualityComparer<SYS_ATTACHMENT>
    {
        public bool Equals(SYS_ATTACHMENT x, SYS_ATTACHMENT y)

        {

            if (x == null)

                return y == null;

            return x.GUID == y.GUID;

        }





        public int GetHashCode(SYS_ATTACHMENT obj)

        {

            if (obj == null)

                return 0;

            return obj.GUID.GetHashCode();

        }

    }


}
