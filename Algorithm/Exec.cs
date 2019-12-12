using System;
using System.Collections;

namespace Algorithm
{
    public class Exec
    {
        /// <summary>
        /// 完美数的算法
        /// </summary>
        /// <returns>The perfect number.</returns>
        /// <param name="end">End.</param>
        public ArrayList FindPerfectNum(int end)
        {
            ArrayList arr = new ArrayList();
            int sum = 0;
            DateTime startime = DateTime.Now;
            for (int i = 1; i < end; i++)
            {
                for (int j = 1; j < i / 2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    arr.Add(sum);
                }
                sum = 0;
            }
            DateTime endtime = DateTime.Now;
            arr.Add((endtime - startime).TotalSeconds);
            return arr;
        }
    }
}
