using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 10.56789;
            string nome = "Diogo";
            //Variaveis exercicio 

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("-----------------------------");
            Console.WriteLine(salario.ToString("F2"));
            Console.WriteLine(salario.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("{0} possui {1} anos de idade e em sua conta possui um salario de {2:F2}",nome,idade,salario);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {salario:F2} reais");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Exercicio de fixaccao 1");
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preco é {preco2:F2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero : {genero}");
            Console.WriteLine($"Medida com oito casas decimais : {media:F8}");
            Console.WriteLine($"Arredondado (três casas decimais) : {media:F3}");
            Console.WriteLine("Separador decimal invariant culture {0}",media.ToString("F3",CultureInfo.InvariantCulture));
            string frase = Console.ReadLine();
            Console.WriteLine("Salve gurizada " + frase);
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine("p1 = {0} , p2 = {1}, p3 = {2}",p1,p2,p3);



        }
    }
}
