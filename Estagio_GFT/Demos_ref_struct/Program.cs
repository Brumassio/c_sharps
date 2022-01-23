using System;
using static System.Console;

namespace Demos_ref_struct// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Joseph";
            p1.Idade = 50;
            p1.EnderecoPessoa = new Endereco()
            {
                Logradouro = "Rua UEM",
                CEP = "20002",
                Cidade = "Maringá",
                Numero = 1653
            };

            WriteLine("Fim");
        }
    }
}
