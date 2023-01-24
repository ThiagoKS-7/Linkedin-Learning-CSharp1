using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Tipos
    {
        public void ConhecendoTipos()
        {
            /* Lembrete de tipos de variáveis EXPLICITAS*/

            int i = 10;
            Console.WriteLine($"Valor da int: {i}");

            float f = 10.9f; // precisa ter f apos o numero
            Console.WriteLine($"Valor da float: {f}");

            double d = 20.9d; // não precisa do f, mas pode ter o d pra aumentar precisão
            Console.WriteLine($"Valor da double: {d}");

            decimal dec = 30.9m; // pode colocar o m no fim
            Console.WriteLine($"Valor da decimal: {dec}");

            /*
             * DECIMAIS PRECISAS - Use decimal (16 bytes)
             * PONTO FLUTUANTE - Float (4bytes) ou double (8bytes), dependendo do tamanho
            */

            // https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

            bool b1 = true;
            bool b2 = false;
            Console.WriteLine($"Valor das bool: b1 {b1}, b2 {b2}");

            char c2 = 'A';
            Console.WriteLine($"Valor da char {c2}");

            string s = "Thiago";
            Console.WriteLine($"Valor da Astring: {s}");

            /* VARIÁVEIS IMPLICITAS */
            var cidade = "Teste";
            var idade = 31;
            Console.WriteLine($"Cidade: {cidade}, idade: {idade}");

            /* CONSTANTES */



        }
    }
}
