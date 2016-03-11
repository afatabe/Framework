using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Text_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("anderson");
            sb.Append(" fabiano");
            sb.Insert(5, "001");
            sb.Remove(1, 2);
            sb.Replace("f", "t");

            Console.Write(sb.ToString());
            Console.ReadKey();

            #endregion




        }
    }
}
