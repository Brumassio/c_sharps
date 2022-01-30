namespace POO_HEPA.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void  Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}