/*
 * Criar programa para armazenar 
 * matricula
 * nome
 * media
 * de alunos de uma escola
 */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientObj.Escola;

namespace OrientObj
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Orientação a Objeto");
            Aluno a1 = new Aluno("Teste", 1, 9);
            a1.MostraInfo();
            Console.Write("\n Clique qualquer tecla para sair... ");
            Console.ReadLine();
        }
    }
}
