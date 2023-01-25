using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            Tipos tp = new Tipos();
            Operadores op = new Operadores();
            tp.ConhecendoTipos();
            op.MostraOperadores();
        }
    }
}
