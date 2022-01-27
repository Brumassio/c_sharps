using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void demo1()
        {
            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);
            //Sempre será a mesma instância ! doidera
        }

        static void demo2()
        {
            Pessoa p1 = new Pessoa("Diogo","Brumassio");
            p1.Apresentar();
        }
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("Joseph","Robert","PAA");
            p1.Apresentar();
        }
    }
}