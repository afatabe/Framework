using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("http://www.devmedia.com.br/system-io-file-curso-de-introducao-ao-net-framework-11/26200");

            File.AppendAllText(@"c:\bk\1.txt", sb.ToString());


            string[] values = { "Linha 1", "Linha 2", "Linha 3" };
            File.AppendAllLines(@"c:\bk\2.txt", values);


            // File.Copy(@"c:\bk\1.txt", @"c:\bk\1.bk");

            File.Encrypt(@"c:\bk\2.txt");

        }
    }
}
