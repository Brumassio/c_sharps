using System;
using APP_CadastroSeries.Classes;

namespace APP_CadastroSeries // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                       VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o id da série :");
            int indiceSerie = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Deseja mesmo excluir essa série ?\nS - Sim\nN- Não");
            string resposta = Console.ReadLine();
            if(resposta == "S" || resposta == "s")
            {
            repositorio.Exclui(indiceSerie);
            }
            return;

        }

        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o id da serie");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            System.Console.WriteLine(serie);
        }
        private static void AtualizarSerie()
        {
            System.Console.WriteLine("Digite o id da série:");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} : {Enum.GetName(typeof(Genero),i)}");
            }

            System.Console.WriteLine("Digite o Gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o Titulo da Série");
            string entradaTitulo = Console.ReadLine();
            System.Console.WriteLine("Digite o Ano da Série");
            int entradaAno = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Descrição da Série");
            string entradaDescricao = Console.ReadLine();

            Serie AtualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie,AtualizaSerie);
        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("Listar Séries");
            
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                if(!excluido)
                System.Console.WriteLine("#ID {0} : {1} - {2}",serie.retornaId(),serie.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }

        private static void InserirSerie()
        {
            System.Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero),i)}");
            }
            System.Console.WriteLine("Digite o Gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o Titulo da Série");
            string entradaTitulo = Console.ReadLine();
            System.Console.WriteLine("Digite o Ano da Série");
            int entradaAno = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Descrição da Série");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Diogo Séries a seu dispor ! :D");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Vizualizar Série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}