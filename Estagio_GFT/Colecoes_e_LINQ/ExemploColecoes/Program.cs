using System;
using System.Collections.Generic;
using ExemploColecoes.Helper;

namespace ExemploColecoes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void demo1()
        {
            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = int.Parse("30");

            System.Console.WriteLine("Percorrendo o array pelo for :");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }
            System.Console.WriteLine("Percorendo o array pelo foreach");
            foreach (var item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }
        }

        static void demo2()
        {
            int[,] matriz = new int[3,4]
            {
                {1,2,3,0},
                {4,5,6,0},
                {7,8,9,0}
            };
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    System.Console.WriteLine(matriz[i,j]);
                }
            }
        }

        static void demo3()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            System.Console.WriteLine("Array original:");
            op.ImprimirArray(array);
            op.OrdenarBubbleSort(ref array);
            op.Ordenar(ref array);
            System.Console.WriteLine("Array ordenado com bubble :");
            op.ImprimirArray(array);
        }

        static void demo4()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];

            System.Console.WriteLine("Array antes da cópia :");
            op.ImprimirArray(arrayCopia);
            op.Copiar(ref array,ref arrayCopia);
            System.Console.WriteLine("\nArray após a cópia:");
            op.ImprimirArray(arrayCopia);
        }

        static void demo5()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];

            int valorProcurado = 1;
            bool existe = op.Existe(array,valorProcurado);
            if(existe)
            {
                System.Console.WriteLine("Encontrei o valor : {0}",valorProcurado);
            }
            else
            {
                System.Console.WriteLine("Não foi encontrado");
            }
        }

        static void demo6()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];
            int valorProcurado = 5;

            bool TodosMaiorQue = op.TodosMaiorQue(array,valorProcurado);
            if(TodosMaiorQue)
            {
                System.Console.WriteLine($"Todos os valores são maiores que {valorProcurado}");
            }
            else
            {
                System.Console.WriteLine($"Existem valores que não são maiores que {valorProcurado}");
            }
        }
        static void demo7()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];
            int valorProcurado = 9 ;
            int valorAchado = op.ObterValor(array, valorProcurado);

            if(valorAchado > 0)
            {
                System.Console.WriteLine("Encontrei o valor");
            }
            else
            {
                System.Console.WriteLine("Nao encontrei o valor");
            }
        }

        static void demo8()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];
            int valorProcurado = 6;
            
            int indice = op.ObterIndice(array,valorProcurado);

            if(indice > -1)
            {
                System.Console.WriteLine($"Valor {valorProcurado} foi encontrado na posição {indice}");
            }
            else
            {
                System.Console.WriteLine("O valor não esta em nenhuma posicao do array");
            }

        }

        static void demo9()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterParaArrayString(ref array);

            System.Console.WriteLine($"Capicidade atual do array : {array.Length}");

            op.RedimensionarArray(ref array,array.Length*2);
            System.Console.WriteLine($"Capicidade atual do array : {array.Length}");
        }

        static void demo10()
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string> {"SP","PR","RJ"};
            string[] estadosArray = new string[2] {"SC" ,"MT"};

            System.Console.WriteLine($"Quantidade de elementos na lista : {estados.Count}");

            opLista.ImprimirLista(estados);

            //System.Console.WriteLine("Removendo o elemento");
            //estados.Remove("PR");
            //estados.AddRange(estadosArray);
            estados.Insert(1,"AC");
            System.Console.WriteLine("-----------");
            opLista.ImprimirLista(estados);
        }

        static void demo11()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Joseph");
            fila.Enqueue("Emilio");
            fila.Enqueue("Kikuti");

            System.Console.WriteLine($"Pessoas na fila : {fila.Count}");

            while (fila.Count > 0)
            {
                System.Console.WriteLine($"Vez de: {fila.Peek()}");
                System.Console.WriteLine($"{fila.Dequeue()} atendido");
            }

            System.Console.WriteLine($"Pessoas na fila : {fila.Count}");
        }

        static void demo12()
        {
            Stack<string> pilhaLivros = new Stack<string>();
            pilhaLivros.Push(".NET");
            pilhaLivros.Push("POO");
            pilhaLivros.Push("Codigo limpo");

            System.Console.WriteLine($"Livros para leitura : {pilhaLivros.Count}");
            while(pilhaLivros.Count > 0)
            {
                System.Console.WriteLine($"Proximo livro para a leitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso");
            }

            System.Console.WriteLine($"Livros para leitura : {pilhaLivros.Count}");
        }

        static void demo13()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP","São Paulo");
            estados.Add("PR","Paraná");
            estados.Add("BA","Bahia");

            string valorProcurado = "BA";
            System.Console.WriteLine("Valor original :");
            System.Console.WriteLine(estados[valorProcurado]);

            estados[valorProcurado] = "BA- teste atualização";
            System.Console.WriteLine(estados[valorProcurado]);
        }

        static void demo14()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP","São Paulo");
            estados.Add("PR","Paraná");
            estados.Add("BA","Bahia");

            foreach (var item in estados)
            {
                System.Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");
            } 

            string valorProcurado = "BA";
            System.Console.WriteLine($"Removendo o valor {valorProcurado}");
            estados.Remove(valorProcurado);

            foreach (var item in estados)
            {
                System.Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");
            } 
        }

        static void demo15()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SP","São Paulo");
            estados.Add("PR","Paraná");
            estados.Add("BA","Bahia");

            foreach (var item in estados)
            {
                //System.Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");
            } 

            string valorProcurado = "SC";

            //var teste = estados["SC"];
            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                System.Console.WriteLine(estadoEncontrado);
            }
            else
            {
                System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            }

        }

        static void demo16()
        {
            int[] arrayNumeros = new int[5] {1,4,8,15,19};

            var numerosParesQuery = 
                from num in arrayNumeros
                where num%2 == 0
                orderby num
                select num;
            
            var numerosParesMetodo = arrayNumeros.Where(x=> x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine("Numero pares query: " + string.Join(",",numerosParesQuery));
            System.Console.WriteLine("Numeros pares metodo: " + string.Join(",", numerosParesMetodo));
        }
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100,1,4,0,8,15,19,19,4,100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Mínimo : {minimo}");
            System.Console.WriteLine($"Máximo {maximo}"); 
            System.Console.WriteLine($"Médio : {medio}");
            System.Console.WriteLine($"Soma : {soma}");
            System.Console.WriteLine($"Array original : {string.Join(",",arrayNumeros)}");
            System.Console.WriteLine($"Array original : {string.Join(",",arrayUnico)}");

        }
    }
}