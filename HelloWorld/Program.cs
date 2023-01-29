using System;
using System.Collections;
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
            dynamic[] fundamentos =
            {
                Tipos.GetInstance(),
                Operadores.GetInstance(),
                Strings.GetInstance(),
                Condicionais.GetInstance(),
                Loops.GetInstance(),
                Colecoes.GetInstance(),
            };
            foreach (Fundamento item in fundamentos)
            {
                item.run();
            }
            Console.Write("\n Clique qualquer tecla para sair... ");
            Console.ReadLine();
        }
    }
}
