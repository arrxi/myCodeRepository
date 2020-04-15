using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepositoy_for_CS {
   public static class StringExtension {
        public static bool IsNULLOREmpty(this string str)
        {
            return str.Equals(string.Empty) || str == null;
        }
        public static string Mul(this string str, int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }

    }

}
