using System;
using static System.Console;

namespace compar_value_ref // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        class Numero
        {
            public int N { get; set; }
            public Numero(int n)
            {
                N = n;
            }
        }
        static void Main(string[] args)
        {
            Numero i = new Numero(2);
            Numero j = new Numero(2);
            //int a = 2;
            //int b = 2;
            if(i.N == j.N)
            {
                WriteLine("a e b são iguais");
            }
            else
            {
                WriteLine("a e b são diferentes!");
            }



        }
    }
}