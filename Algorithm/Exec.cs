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

        /// <summary>
        /// 解密QQ的算法
        /// </summary>
        /// <returns>The qq.</returns>
        /// <param name="qq">Qq.</param>
        public string DecryptQQ(string qq)
        {
            string result = "";
            Queue que = new Queue();
            foreach (var item in qq)
            {
                que.Enqueue(item);
            }
            for (int i = 0; i < qq.Length; i++)
            {
                result += que.Dequeue();
                if (que.Count != 0)
                {
                    que.Enqueue(que.Dequeue());
                }
            }
            return result;
        }
    }
}
