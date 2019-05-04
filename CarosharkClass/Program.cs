using System;
using System.Collections.Generic;
using static CarosharkClass.Caroshark;
using static CarosharkClass.Caroshark.Printer;

namespace CarosharkClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[][] b = {
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 1, 2, 3, 4 }
            };
            List<int> c = new List<int>(){ 1, 2, 3, 4 };

            
            File.WriteList(@"..\TextFile2.txt",c);
            Print(File.GetAsList(@"..\TextFile2.txt"));

            Console.ReadKey();
        }
    }
}
