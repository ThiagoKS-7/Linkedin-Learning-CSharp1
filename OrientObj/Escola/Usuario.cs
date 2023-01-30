using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientObj.Escola
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        private string Senha { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public virtual void Login()
        {
            Console.WriteLine($"Usuario {Nome} logou.");
        }

        public void AlterarSenha(string senha)
        {
            this.Senha = senha;
            Console.WriteLine("Senha alterada com sucesso!");
        }
    }
}
