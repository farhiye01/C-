using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Util.Max(1, 2, 4, 5, 89, 20, -11));
            Console.WriteLine(Util.Max(2, 5, 5, 8));
        }
    }

    class Util
    {
        public static int Max(params int[] paramList)
        {
            int Max = paramList[0];
            for (int i = 1; i < paramList.Length; i++)
            {
                if (Max < paramList[i])
                    Max = paramList[i];
            }
            return Max;
        }

    }

}
