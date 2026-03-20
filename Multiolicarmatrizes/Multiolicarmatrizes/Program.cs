using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiolicarmatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] Resultado = new int[2, 2];

            Console.WriteLine("Preencher a matriz #1");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencher a matriz #2");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2. Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado de matriz #1 x matriz #2");
            Resultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            Resultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            Resultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            Resultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + Resultado[0, 0] + "][" + Resultado[0, 1] + "]");
            Console.WriteLine("[" + Resultado[1, 0] + "][" + Resultado[1, 1] + "]");

            Console.ReadKey();
        }


    }
}
