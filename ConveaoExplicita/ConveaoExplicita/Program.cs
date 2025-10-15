using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveaoExplicita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort num1 = 100;
            byte num2 = (byte)num1;

            float num3 = 2500.786f;
            int num4 = (int)1985.75f;

            char letra = (char)97;

            Console.WriteLine(letra);
            Console.ReadKey();
        }
    }
}
