using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    public class ThrowHelper
    {
        public static void ThrowIfTure(bool condition, string msg)
        {
            if (condition)
            {
                throw new MyException(msg);
            }
        }
    }
}
