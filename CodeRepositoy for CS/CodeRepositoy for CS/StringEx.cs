using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepositoy_for_CS {
   public static class Expand {
        public static bool IsNULLOREmpty(this string str)
        {
            return str.Equals(string.Empty) || str == null;
        }


    }

}
