using static System.Console;  // não precisa usar o Conole no WriteLine !

namespace Demos 
{
    public class Program
    {
        static void demo7()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(){Nome = "Ricardo"},
                new Pessoa(){Nome = "Joseph"},
                new Pessoa(){Nome = "Jonas"},
                new Pessoa(){Nome = "Ronald"},
                new Pessoa(){Nome = "Daniel"}
            };
            WriteLine("Digite a pessoa que gostaria de localiza:");
            string nome = ReadLine();
            var pessoa = new Pessoa(){Nome = nome};
            bool encontrado = encontraPessoa(pessoas,pessoa);
            if(encontrado)
            {
                WriteLine($"A pessoa {nome} está na lista");
            }
            else WriteLine($"A pessoa {nome} não está na lista");
        }


        static void demo6()
        {
            int[] numeros = new int[] {0,2,4,6,8};
            WriteLine("Digite o número que gostaria de encontrar");
            var numero = int.Parse(ReadLine());
            var idxEncontrado = encontrarNumero(numeros,numero);
            if(idxEncontrado >= 0)
            {
                WriteLine($"O numero digitado está na posição {idxEncontrado}");
            }
            else WriteLine("Numero nao encontrado");
        }


        static void demo5()
        {
            int[] pares = new int[]{0,2,4,6,8};
            mudaParaImpar(pares);
            WriteLine($"Os impares {string.Join(",",pares)}");
        }


        static void demo4()
        {
            string nome = "Ricardoxxxxxxxxxxxxxxxxxxxxxx";
            nome =trocaNome(nome,"Joseph Robert Vasconcilos");
            WriteLine($"O novo nome é {nome}");
        }


        static void demo3()
        {
            StructPessoa p1 = new StructPessoa()
            {
                Documento = "1234",
                Idade = 19,
                Nome = "Diogo"
            };

            StructPessoa p2 = p1;

            p1 = trocaNome(p1,"Joseph Robert");

            WriteLine($@"
                Nome do p1 {p1.Nome}
                Nome do p2 {p2.Nome}");
        }


        static void demo2()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Diogo";
            p1.Idade = 19;
            p1.Documento = "1234";

            Pessoa p2 = p1.Clone();

            trocaNome(p1,"Joseph");

            WriteLine($@"
            O nome de p1 é :{p1.Nome}
            O nome de p2 é :{p2.Nome}");
        }


        static void demo1()
        {
            int a = 2;
            a = adicionar20(a);
            WriteLine($"O valor da variável a é {a}");
        }


        static int adicionar20(int x)
        {
            return  x + 20;
        }

        static void trocaNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }

        static StructPessoa trocaNome(StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
            return p1;
        }

        static string trocaNome(string nome,string nomeNovo)
        {
            nome = nomeNovo;
            return nome;
        }
        
        static void mudaParaImpar(int[] pares)
        {
            for(int i = 0; i<pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static int encontrarNumero(int[] numeros, int numero)
        {
            for(int i=0;i<numeros.Length;i++)
            {
                if(numero == numeros[i])
                {
                    return i;
                }
                
            }
            return -1;
        }
        static bool encontraPessoa(List<Pessoa> pessoas,Pessoa nome)
        {
            foreach (var item in pessoas)
            {
                if(item.Nome == nome.Nome)
                {
                    return true;
                }
            }
            return false;
        }


        static bool encontraPessoa(List<StructPessoa> pessoas,StructPessoa nome)
        {
            foreach (var item in pessoas)
            {
                if(item.Equals(nome))
                {
                    return true;
                }
            }
            return false;
        }


        public static void Main(string[] args)
        {
            List<StructPessoa> pessoas = new List<StructPessoa>()
            {
                new StructPessoa(){Nome = "Ricardo"},
                new StructPessoa(){Nome = "Joseph"},
                new StructPessoa(){Nome = "Jonas"},
                new StructPessoa(){Nome = "Ronald"},
                new StructPessoa(){Nome = "Daniel"}
            };
            WriteLine("Digite a pessoa que gostaria de localiza:");
            string nome = ReadLine();
            var pessoa = new StructPessoa(){Nome = nome};
            bool encontrado = encontraPessoa(pessoas,pessoa);
            if(encontrado)
            {
                WriteLine($"A pessoa {nome} está na lista");
            }
            else WriteLine($"A pessoa {nome} não está na lista");
        }
    }
}
