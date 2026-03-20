using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condição if else + if else if
            //int valor = 15;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição alternativa 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}
            #endregion

            #region Condição aninhadas
            //int numero = 10;

            //if (numero > 5)
            //{
            //    Console.Write("O numero é menor que 5.");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e tambem é Par");
            //    }
            //    else 
            //    {
            //        Console.WriteLine(" mais não é Par");
            //    }
            #endregion

            #region Operador Ternário
            //int numero = 10;
            //string mensagem = numero > 5 ? "maior que 5" : "menor que 5";

            //mensagem = numero > 5 ? "maior que 5" : "menor que 5";

            //if (numero > 5)
            //{
            //    mensagem = "maior que 5";
            //}
            //else 
            //{ 
            //    mensagem = "menor que 5";
            //}
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
