using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarosharkClass
{
    public partial class Caroshark
    {
        public static class File
        {
            #region Read
            public static List<string> GetAsList(string file)
            {
                TextReader dLoad = new StreamReader(file);
                string buffer;
                List<string> str = new List<string>();

                while ((buffer = dLoad.ReadLine()) != null)
                    str.Add(buffer);
                dLoad.Close();
                return str;
            }

            public static string GetFullContent(string file)
            {
                TextReader dLoad = new StreamReader(file);
                string buffer;
                StringBuilder str = new StringBuilder();

                while ((buffer = dLoad.ReadLine()) != null)
                    str.AppendLine(buffer);
                dLoad.Close();
                return str.ToString();
            }

            #endregion

            #region Write
            public static void WriteFullContent(string file, string content)
            {
                TextWriter dLoad = new StreamWriter(file);
                dLoad.WriteLine(content);
                dLoad.Close();
            }
            public static void WriteList(string file, IEnumerable content)
            {
                TextWriter dLoad = new StreamWriter(file);
                foreach (object item in content)
                    dLoad.WriteLine(item.ToString());
                dLoad.Close();
            }
            #endregion
        }
    }
}
