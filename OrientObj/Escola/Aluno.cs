using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientObj.Escola
{
    public class Aluno
    {
        public string Nome { get; }
        public int Matricula { get; }
        public decimal Media { get; }

        public Aluno(string name, int matricula, decimal media)
        {
            Nome = name;
            Matricula = matricula;
            Media = media;
        }

        public void MostraInfo()
        {
            Console.WriteLine($"Nome: {Nome}\nMatrícula: {Matricula}\nMédia: {Media}");
        }
    }
}
