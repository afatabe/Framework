using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace System.Resource_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Resources.ResourceManager rm = new ResourceManager(typeof(System.Resource_Example.Main));
            System.Globalization.CultureInfo ci = new Globalization.CultureInfo("pt-BR");
            string d = rm.GetString("DESCRICAO",ci);

            Console.Write(d);
            Console.ReadKey();

//            ResourceHelper.getResource("DESCRICAO");


        }
    }
}
