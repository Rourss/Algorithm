using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex =new Exec();
            #region
            //var num = ex.FindPerfectNum(10000);
            //if (num != null)
            //{
            //    foreach (var item in num)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not PerfectNumber");
            //}
            #endregion

            #region
            //var str = ex.DecryptQQ("631758924");
            //foreach (var item in str)
            //{
            //    Console.Write(item);
            //}
            #endregion

            #region
            //var str = ex.DecrypttQQ("631758924");
            //foreach (var item in str)
            //{
            //    Console.Write(item);
            //}
            #endregion

            #region
            //Console.WriteLine();
            //string huiwen = "12321";
            //var wt = ex.LIFO(huiwen);
            //Console.WriteLine(wt);
            #endregion

            #region
            Console.WriteLine(ex.CK(3));
            Console.WriteLine(ex.Fib(2));
            #endregion
            Console.ReadKey();
        }
    }
}
