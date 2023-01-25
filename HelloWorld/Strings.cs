using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Strings
    {
        private Strings() { }

        private static Strings _instance;

        public static Strings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Strings();
            }
            return _instance;
        }

        public void run ()
        {
            MostraStrings();
        }

        private void MostraStrings()
        {
            Console.WriteLine("\nStrings:");
            string frase = "O dia está lindo!";

            Console.WriteLine($"Frase: {frase}, substr: {frase.Substring(0,5)}");
            Console.WriteLine($"Trim: {frase.Trim()}, TrimEnd: {frase.TrimEnd()}, TrimStart {frase.TrimStart()}");
            Console.WriteLine($"Trim de char especifico: {frase.Trim('!')}");

            string cpf = "34567890";

            Console.WriteLine($"Cpf com padleft: {cpf.PadLeft(11, '0')}");

            string frase2 = frase.Trim('!') + " e ensolarado!";
            Console.WriteLine($"Frase concatenada: {frase2}");

        }
    }
}
