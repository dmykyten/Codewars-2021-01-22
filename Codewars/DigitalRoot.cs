using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class DigitalRoot               //https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp
    {
        public static int SumOfDigits(long n)
        {
            /*int result = 0;
            string line = n.ToString();
            foreach(var value in line)
            {
                result += value - 48;
            }
            if(result >= 10)
            {
                return SumOfDigits(result);
            }
            return result;*/
            int result = n.ToString().Sum(x => int.Parse(x.ToString()));
            return result >= 10 ? SumOfDigits(result) : result;
        }
    }
}
