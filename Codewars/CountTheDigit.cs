using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class CountTheDigit             //https://www.codewars.com/kata/566fc12495810954b1000030/train/csharp
    {
        public static int NbDig(int n, int d)
        {
            /*int result = 0;
            string temp = "";
            char digit = char.Parse(d.ToString());
            for(int i = 0; i != n; i++)
            {
                temp = (i * i).ToString();
                foreach(var value in temp)
                {
                    if(value == digit)
                    {
                        result++;
                    }
                }
            }
            -------------------------------------*/
            StringBuilder temp = new StringBuilder();
            char digit = char.Parse(d.ToString());
            for(int i = 0; i <= n; i++)
            {
                //Console.WriteLine(i * i);
                temp.Append((i * i).ToString());
            }
            return (temp.ToString()).Where(x => x == digit).Count();
        }
    }
}
