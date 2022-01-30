using System;
using POO_HEPA.Models;
using POO_HEPA.Interfaces;
using POO_HEPA.Helper;
using System.IO;

namespace POO_HEPA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void demo1()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Joseph";
            p1.Idade = 20;
            p1.Apresentar();
        }

        static void demo2()
        {
            //Valores validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(12,23);
            System.Console.WriteLine($"Area : {r.ObterArea()}"); 

            //Valores invalidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(-2,33);
            System.Console.WriteLine($"Area : {r2.ObterArea()}");
        }

        static void demo3()
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Joseph Robert";
            p1.Idade = 55;
            p1.Nota = 10;
            p1.Documento = "1234";
            p1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Vasconcelos";
            p2.Idade = 62;
            p2.Salario = 1500.32;
            p2.Documento = "1234767";
            p2.Apresentar();
        }

        static void demo4()
        {
            Calculadora ca = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma :"+ ca.Somar(1,2));
            System.Console.WriteLine("Resultado da segunda soma :"+ ca.Somar(1,2,3));
        }

        static void demo5()
        {
            Corrente c1 = new Corrente();
            c1.Creditar(10);
            c1.ExibirSaldo();
        }

        static void demo6()
        {
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());
        }

        static void demo7()
        {
            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Somar(12,133));
        }
        static void Main(string[] args)
        {   
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho,"PastaTeste1");
            var caminhoArquivo = Path.Combine(caminho,"arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho,"arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho,"PastaTeste2","arquivo-teste-stream.txt");
            var listaString = new List<string>{"Linha 1","Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string>{"Linha 4","Linha 5", "Linha 6"};
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //System.Console.WriteLine("Criando diretório :" + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine,true);
            //helper.CriarArquivoTexto(caminhoArquivo,"Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo,listaString);
            //helper.AdicionarTextoStream(caminhoArquivo,listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo,false);
            //helper.CopiarArquivo(caminhoArquivoTeste,caminhoArquivoTesteCopia,false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
        }
    }
}