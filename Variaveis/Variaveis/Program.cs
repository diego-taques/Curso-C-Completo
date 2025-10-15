using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas 
        {
            minimo = 03,
            media = 06,
            maximo = 10
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numeros Integrais
            //// Intrgral assinado
            //sbyte num1 = 10; // 8 bits - de -128 a 127
            //short num2 = 20; // 16 bits - -32.768 a 32.767
            //int num3 = 30; // 32 bits - -2.147.483.648 a 2.147.483.647
            //long num4 = 40; // 64 bits - -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// Integral sem sial
            //byte num5 = 50; // 8 bits intervalo de 0 a 255
            //ushort num6 = 60; // 16 bits - de 0 a 65.535
            //uint num7 = 70; // 32 bits - de 0 a 4.294.967.295
            //ulong num8 = 80; // 64 bits - de 0 a 18.446.744.073.709.551.615

            //sbyte numero;

            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Numeros Reais
            //float real1 = 100.75f; // 32 bits, de 1,5 x 10−45 a 3,4 x 1038, precisão de 7 dígitos => sufixo f, Ex.: 10.5f
            //double real2 = 12500.45; // 64 bits, de 5,0 x 10−324 a 1,7 x 10308, precisão de 15-16 dígitos => sufixo d (opcional), Ex.: 10.5d
            //decimal real3 = 752538.457m; // 128 bits, intervalo de pelo menos 1,0 x 10−28 a 7,9 x 1028, com precisão de 28-29 dígitos => sufixo m, Ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caracteres
            //char letra = '\u0041';
            //char escape = '\0';
            //char literal = 'C';
            #endregion

            #region boolean
            //bool vereficar = false;
            //vereficar = true;
            #endregion

            #region string (cadeia de caracteres)
            //string texto = @"Gabriel Artigas\n 1985 @@??$$";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implicito (var)
            //var valor = 100;
            //valor = 20;
            //valor = "Gabriel";
            #endregion

            #region Tipo objetc (Bade para todos os tipos)
            //object obj1 = false;
            //obj1 = 100;
            //obj1 = "Gabriel Artigas";
            #endregion

            #region Constantes
            //const double pi = 3.1415;
            //const string nome = "Gabriel Artigas";
            #endregion

            #region Enumerações
            //Notas notaAluno = Notas.media;
            #endregion

            #region struct
            //Pessoa p1 = new Pessoa();

            //p1.nome = "Gabriel Artigas";
            //p1.idade = 38;
            //p1.altura = 1.80;

            //Pessoa p2 = new Pessoa() 
            //{ 
            //   nome = "Maria Silva",
            //   idade = 25,
            //   altura = 1.65
            //};

            //p1.nome = "João Souza";

            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.idade);
            //Console.WriteLine(p1.altura);

            //Console.WriteLine();

            //Console.WriteLine(p2.nome);
            //Console.WriteLine(p2.idade);
            //Console.WriteLine(p2.altura);
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
