using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex =new Exec();
            #region
            var num = ex.FindPerfectNum(10000);
            if (num != null)
            {
                foreach (var item in num)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Not PerfectNumber");
            }
            #endregion
        }
    }
}
