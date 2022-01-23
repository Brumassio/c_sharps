using System;
using static System.Console;

namespace Demos_ref // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void demo3()
        {
            var nomes = new string[]{"Joseph","Kikuti","Robert","Vasconcelos"};
            WriteLine("Digite o nome a ser substituído! : ");
            var nome = ReadLine();
            WriteLine("Digite o nome novo");
            var nomeNovo = ReadLine();
            
            var indice = localizaNome(nomes,nome);
            if(indice >= 0)
            {
                nomes[indice] = nomeNovo;
                WriteLine($@"A lista de nomes Alterada é : 
                {string.Join(",\n",nomes)}");
            }
            else
            {
                WriteLine("Nome não encontrado! Lista permanece igual");
            }
        }

        static void demo2()
        {
            var nomes = new string[]{"Joseph","Kikuti","Robert","Vasconcelos"};
            WriteLine("Digite o nome a ser substituído! : ");
            var nome = ReadLine();
            WriteLine("Digite o nome novo");
            var nomeNovo = ReadLine();

            alteraNome(nomes,nome,nomeNovo);

            WriteLine($@"A lista de nomes Alterada é:
            {string.Join(",\n",nomes)}");
        }
        static void demo1()
        {
            int a =5;
            Adicionar20(ref a);
            Console.WriteLine("Hello World!");
        }
        static void Adicionar20(ref int a)
        {
            a+= 20;
        }
        static void alteraNome(string[] nomes,string nome, string nomeNovo)
        {
            for(int i = 0; i<nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static int localizaNome(string[] nomes, string nome)
        {
            for(int i =0 ; i< nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    return i;
                }
            }

            return -1;
        }

        static ref string localizandoNome(string[] nomes, string nome)
        {
            for(int i =0 ; i< nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    return ref nomes[i];
                }
            }

            throw new Exception("Nome não encontrado");
        }

        static void Main()
        {
            var nomes = new string[]{"Joseph","Kikuti","Robert","Vasconcelos"};
            WriteLine("Digite o nome a ser substituído! : ");
            var nome = ReadLine();
            WriteLine("Digite o nome novo");
            var nomeNovo = ReadLine();
            
            ref var nomeEncontrado = ref localizandoNome(nomes,nome);
            if(!string.IsNullOrWhiteSpace(nomeEncontrado))
            {
                nomeEncontrado = nomeNovo;
                WriteLine($@"A lista de nomes Alterada é : 
                {string.Join(",\n",nomes)}");
            }
            else
            {
                WriteLine("Nome não encontrado! Lista permanece igual");
            }
        }
    }
}