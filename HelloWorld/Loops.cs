using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Loops: Fundamento
    {
        private Loops() { }

        private static Loops _instance;

        public static Loops GetInstance()
        {
            if (_instance == null )
            {
                _instance = new Loops();
            }
            return _instance;
        }
        public override void run ()
        {
            MostraLoops();
        }

        private void MostraLoops()
        {
            int[] arInt = new int[] { 99, 98, 92, 97, 95};
            int i = 0;
            int j = 0;
            Console.WriteLine("\n Loops: ");

            Console.WriteLine("While 1: ");
            while (i < 10)
             {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\nWhile 2: ");
            while (j < arInt.Length)
            {
                int num = arInt[j];
                Console.WriteLine($"{j} - {arInt} => {arInt[j]}");
                j++;
            }

            Console.WriteLine("\nFor 1: ");
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("\nFor 2: ");
            for (int k = 0; k < arInt.Length; k++)
            {
                Console.WriteLine($"{k} - {arInt} => {arInt[k]}");
            }

            Console.WriteLine("\nForeach: ");
            foreach(int num in arInt)
            {
                Console.WriteLine(num);
            }
        }
    }
}
