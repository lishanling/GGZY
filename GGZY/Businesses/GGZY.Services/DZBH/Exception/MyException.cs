using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGZY.Services.DZBH
{
    public class MyException : System.Exception
    {
        public MyException(string msg) : base(msg)
        {

        }
    }
}
