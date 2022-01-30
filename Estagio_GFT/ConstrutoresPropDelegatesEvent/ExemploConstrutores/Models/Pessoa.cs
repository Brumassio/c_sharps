namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        //readonly protege contra a alteração sem ser na sua inicialização ou no construtor
        private readonly string nome = "Diogo";
        private readonly string sobrenome;

        //construtor 1
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        //construtor 2
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa !");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }

    }
}