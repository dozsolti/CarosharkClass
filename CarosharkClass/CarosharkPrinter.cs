using System;
using System.Collections;
using System.Text;

namespace CarosharkClass
{
    public partial class Caroshark
    {
        public static class Printer
        {
            public static void Print(object a)
            {
                if (a is String)
                {
                    Console.WriteLine(a.ToString());
                    Console.WriteLine();
                }
                else if (a is IEnumerable[])
                    PrintMatrix(a as IEnumerable[]);
                else if (a is IEnumerable)
                    PrintVector(a as IEnumerable);
                else
                {
                    Console.WriteLine(a.ToString());
                    Console.WriteLine();
                }
               
            }

            public static void PrintVector(IEnumerable v)
            {
                StringBuilder str = new StringBuilder();
                
                foreach (object item in v)
                    str.Append(item.ToString() + ", ");

                str.Remove(str.Length - 2, 2);

                Console.WriteLine(str.ToString());
                Console.WriteLine();

            }



            public static void PrintMatrix(IEnumerable[] v)
            {
                StringBuilder str = new StringBuilder();

                foreach (IEnumerable item in v)
                {
                    str.AppendLine();
                    foreach (object item2 in item)
                        str.Append(item2.ToString() + ", ");
                }

                str.Remove(str.Length - 2, 2);
                Console.WriteLine(str.ToString());
                Console.WriteLine();
            }
        }
    }
}
