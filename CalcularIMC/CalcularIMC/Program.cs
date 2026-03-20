using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("imforme o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("imforme a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("n/IMC = " + valorIMC + " -> Abaixo do peso.");
            }
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("n/IMC = " + valorIMC + " -> Normal.");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("n/IMC = " + valorIMC + " -> Acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine("n/IMC = " + valorIMC + " -> Obeso");
            }
            else
            {
                Console.WriteLine("n/IMC = " + valorIMC + " -> Obeso mórbido."); 
            }

            Console.ReadKey();
        }
    }
}
