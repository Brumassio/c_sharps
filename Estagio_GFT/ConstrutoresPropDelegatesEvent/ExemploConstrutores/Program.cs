using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);
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

        static void demo3()
        {
            Aluno p1 = new Aluno("Joseph","Robert","PAA");
            p1.Apresentar();
        }

        static void demo4()
        {
            Data d1 = new Data();
            //d1.SetMes(333);
            
            d1.Mes = 20;
            d1.ApresentarMes();
        }
        static void demo5()
        {
            const double pi = 3.14;
            System.Console.WriteLine(pi);
        }
        static void demo6()
        {
            //Operacao op = Calculadora.Somar;
            //op(12,1);
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(12,1);
        }
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10,20);
            m.Somar();
        }
    }
}