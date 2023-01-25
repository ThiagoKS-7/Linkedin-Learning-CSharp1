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

            Tipos tp = Tipos.GetInstance();
            Operadores op = Operadores.GetInstance();
            Strings st = Strings.GetInstance();

            tp.run();
            op.run();
            st.run();
        }
    }
}
