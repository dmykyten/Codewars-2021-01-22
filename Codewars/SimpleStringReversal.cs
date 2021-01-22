using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class SimpleStringReversal
    {
        public static String Solve(String s)
        {
            string result = "";
            result = String.Join("" ,s.Reverse().Where(x => x != ' '));
            for (int j = 0; j != s.Length; j++)
            {
                if (s[j] == ' ')
                {
                    result = result.Insert(j, " ");
                }
            }
            return result;
        }
    }
}
