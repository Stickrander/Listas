using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_58
{
    internal class Program
    {

        static void PreencherA(double[] ALT)
        {
            for (int i = 0; i < ALT.Length; i++)
            {
                ALT[i] = double.Parse(Console.ReadLine());
            }
        }

        static int[] PreencherM()
        {
            int[] M = new int[10];
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = int.Parse(Console.ReadLine());
            }
            return M;
        }

        static void Analisa(double[] V1, int[] V2, ref int MMA, ref int MMEA,
                        out double AMA, out double AME)
        {
            AMA = double.MinValue;
            AME = double.MaxValue;

            for (int i = 0; i < V1.Length; i++)
            {
                if (V1[i] > AMA)
                {
                    AMA = V1[i];
                    MMA = V2[i];
                }
                if (V1[i] < AME)
                {
                    AME = V1[i];
                    MMEA = V2[i];
                }
            }
        }

        static void Main(string[] args)
        {

            double[] ALTURA = new double[10];
            PreencherA(ALTURA);

            int[] MATRICULA = PreencherM();

            double MAIORA, MENORA;
            int MATMAIOR = 0, MATMENOR = 0;

            Analisa(ALTURA, MATRICULA, ref MATMAIOR, ref MATMENOR,
                    out MAIORA, out MENORA);

            Console.WriteLine($"{MATMAIOR} {MATMENOR} {MAIORA} {MENORA}");

        }
    }
}
