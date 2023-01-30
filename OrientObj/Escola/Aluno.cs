using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientObj.Escola
{
    public class Aluno : Usuario
    {
        public int Matricula { get; }
        public decimal Media { get; private set; }
        public List<Materia> Materias { get; set; }

        public Aluno() : base()
        {
            Materias = new List<Materia>();
        }

        public Aluno(string nome, string email, int matricula, decimal n1, decimal n2, decimal n3) : base(nome, email)
        {
            Materias = new List<Materia>();
            Matricula = matricula;
            CalcularMedia(n1, n2, n3);
            Console.WriteLine("Aluno criado com sucesso!");
            Login();
        }

        public override void Login()
        {
            Console.WriteLine($"Aluno {Nome} logou.");
        }

        private void CalcularMedia(decimal n1, decimal n2, decimal n3)
        {
            this.Media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Média calculada com sucesso!");
        }

        public void criaCurriculoEscolar(List<Materia> mats)
        {
            AdicionaMateria(mats);
        }

        private bool ChecaMateria(Materia mat)
        {
            return this.Materias.Contains(mat);
        }

        public void AdicionaMateria(List<Materia> mats)
        {
            foreach (Materia m in mats)
            {
                if (!ChecaMateria(m))
                {
                    Materias.Add(m);
                }
            }
            Console.WriteLine("Materia adicionada!");
        }

        public void RemoveMateria(List<Materia> mats)
        {
            foreach (Materia m in mats)
            {
                if (!ChecaMateria(m))
                {
                    Materias.Remove(m);
                }
            }
            Console.WriteLine("Materia removida!");
        }


        public void MostraInfo()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine($"Nome: {Nome}\nMatrícula: {Matricula}\nMédia: {Media}");
        }
    }
}
