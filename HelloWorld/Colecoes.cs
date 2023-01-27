using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Colecoes : IFundamentos
    {
        private Colecoes() { }

        private static Colecoes _instance;

        public static Colecoes GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Colecoes();
            }
            return _instance;
        }

        public void run()
        {
            MostraColecoes();
        }

        private void MostraListas()
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
            int num = numeros[0];
            Console.WriteLine($"{num} - Length {numeros.Length}");

            Console.WriteLine("List");
            List<int> listNumeros = new List<int>();
            List<int> listNums = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> listDesordenada = new List<int>() { 1, 0, 9, 6, 3 };
            listNumeros.Add(6);
            listNums.Remove(2);
            // Para limpar lista, use arr.Clear()

            Console.WriteLine($"listNumeros - {listNumeros} - {listNumeros.Count}");
            Console.WriteLine($"listNumeros - {listNums} - {listNums.Count}");

            Console.WriteLine("\n ListNumeros: ");
            foreach (int n in listNumeros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n ListNums: ");
            foreach (int n2 in listNums)
            {
                Console.WriteLine(n2);
            }
            Console.WriteLine($"Indice 0 com ElementAt na listNumeros: {listNumeros.ElementAt(0)}");
            Console.WriteLine("\n Sort na lista desordenada:");
            foreach (int p in listDesordenada)
            {
                Console.WriteLine(p);
            }
        }

        private void MostraDict()
        {
            string[] listEstados = { "RJ", "SP", "SC" };

            Dictionary<int, string> estados = new Dictionary<int, string>();
            for (int estInd = 0; estInd < listEstados.Length; estInd++)
            {
                estados.TryAdd(estInd, listEstados[estInd]);
            }

            Console.WriteLine("\nDados no dict: ");
            foreach (string estado in estados.Values)
            {
                Console.WriteLine(estado);
            }
            string est = "-";
            estados.TryGetValue(3, out est);
        }

        private void MostraQueue()
        {
            /*
             * FIFO - First in First Out - é basicamente a regra de uma fila (nao pode mudar as posicoes dps de atribuir)
             */
            Console.WriteLine("Na Queue: ");
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Remova-me");
            fila.Enqueue("Ola");
            fila.Enqueue("Pessoal");
            fila.Enqueue("Do linkedin!");
            fila.Dequeue(); // remove o primeiro;
            foreach (Object obj in fila)
            {
                Console.WriteLine(obj);
            }
        }
        private void MostraColecoes()
        {
            Console.WriteLine("\n Colecoes: ");
            MostraListas();
            MostraDict();
            MostraQueue();
        }
    }
}
