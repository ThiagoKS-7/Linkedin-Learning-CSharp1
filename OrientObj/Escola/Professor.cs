using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientObj.Escola
{
    public class Professor : Usuario
    {
        public string MateriaLecionada { get; set; }

        public Professor(string nome, string email, string materia)
        {
            Nome = nome;
            Email = email;
            MateriaLecionada = materia;
        }

    }
}
