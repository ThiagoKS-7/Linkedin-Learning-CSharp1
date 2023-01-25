using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Operadores
    {
        public void MostraOperadores()
        {
            Console.WriteLine("\nOperadores: ");
            // Operadores Aritméticos
            int adicao = 5 + 3;
            int subtracao = 5 - 3;
            int multiplicacao = 5 * 3;
            int divisao = 15 / 3;
            int expr = (1 + 2) * 5 - 2 / 2;
            Console.WriteLine($"Resultados: {adicao}, {subtracao}, {multiplicacao}, {divisao}, {expr}");

            //Operadores relacionais
            string cidade1 = "teste";
            string cidade2 = "teste2";

            bool ret1 = cidade1 == cidade2;
            bool ret2 = cidade1 != cidade2;
            Console.WriteLine($"Retornos dos op rel => ret1: {ret1}, ret2: {ret2}");

            int i = 2;
            int j = 4;

            Console.WriteLine($"Comaparando numeros=> i = j: {i == j}, i !=j {i != j}");

        }
    }
}
