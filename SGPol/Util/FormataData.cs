using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGPol.Util
{
    class FormatData
    {
        public static string FormataData(string data)
        {
            string dt = data.Replace("/","-");
            return dt;
        }
    }
}
