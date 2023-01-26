using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Condicionais:IFundamentos
    {
        private Condicionais() { }

        private static Condicionais _instance;

        public static Condicionais GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Condicionais();
            }
            return _instance;
        }

        public void run()
        {
            MostraCondicionais();
        }


        private void GetTodosMeses()
        {

        }

        private void MostraCondicionais()
        {
            Console.WriteLine("\n Condicionais: ");
            const string APROVADO = "Aprovado!";
            const string REPROVADO = "Reprovado!";
            const string EM_REC = "Em Recuperação";

            Console.Write("[IF] Digite a nota: ");
            decimal nota = Convert.ToDecimal(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine(APROVADO);
            }
            else if (nota >= 4 && nota < 5)
            {
                Console.WriteLine(EM_REC);
            }
            else
            {
                Console.WriteLine(REPROVADO);
            }

            Console.Write("[SWITCH] Digite um mês: ");
            string mes = Console.ReadLine();

            /* Criando uma lista com os meses que tem 30 dias,
             * pra dai checar se a string pega ta nesses meses
             */
            List<String> mesesComTrinta = new List<String>();
            mesesComTrinta.Add("ABRIL");
            mesesComTrinta.Add("JUNHO");
            mesesComTrinta.Add("SETEMBRO");
            mesesComTrinta.Add("NOVEMBRO");
            bool temTrintaDias = mesesComTrinta.Contains(mes);

            switch (mes.ToUpper()) {
                case "FEVEREIRO":
                    int CurrentYear = DateTime.Now.Year;
                    if (DateTime.IsLeapYear(CurrentYear))
                    {
                        Console.WriteLine("29 dias.");
                    } else
                    {
                        Console.WriteLine("28 dias.");
                    }
                    break;
                default: 
                    if (temTrintaDias)
                    {
                        Console.WriteLine("30 dias.");
                    } else
                    {
                        Console.WriteLine("31 dias.");
                    }
                    break;

            }
        }
    }
}
